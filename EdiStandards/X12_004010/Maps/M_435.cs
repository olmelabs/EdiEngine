using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_435 : MapLoop
	{
		public M_435() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new L_SID(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
			});
		}

		//1000
		public class L_SID : MapLoop
		{
			public L_SID(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
				});
			}
		}

		//1100
		public class L_LQ : MapLoop
		{
			public L_LQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//1200
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 8 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

