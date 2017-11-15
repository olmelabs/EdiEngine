using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_869 : MapLoop
	{
		public M_869() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BSI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new CTT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PRF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new GF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_REF(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_FA1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1100
		public class L_REF : MapLoop
		{
			public L_REF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1200
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//1300
		public class L_LM : MapLoop
		{
			public L_LM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1400
		public class L_FA1 : MapLoop
		{
			public L_FA1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FA1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FA2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

