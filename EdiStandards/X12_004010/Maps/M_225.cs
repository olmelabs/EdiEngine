using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_225 : MapLoop
	{
		public M_225() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SCP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
			});
		}

	}
 }

