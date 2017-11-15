using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_126 : MapLoop
	{
		public M_126() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new L_BVA(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
			});
		}

		//1000
		public class L_BVA : MapLoop
		{
			public L_BVA(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BVA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new V1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_VAD(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
				});
			}
		}

		//1100
		public class L_VAD : MapLoop
		{
			public L_VAD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VAD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

