using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_325 : MapLoop
	{
		public M_325() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new B12() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new M7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new W09() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new V1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new V9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new R4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 4 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_MBL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
			});
		}

		//1000
		public class L_MBL : MapLoop
		{
			public L_MBL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new MBL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new R4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new L_LIN(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
				});
			}
		}

		//1100
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

		//1200
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PRF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TD1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_H1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G20() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new UIT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new C3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new R4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1210
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

