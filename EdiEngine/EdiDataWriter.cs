using System.Text;
using EdiEngine.Runtime;

namespace EdiEngine
{
    public class EdiDataWriter
    {
        private string _elementSeparator;
        private string _segmentSeparator;
        private int _currentTranSegCount;
        private readonly EdiDataWriterSettings _settings;

        public EdiDataWriter(EdiDataWriterSettings settings)
        {
            _settings = settings;
        }

        public string WriteToString(EdiBatch batch)
        {
            StringBuilder sb = new StringBuilder();

            int icn = _settings.IsaFirstControlNumber;
            int gcn = _settings.GsFirstControlNumber;

            foreach (EdiInterchange ich in batch.Interchanges)
            {
                _elementSeparator = ich.ElementSeparator;
                _segmentSeparator = ich.SegmentSeparator;

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
                        WriteEntity(t.ST, ref sb);

                        foreach (MappedObjectBase ent in t.Content)
                        {
                            WriteEntity(ent, ref sb);
                        }

                        _currentTranSegCount++;
                        t.SE = new SE(_settings.SeDef, _currentTranSegCount, currentTranIdx);
                        WriteEntity(t.SE, ref sb);

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

            return sb.ToString();
        }

        private void WriteEntity(MappedObjectBase ent, ref StringBuilder sb)
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
                _currentTranSegCount++;
                sb.Append(ent.Name);

                foreach (var el in ((EdiSegment)ent).Content)
                {
                    sb.Append($"{_elementSeparator}{el.Val}");
                }

                sb.Append(_segmentSeparator);
            }
        }
    }
}
