using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_998 : MapLoop
	{
		public M_998() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new ZD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}

	}
 }

