using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_452 : MapLoop
	{
		public M_452() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}

	}
 }

