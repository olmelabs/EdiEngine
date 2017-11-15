using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_835 : MapLoop
	{
		public M_835() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BPR() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new TRN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PLB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new RDM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new TS3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new TS2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_CLP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//2100
		public class L_CLP : MapLoop
		{
			public L_CLP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CLP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new CAS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new NM1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new MIA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new MOA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new L_SVC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999 },
				});
			}
		}

		//2110
		public class L_SVC : MapLoop
		{
			public L_SVC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SVC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 9 },
					new CAS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
					new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
					new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 99 },
				});
			}
		}

	}
 }

