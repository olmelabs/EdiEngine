using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_304 : MapLoop
	{
		public M_304() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new B2A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new Y6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new G1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new V1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new V3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new M0() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_M1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new M2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new C2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_R4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new R2A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_C8(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new L_L3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_M1 : MapLoop
		{
			public L_M1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//3000
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

		//4000
		public class L_C8 : MapLoop
		{
			public L_C8(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new C8() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new C8C() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new SUP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//5000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new Y2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_PO4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_L0(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 120 },
				});
			}
		}

		//5100
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N12() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new M7A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_L1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_H1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LH1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//5110
		public class L_L1 : MapLoop
		{
			public L_L1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//5120
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

		//5130
		public class L_LH1 : MapLoop
		{
			public L_LH1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LH1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//5200
		public class L_PO4 : MapLoop
		{
			public L_PO4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PO4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//5300
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_PO4_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_PAL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L_CTP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L12() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_L1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SAC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_L9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_C8_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_H1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LH1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//5310
		public class L_PO4_1 : MapLoop
		{
			public L_PO4_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PO4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//5320
		public class L_PAL : MapLoop
		{
			public L_PAL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PAL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//5330
		public class L_CTP : MapLoop
		{
			public L_CTP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CTP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//5340
		public class L_L1_1 : MapLoop
		{
			public L_L1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//5350
		public class L_SAC : MapLoop
		{
			public L_SAC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//5360
		public class L_L9 : MapLoop
		{
			public L_L9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//5370
		public class L_C8_1 : MapLoop
		{
			public L_C8_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new C8() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new C8C() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new SUP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//5380
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

		//5390
		public class L_LH1_1 : MapLoop
		{
			public L_LH1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LH1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//5395
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//6000
		public class L_L3 : MapLoop
		{
			public L_L3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new SUP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_L1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_TDS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SAC_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_L9_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new ISS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 24 },
				});
			}
		}

		//6100
		public class L_L1_2 : MapLoop
		{
			public L_L1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6200
		public class L_TDS : MapLoop
		{
			public L_TDS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TDS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6300
		public class L_SAC_1 : MapLoop
		{
			public L_SAC_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6400
		public class L_L9_1 : MapLoop
		{
			public L_L9_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

