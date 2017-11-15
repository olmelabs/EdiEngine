using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_249 : MapLoop
	{
		public M_249() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new STP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new L_GID(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_GID : MapLoop
		{
			public L_GID(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new GID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new GRP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new GDP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new L_ANI(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2200
		public class L_ANI : MapLoop
		{
			public L_ANI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ANI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new ARC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
					new GDP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new ADI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new ATR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AOL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AST(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AOI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2210
		public class L_AOL : MapLoop
		{
			public L_AOL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AOL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AOR(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2211
		public class L_AOR : MapLoop
		{
			public L_AOR(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AOR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2220
		public class L_AST : MapLoop
		{
			public L_AST(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AST() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new ADT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new AOC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2230
		public class L_AOI : MapLoop
		{
			public L_AOI(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AOI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new ATR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AOL_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2231
		public class L_AOL_1 : MapLoop
		{
			public L_AOL_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AOL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_AOR_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2232
		public class L_AOR_1 : MapLoop
		{
			public L_AOR_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AOR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

