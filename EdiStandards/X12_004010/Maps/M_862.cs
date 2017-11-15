using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_862 : MapLoop
	{
		public M_862() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BSS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_LIN(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10000 },
				new CTT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
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
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_LIN : MapLoop
		{
			public L_LIN(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LIN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new UIT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PRS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SDP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_FST(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
					new L_SHP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2100
		public class L_FST : MapLoop
		{
			public L_FST(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new FST() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_JIT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 96 },
				});
			}
		}

		//2110
		public class L_JIT : MapLoop
		{
			public L_JIT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new JIT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				});
			}
		}

		//2200
		public class L_SHP : MapLoop
		{
			public L_SHP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SHP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				});
			}
		}

	}
 }

