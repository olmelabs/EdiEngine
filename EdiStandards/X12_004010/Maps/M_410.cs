using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_410 : MapLoop
	{
		public M_410() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B3B() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new C4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new CM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new L_N7(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 500 },
				new N8() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 499 },
				new F9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new D9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_S1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new R9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 25 },
				new L_T1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 64 },
				new L3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new X7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
			});
		}

		//1000
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 21 },
					new G4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M12() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new GA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				});
			}
		}

		//2000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new BL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				});
			}
		}

		//3000
		public class L_S1 : MapLoop
		{
			public L_S1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new S2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new S9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//4000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 15 },
					new L_L0(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 25 },
				});
			}
		}

		//4100
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				});
			}
		}

		//5000
		public class L_T1 : MapLoop
		{
			public L_T1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new T1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new T2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new T3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new T6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new T8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

	}
 }

