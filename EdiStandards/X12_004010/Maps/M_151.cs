using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_151 : MapLoop
	{
		public M_151() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BTA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new BTI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_PBI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_TFS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100000 },
			});
		}

		//1000
		public class L_PBI : MapLoop
		{
			public L_PBI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PBI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TIA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2000
		public class L_TFS : MapLoop
		{
			public L_TFS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TFS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_PBI_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new L_FGS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100000 },
				});
			}
		}

		//2100
		public class L_PBI_1 : MapLoop
		{
			public L_PBI_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PBI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TIA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//2200
		public class L_FGS : MapLoop
		{
			public L_FGS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FGS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_PBI_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

		//2210
		public class L_PBI_2 : MapLoop
		{
			public L_PBI_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PBI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TIA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

	}
 }

