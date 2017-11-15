using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_121 : MapLoop
	{
		public M_121() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BVS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new V1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_VC(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
			});
		}

		//1000
		public class L_VC : MapLoop
		{
			public L_VC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DEL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CGS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

