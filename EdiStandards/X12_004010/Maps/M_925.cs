using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_925 : MapLoop
	{
		public M_925() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new L_F10(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
			});
		}

		//1000
		public class L_F10 : MapLoop
		{
			public L_F10(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new F10() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new F02() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

