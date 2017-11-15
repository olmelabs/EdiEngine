using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_272 : MapLoop
	{
		public M_272() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_LID(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_N9 : MapLoop
		{
			public L_N9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1100
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2000
		public class L_LID : MapLoop
		{
			public L_LID(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new BCI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_LIE(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_N9_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PWK(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_NM1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_REF(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_LIE : MapLoop
		{
			public L_LIE(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIE() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2200
		public class L_N9_1 : MapLoop
		{
			public L_N9_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2300
		public class L_PWK : MapLoop
		{
			public L_PWK(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PWK() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2400
		public class L_NM1_1 : MapLoop
		{
			public L_NM1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_LIE_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2410
		public class L_LIE_1 : MapLoop
		{
			public L_LIE_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIE() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2500
		public class L_REF : MapLoop
		{
			public L_REF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_VEH(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NX1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2503
		public class L_VEH : MapLoop
		{
			public L_VEH(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VEH() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new VAT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DVI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new VRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LIE_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2510
		public class L_LIE_2 : MapLoop
		{
			public L_LIE_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIE() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2515
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PDR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PDP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new K2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LIE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new EM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PKD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new V1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new R1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new R4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_K2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2518
		public class L_K2 : MapLoop
		{
			public L_K2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new K2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LIE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2520
		public class L_NX1 : MapLoop
		{
			public L_NX1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new ICH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new BCI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_NM1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2525
		public class L_LQ : MapLoop
		{
			public L_LQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LQ_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2528
		public class L_LQ_1 : MapLoop
		{
			public L_LQ_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2600
		public class L_NM1_2 : MapLoop
		{
			public L_NM1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new ICH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new BCI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_III(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2610
		public class L_III : MapLoop
		{
			public L_III(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new III() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_LQ_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2615
		public class L_LQ_2 : MapLoop
		{
			public L_LQ_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2700
		public class L_PIN : MapLoop
		{
			public L_PIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new BCI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_PWK_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2710
		public class L_PWK_1 : MapLoop
		{
			public L_PWK_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PWK() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

