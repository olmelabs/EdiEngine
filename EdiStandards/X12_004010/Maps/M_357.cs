using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_357 : MapLoop
	{
		public M_357() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new M10() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_P4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
			});
		}

		//1000
		public class L_P4 : MapLoop
		{
			public L_P4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new P4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_M21(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				});
			}
		}

		//1100
		public class L_M21 : MapLoop
		{
			public L_M21(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M21() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new M12() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				});
			}
		}

	}
 }

