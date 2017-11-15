using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_810 : MapLoop
	{
		public M_810() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BIG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
				new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new BAL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new INC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_V1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_FA1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_IT1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200000 },
				new TDS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new CAD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SAC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_ISS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
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
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
		public class L_N9 : MapLoop
		{
			public L_N9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//4000
		public class L_V1 : MapLoop
		{
			public L_V1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new V1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new R4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//5000
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

		//6000
		public class L_IT1 : MapLoop
		{
			public L_IT1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IT1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IT3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
					new L_PID(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CAD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SAC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
					new L_LM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_V1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_FA1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//6100
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

		//6200
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

		//6300
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new TC2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//6400
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
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6500
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

		//6600
		public class L_V1_1 : MapLoop
		{
			public L_V1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new V1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new R4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//6700
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

		//7000
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

		//8000
		public class L_ISS : MapLoop
		{
			public L_ISS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ISS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

