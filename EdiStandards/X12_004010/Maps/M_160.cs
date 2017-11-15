using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_160 : MapLoop
	{
		public M_160() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BAX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new AES() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new YNQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new AEI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 16 },
				new L_EI(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 500 },
			});
		}

		//1000
		public class L_EI : MapLoop
		{
			public L_EI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new EI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_TSI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//1100
		public class L_TSI : MapLoop
		{
			public L_TSI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TSI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new L_QTY(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//1110
		public class L_QTY : MapLoop
		{
			public L_QTY(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new QTY() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

	}
 }

