using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_271 : MapLoop
	{
		public M_271() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BHT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//2000
		public class L_HL : MapLoop
		{
			public L_HL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new INS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new L_EB(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2110
		public class L_EB : MapLoop
		{
			public L_EB(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new EB() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new HSD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new AAA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new VEH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PDR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PDP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new EM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PKD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_III(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_NM1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2115
		public class L_III : MapLoop
		{
			public L_III(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new III() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_LQ(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2117
		public class L_LQ : MapLoop
		{
			public L_LQ(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LQ() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//2120
		public class L_NM1_1 : MapLoop
		{
			public L_NM1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

