using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_301 : MapLoop
	{
		public M_301() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new Y6() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new Y3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_Y4(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new R2A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
				new L_R4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
				new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new EA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				new V1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

		//1000
		public class L_Y4 : MapLoop
		{
			public L_Y4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new Y4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
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

		//3000
		public class L_R4 : MapLoop
		{
			public L_R4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				});
			}
		}

		//4000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L0() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_H1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//4100
		public class L_H1 : MapLoop
		{
			public L_H1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new H1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new H2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

