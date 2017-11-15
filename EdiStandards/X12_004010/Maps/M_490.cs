using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_490 : MapLoop
	{
		public M_490() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new REN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DK() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new GH() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 8 },
				new TT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new CD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new PR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new L_PT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
			});
		}

		//1000
		public class L_PT : MapLoop
		{
			public L_PT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

	}
 }

