using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_211 : MapLoop
	{
		public M_211() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BOL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new B2A() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new MS3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new MS2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new AT5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_AT1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
			});
		}

		//0100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//0200
		public class L_AT1 : MapLoop
		{
			public L_AT1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AT1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new AT3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AT4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new L_AT2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_G61(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//0210
		public class L_AT2 : MapLoop
		{
			public L_AT2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AT2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SPO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0220
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SPO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0230
		public class L_G61 : MapLoop
		{
			public L_G61(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G61() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_LH1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//0231
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
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

