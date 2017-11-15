using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_456 : MapLoop
	{
		public M_456() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new EIA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new L_IS1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_ER(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
			});
		}

		//1000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new H5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new F9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new D9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
					new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 21 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new L_S1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				});
			}
		}

		//1100
		public class L_S1 : MapLoop
		{
			public L_S1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new S9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_IS1 : MapLoop
		{
			public L_IS1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IS1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new ISC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new IS2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//3000
		public class L_ER : MapLoop
		{
			public L_ER(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ER() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ES() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

