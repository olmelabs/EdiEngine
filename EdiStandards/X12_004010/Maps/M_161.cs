using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_161 : MapLoop
	{
		public M_161() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BTS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_FAC(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

		//1000
		public class L_FAC : MapLoop
		{
			public L_FAC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2000
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

	}
 }

