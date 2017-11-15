using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_849 : MapLoop
	{
		public M_849() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BRC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new L_CON(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10000 },
				new CTT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
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
					new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new L_PAD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
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
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
					new UIT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new RCD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SSS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

