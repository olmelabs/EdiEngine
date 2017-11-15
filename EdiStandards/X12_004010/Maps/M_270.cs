using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_270 : MapLoop
	{
		public M_270() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BHT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//2000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new L_NM1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new INS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new L_EQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//2110
		public class L_EQ : MapLoop
		{
			public L_EQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new EQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new VEH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PDR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PDP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new III() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
				});
			}
		}

	}
 }

