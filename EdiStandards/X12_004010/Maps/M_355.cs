using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_355 : MapLoop
	{
		public M_355() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new M10() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_P4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
				new K3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_P4 : MapLoop
		{
			public L_P4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new P4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				});
			}
		}

		//1100
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_M13(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_M11(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_M12(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new L_M14(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new L_M15(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new L_M20(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new L_VID(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//1110
		public class L_M13 : MapLoop
		{
			public L_M13(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M13() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1120
		public class L_M11 : MapLoop
		{
			public L_M11(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M11() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1130
		public class L_N9 : MapLoop
		{
			public L_N9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1140
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_N4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_PER(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1141
		public class L_N3 : MapLoop
		{
			public L_N3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1142
		public class L_N4 : MapLoop
		{
			public L_N4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1143
		public class L_PER : MapLoop
		{
			public L_PER(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PER() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1150
		public class L_M12 : MapLoop
		{
			public L_M12(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M12() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_P5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_M21(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1151
		public class L_P5 : MapLoop
		{
			public L_P5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new P5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1152
		public class L_M21 : MapLoop
		{
			public L_M21(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M21() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1160
		public class L_M14 : MapLoop
		{
			public L_M14(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M14() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1170
		public class L_M15 : MapLoop
		{
			public L_M15(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M15() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1180
		public class L_M20 : MapLoop
		{
			public L_M20(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M20() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1190
		public class L_VID : MapLoop
		{
			public L_VID(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_MBL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new L_VC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 21 },
					new L_N10(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//1191
		public class L_MBL : MapLoop
		{
			public L_MBL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new MBL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_M13_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//1192
		public class L_M13_1 : MapLoop
		{
			public L_M13_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M13() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1194
		public class L_VC : MapLoop
		{
			public L_VC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1195
		public class L_N10 : MapLoop
		{
			public L_N10(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N10() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_H1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1196
		public class L_H1 : MapLoop
		{
			public L_H1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new H1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_H2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//1197
		public class L_H2 : MapLoop
		{
			public L_H2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new H2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

