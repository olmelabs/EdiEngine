using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_453 : MapLoop
	{
		public M_453() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SSC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new R2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 13 },
				new OD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new CT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new APR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new SHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new L_SR(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 7 },
			});
		}

		//1000
		public class L_SR : MapLoop
		{
			public L_SR(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//1100
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new ISD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new ISC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

