using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_601 : MapLoop
	{
		public M_601() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new L_BA1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
			});
		}

		//1000
		public class L_BA1 : MapLoop
		{
			public L_BA1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new BA1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new V5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new P5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new M12() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new VID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new L_L13(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999 },
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
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1200
		public class L_L13 : MapLoop
		{
			public L_L13(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L13() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new X1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new VEH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1210
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

