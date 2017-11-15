using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_255 : MapLoop
	{
		public M_255() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
				new L_ACT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2000
		public class L_ACT : MapLoop
		{
			public L_ACT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ACT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new L_NM1_1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_NM1_1 : MapLoop
		{
			public L_NM1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new L_EFI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PO1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2110
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ASI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IND() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CD2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
				});
			}
		}

		//2120
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

		//2130
		public class L_PO1 : MapLoop
		{
			public L_PO1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PO1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new ASI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LX_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2131
		public class L_LX_1 : MapLoop
		{
			public L_LX_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IND() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new EMS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new CN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new CD2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new AM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

