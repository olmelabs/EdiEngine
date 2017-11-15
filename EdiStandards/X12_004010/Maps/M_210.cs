using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_210 : MapLoop
	{
		public M_210() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new C2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 300 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new R3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_S5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

		//0100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//0200
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//0250
		public class L_SPO : MapLoop
		{
			public L_SPO(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SPO() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0300
		public class L_S5 : MapLoop
		{
			public L_S5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_SPO_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//0305
		public class L_SPO_1 : MapLoop
		{
			public L_SPO_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SPO() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0310
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_N7_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0320
		public class L_N7_1 : MapLoop
		{
			public L_N7_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//0400
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new POD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new H1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new H2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L0() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_SPO_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0430
		public class L_SPO_2 : MapLoop
		{
			public L_SPO_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SPO() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0460
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_CD3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SPO_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0463
		public class L_CD3 : MapLoop
		{
			public L_CD3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CD3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new H6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new POD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//0465
		public class L_SPO_3 : MapLoop
		{
			public L_SPO_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SPO() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

