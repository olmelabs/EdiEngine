using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_829 : MapLoop
	{
		public M_829() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new PCR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

	}
 }

