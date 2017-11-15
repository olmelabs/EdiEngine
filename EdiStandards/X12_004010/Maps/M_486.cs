using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_486 : MapLoop
	{
		public M_486() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new REN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}

	}
 }

