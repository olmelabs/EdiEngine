using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_429 : MapLoop
	{
		public M_429() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new RU1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new L_RU2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
			});
		}

		//1000
		public class L_RU2 : MapLoop
		{
			public L_RU2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RU2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new RU3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

	}
 }

