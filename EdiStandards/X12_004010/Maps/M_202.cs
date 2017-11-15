using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_202 : MapLoop
	{
		public M_202() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_N9(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new CTT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2000
		public class L_N9 : MapLoop
		{
			public L_N9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_DEX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_DEX : MapLoop
		{
			public L_DEX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DEX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 15 },
					new CN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new INT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new MPP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new III() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new L_ASM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//2110
		public class L_ASM : MapLoop
		{
			public L_ASM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ASM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2120
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//2121
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new III() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new LUC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new RLD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new INT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new PPD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new BUY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PEX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new BEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_IGI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NX1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LN1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_CRC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PAM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new L_UWI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2122
		public class L_IGI : MapLoop
		{
			public L_IGI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IGI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2123
		public class L_NX1 : MapLoop
		{
			public L_NX1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new REA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PDS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2124
		public class L_LN1 : MapLoop
		{
			public L_LN1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2125
		public class L_CRC : MapLoop
		{
			public L_CRC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CRC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new AIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new L_SCM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2126
		public class L_SCM : MapLoop
		{
			public L_SCM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SCS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2128
		public class L_PAM : MapLoop
		{
			public L_PAM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PAM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2129
		public class L_UWI : MapLoop
		{
			public L_UWI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new UWI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new III() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

