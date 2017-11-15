using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_891 : MapLoop
	{
		public M_891() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_ENT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100 },
			});
		}

		//0100
		public class L_ENT : MapLoop
		{
			public L_ENT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//0110
		public class L_N9 : MapLoop
		{
			public L_N9(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_ADX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

		//0111
		public class L_ADX : MapLoop
		{
			public L_ADX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ADX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

