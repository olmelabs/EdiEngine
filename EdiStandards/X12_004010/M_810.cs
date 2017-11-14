using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;
using EdiEngine.Standards.X12_004010.Loops.M_810;

namespace EdiEngine.Standards.X12_004010
{
	public class M_810 : MapLoop
	{
		public M_810() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BIG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new YNQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
				new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L7() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new BAL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new INC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_V1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_FA1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_IT1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200000 },
				new TDS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new CAD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SAC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_ISS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new CTT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}
 }

