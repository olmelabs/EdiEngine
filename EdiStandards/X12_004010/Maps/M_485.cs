using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_485 : MapLoop
	{
		public M_485() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new DK() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PRI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_SC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 8 },
			});
		}

		//0100
		public class L_SC : MapLoop
		{
			public L_SC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_RA(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0110
		public class L_RA : MapLoop
		{
			public L_RA(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_MC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 64 },
					new SW() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//0111
		public class L_MC : MapLoop
		{
			public L_MC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new MC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

