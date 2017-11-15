using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_219 : MapLoop
	{
		public M_219() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new B9A() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 7 },
				new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new MS3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new L_S5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new L3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_N7 : MapLoop
		{
			public L_N7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N7A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N7B() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_S5 : MapLoop
		{
			public L_S5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_G61(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//2100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2200
		public class L_G61 : MapLoop
		{
			public L_G61(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G61() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LH1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//2250
		public class L_LH1 : MapLoop
		{
			public L_LH1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LH1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2300
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AT5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_G61_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new L_LAD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//2350
		public class L_G61_1 : MapLoop
		{
			public L_G61_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G61() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_LH1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//2355
		public class L_LH1_1 : MapLoop
		{
			public L_LH1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LH1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2370
		public class L_LAD : MapLoop
		{
			public L_LAD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LAD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G69() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new AT5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_G61_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//2375
		public class L_G61_2 : MapLoop
		{
			public L_G61_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G61() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_LH1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//2378
		public class L_LH1_2 : MapLoop
		{
			public L_LH1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LH1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

	}
 }

