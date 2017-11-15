using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_189 : MapLoop
	{
		public M_189() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new L_REF(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 15 },
				new L_IN1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new L_N3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_COM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_N1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_ATV(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_AMT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
				new L_SSE(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_RSD(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_RQS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_SST(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_SES(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				new L_TST(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				new L_PCL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_SES(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				new L_LX(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				new L_LT(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
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
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//2000
		public class L_REF : MapLoop
		{
			public L_REF(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3000
		public class L_IN1 : MapLoop
		{
			public L_IN1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new IN1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new IN2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IND() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IMM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new HC() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new LUI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new III() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_N3(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_COM(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//3100
		public class L_N3 : MapLoop
		{
			public L_N3(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N3() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//3200
		public class L_COM : MapLoop
		{
			public L_COM(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new COM() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
				});
			}
		}

		//3300
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_EMS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//3310
		public class L_EMS : MapLoop
		{
			public L_EMS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new EMS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3500
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

		//4000
		public class L_AMT : MapLoop
		{
			public L_AMT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new AMT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//4500
		public class L_SSE : MapLoop
		{
			public L_SSE(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SSE() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DEG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//5000
		public class L_RSD : MapLoop
		{
			public L_RSD(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RSD() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//5500
		public class L_RQS : MapLoop
		{
			public L_RQS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RQS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//6000
		public class L_SST : MapLoop
		{
			public L_SST(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SST() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SSE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 2 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SUM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new L_SES(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 20 },
				});
			}
		}

		//6100
		public class L_SES : MapLoop
		{
			public L_SES(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SES() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_CRS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
				});
			}
		}

		//6110
		public class L_CRS : MapLoop
		{
			public L_CRS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CRS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6500
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

		//6510
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

		//7000
		public class L_PCL : MapLoop
		{
			public L_PCL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PCL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SSE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SUM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new L_SES_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1000 },
				});
			}
		}

		//7100
		public class L_SES_1 : MapLoop
		{
			public L_SES_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SES() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new L_CRS_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 50 },
					new L_DEG(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//7110
		public class L_CRS_1 : MapLoop
		{
			public L_CRS_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new CRS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//7120
		public class L_DEG : MapLoop
		{
			public L_DEG(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DEG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SUM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
					new NTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				});
			}
		}

		//8000
		public class L_LX : MapLoop
		{
			public L_LX(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LX() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

		//8500
		public class L_LT : MapLoop
		{
			public L_LT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new LT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new QTY() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new COM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LTE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 15 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
				});
			}
		}

	}
 }

