using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_313 : MapLoop
	{
		public M_313() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
			});
		}

	}
 }

