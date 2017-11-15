using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_212 : MapLoop
	{
		public M_212() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new ATA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new B2A() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 300 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
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

		//0150
		public class L_AT7 : MapLoop
		{
			public L_AT7(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AT7() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new MS1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_MS2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//0160
		public class L_MS2 : MapLoop
		{
			public L_MS2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new MS2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AT9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new BLR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new AT8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new TSD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SPO(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//0210
		public class L_SPO : MapLoop
		{
			public L_SPO(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SPO() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
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
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

