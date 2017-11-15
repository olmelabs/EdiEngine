using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_120 : MapLoop
	{
		public M_120() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BVP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_G62(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
			});
		}

		//1000
		public class L_G62 : MapLoop
		{
			public L_G62(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G62() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_VC(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				});
			}
		}

		//1100
		public class L_VC : MapLoop
		{
			public L_VC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new VC1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

