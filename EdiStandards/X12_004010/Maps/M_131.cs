using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_131 : MapLoop
	{
		public M_131() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new QTY() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new SUM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new IN2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}

	}
 }

