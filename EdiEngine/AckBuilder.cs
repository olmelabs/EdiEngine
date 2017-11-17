using System;
using System.IO;
using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;

namespace EdiEngine
{
    public class AckBuilder
    {
        private readonly AckBuilderSettings _settings;

        public AckBuilder()
        {
            _settings = new AckBuilderSettings(AckValidationErrorBehavour.AcceptButNoteErrors, false);
        }

        public AckBuilder(AckBuilderSettings settings)
        {
            _settings = settings;
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

                var map = (MapLoop)Activator.CreateInstance(asmName, typeName).Unwrap();
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

        private EdiSegment CreateAk1Segment(MapLoop map, EdiGroup g)
        {
            var sDef = (MapSegment)map.Content.First(s => s.Name == "AK1");
            var seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[]{
                new EdiDataElement(sDef.Content[0], g.FunctionalCode),
                new EdiDataElement(sDef.Content[1], g.GS.Content[5].Val),
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

            seg.Content.AddRange(new[] {
                new EdiDataElement(sDef.Content[0], status),
                new EdiDataElement(sDef.Content[1], includedTranCount.ToString()),
                new EdiDataElement(sDef.Content[2], receivedTranCount.ToString()),
                new EdiDataElement(sDef.Content[3], reportedAcceptedTranCount.ToString()),
            });

            return seg;
        }

        private EdiSegment CreateAk2Segment(MapLoop map, EdiTrans t)
        {
            var sDef = (MapSegment)map.Content.First(s => s.Name == "AK2");

            var seg = new EdiSegment(sDef);
            seg.Content.AddRange(new[]{
                new EdiDataElement(sDef.Content[0], t.ST.Content[0].Val),
                new EdiDataElement(sDef.Content[1], t.ST.Content[1].Val),
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

            seg.Content.Add(new EdiDataElement(sDef.Content[0], status));

            if (status == "R")
            {
                seg.Content.Add(new EdiDataElement(sDef.Content[1], "5")); //AK502 = One or more segments in error
            }

            return seg;
        }
    }
}
