using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_851 : MapLoop
	{
		public M_851() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BLS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 7 },
				new TAX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 35 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100000 },
				new L_LS1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new CTT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2000
		public class L_LS1 : MapLoop
		{
			public L_LS1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LS1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PO3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 7 },
					new TAX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 35 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
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
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

