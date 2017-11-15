using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_895 : MapLoop
	{
		public M_895() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new G87() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G88() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_G89(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G72() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new G84() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G86() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G85() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}

		//0100
		public class L_G89 : MapLoop
		{
			public L_G89(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G89() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G22() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G72() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

	}
 }

