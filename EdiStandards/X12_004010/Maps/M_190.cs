using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_190 : MapLoop
	{
		public M_190() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new ENR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new ERP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new SST() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SUM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new L_ENT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_SES(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_DEG(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_ENT : MapLoop
		{
			public L_ENT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ENT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3000
		public class L_SES : MapLoop
		{
			public L_SES(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SES() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SUM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 6 },
					new ENR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//4000
		public class L_DEG : MapLoop
		{
			public L_DEG(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DEG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

	}
 }

