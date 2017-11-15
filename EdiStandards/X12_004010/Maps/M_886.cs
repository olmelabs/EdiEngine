using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_886 : MapLoop
	{
		public M_886() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_ENT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5000 },
			});
		}

		//0100
		public class L_ENT : MapLoop
		{
			public L_ENT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 150 },
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
					new G32() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new G37() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_G28(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

		//0111
		public class L_G28 : MapLoop
		{
			public L_G28(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G28() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G29() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new G35() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

