using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_130 : MapLoop
	{
		public M_130() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new ERP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new LUI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new IND() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new RAP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new PCL() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new L_IN1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 15 },
				new L_SST(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 500 },
				new L_ATV(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 100 },
				new L_TST(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SUM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_IN1 : MapLoop
		{
			public L_IN1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new EMS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new IN2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new L_N3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2100
		public class L_N3 : MapLoop
		{
			public L_N3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3000
		public class L_SST : MapLoop
		{
			public L_SST(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SST() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SSE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//4000
		public class L_ATV : MapLoop
		{
			public L_ATV(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ATV() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//5000
		public class L_TST : MapLoop
		{
			public L_TST(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new TST() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_SBT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//5200
		public class L_SBT : MapLoop
		{
			public L_SBT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SBT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SRE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 3 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//6000
		public class L_SUM : MapLoop
		{
			public L_SUM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SUM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				});
			}
		}

		//7000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new HS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new IMM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new L_HC(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
					new L_SP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new L_SES(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

		//7100
		public class L_HC : MapLoop
		{
			public L_HC(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new HC() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N2() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//7200
		public class L_SP : MapLoop
		{
			public L_SP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_OPS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//7210
		public class L_OPS : MapLoop
		{
			public L_OPS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new OPS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new OPX() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//7300
		public class L_SES : MapLoop
		{
			public L_SES(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SES() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SSE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SUM_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_CRS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new L_DEG(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//7310
		public class L_SUM_1 : MapLoop
		{
			public L_SUM_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SUM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//7320
		public class L_CRS : MapLoop
		{
			public L_CRS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CRS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new CSU() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LUI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new RAP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_MKS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//7321
		public class L_MKS : MapLoop
		{
			public L_MKS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new MKS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new LUI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//7330
		public class L_DEG : MapLoop
		{
			public L_DEG(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DEG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SUM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				});
			}
		}

	}
 }

