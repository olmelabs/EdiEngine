using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_602 : MapLoop
	{
		public M_602() : base(null)
		{
            Content.AddRange(new MapBaseEntity[] {
				new DK() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new PRI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new SS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new CD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_PR(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_SB(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				new EdiEngine.Standards.X12_004010.Segments.MS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new DM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
			});
		}

		//0100
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				});
			}
		}

		//0200
		public class L_PR : MapLoop
		{
			public L_PR(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new CD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//0300
		public class L_SB : MapLoop
		{
			public L_SB(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SB() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new L_SC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 400 },
					new L_SRT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//0310
		public class L_SC : MapLoop
		{
			public L_SC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9999 },
					new CD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_RA(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_RH(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//0311
		public class L_RA : MapLoop
		{
			public L_RA(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new RB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 8 },
					new FK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				});
			}
		}

		//0312
		public class L_RH : MapLoop
		{
			public L_RH(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RH() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				});
			}
		}

		//0320
		public class L_SRT : MapLoop
		{
			public L_SRT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SRT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new SRD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
					new SRM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
					new N9() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				});
			}
		}

		//0321
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SRD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SRM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				});
			}
		}

		//0322
		public class L_SRM : MapLoop
		{
			public L_SRM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SRM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SRA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

	}
 }

