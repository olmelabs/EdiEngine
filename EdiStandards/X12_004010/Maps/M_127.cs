using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_127 : MapLoop
	{
		public M_127() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BVB() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G62() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new SFC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
			});
		}

	}
 }

