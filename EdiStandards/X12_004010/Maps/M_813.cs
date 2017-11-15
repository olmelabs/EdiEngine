using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_813 : MapLoop
	{
		public M_813() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BTI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new TIA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new BPR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_TFS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100000 },
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
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
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
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_TIA(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10000 },
					new L_FGS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100000 },
				});
			}
		}

		//2100
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2200
		public class L_TIA : MapLoop
		{
			public L_TIA(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TIA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

		//2300
		public class L_FGS : MapLoop
		{
			public L_FGS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FGS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_TIA_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10000 },
				});
			}
		}

		//2310
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2320
		public class L_TIA_1 : MapLoop
		{
			public L_TIA_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TIA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

	}
 }

