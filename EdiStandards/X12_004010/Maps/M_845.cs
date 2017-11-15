using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_845 : MapLoop
	{
		public M_845() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BPA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10000 },
				new L_CON(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10000 },
				new CTT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
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
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2000
		public class L_CON : MapLoop
		{
			public L_CON(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CON() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10000 },
					new L_PAD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
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
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//2200
		public class L_PAD : MapLoop
		{
			public L_PAD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PAD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
					new UIT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SSS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SHP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_LIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10000 },
					new L_CTP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//2210
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G53() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SLN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//2220
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//2230
		public class L_CTP : MapLoop
		{
			public L_CTP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CTP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new L_N1_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10000 },
				});
			}
		}

		//2231
		public class L_N1_3 : MapLoop
		{
			public L_N1_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

	}
 }

