using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_887 : MapLoop
	{
		public M_887() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 4 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 7 },
				new G43() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new G11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G12() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_G14(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_G15(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_LIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

		//0100
		public class L_G14 : MapLoop
		{
			public L_G14(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G14() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//0200
		public class L_G15 : MapLoop
		{
			public L_G15(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G15() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//0300
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_G28(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//0310
		public class L_G28 : MapLoop
		{
			public L_G28(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G28() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new G51() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

