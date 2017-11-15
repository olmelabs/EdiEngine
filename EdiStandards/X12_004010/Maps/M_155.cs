using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_155 : MapLoop
	{
		public M_155() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LUI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NX1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_INR(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new TPB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2200
		public class L_NX1 : MapLoop
		{
			public L_NX1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new COM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_REQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2210
		public class L_REQ : MapLoop
		{
			public L_REQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LOD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new FDA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AWD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2300
		public class L_INR : MapLoop
		{
			public L_INR(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new INR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NX1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ITC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ASO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SPR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new EMS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ASI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_INQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_REQ_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_API(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2310
		public class L_INQ : MapLoop
		{
			public L_INQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new INQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new III() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PYT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PYM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AWD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ACD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SPR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ASO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2320
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NX1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new TPB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AWD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ASO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2330
		public class L_LM : MapLoop
		{
			public L_LM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new III() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LX_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2331
		public class L_LX_1 : MapLoop
		{
			public L_LX_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AWD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2332
		public class L_NM1_1 : MapLoop
		{
			public L_NM1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new TPB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2340
		public class L_REQ_1 : MapLoop
		{
			public L_REQ_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AWD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2350
		public class L_API : MapLoop
		{
			public L_API(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new API() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CDS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new BBC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ASO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_CRC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_CED(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2351
		public class L_LM_1 : MapLoop
		{
			public L_LM_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new III() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2352
		public class L_CRC : MapLoop
		{
			public L_CRC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CRC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AWD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2353
		public class L_NM1_2 : MapLoop
		{
			public L_NM1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new TPB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ITC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AWD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_IN1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2354
		public class L_IN1 : MapLoop
		{
			public L_IN1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TPB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2355
		public class L_CED : MapLoop
		{
			public L_CED(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CED() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_LM_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2356
		public class L_LM_2 : MapLoop
		{
			public L_LM_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

