using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_353 : MapLoop
	{
		public M_353() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new M10() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new P4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new M15() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
			});
		}

	}
 }

