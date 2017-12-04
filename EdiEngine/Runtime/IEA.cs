using EdiEngine.Common.Definitions;

namespace EdiEngine.Runtime
{
    public class IEA : EdiSegment
    {
        public IEA(string[] elements) : base(null)
        {
            foreach (string el in elements)
            {
                Content.Add(new EdiDataElement(null, el));
            }
        }

        public IEA(MapSegment definition, 
            int IEA01_IncludedGroupsCount,
            int IEA02_ControlNumber) : base(definition)
        {
            Content.AddRange(new[] {
                new EdiDataElement((MapDataElement)definition.Content[0], IEA01_IncludedGroupsCount.ToString()),
                new EdiDataElement((MapDataElement)definition.Content[1], IEA02_ControlNumber.ToString().PadLeft(9, '0'))
            });
        }
    }
}
