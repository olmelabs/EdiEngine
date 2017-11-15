using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_214 : MapLoop
	{
		public M_214() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B10() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 300 },
				new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new MS3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
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
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0200
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_AT7(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new Q7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AT5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AT8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_CD3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PRF(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SPO(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_EFI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0205
		public class L_AT7 : MapLoop
		{
			public L_AT7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AT7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MS1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MS2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//0210
		public class L_CD3 : MapLoop
		{
			public L_CD3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CD3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_AT7_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new Q7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AT8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0215
		public class L_AT7_1 : MapLoop
		{
			public L_AT7_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AT7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MS1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MS2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//0220
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0230
		public class L_PRF : MapLoop
		{
			public L_PRF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PRF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_CD3_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0231
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0233
		public class L_CD3_1 : MapLoop
		{
			public L_CD3_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CD3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_AT7_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				});
			}
		}

		//0240
		public class L_AT7_2 : MapLoop
		{
			public L_AT7_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AT7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MS1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MS2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//0250
		public class L_SPO : MapLoop
		{
			public L_SPO(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SPO() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0260
		public class L_EFI : MapLoop
		{
			public L_EFI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new EFI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new BIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

