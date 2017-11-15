using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_815 : MapLoop
	{
		public M_815() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new CSM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CSB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_CSC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_CSC : MapLoop
		{
			public L_CSC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CSC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
				});
			}
		}

	}
 }

