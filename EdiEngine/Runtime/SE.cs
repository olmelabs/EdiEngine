using EdiEngine.Common.Definitions;

namespace EdiEngine.Runtime
{
    public class SE : EdiSegment
    {
        public SE(string[] elements) : base(null)
        {
            foreach (string el in elements)
            {
                Content.Add(new EdiDataElement(null, el));
            }
        }

        public SE(MapBaseEntity definition,
            int SE01_IncludedSegCount,
            int SE02_ControlNumber
        ) : base(definition)
        {
            string tcn = SE02_ControlNumber.ToString();
            if (tcn.Length < 4)
            {
                tcn = tcn.PadLeft(4, '0');
            }

            Content.AddRange(new[] {
                new EdiDataElement(null, SE01_IncludedSegCount.ToString()),
                new EdiDataElement(null, tcn),
            });
        }
    }
}
