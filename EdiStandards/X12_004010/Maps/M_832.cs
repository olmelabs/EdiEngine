using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_832 : MapLoop
	{
		public M_832() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BCT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new LDT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new G93() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_LIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
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
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2000
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

		//3000
		public class L_N9 : MapLoop
		{
			public L_N9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//4000
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PO1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G53() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CRD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
					new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new LDT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TC2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new G55() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G54() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_CTP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_G39(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PKL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_LFG(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N9_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//4100
		public class L_CTP : MapLoop
		{
			public L_CTP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CTP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G40() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G36() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LDT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new G43() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new G26() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//4200
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
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//4300
		public class L_G39 : MapLoop
		{
			public L_G39(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G39() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//4400
		public class L_PKL : MapLoop
		{
			public L_PKL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PKL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//4500
		public class L_LFG : MapLoop
		{
			public L_LFG(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LFG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_CRC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//4510
		public class L_CRC : MapLoop
		{
			public L_CRC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CRC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//4600
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

		//4700
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LM_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//4710
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

		//4800
		public class L_N9_1 : MapLoop
		{
			public L_N9_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

