using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_404 : MapLoop
	{
		public M_404() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new ZC1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new BX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new BNX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new M3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 30 },
				new CM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new M1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_N7(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 500 },
				new NA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new F9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new D9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new L_S1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new R9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_E1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new PS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 25 },
				new L_T1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 64 },
				new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LH1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new LHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new XH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new X7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

		//1000
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new EM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_VC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 21 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M12() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_E1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new GA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new L_REF(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//1100
		public class L_VC : MapLoop
		{
			public L_VC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//1110
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1200
		public class L_E1 : MapLoop
		{
			public L_E1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new E4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new E5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1300
		public class L_REF : MapLoop
		{
			public L_REF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//1310
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
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
					new S2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new S9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//4000
		public class L_E1_1 : MapLoop
		{
			public L_E1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new E4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new E5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new L5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 15 },
					new L_L0(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				});
			}
		}

		//5100
		public class L_L0 : MapLoop
		{
			public L_L0(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L0() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				});
			}
		}

		//6000
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

		//7000
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

