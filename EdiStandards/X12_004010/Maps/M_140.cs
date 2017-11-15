using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_140 : MapLoop
	{
		public M_140() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 3 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
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
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LIN(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2200
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

		//2300
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PSC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2310
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2320
		public class L_PSC : MapLoop
		{
			public L_PSC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PSC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SSS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2330
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PSC_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2331
		public class L_N1_3 : MapLoop
		{
			public L_N1_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2332
		public class L_PSC_1 : MapLoop
		{
			public L_PSC_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PSC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SSS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2340
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

	}
 }

