using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_150 : MapLoop
	{
		public M_150() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_TFS(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1000 },
			});
		}

		//1000
		public class L_TFS : MapLoop
		{
			public L_TFS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TFS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_TRS(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100000 },
					new L_FGS(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1000 },
				});
			}
		}

		//1100
		public class L_TRS : MapLoop
		{
			public L_TRS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TRS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
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
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//1200
		public class L_FGS : MapLoop
		{
			public L_FGS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FGS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_TRS_1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100000 },
				});
			}
		}

		//1210
		public class L_TRS_1 : MapLoop
		{
			public L_TRS_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TRS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

		//1211
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

