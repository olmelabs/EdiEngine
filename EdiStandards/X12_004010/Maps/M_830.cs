using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_830 : MapLoop
	{
		public M_830() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BFR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new XPO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new TAX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new CSH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
				new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_LIN(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
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
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//3000
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new UIT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PO3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PRS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new TAX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LDT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ATH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
					new L_LM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_FST(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SDP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 260 },
					new L_SHP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//3100
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//3200
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
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3300
		public class L_LM_1 : MapLoop
		{
			public L_LM_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//3400
		public class L_FST : MapLoop
		{
			public L_FST(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FST() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new L_LM_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3410
		public class L_LM_2 : MapLoop
		{
			public L_LM_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//3500
		public class L_SDP : MapLoop
		{
			public L_SDP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SDP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FST() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 260 },
				});
			}
		}

		//3600
		public class L_SHP : MapLoop
		{
			public L_SHP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SHP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

