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

        public IEA(MapBaseEntity definition, 
            int IEA01_IncludedGroupsCount,
            int IEA02_ControlNumber) : base(definition)
        {
            Content.AddRange(new[] {
                new EdiDataElement(null, IEA01_IncludedGroupsCount.ToString()),
                new EdiDataElement(null, IEA02_ControlNumber.ToString().PadLeft(9, '0'))
            });
        }
    }
}
