using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_350 : MapLoop
	{
		public M_350() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new M10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_P4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_BA1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
			});
		}

		//1000
		public class L_P4 : MapLoop
		{
			public L_P4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new P4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_X4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				});
			}
		}

		//1100
		public class L_N9 : MapLoop
		{
			public L_N9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
				});
			}
		}

		//1200
		public class L_X4 : MapLoop
		{
			public L_X4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new X4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new N7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//2000
		public class L_BA1 : MapLoop
		{
			public L_BA1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BA1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_X4_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				});
			}
		}

		//2100
		public class L_X4_1 : MapLoop
		{
			public L_X4_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new X4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
				});
			}
		}

	}
 }

