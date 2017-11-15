using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_868 : MapLoop
	{
		public M_868() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new E01() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DMI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new E03() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_E10(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_E20(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_E30(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2000 },
				new L_E40(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10000 },
			});
		}

		//1000
		public class L_E10 : MapLoop
		{
			public L_E10(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E10() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new E13() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

		//2000
		public class L_E20 : MapLoop
		{
			public L_E20(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E20() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new E22() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_E24(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//2100
		public class L_E24 : MapLoop
		{
			public L_E24(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E24() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new E26() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//3000
		public class L_E30 : MapLoop
		{
			public L_E30(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E30() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DAI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_E34(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100000 },
				});
			}
		}

		//3100
		public class L_E34 : MapLoop
		{
			public L_E34(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E34() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DDI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new DAI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//4000
		public class L_E40 : MapLoop
		{
			public L_E40(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E40() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DMI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new DDI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

	}
 }

