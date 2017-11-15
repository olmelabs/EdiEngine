using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_879 : MapLoop
	{
		public M_879() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new G91() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new G36() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G26() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new G43() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new G62() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new G93() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new G46() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_G28(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
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
				});
			}
		}

		//0200
		public class L_G28 : MapLoop
		{
			public L_G28(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G28() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G20() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G69() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new G26() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new G43() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new G46() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new G22() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SAC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_G40(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//0210
		public class L_G40 : MapLoop
		{
			public L_G40(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G40() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G46() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

	}
 }

