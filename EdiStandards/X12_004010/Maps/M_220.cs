using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_220 : MapLoop
	{
		public M_220() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new B9A() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 7 },
				new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new MS3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_LCD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new L_N7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new L_S5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
			});
		}

		//0500
		public class L_LCD : MapLoop
		{
			public L_LCD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LCD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
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
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
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
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LAD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//2250
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
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

