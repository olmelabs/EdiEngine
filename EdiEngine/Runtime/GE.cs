using EdiEngine.Common.Definitions;

namespace EdiEngine.Runtime
{
    public class GE: EdiSegment
    {
        public GE(string[] elements) : base(null)
        {
            foreach (string el in elements)
            {
                Content.Add(new EdiDataElement(null, el));
            }
        }

        public GE(MapSegment definition,
            int GE01_IncludedTransCount,
            int GE02_ControlNumber) : base(definition)
        {
            Content.AddRange(new[] {
                new EdiDataElement(definition.Content[0], GE01_IncludedTransCount.ToString()),
                new EdiDataElement(definition.Content[1], GE02_ControlNumber.ToString())
            });
        }
    }
}
