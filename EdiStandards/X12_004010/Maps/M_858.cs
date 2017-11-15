using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_858 : MapLoop
	{
		public M_858() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new ZC1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new BX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new BNX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new M3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new CM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new Y6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
				new Y7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new F9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new D9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new R1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new R3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new R4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new PS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new H6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new V4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new V5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_E1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new M1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new M2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new XH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 600 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new L_S5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new L_FA1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_E1 : MapLoop
		{
			public L_E1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new E4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new E5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new EM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new IC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 21 },
					new GA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new L_E1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2100
		public class L_E1_1 : MapLoop
		{
			public L_E1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new E4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new E5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//4000
		public class L_S5 : MapLoop
		{
			public L_S5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new H6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//4100
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//5000
		public class L_FA1 : MapLoop
		{
			public L_FA1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FA1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FA2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new IC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 24 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new SL1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new LHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new Y7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new LP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AXL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new L_L0(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_LH1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_FA1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
				});
			}
		}

		//6100
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//6200
		public class L_LH1 : MapLoop
		{
			public L_LH1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LH1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LHE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6300
		public class L_FA1_1 : MapLoop
		{
			public L_FA1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FA1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FA2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6400
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6500
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

