using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_163 : MapLoop
	{
		public M_163() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B13() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new B2A() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new H6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new N7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G05() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_S5(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
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
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_SPO(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99999 },
				});
			}
		}

		//0150
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

		//0300
		public class L_S5 : MapLoop
		{
			public L_S5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new H6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_SPO_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99999 },
				});
			}
		}

		//0350
		public class L_SPO_1 : MapLoop
		{
			public L_SPO_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SPO() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

