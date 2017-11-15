using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_885 : MapLoop
	{
		public M_885() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 3 },
				new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_ENT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//0100
		public class L_ENT : MapLoop
		{
			public L_ENT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G53() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G13() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G18() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new G29() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G30() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new SPR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new RDI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0110
		public class L_LM : MapLoop
		{
			public L_LM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

