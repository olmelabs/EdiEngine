using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_990 : MapLoop
	{
		public M_990() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new N7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
				new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_S5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
			});
		}

		//0100
		public class L_S5 : MapLoop
		{
			public L_S5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

