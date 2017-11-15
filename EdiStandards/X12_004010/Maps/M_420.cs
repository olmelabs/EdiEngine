using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_420 : MapLoop
	{
		public M_420() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new L_E6(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 150 },
			});
		}

		//1000
		public class L_E6 : MapLoop
		{
			public L_E6(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new E6() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new E8() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				});
			}
		}

	}
 }

