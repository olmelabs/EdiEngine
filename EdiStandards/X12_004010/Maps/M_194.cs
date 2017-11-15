using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_194 : MapLoop
	{
		public M_194() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new LDT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_N9 : MapLoop
		{
			public L_N9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2000
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new HSD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new NX1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N9_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PO1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PPL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3100
		public class L_N9_1 : MapLoop
		{
			public L_N9_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_INX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3110
		public class L_INX : MapLoop
		{
			public L_INX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new INX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3200
		public class L_PO1 : MapLoop
		{
			public L_PO1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PO1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3300
		public class L_PPL : MapLoop
		{
			public L_PPL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PPL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3310
		public class L_PD : MapLoop
		{
			public L_PD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PDD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3320
		public class L_PL : MapLoop
		{
			public L_PL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PD_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3321
		public class L_PD_1 : MapLoop
		{
			public L_PD_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SPI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PDD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//3400
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new EMS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_N9_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_DEG(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_K2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3410
		public class L_N9_2 : MapLoop
		{
			public L_N9_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3420
		public class L_DEG : MapLoop
		{
			public L_DEG(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DEG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//3430
		public class L_K2 : MapLoop
		{
			public L_K2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new K2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

