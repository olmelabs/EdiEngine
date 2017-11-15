using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_218 : MapLoop
	{
		public M_218() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new TF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_TS(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_SCL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_SCL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_SCL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2000
		public class L_TS : MapLoop
		{
			public L_TS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new CL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new WGP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TFR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new TFM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2100
		public class L_SCL : MapLoop
		{
			public L_SCL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TFM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new RTS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2200
		public class L_SCL_1 : MapLoop
		{
			public L_SCL_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TFM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_CL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//2210
		public class L_CL : MapLoop
		{
			public L_CL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new RTS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LX_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2310
		public class L_LX_1 : MapLoop
		{
			public L_LX_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new SCL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TFR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new TFM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new RTS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SCL_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2320
		public class L_SCL_2 : MapLoop
		{
			public L_SCL_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new RTS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2400
		public class L_LX_2 : MapLoop
		{
			public L_LX_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LX_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2410
		public class L_LX_3 : MapLoop
		{
			public L_LX_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new L_SCL_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				});
			}
		}

		//2420
		public class L_SCL_3 : MapLoop
		{
			public L_SCL_3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TFR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new TFM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_CL_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//2430
		public class L_CL_1 : MapLoop
		{
			public L_CL_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new RTS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2500
		public class L_LX_4 : MapLoop
		{
			public L_LX_4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new SCL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2600
		public class L_LX_5 : MapLoop
		{
			public L_LX_5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LX_6(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2610
		public class L_LX_6 : MapLoop
		{
			public L_LX_6(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new TFA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TFD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2700
		public class L_SCL_4 : MapLoop
		{
			public L_SCL_4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_CL_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2710
		public class L_CL_2 : MapLoop
		{
			public L_CL_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TFA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TFD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2800
		public class L_LX_7 : MapLoop
		{
			public L_LX_7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

	}
 }

