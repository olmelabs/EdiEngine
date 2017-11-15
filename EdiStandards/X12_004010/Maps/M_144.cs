using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_144 : MapLoop
	{
		public M_144() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new GR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new LV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new DB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new IDB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_ENT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
			});
		}

		//1000
		public class L_ENT : MapLoop
		{
			public L_ENT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

