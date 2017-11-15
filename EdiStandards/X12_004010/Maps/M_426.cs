using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_426 : MapLoop
	{
		public M_426() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new ZR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new BX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_BNX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_BNX : MapLoop
		{
			public L_BNX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BNX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_N7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
					new N8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 499 },
					new N8A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 499 },
					new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new F9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new D9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_S1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new L_R2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
					new R9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new PS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new L_T1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 64 },
					new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L1A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
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
					new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 21 },
					new IC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new GA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				});
			}
		}

		//1200
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new BL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				});
			}
		}

		//1300
		public class L_S1 : MapLoop
		{
			public L_S1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new S9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1400
		public class L_R2 : MapLoop
		{
			public L_R2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_R2B(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
				});
			}
		}

		//1410
		public class L_R2B : MapLoop
		{
			public L_R2B(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R2B() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new R2C() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new R2D() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//1500
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new L_L0(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//1510
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1600
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

