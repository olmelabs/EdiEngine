using System.Text;
using EdiEngine.Runtime;

namespace EdiEngine
{
    public class EdiDataWriter
    {

        private string _elementSeparator;
        private string _segmentSeparator;
        private int _currentTranSegCount;

        public string WriteToString(EdiBatch batch)
        {
            StringBuilder sb = new StringBuilder();

            foreach (EdiInterchange ich in batch.Interchanges)
            {
                _elementSeparator = ich.ElementSeparator;
                _segmentSeparator = ich.SegmentSeparator;

                sb.AppendLine("ISA....");

                foreach (EdiGroup g in ich.Groups)
                {
                    int currentTran = 1;
                    sb.AppendLine("GS....");

                    foreach (EdiTrans t in g.Transactions)
                    {
                        string ctrl = currentTran.ToString();
                        if (ctrl.Length < 4)
                        {
                            ctrl = ctrl.PadLeft(4, '0');
                        }
                        sb.Append($"ST{_elementSeparator}{t.Definition.EdiName}{_elementSeparator}{ctrl}{_segmentSeparator}");

                        _currentTranSegCount = 1;

                        foreach (MappedObjectBase ent in t.Content)
                        {
                            WriteEntity(ent, ref sb);
                        }

                        sb.Append($"SE{_elementSeparator}{_currentTranSegCount + 1}{_elementSeparator}{ctrl}{_segmentSeparator}");

                        currentTran++;
                    }

                    sb.AppendLine("GE....");
                }

                sb.AppendLine("IEA....");
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

                foreach (var el in ((EdiSegment) ent).Content)
                {
                    sb.Append($"{_elementSeparator}{el.Val}");
                }

                sb.Append(_segmentSeparator);
            }
        }
    }
}
