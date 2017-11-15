using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_944 : MapLoop
	{
		public M_944() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new W17() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new W08() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new W18() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G08() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new L_W07(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
				new W14() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}

		//0100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//0200
		public class L_W07 : MapLoop
		{
			public L_W07(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new W07() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G69() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
					new W20() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_W13(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				});
			}
		}

		//0210
		public class L_W13 : MapLoop
		{
			public L_W13(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new W13() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				});
			}
		}

	}
 }

