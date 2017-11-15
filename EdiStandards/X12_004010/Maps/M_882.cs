using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_882 : MapLoop
	{
		public M_882() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new G47() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 8 },
				new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_G48(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
				new G49() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
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
		public class L_G48 : MapLoop
		{
			public L_G48(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G48() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_G72(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new G25() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G31() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G33() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				});
			}
		}

		//0210
		public class L_G72 : MapLoop
		{
			public L_G72(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G72() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G73() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

