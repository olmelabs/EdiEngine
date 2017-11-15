using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_191 : MapLoop
	{
		public M_191() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_ENT(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
			});
		}

		//1000
		public class L_ENT : MapLoop
		{
			public L_ENT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DMA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new ENR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_IN1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_REF(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100 },
				});
			}
		}

		//1100
		public class L_IN1 : MapLoop
		{
			public L_IN1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//1200
		public class L_REF : MapLoop
		{
			public L_REF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SLI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new GR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DEF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new DB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
					new L_IN1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//1210
		public class L_IN1_1 : MapLoop
		{
			public L_IN1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

