using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_451 : MapLoop
	{
		public M_451() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new ER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new L_ED(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
			});
		}

		//1000
		public class L_ED : MapLoop
		{
			public L_ED(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ED() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new ER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new CLR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new ES() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

