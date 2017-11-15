using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_455 : MapLoop
	{
		public M_455() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BTC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ED() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500000 },
				new BLR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
			});
		}

		//1000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PRM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new F9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new D9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

