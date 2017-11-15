using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_432 : MapLoop
	{
		public M_432() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new BLR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

		//1000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 8 },
					new DRT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_CIC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1500 },
				});
			}
		}

		//1100
		public class L_CIC : MapLoop
		{
			public L_CIC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CIC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DRT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

