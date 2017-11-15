using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_215 : MapLoop
	{
		public M_215() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B2A() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new BLR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L11() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_SMD(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
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
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L11() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0200
		public class L_SMD : MapLoop
		{
			public L_SMD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SMD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MS6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MS5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new MS4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ACS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new L_CD3(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new L_AT6(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
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
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new X2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new R4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0240
		public class L_CD3 : MapLoop
		{
			public L_CD3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CD3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new MS4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new ACS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0260
		public class L_AT6 : MapLoop
		{
			public L_AT6(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AT6() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MS5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IT1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CGS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MS4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0280
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new TC2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

