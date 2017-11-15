using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_838 : MapLoop
	{
		public M_838() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BTP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SPI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new ERI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PLA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LCD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_ENE(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TAX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SPI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new FBB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LCD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_TPD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PAM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_TXN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1110
		public class L_LCD : MapLoop
		{
			public L_LCD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LCD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1120
		public class L_TPD : MapLoop
		{
			public L_TPD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TPD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_TUD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SPR(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1121
		public class L_TUD : MapLoop
		{
			public L_TUD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TUD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1122
		public class L_SPR : MapLoop
		{
			public L_SPR(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SPR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1130
		public class L_PAM : MapLoop
		{
			public L_PAM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PAM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TAX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1140
		public class L_TXN : MapLoop
		{
			public L_TXN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TXN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1150
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

		//1200
		public class L_ENE : MapLoop
		{
			public L_ENE(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENE() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_TXN_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1210
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TPD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1220
		public class L_TXN_1 : MapLoop
		{
			public L_TXN_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TXN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

