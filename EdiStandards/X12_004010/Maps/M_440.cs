using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_440 : MapLoop
	{
		public M_440() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BW() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 255 },
			});
		}

	}
 }

