using System.IO;
using System.Text;
using EdiEngine.Common.Definitions;
using EdiEngine.Runtime;
using EdiEngine.Validation;

namespace EdiEngine
{
    public class EdiDataWriter : DataWriter
    {
        private int _currentTranSegCount;
        private readonly EdiDataWriterSettings _settings;

        protected string CurrentSegmentSeparator { get; set; }
    
        protected string CurrentElementSeparator { get; set; }


        public EdiDataWriter(EdiDataWriterSettings settings)
        {
            _settings = settings;
            CurrentSegmentSeparator = _settings?.SegmentSeparator;
            CurrentElementSeparator = _settings?.ElementSeparator;
        }

        public override Stream WriteToStream(EdiBatch batch)
        {
            Stream s = new MemoryStream();
            StreamWriter w = new StreamWriter(s);
            w.Write(WriteToStringBuilder(batch));
            w.Flush();
            s.Position = 0;
            return s;
        }

        public override string WriteToString(EdiBatch batch)
        {
            return WriteToStringBuilder(batch).ToString();
        }

        protected virtual StringBuilder WriteToStringBuilder(EdiBatch batch)
        {
            StringBuilder sb = new StringBuilder();

            int icn = _settings.IsaFirstControlNumber;
            int gcn = _settings.GsFirstControlNumber;

            foreach (EdiInterchange ich in batch.Interchanges)
            {
                ich.ISA = new ISA(_settings.IsaDef,
                    _settings.IsaSenderQual, _settings.IsaSenderId,
                    _settings.IsaReceiverQual, _settings.IsaReceiverId,
                    _settings.IsaEdiVersion, icn, _settings.IsaUsageIndicator);

                WriteEntity(ich.ISA, ref sb);

                foreach (EdiGroup g in ich.Groups)
                {
                    int currentTranIdx = 1;
                    g.GS = new GS(_settings.GsDef, g.FunctionalCode, _settings.GsSenderId, _settings.GsReceiverId, gcn, _settings.GsEdiVersion);
                    WriteEntity(g.GS, ref sb);

                    foreach (EdiTrans t in g.Transactions)
                    {
                        _currentTranSegCount = 0;

                        t.ST = new ST(_settings.StDef, t.Definition.EdiName, currentTranIdx);
                        WriteEntity(t.ST, ref sb, t);

                        foreach (EdiBaseEntity ent in t.Content)
                        {
                            WriteEntity(ent, ref sb, t);
                        }

                        _currentTranSegCount++;
                        t.SE = new SE(_settings.SeDef, _currentTranSegCount, currentTranIdx);
                        WriteEntity(t.SE, ref sb, t);

                        currentTranIdx++;
                    }

                    g.GE = new GE(_settings.GeDef, g.Transactions.Count, gcn);
                    WriteEntity(g.GE, ref sb);
                    gcn++;
                }

                ich.IEA = new IEA(_settings.IeaDef, ich.Groups.Count, icn);
                WriteEntity(ich.IEA, ref sb);
                icn++;
            }

            return sb;
        }

        protected virtual void WriteEntity(EdiBaseEntity ent, ref StringBuilder sb, IValidatedEntity validationScope = null)
        {
            if (ent is EdiLoop)
            {
                foreach (var child in ((EdiLoop)ent).Content)
                {
                    WriteEntity(child, ref sb);
                }
            }
            else if (ent is EdiSegment)
            {
                var seg = (EdiSegment) ent;

                _currentTranSegCount++;

                sb.Append(ent.Name);
                foreach (var el in ((EdiSegment)ent).Content)
                {
                    sb.Append($"{CurrentElementSeparator}{el.Val}");
                }
                sb.Append(CurrentSegmentSeparator);

                if (validationScope != null)
                {
                    SegmentValidator.ValidateSegment(seg, _currentTranSegCount, validationScope);
                }
            }
        }
    }
}
