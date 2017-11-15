using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_303 : MapLoop
	{
		public M_303() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new Y6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new Y5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

	}
 }

