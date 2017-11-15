using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_180 : MapLoop
	{
		public M_180() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new RDR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PRF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G38() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_BLI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
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
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
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
		public class L_BLI : MapLoop
		{
			public L_BLI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BLI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new RDR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PRF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new DD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new GF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_LM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
					new L_QTY(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_FA1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
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
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//3300
		public class L_QTY : MapLoop
		{
			public L_QTY(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new QTY() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LM_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3310
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

		//3320
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LM_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//3321
		public class L_LM_3 : MapLoop
		{
			public L_LM_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//3400
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

	}
 }

