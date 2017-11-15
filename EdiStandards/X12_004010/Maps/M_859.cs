using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_859 : MapLoop
	{
		public M_859() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new B3A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new CM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new Y6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
				new Y7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new F9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new D9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new R1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new PS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new H6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new M1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new M2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new XH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new P1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 499 },
				new R9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_H1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_N7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 600 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_S5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_H1 : MapLoop
		{
			public L_H1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new H1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new H2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2000
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new IC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 21 },
					new G4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new GA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				});
			}
		}

		//3000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//4000
		public class L_S5 : MapLoop
		{
			public L_S5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new H6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//4100
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//5000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_L0(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new SL1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new R1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new P1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new POD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new P2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_H1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//5100
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//5200
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//5300
		public class L_H1_1 : MapLoop
		{
			public L_H1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new H1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new H2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

	}
 }

