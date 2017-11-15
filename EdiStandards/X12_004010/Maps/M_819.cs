using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_819 : MapLoop
	{
		public M_819() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BOS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_JIL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10000 },
				new AMT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new TDS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_PSA(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new CTT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
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
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//2000
		public class L_JIL : MapLoop
		{
			public L_JIL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new JIL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new ITA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PSA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_JID(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

		//2100
		public class L_JID : MapLoop
		{
			public L_JID(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new JID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//3000
		public class L_PSA : MapLoop
		{
			public L_PSA(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PSA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

	}
 }

