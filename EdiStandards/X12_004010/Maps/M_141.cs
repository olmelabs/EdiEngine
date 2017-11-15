using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_141 : MapLoop
	{
		public M_141() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new L_LX(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new L_TDS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 8 },
					new PCS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new RC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3000
		public class L_TDS : MapLoop
		{
			public L_TDS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TDS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

