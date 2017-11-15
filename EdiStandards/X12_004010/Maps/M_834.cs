using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_834 : MapLoop
	{
		public M_834() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new L_INS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}

		//1000
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
					new L_ACT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1100
		public class L_ACT : MapLoop
		{
			public L_ACT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ACT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_INS : MapLoop
		{
			public L_INS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new INS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_DSB(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new L_HD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new L_LC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_FSA(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_RP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new EC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ICM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new HLH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new HI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LUI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2200
		public class L_DSB : MapLoop
		{
			public L_DSB(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DSB() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2300
		public class L_HD : MapLoop
		{
			public L_HD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new IDC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new L_COB(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2310
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new PLA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2320
		public class L_COB : MapLoop
		{
			public L_COB(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new COB() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2400
		public class L_LC : MapLoop
		{
			public L_LC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_BEN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//2410
		public class L_BEN : MapLoop
		{
			public L_BEN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BEN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2500
		public class L_FSA : MapLoop
		{
			public L_FSA(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FSA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2600
		public class L_RP : MapLoop
		{
			public L_RP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new INV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new REL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_NM1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_FC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2610
		public class L_NM1_1 : MapLoop
		{
			public L_NM1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new BEN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NX1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2620
		public class L_NX1 : MapLoop
		{
			public L_NX1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2630
		public class L_FC : MapLoop
		{
			public L_FC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_INV(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2640
		public class L_INV : MapLoop
		{
			public L_INV(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new INV() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ENT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2650
		public class L_AIN : MapLoop
		{
			public L_AIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

