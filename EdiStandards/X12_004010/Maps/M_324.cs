using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_324 : MapLoop
	{
		public M_324() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new V1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_R4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
				new L_N7(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
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

		//2000
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new ED() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new V4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new R4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new H1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

