using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_466 : MapLoop
	{
		public M_466() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new REN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PR1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PR2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

	}
 }

