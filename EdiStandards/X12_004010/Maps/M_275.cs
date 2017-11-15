using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_275 : MapLoop
	{
		public M_275() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_NM1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_NM1 : MapLoop
		{
			public L_NM1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NM1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_NX1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//1100
		public class L_NX1 : MapLoop
		{
			public L_NX1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new NX1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PRV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_DTP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_DTP : MapLoop
		{
			public L_DTP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DTP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CAT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_EFI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2110
		public class L_EFI : MapLoop
		{
			public L_EFI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new EFI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new BIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

