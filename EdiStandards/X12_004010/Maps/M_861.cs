using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_861 : MapLoop
	{
		public M_861() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BRA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new PRF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_RCD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200000 },
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
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
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
		public class L_RCD : MapLoop
		{
			public L_RCD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RCD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PRF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				});
			}
		}

		//3100
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

		//3200
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LM_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//3210
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

		//3300
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

