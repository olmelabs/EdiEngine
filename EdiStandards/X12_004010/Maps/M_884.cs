using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_884 : MapLoop
	{
		public M_884() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BMP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new BAL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
			});
		}

		//0100
		public class L_N9 : MapLoop
		{
			public L_N9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

