using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_431 : MapLoop
	{
		public M_431() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SMB() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new CD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new SMS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new SMA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SMR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new SMO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

	}
 }

