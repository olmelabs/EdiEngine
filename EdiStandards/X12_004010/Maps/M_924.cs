using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_924 : MapLoop
	{
		public M_924() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new F01() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new F6X() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new F02() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new F12() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new F07() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
			});
		}

	}
 }

