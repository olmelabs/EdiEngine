using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_278 : MapLoop
	{
		public M_278() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BHT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new UM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new HCR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new HI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new HSD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new CL1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1100
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
					new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new INS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
				});
			}
		}

	}
 }

