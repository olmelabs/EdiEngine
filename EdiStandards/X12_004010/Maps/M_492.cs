using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_492 : MapLoop
	{
		public M_492() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new DK() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PRI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_SC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

		//0100
		public class L_SC : MapLoop
		{
			public L_SC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

