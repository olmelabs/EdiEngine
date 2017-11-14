using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Loops.M_850
{


	//1000
	public class L_SAC : MapLoop
	{
		public L_SAC(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}

	//2000
	public class L_AMT : MapLoop
	{
		public L_AMT(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new AMT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_FA1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N9(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_LM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SPI(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//2100
	public class L_FA1 : MapLoop
	{
		public L_FA1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new FA1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}
	}

	//3000
	public class L_N9 : MapLoop
	{
		public L_N9(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
			});
		}
	}

	//4000
	public class L_N1 : MapLoop
	{
		public L_N1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
			});
		}
	}

	//5000
	public class L_LM : MapLoop
	{
		public L_LM(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new LQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//6000
	public class L_SPI : MapLoop
	{
		public L_SPI(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SPI() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_CB1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_ADV(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_PO1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 100000 },
			});
		}
	}

	//6100
	public class L_N1_1 : MapLoop
	{
		public L_N1_1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new G61() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
			});
		}
	}

	//6200
	public class L_CB1 : MapLoop
	{
		public L_CB1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new CB1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new LDT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}

	//7000
	public class L_ADV : MapLoop
	{
		public L_ADV(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new ADV() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new MTX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//8000
	public class L_PO1 : MapLoop
	{
		public L_PO1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new PO1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new LIN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new CN1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PO3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_CTP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
				new L_PID(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new PWK() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_SAC_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new IT8() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new CSH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new ITD() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new DIS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new INC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new TAX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new SDQ() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new IT3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new TC2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new SPI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new TXI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new CTB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_QTY(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SCH(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_PKG(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new LS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LDT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N9_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_CTT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}

	//8100
	public class L_CTP : MapLoop
	{
		public L_CTP(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new CTP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}

	//8150
	public class L_PID : MapLoop
	{
		public L_PID(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new PID() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
			});
		}
	}

	//8200
	public class L_SAC_1 : MapLoop
	{
		public L_SAC_1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}

	//8250
	public class L_QTY : MapLoop
	{
		public L_QTY(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new QTY() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//8300
	public class L_SCH : MapLoop
	{
		public L_SCH(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SCH() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//8350
	public class L_PKG : MapLoop
	{
		public L_PKG(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new PKG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//8400
	public class L_LDT : MapLoop
	{
		public L_LDT(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new LDT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_LM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//8410
	public class L_LM_1 : MapLoop
	{
		public L_LM_1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}
	}

	//8500
	public class L_N9_1 : MapLoop
	{
		public L_N9_1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new MEA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 40 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
			});
		}
	}

	//8600
	public class L_N1_2 : MapLoop
	{
		public L_N1_2(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new FOB() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new SCH() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new TD1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new TD5() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new TD4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new PKG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 200 },
				new L_LDT_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SLN(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
			});
		}
	}

	//8610
	public class L_LDT_1 : MapLoop
	{
		public L_LDT_1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new LDT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new MAN() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}

	//8700
	public class L_SLN : MapLoop
	{
		public L_SLN(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SLN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new PID() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new PO3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 104 },
				new TC2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new ADV() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new PAM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PO4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new TAX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
				new L_N9_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SAC_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_QTY_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_N1_3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_AMT_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_LM_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//8710
	public class L_N9_2 : MapLoop
	{
		public L_N9_2(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N9() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new DTM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//8720
	public class L_SAC_2 : MapLoop
	{
		public L_SAC_2(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new SAC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new CUR() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new CTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}

	//8730
	public class L_QTY_1 : MapLoop
	{
		public L_QTY_1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new QTY() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new SI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//8740
	public class L_N1_3 : MapLoop
	{
		public L_N1_3(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new NX2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 12 },
				new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
			});
		}
	}

	//8800
	public class L_AMT_1 : MapLoop
	{
		public L_AMT_1(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new AMT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new PCT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}
	}

	//8850
	public class L_LM_2 : MapLoop
	{
		public L_LM_2(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new LM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
			});
		}
	}

	//9000
	public class L_CTT : MapLoop
	{
		public L_CTT(MapLoop parentLoop) : base(parentLoop)
		{
			Content.AddRange(new MapBaseEntity[] {
				new CTT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new AMT() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}
	}

}
