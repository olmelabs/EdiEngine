using EdiEngine.Common.Definitions;
using System;

namespace EdiEngine.Runtime
{
    public class ISA : EdiSegment
    {
        public ISA(string[] elements) : base(null)
        {
            foreach (string el in elements)
            {
                Content.Add(new EdiDataElement(null, el));
            }
        }

        public ISA(MapBaseEntity definition,
            string ISA05_SenderQual,
            string ISA06_SenderId,
            string ISA07_ReceiverQual,
            string ISA08_ReceiverId,
            string ISA12_VersionlNumber,
            int ISA13_ControlNumber,
            string ISA15_UsageIndicator
            ) : base(definition)
        {
            Content.AddRange(new[] {
                new EdiDataElement(null, "00"),
                new EdiDataElement(null, string.Empty.PadRight(10, ' ')),
                new EdiDataElement(null, "00"),
                new EdiDataElement(null, string.Empty.PadRight(10, ' ')),
                new EdiDataElement(null, ISA05_SenderQual),
                new EdiDataElement(null, ISA06_SenderId.PadRight(15)),
                new EdiDataElement(null, ISA07_ReceiverQual),
                new EdiDataElement(null, ISA08_ReceiverId.PadRight(15)),
                new EdiDataElement(null, DateTime.Now.ToString("yyMMdd")),
                new EdiDataElement(null, DateTime.Now.ToString("hhmm")),
                new EdiDataElement(null, "U"),
                new EdiDataElement(null, ISA12_VersionlNumber),
                new EdiDataElement(null, ISA13_ControlNumber.ToString().PadLeft(9, '0')),
                new EdiDataElement(null, "0"),
                new EdiDataElement(null, ISA15_UsageIndicator),
                new EdiDataElement(null, ">")
            });
        }
    }
}

