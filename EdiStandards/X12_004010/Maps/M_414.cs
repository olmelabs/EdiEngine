using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_414 : MapLoop
	{
		public M_414() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new LEQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_CTC(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 99 },
			});
		}

		//1000
		public class L_CTC : MapLoop
		{
			public L_CTC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CTC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_CIC(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1000 },
				});
			}
		}

		//1100
		public class L_CIC : MapLoop
		{
			public L_CIC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CIC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//1110
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CHR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new CYC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new PRI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L7A() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new CV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

