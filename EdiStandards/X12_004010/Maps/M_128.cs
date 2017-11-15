using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_128 : MapLoop
	{
		public M_128() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 7 },
				new R9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new DH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 28 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

	}
 }

