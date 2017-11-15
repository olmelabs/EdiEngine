using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_129 : MapLoop
	{
		public M_129() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new VR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G62() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 3 },
				new L_RT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
			});
		}

		//1000
		public class L_RT : MapLoop
		{
			public L_RT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new RT1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
				});
			}
		}

	}
 }

