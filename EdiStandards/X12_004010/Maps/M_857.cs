using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_857 : MapLoop
	{
		public M_857() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BHT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_G05(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_TDS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_PAL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_IT1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1100
		public class L_G05 : MapLoop
		{
			public L_G05(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G05() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1110
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1120
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
		public class L_TDS : MapLoop
		{
			public L_TDS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TDS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PRF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new SN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ISS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SAC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_FA1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1210
		public class L_SAC : MapLoop
		{
			public L_SAC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1220
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1230
		public class L_FA1 : MapLoop
		{
			public L_FA1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FA1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FA2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1300
		public class L_PAL : MapLoop
		{
			public L_PAL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PAL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1400
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new SN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1500
		public class L_IT1 : MapLoop
		{
			public L_IT1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IT1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IT3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TC2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PID(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new L_SAC_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new L_LM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_FA1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1510
		public class L_PID : MapLoop
		{
			public L_PID(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1520
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//1530
		public class L_SAC_1 : MapLoop
		{
			public L_SAC_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1540
		public class L_LM_1 : MapLoop
		{
			public L_LM_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1550
		public class L_FA1_1 : MapLoop
		{
			public L_FA1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FA1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FA2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

