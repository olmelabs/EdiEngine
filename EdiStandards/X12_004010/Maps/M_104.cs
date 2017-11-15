using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_104 : MapLoop
	{
		public M_104() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new P1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G47() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new F9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_FOB(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99999 },
				new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

		//1000
		public class L_FOB : MapLoop
		{
			public L_FOB(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FOB() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SL1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new H1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new H2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
					new L_L5(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100 },
					new ACS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//1100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1200
		public class L_L5 : MapLoop
		{
			public L_L5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L0() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

