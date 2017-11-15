using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_309 : MapLoop
	{
		public M_309() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new M10() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_P4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
			});
		}

		//1000
		public class L_P4 : MapLoop
		{
			public L_P4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new P4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
				});
			}
		}

		//1100
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new M13() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new M11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_M12(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_VID(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//1110
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1120
		public class L_M12 : MapLoop
		{
			public L_M12(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new M12() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new P5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//1130
		public class L_VID : MapLoop
		{
			public L_VID(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new VID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new VC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 21 },
					new L_N10(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//1131
		public class L_N10 : MapLoop
		{
			public L_N10(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N10() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_H1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1132
		public class L_H1 : MapLoop
		{
			public L_H1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new H1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new H2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

	}
 }

