using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_926 : MapLoop
	{
		public M_926() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new L_F11(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 500 },
			});
		}

		//1000
		public class L_F11 : MapLoop
		{
			public L_F11(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new F11() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new F14() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new F13() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

