using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;
using EdiEngine.Standards.X12_004010.Loops.M_850;

namespace EdiEngine.Standards.X12_004010
{
	public class M_850 : MapLoop
	{
		public M_850() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BEG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new TAX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new CSH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new TC2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SAC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DIS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new INC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new LDT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
				new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_AMT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SPI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_ADV(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_PO1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100000 },
				new L_CTT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}
 }

