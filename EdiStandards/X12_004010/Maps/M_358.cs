using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_358 : MapLoop
	{
		public M_358() : base(null)
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
					new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 500 },
				});
			}
		}

		//1100
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new VID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_MBL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
				});
			}
		}

		//1110
		public class L_MBL : MapLoop
		{
			public L_MBL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new MBL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new M13() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new VID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				});
			}
		}

	}
 }

