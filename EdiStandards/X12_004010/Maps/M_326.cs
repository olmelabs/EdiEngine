using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_326 : MapLoop
	{
		public M_326() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new L_V1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
			});
		}

		//1000
		public class L_V1 : MapLoop
		{
			public L_V1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new V1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MBL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new L_N7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_R4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 4 },
				});
			}
		}

		//1100
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
				});
			}
		}

		//1200
		public class L_R4 : MapLoop
		{
			public L_R4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

