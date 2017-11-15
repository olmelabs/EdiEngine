using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_823 : MapLoop
	{
		public M_823() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new L_DEP(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100 },
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
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2000
		public class L_DEP : MapLoop
		{
			public L_DEP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DEP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_BAT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_BAT : MapLoop
		{
			public L_BAT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BAT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AVA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_BPR(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2110
		public class L_BPR : MapLoop
		{
			public L_BPR(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BPR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AVA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_ADX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
					new L_RMR(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_TXP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DED() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2111
		public class L_ADX : MapLoop
		{
			public L_ADX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ADX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_REF(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_IT1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2112
		public class L_REF : MapLoop
		{
			public L_REF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2113
		public class L_IT1 : MapLoop
		{
			public L_IT1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IT1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_REF_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SAC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2114
		public class L_REF_1 : MapLoop
		{
			public L_REF_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2115
		public class L_SAC : MapLoop
		{
			public L_SAC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2116
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_REF_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SAC_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2117
		public class L_REF_2 : MapLoop
		{
			public L_REF_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2118
		public class L_SAC_1 : MapLoop
		{
			public L_SAC_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2120
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

		//2130
		public class L_RMR : MapLoop
		{
			public L_RMR(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RMR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_IT1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_ADX_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2131
		public class L_IT1_1 : MapLoop
		{
			public L_IT1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IT1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_REF_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SAC_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SLN_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2132
		public class L_REF_3 : MapLoop
		{
			public L_REF_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2133
		public class L_SAC_2 : MapLoop
		{
			public L_SAC_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2134
		public class L_SLN_1 : MapLoop
		{
			public L_SLN_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_REF_4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SAC_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2135
		public class L_REF_4 : MapLoop
		{
			public L_REF_4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2136
		public class L_SAC_3 : MapLoop
		{
			public L_SAC_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2140
		public class L_ADX_1 : MapLoop
		{
			public L_ADX_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ADX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_REF_5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_IT1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2141
		public class L_REF_5 : MapLoop
		{
			public L_REF_5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2142
		public class L_IT1_2 : MapLoop
		{
			public L_IT1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IT1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_REF_6(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SAC_4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SLN_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2143
		public class L_REF_6 : MapLoop
		{
			public L_REF_6(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2144
		public class L_SAC_4 : MapLoop
		{
			public L_SAC_4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2145
		public class L_SLN_2 : MapLoop
		{
			public L_SLN_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_REF_7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SAC_5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2146
		public class L_REF_7 : MapLoop
		{
			public L_REF_7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2147
		public class L_SAC_5 : MapLoop
		{
			public L_SAC_5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2150
		public class L_TXP : MapLoop
		{
			public L_TXP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TXP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2160
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2161
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new G53() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PEN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2162
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

		//2163
		public class L_PEN : MapLoop
		{
			public L_PEN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PEN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_INV(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2164
		public class L_INV : MapLoop
		{
			public L_INV(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new INV() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

