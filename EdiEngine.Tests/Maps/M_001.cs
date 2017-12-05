using EdiEngine.Common.Definitions;
using EdiEngine.Common.Enums;
using EdiEngine.Tests.Segments;

namespace EdiEngine.Tests.Maps
{
    public class M_001 : MapLoop
    {
        public M_001() : base(null)
        {
            Content.AddRange(new MapBaseEntity[] {
                new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
            });
        }
    }
}
