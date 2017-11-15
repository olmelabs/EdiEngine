using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_322 : MapLoop
	{
		public M_322() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new ZC1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new Q5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N7(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1000 },
			});
		}

		//1000
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new V4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new W2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new GR5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new Y7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new V1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_R4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_L0(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//1100
		public class L_R4 : MapLoop
		{
			public L_R4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				});
			}
		}

		//1200
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1300
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new H1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

	}
 }

