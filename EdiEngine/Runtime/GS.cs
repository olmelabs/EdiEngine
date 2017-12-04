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
                Content.Add(new EdiDataElement(null, el));
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
                new EdiDataElement((MapDataElement)definition.Content[0], GS01_GroupName),
                new EdiDataElement((MapDataElement)definition.Content[1], GS02_SenderId),
                new EdiDataElement((MapDataElement)definition.Content[2], GS03_ReceiverId),
                new EdiDataElement((MapDataElement)definition.Content[3], DateTime.Now.ToString("yyyyMMdd")),
                new EdiDataElement((MapDataElement)definition.Content[4], DateTime.Now.ToString("hhmm")),
                new EdiDataElement((MapDataElement)definition.Content[5], GS06_ControlNumber.ToString()),
                new EdiDataElement((MapDataElement)definition.Content[6], "X"),
                new EdiDataElement((MapDataElement)definition.Content[7], GS08_VersionlNumber)
            });
        }
    }
}
