using System;
using System.IO;
using System.Linq;
using System.Text;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;

namespace EdiEngine
{
    public class AckBuilder : EdiDataWriter
    {
        private readonly AckBuilderSettings _settings;

        public AckBuilder(AckBuilderSettings settings) : base(null)
        {
            _settings = settings;
        }

        public override Stream WriteToStream(EdiBatch batch)
        {
            EdiBatch ackBatch = GetnerateAcknowledgment(batch);
            BuildAckControlSegments(ackBatch, batch);

            Stream s = new MemoryStream();
            StreamWriter w = new StreamWriter(s);
            w.Write(WriteToStringBuilder(ackBatch));
            w.Flush();
            s.Position = 0;
            return s;
        }

        public override string WriteToString(EdiBatch batch)
        {
            EdiBatch ackBatch = GetnerateAcknowledgment(batch);
            BuildAckControlSegments(ackBatch, batch);

            return WriteToStringBuilder(ackBatch).ToString();
        }

        public EdiBatch GetnerateAcknowledgment(EdiBatch input)
        {
            string mapVersion = null;
            var firstGroup = input?.Interchanges?.FirstOrDefault()?.Groups?.FirstOrDefault();
            if (firstGroup != null)
                mapVersion = firstGroup.GS.Content[7].Val;

            if (string.IsNullOrWhiteSpace(mapVersion))
                throw new InvalidDataException(
                    "Can not determine EDI X12 version from batch. Check there is at least one interchange with at least one group in it");

            EdiBatch b997 = new EdiBatch();
            foreach (EdiInterchange ich in input.Interchanges)
            {
                var ich997 = new EdiInterchange();
                b997.Interchanges.Add(ich997);

                string asmName = $"EdiEngine.Standards.X12_{mapVersion}";
                string typeName = $"{asmName}.Maps.M_997";

                var map = (MapLoop) ActivatorHelper.Instantiate(asmName, typeName);

                var lAk2Def = (MapLoop)map.Content.First(s => s.Name == "L_AK2");

                foreach (EdiGroup g in ich.Groups)
                {
                    var g997 = new EdiGroup("FA");
                    ich997.Groups.Add(g997);

                    var t997 = new EdiTrans(map);
                    g997.Transactions.Add(t997);

                    int includedTranCount = int.Parse(g.GE.Content[0].Val);
                    int receivedTranCount = g.Transactions.Count;
                    int acceptedTranCount = g.Transactions.Count(t => !t.ValidationErrors.Any());

                    t997.Content.Add(CreateAk1Segment(map, g));

                    if (((_settings.AckValidationErrorBehavour == AckValidationErrorBehavour.AcceptButNoteErrors ||
                          _settings.AckValidationErrorBehavour == AckValidationErrorBehavour.RejectValidationErrors) &&
                         acceptedTranCount < receivedTranCount) ||
                        (_settings.AlwaysGenerateAk2Loop))
                    {
                        foreach (EdiTrans t in g.Transactions)
                        {
                            EdiLoop lAk2 = new EdiLoop(lAk2Def, null);
                            t997.Content.Add(lAk2);

                            lAk2.Content.Add(CreateAk2Segment(lAk2Def, t));
                            lAk2.Content.Add(CreateAk5Segment(lAk2Def, t));
                        }
                    }


                    t997.Content.Add(CreateAk9Segment(map, g, includedTranCount, receivedTranCount));
                }
            }

            return b997;
        }

        private void BuildAckControlSegments(EdiBatch ackBatch, EdiBatch originalBatch)
        {
            int icn = _settings.IsaFirstControlNumber;
            int gcn = _settings.GsFirstControlNumber;
            int i = 0;
            foreach (EdiInterchange ich in ackBatch.Interchanges)
            {
                var isa = originalBatch.Interchanges[i].ISA;
                var iea = originalBatch.Interchanges[i].IEA;
                ich.ISA = new ISA((MapSegment)isa.Definition, isa.Content[6].Val, isa.Content[7].Val,
                    isa.Content[4].Val, isa.Content[5].Val, isa.Content[11].Val, icn, isa.Content[14].Val);

                ich.SegmentSeparator = originalBatch.Interchanges[i].SegmentSeparator;
                ich.ElementSeparator = originalBatch.Interchanges[i].ElementSeparator;

                int j = 0;
                foreach (EdiGroup g in ich.Groups)
                {
                    var gs = originalBatch.Interchanges[i].Groups[j].GS;
                    var ge = originalBatch.Interchanges[i].Groups[j].GE;
                    var st = originalBatch.Interchanges[i].Groups[j].Transactions[0].ST;
                    var se = originalBatch.Interchanges[i].Groups[j].Transactions[0].SE;

                    g.GS = new GS((MapSegment)gs.Definition, "FA", gs.Content[2].Val, gs.Content[1].Val, gcn,
                        gs.Content[7].Val);
                    g.GE = new GE((MapSegment)ge.Definition, g.Transactions.Count, gcn);

                    //always 1 tran per FA group
                    g.Transactions[0].ST = new ST((MapSegment)st.Definition, "997", 1);

                    int segCount = 2; //ST, SE
                    GetTranSegCount(g.Transactions[0], ref segCount);

                    g.Transactions[0].SE = new SE((MapSegment)se.Definition, segCount, 1);

                    gcn++;
                    j++;
                }

                ich.IEA = new IEA((MapSegment)iea.Definition, ich.Groups.Count, icn);
                icn++;
                i++;
            }
        }

