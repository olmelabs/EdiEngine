using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_889 : MapLoop
	{
		public M_889() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new G42() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new G62() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 50 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 300 },
				new G43() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new L_G94(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
			});
		}

		//0100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//0200
		public class L_G94 : MapLoop
		{
			public L_G94(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G94() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G95() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//0300
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G46() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new G51() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_G94_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_G45(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				});
			}
		}

		//0310
		public class L_G94_1 : MapLoop
		{
			public L_G94_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G94() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_G95(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//0311
		public class L_G95 : MapLoop
		{
			public L_G95(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G95() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//0320
		public class L_G45 : MapLoop
		{
			public L_G45(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new G45() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new G69() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new G43() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new G51() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G23() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G22() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

