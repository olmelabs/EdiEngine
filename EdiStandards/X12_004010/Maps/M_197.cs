using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_197 : MapLoop
	{
		public M_197() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
				new L_PID(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
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
		public class L_PID : MapLoop
		{
			public L_PID(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 12 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_NX1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_FGS(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_EFI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2110
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

		//2200
		public class L_NX1 : MapLoop
		{
			public L_NX1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PDS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new PDE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2300
		public class L_FGS : MapLoop
		{
			public L_FGS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FGS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new FPT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_IN1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2310
		public class L_IN1 : MapLoop
		{
			public L_IN1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new M1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2320
		public class L_LQ : MapLoop
		{
			public L_LQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_IN1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2321
		public class L_IN1_1 : MapLoop
		{
			public L_IN1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new M1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
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
					new G86() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

