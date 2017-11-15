using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_148 : MapLoop
	{
		public M_148() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new ACT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
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
					new ACT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new FC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CRI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new EMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new VEH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1_1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
					new L_ESI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new L_LN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_III(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AD1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//2100
		public class L_NM1_1 : MapLoop
		{
			public L_NM1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new ACT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2200
		public class L_ESI : MapLoop
		{
			public L_ESI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ESI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new L_AIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//2210
		public class L_AIN : MapLoop
		{
			public L_AIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new WS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
				});
			}
		}

		//2300
		public class L_LN : MapLoop
		{
			public L_LN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_VEH(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AMT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new L_NM1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2310
		public class L_VEH : MapLoop
		{
			public L_VEH(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VEH() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2320
		public class L_AMT : MapLoop
		{
			public L_AMT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AMT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2330
		public class L_NM1_2 : MapLoop
		{
			public L_NM1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2400
		public class L_III : MapLoop
		{
			public L_III(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new III() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IMP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//2410
		public class L_LM : MapLoop
		{
			public L_LM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2420
		public class L_NM1_3 : MapLoop
		{
			public L_NM1_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new ACT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2500
		public class L_AD1 : MapLoop
		{
			public L_AD1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AD1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new REL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new L_NM1_4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//2510
		public class L_NM1_4 : MapLoop
		{
			public L_NM1_4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new ACT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
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
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

	}
 }

