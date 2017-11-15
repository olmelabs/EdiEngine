using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_276 : MapLoop
	{
		public M_276() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BHT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_HL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new SBR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PAT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_NM1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_TRN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_NM1_1 : MapLoop
		{
			public L_NM1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2200
		public class L_TRN : MapLoop
		{
			public L_TRN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TRN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_SVC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2210
		public class L_SVC : MapLoop
		{
			public L_SVC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SVC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

