using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_110 : MapLoop
	{
		public M_110() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new B3A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new C2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
				new L3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new ACS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new P1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new R1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new POD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new RMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G47() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_L5(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 4 },
				});
			}
		}

		//2100
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2200
		public class L_L5 : MapLoop
		{
			public L_L5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L0() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new L10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new SL1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_L1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				});
			}
		}

		//2210
		public class L_L1 : MapLoop
		{
			public L_L1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

