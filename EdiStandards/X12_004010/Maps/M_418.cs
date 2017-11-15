using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_418 : MapLoop
	{
		public M_418() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BAX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_W1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 30 },
			});
		}

		//1000
		public class L_W1 : MapLoop
		{
			public L_W1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new W1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_W2(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 400 },
				});
			}
		}

		//1100
		public class L_W2 : MapLoop
		{
			public L_W2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new W2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new W3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 7 },
					new IMA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new W4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new W5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new W6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new PS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LH1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1110
		public class L_LH1 : MapLoop
		{
			public L_LH1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LH1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

