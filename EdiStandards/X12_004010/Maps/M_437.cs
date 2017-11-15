using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_437 : MapLoop
	{
		public M_437() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BJF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new JCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_JS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
			});
		}

		//1000
		public class L_JS : MapLoop
		{
			public L_JS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new JS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new SID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

	}
 }

