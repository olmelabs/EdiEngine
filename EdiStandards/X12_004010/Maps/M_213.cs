using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_213 : MapLoop
	{
		public M_213() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B11() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new K2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
			});
		}

		//0100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

