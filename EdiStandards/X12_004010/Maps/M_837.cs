using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_837 : MapLoop
	{
		public M_837() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BHT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SBR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PAT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_NM1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_CLM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//2010
		public class L_NM1_1 : MapLoop
		{
			public L_NM1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2300
		public class L_CLM : MapLoop
		{
			public L_CLM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CLM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 150 },
					new CL1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 35 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DSB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new UR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new CR1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new CR5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new HI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new HCP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_CR7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_NM1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new L_SBR(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2305
		public class L_CR7 : MapLoop
		{
			public L_CR7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CR7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new HSD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				});
			}
		}

		//2310
		public class L_NM1_2 : MapLoop
		{
			public L_NM1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2320
		public class L_SBR : MapLoop
		{
			public L_SBR(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SBR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CAS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new OI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MIA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MOA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_NM1_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2330
		public class L_NM1_3 : MapLoop
		{
			public L_NM1_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2400
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SV1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SV2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SV3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TOO() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 32 },
					new SV4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SV5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SV6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SV7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new HI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CR1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new CR3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CR4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new CR5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new CN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new K3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PS1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IMM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new HSD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new HCP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1_4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_SVD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2410
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2420
		public class L_NM1_4 : MapLoop
		{
			public L_NM1_4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2430
		public class L_SVD : MapLoop
		{
			public L_SVD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SVD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CAS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
				});
			}
		}

	}
 }

