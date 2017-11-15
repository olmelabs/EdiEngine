using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_425 : MapLoop
	{
		public M_425() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new L_ZT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 255 },
			});
		}

		//1000
		public class L_ZT : MapLoop
		{
			public L_ZT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ZT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new F9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new D9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

