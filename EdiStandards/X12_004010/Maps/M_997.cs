using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_997 : MapLoop
	{
		public M_997() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new AK1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_AK2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new AK9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_AK2 : MapLoop
		{
			public L_AK2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AK2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_AK3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AK5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1100
		public class L_AK3 : MapLoop
		{
			public L_AK3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AK3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AK4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

	}
 }