        private EdiSegment CreateAk1Segment(MapLoop map, EdiGroup g)
        {
            var sDef = (MapSegment)map.Content.First(s => s.Name == "AK1");
            var seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[]
            {
                new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[0], g.FunctionalCode),
                new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[1], g.GS.Content[5].Val),
            });
            return seg;
        }

        private EdiSegment CreateAk9Segment(MapLoop map, EdiGroup g, int includedTranCount, int receivedTranCount)
        {
            var sDef = (MapSegment)map.Content.First(s => s.Name == "AK9");
            var seg = new EdiSegment(sDef);

            var status = "A";
            int acceptedTranCount = g.Transactions.Count(t => !t.ValidationErrors.Any());
            var reportedAcceptedTranCount = g.Transactions.Count;

            switch (_settings.AckValidationErrorBehavour)
            {
                case AckValidationErrorBehavour.AcceptButNoteErrors:
                    if (receivedTranCount > acceptedTranCount)
                        status = "E"; //Accepted but errors were noted.
                    break;

                case AckValidationErrorBehavour.RejectValidationErrors:
                    if (acceptedTranCount == 0)
                        status = "R"; //Rejected - no accepted trans
                    else if (receivedTranCount > acceptedTranCount)
                        status = "P"; //Partially accepted, at least one transaction set was rejected

                    reportedAcceptedTranCount = acceptedTranCount;
                    break;
            }

            seg.Content.AddRange(new[]
            {
                new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[0], status),
                new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[1], includedTranCount.ToString()),
                new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[2], receivedTranCount.ToString()),
                new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[3], reportedAcceptedTranCount.ToString()),
            });

            return seg;
        }

        private EdiSegment CreateAk2Segment(MapLoop map, EdiTrans t)
        {
            var sDef = (MapSegment)map.Content.First(s => s.Name == "AK2");

            var seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[]
            {
                new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[0], t.ST.Content[0].Val),
                new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[1], t.ST.Content[1].Val),
            });
            return seg;
        }

        private EdiSegment CreateAk5Segment(MapLoop map, EdiTrans t)
        {
            var sDef = (MapSegment)map.Content.First(s => s.Name == "AK5");

            var status = "A";

            var seg = new EdiSegment(sDef);
            switch (_settings.AckValidationErrorBehavour)
            {

                case AckValidationErrorBehavour.AcceptButNoteErrors:
                    if (t.ValidationErrors.Any())
                        status = "E";
                    break;

                case AckValidationErrorBehavour.RejectValidationErrors:
                    if (t.ValidationErrors.Any())
                        status = "R";
                    break;
            }

            seg.Content.Add(new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[0], status));

            if (status == "R")
            {
                seg.Content.Add(new EdiSimpleDataElement((MapSimpleDataElement)sDef.Content[1], "5")); //AK502 = One or more segments in error
            }

            return seg;
        }

        protected override StringBuilder WriteToStringBuilder(EdiBatch batch)
        {
            StringBuilder sb = new StringBuilder();

            foreach (EdiInterchange ich in batch.Interchanges)
            {
                //use original separators taken from original interchange(s).
                CurrentSegmentSeparator = ich.SegmentSeparator;
                CurrentElementSeparator = ich.ElementSeparator;

                WriteEntity(ich.ISA, ref sb);

                foreach (EdiGroup g in ich.Groups)
                {
                    WriteEntity(g.GS, ref sb);

                    foreach (EdiTrans t in g.Transactions)
                    {
                        WriteEntity(t.ST, ref sb);

                        foreach (EdiBaseEntity ent in t.Content)
                        {
                            WriteEntity(ent, ref sb);
                        }

                        WriteEntity(t.SE, ref sb);
                    }

                    WriteEntity(g.GE, ref sb);
                }

                WriteEntity(ich.IEA, ref sb);
            }

            return sb;
        }

        private void GetTranSegCount(EdiBaseEntity ent, ref int segCount)
        {
            if (ent is EdiLoop)
            {
                foreach (var child in ((EdiLoop)ent).Content)
                {
                    GetTranSegCount(child, ref segCount);
                }
            }
            else if (ent is EdiSegment)
            {
                segCount++;
            }
        }
    }
}
