using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_468 : MapLoop
	{
		public M_468() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new DK() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_JL(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 7 },
			});
		}

		//0100
		public class L_JL : MapLoop
		{
			public L_JL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new JL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new K1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100 },
				});
			}
		}

	}
 }

