using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_361 : MapLoop
	{
		public M_361() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_CI(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
			});
		}

		//1000
		public class L_CI : MapLoop
		{
			public L_CI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

