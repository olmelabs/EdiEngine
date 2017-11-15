using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_222 : MapLoop
	{
		public M_222() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SCN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_PLC(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_S5(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
				new L_LAD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
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
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2000
		public class L_PLC : MapLoop
		{
			public L_PLC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PLC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AT5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
					new L_S5(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
				});
			}
		}

		//2100
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new AT3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2200
		public class L_S5 : MapLoop
		{
			public L_S5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AT5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new PLD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_LAD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new L_LX_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//2210
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2400
		public class L_LAD : MapLoop
		{
			public L_LAD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LAD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_G61(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2410
		public class L_G61 : MapLoop
		{
			public L_G61(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G61() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new LH6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_LH1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				});
			}
		}

		//2415
		public class L_LH1 : MapLoop
		{
			public L_LH1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LH1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2600
		public class L_LX_1 : MapLoop
		{
			public L_LX_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AT3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

