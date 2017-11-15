using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_423 : MapLoop
	{
		public M_423() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 150 },
			});
		}

		//1000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new XD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new L_N7(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 150 },
				});
			}
		}

		//1100
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new XD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new D9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new F9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_LH1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
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

