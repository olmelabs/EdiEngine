using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_494 : MapLoop
	{
		public M_494() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new REN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DK() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 8 },
				new PR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new SS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 150 },
				new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 150 },
				new RAB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new PT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_R9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_SCL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
			});
		}

		//1000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				});
			}
		}

		//2000
		public class L_R9 : MapLoop
		{
			public L_R9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_R2B(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2100
		public class L_R2B : MapLoop
		{
			public L_R2B(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R2B() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new R2C() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//3000
		public class L_SCL : MapLoop
		{
			public L_SCL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new RD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				});
			}
		}

	}
 }

