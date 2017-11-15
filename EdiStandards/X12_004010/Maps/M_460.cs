using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_460 : MapLoop
	{
		public M_460() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new REN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DK() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 8 },
				new PR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new SS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new CD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 150 },
				new RAB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 48 },
				new L_PT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new L_SB(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 50 },
			});
		}

		//1000
		public class L_PT : MapLoop
		{
			public L_PT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2000
		public class L_SB : MapLoop
		{
			public L_SB(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SB() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 150 },
					new L_SC(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 300 },
				});
			}
		}

		//2100
		public class L_SC : MapLoop
		{
			public L_SC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 150 },
					new CD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 150 },
					new RAB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 48 },
					new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 60 },
				});
			}
		}

		//2110
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new RS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
					new RD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new L_R9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2111
		public class L_R9 : MapLoop
		{
			public L_R9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
					new L_R2B(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				});
			}
		}

		//2112
		public class L_R2B : MapLoop
		{
			public L_R2B(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R2B() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new R2C() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

	}
 }

