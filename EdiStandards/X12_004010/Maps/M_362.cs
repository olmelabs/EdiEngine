using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_362 : MapLoop
	{
		public M_362() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_L5(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_L5 : MapLoop
		{
			public L_L5(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new L5() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 20 },
					new DTP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9 },
					new V1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new R1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_R4(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
					new L_AMT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9 },
				});
			}
		}

		//1100
		public class L_R4 : MapLoop
		{
			public L_R4(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new R4() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//1200
		public class L_AMT : MapLoop
		{
			public L_AMT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AMT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_LQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1210
		public class L_LQ : MapLoop
		{
			public L_LQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

