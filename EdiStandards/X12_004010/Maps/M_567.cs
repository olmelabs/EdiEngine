using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_567 : MapLoop
	{
		public M_567() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_CS(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100 },
			});
		}

		//1000
		public class L_CS : MapLoop
		{
			public L_CS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1100
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

		//1200
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

