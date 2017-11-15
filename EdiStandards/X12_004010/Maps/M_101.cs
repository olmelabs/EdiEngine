using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_101 : MapLoop
	{
		public M_101() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_DTM(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_DTM : MapLoop
		{
			public L_DTM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//1100
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new NX2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SPA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new COM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

