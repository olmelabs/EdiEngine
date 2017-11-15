using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_312 : MapLoop
	{
		public M_312() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new Y6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new Q3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				new V1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new L_R4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_L1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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

		//3000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_N7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_L0(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 120 },
				});
			}
		}

		//3100
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N12() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_H1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//3110
		public class L_H1 : MapLoop
		{
			public L_H1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new H1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new H2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//3200
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_L1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_H1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//3210
		public class L_L1 : MapLoop
		{
			public L_L1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3220
		public class L_H1_1 : MapLoop
		{
			public L_H1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new H1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new H2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//4000
		public class L_L1_1 : MapLoop
		{
			public L_L1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

