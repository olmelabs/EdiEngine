using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_311 : MapLoop
	{
		public M_311() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B2A() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new Y6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new V1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new V2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new V3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new R4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new Y2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_ED(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_L0(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 120 },
				});
			}
		}

		//2100
		public class L_ED : MapLoop
		{
			public L_ED(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ED() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2200
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

