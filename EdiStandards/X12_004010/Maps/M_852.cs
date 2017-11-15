using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_852 : MapLoop
	{
		public M_852() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new XQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new XPO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
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
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2000
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PAL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_ZA(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_ZA : MapLoop
		{
			public L_ZA(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ZA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_G95(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2110
		public class L_G95 : MapLoop
		{
			public L_G95(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G95() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

	}
 }

