using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_920 : MapLoop
	{
		public M_920() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new F01() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_F02(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//2000
		public class L_F02 : MapLoop
		{
			public L_F02(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new F02() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new F05() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new Q7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_F09(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//2100
		public class L_F09 : MapLoop
		{
			public L_F09(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new F09() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new F04() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new F05() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				});
			}
		}

	}
 }

