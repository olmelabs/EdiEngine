using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_877 : MapLoop
	{
		public M_877() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 3 },
				new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_ENT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//0100
		public class L_ENT : MapLoop
		{
			public L_ENT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_LIN(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//0110
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_G28(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
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
					new G69() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

