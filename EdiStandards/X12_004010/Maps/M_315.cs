using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_315 : MapLoop
	{
		public M_315() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new Q2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				new L_R4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
				new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

		//1000
		public class L_R4 : MapLoop
		{
			public L_R4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				});
			}
		}

	}
 }

