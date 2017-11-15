using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_866 : MapLoop
	{
		public M_866() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BSS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new UIT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_DTM(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100 },
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
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_DTM : MapLoop
		{
			public L_DTM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DTM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new UIT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_LIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new OQS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//2110
		public class L_SLN : MapLoop
		{
			public L_SLN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_PID(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2111
		public class L_PID : MapLoop
		{
			public L_PID(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

