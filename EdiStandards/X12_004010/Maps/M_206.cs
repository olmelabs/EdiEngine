using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_206 : MapLoop
	{
		public M_206() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SI(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//0100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

		//0200
		public class L_SI : MapLoop
		{
			public L_SI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new RLT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_IN1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_NX1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//0210
		public class L_IN1 : MapLoop
		{
			public L_IN1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//0220
		public class L_NX1 : MapLoop
		{
			public L_NX1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NX2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new PDS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PDE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new REA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new III() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new REC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0221
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CRC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DFI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new OBI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new AIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				});
			}
		}

	}
 }

