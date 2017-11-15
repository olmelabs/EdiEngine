using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_170 : MapLoop
	{
		public M_170() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_THE(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
			});
		}

		//1000
		public class L_THE : MapLoop
		{
			public L_THE(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new THE() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
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
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new L_DTM(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 7 },
				});
			}
		}

		//1110
		public class L_DTM : MapLoop
		{
			public L_DTM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new BOX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 250 },
				});
			}
		}

	}
 }

