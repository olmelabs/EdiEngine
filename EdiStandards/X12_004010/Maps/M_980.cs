using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_980 : MapLoop
	{
		public M_980() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BT1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
			});
		}

	}
 }

