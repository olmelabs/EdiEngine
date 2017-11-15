using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_880 : MapLoop
	{
		public M_880() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new G01() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new G27() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new G25() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new L_G72(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_G17(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new L_ENT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new G31() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G33() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
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
				});
			}
		}

		//0200
		public class L_G72 : MapLoop
		{
			public L_G72(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G72() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G73() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0300
		public class L_G17 : MapLoop
		{
			public L_G17(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G17() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G69() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new G19() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G20() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new G25() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_G72_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//0310
		public class L_G72_1 : MapLoop
		{
			public L_G72_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G72() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G73() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0400
		public class L_ENT : MapLoop
		{
			public L_ENT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_REF(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0410
		public class L_REF : MapLoop
		{
			public L_REF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new G72() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_G17_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0411
		public class L_G17_1 : MapLoop
		{
			public L_G17_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G17() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G19() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

