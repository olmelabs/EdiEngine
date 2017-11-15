using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_250 : MapLoop
	{
		public M_250() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new SSD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_PRF(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//0100
		public class L_PRF : MapLoop
		{
			public L_PRF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PRF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G05() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0110
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new G05() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

