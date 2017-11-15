using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_323 : MapLoop
	{
		public M_323() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new V1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new L_R4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
			});
		}

		//1000
		public class L_R4 : MapLoop
		{
			public L_R4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new V9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
				});
			}
		}

	}
 }

