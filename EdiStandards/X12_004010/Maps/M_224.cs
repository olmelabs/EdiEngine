using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_224 : MapLoop
	{
		public M_224() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new CF1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_CF2(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 9999 },
			});
		}

		//0100
		public class L_CF2 : MapLoop
		{
			public L_CF2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CF2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L11() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

	}
 }

