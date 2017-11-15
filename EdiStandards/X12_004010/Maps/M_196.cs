using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_196 : MapLoop
	{
		public M_196() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BCM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
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
					new L_G61(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1100
		public class L_G61 : MapLoop
		{
			public L_G61(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G61() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CRT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new BSD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CLI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CAL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new RPA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_PD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_PD : MapLoop
		{
			public L_PD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PDD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

