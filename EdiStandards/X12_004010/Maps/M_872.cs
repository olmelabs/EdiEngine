using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_872 : MapLoop
	{
		public M_872() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new L_LRQ(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//1100
		public class L_LRQ : MapLoop
		{
			public L_LRQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LRQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PRD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MIC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PEX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new RLD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PAY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new RAT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SCM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_NX1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
					new L_IN1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 12 },
					new L_REA(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_MCD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_BUY(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_PRJ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1110
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

		//1120
		public class L_NX1 : MapLoop
		{
			public L_NX1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 30 },
					new L_PAS(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
				});
			}
		}

		//1121
		public class L_PAS : MapLoop
		{
			public L_PAS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PAS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1130
		public class L_IN1 : MapLoop
		{
			public L_IN1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new BFS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SCM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_NX1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1131
		public class L_SCM_1 : MapLoop
		{
			public L_SCM_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SCS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//1132
		public class L_NX1_1 : MapLoop
		{
			public L_NX1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new N10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ARS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1140
		public class L_REA : MapLoop
		{
			public L_REA(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1150
		public class L_MCD : MapLoop
		{
			public L_MCD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new MCD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1160
		public class L_BUY : MapLoop
		{
			public L_BUY(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BUY() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TBA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1170
		public class L_PRJ : MapLoop
		{
			public L_PRJ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PRJ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

