using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_273 : MapLoop
	{
		public M_273() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new UD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new L_ACT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2000
		public class L_ACT : MapLoop
		{
			public L_ACT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ACT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new UD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 19 },
					new BLI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new L_MSG(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new BLI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new INV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new UD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new RPA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L_BEN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_ENT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2110
		public class L_BEN : MapLoop
		{
			public L_BEN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BEN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2120
		public class L_ENT : MapLoop
		{
			public L_ENT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new UD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L_LQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_BEN_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_BLI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2121
		public class L_LQ : MapLoop
		{
			public L_LQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L_NM1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2122
		public class L_NM1_1 : MapLoop
		{
			public L_NM1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
				});
			}
		}

		//2125
		public class L_BEN_1 : MapLoop
		{
			public L_BEN_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BEN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2126
		public class L_BLI : MapLoop
		{
			public L_BLI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BLI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new INV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new UD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new UDA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new M1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new RPA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L_BEN_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2127
		public class L_BEN_2 : MapLoop
		{
			public L_BEN_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BEN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2200
		public class L_MSG : MapLoop
		{
			public L_MSG(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new MSG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

