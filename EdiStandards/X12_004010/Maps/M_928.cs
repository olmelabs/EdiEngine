using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_928 : MapLoop
	{
		public M_928() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BIX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new TI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_VC(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 21 },
			});
		}

		//1000
		public class L_VC : MapLoop
		{
			public L_VC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new ID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

	}
 }

