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
                Content.Add(new EdiSimpleDataElement(null, el));
            }
        }

        public ISA(MapSegment definition,
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
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[0], "00"),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[1], string.Empty.PadRight(10, ' ')),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[2], "00"),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[3], string.Empty.PadRight(10, ' ')),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[4], ISA05_SenderQual),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[5], ISA06_SenderId.PadRight(15)),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[6], ISA07_ReceiverQual),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[7], ISA08_ReceiverId.PadRight(15)),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[8], DateTime.Now.ToString("yyMMdd")),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[9], DateTime.Now.ToString("hhmm")),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[10], "U"),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[11], ISA12_VersionlNumber),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[12], ISA13_ControlNumber.ToString().PadLeft(9, '0')),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[12], "0"),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[14], ISA15_UsageIndicator),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[15], EdiInterchange.DefaultCompositeSeparator)
            });
        }
    }
}

