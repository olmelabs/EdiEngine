using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_310 : MapLoop
	{
		public M_310() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new B2A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new Y6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new G3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				new V1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new M0() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new M1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new C2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new Y2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_R4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
				new R2A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_C8(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				new L3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_L1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new C8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
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
		public class L_C8 : MapLoop
		{
			public L_C8(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new C8() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new C8C() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//4000
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

		//4100
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new V4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N12() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_L1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L_H1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//4110
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

		//4120
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

		//4200
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_L1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_C8_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_H1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//4210
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

		//4220
		public class L_C8_1 : MapLoop
		{
			public L_C8_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new C8() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new C8C() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//4230
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

		//5000
		public class L_L1_2 : MapLoop
		{
			public L_L1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

