using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_876 : MapLoop
	{
		public M_876() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new G92() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new G66() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new L_G72(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_G68(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new G76() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
		public class L_G68 : MapLoop
		{
			public L_G68(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G68() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G69() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new G70() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_G72_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
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

		//0320
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0330
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G72() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

