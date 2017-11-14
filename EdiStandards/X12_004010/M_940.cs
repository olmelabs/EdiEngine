using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;
using EdiEngine.Standards.X12_004010.Loops.M_940;

namespace EdiEngine.Standards.X12_004010
{
	public class M_940 : MapLoop
	{
		public M_940() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new W05() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new W66() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new W6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new BNX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new W76() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}
 }

