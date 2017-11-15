using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_125 : MapLoop
	{
		public M_125() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BMM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G62() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 21 },
			});
		}

	}
 }

