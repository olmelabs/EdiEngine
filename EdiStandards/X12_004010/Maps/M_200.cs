using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_200 : MapLoop
	{
		public M_200() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CRO() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new NX1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new L_TLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_RO(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new L_CCI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_INQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_VAR(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_NTE(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_REF(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_IN1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 15 },
					new L_NX1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//2100
		public class L_IN1 : MapLoop
		{
			public L_IN1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//2200
		public class L_NX1 : MapLoop
		{
			public L_NX1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ARS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//2300
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_SOI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2310
		public class L_SOI : MapLoop
		{
			public L_SOI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SOI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new EMS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_AIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 7 },
				});
			}
		}

		//2311
		public class L_AIN : MapLoop
		{
			public L_AIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3000
		public class L_TLN : MapLoop
		{
			public L_TLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 7 },
					new TBI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PPD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_AMT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				});
			}
		}

		//3100
		public class L_AMT : MapLoop
		{
			public L_AMT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AMT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//4000
		public class L_RO : MapLoop
		{
			public L_RO(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RO() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CDS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TBI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_AMT_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//4100
		public class L_AMT_1 : MapLoop
		{
			public L_AMT_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AMT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//4200
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//5000
		public class L_CCI : MapLoop
		{
			public L_CCI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CCI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
				});
			}
		}

		//6000
		public class L_INQ : MapLoop
		{
			public L_INQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new INQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TBI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//7000
		public class L_VAR : MapLoop
		{
			public L_VAR(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VAR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new IN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N10() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_NX1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SCM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//7100
		public class L_NX1_1 : MapLoop
		{
			public L_NX1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//7200
		public class L_N1_3 : MapLoop
		{
			public L_N1_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new EMS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//7300
		public class L_SCM : MapLoop
		{
			public L_SCM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SCS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//8000
		public class L_NTE : MapLoop
		{
			public L_NTE(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NTE() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TBI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//9000
		public class L_REF : MapLoop
		{
			public L_REF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G32() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

