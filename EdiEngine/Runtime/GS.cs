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

        public GS(MapBaseEntity definition,
        string GS01_GroupName,
        string GS02_SenderId,
        string GS03_ReceiverId,
        int GS06_ControlNumber,
        string GS08_VersionlNumber
        ) : base(definition)
        {
            Content.AddRange(new[] {
                new EdiDataElement(null, GS01_GroupName),
                new EdiDataElement(null, GS02_SenderId),
                new EdiDataElement(null, GS03_ReceiverId),
                new EdiDataElement(null, DateTime.Now.ToString("yyyyMMdd")),
                new EdiDataElement(null, DateTime.Now.ToString("hhmm")),
                new EdiDataElement(null, GS06_ControlNumber.ToString()),
                new EdiDataElement(null, "X"),
                new EdiDataElement(null, GS08_VersionlNumber)
            });
        }
    }
}
