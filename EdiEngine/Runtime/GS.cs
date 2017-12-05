using EdiEngine.Common.Definitions;
using System;

namespace EdiEngine.Runtime
{
    public class GS : EdiSegment
    {
        public GS(string[] elements) : base(null)
        {
            foreach (string el in elements)
            {
                Content.Add(new EdiSimpleDataElement(null, el));
            }
        }

        public GS(MapSegment definition,
        string GS01_GroupName,
        string GS02_SenderId,
        string GS03_ReceiverId,
        int GS06_ControlNumber,
        string GS08_VersionlNumber
        ) : base(definition)
        {
            Content.AddRange(new[] {
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[0], GS01_GroupName),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[1], GS02_SenderId),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[2], GS03_ReceiverId),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[3], DateTime.Now.ToString("yyyyMMdd")),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[4], DateTime.Now.ToString("hhmm")),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[5], GS06_ControlNumber.ToString()),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[6], "X"),
                new EdiSimpleDataElement((MapSimpleDataElement)definition.Content[7], GS08_VersionlNumber)
            });
        }
    }
}
