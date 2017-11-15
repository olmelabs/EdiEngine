using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_421 : MapLoop
	{
		public M_421() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new IS1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 5 },
				new ISC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new N8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new IS2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new F9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new D9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new L5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new H3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new H5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new IC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new IMA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new N8A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_S1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LH1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new LE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
			});
		}

		//1000
		public class L_S1 : MapLoop
		{
			public L_S1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new S1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new S9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_LH1 : MapLoop
		{
			public L_LH1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LH1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LH2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 4 },
					new LH3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new LFH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new LEP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LH4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LHT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new LHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

