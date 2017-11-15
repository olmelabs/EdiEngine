using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_883 : MapLoop
	{
		public M_883() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BMA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new G62() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new G43() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new G95() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_LIN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
			});
		}

		//0100
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_UIT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

		//0110
		public class L_UIT : MapLoop
		{
			public L_UIT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new UIT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0200
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new G95() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_LIN_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
				});
			}
		}

		//0210
		public class L_LIN_1 : MapLoop
		{
			public L_LIN_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//0310
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G62() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

	}
 }

