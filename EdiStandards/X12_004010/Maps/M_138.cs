using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.Segments;

namespace EdiEngine.Standards.X12_004010.Maps
{
	public class M_138 : MapLoop
	{
		public M_138() : base(null)
		{
			Content.AddRange(new MapBaseEntity[] {
				new BGN() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new ERP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new REF() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
				new L_N1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 2 },
				new L_IN1(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
				new L_TST(this) { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 999999 },
				new L_DEG(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				new L_SST(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				new L_PCL(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 25 },
				new L_ATV(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
			});
		}

		//1000
		public class L_N1 : MapLoop
		{
			public L_N1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
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
					new IN2() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 10 },
					new REF() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new DMG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new IND() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new LUI() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new COM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new RQS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new SCA() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_EMS(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//2100
		public class L_EMS : MapLoop
		{
			public L_EMS(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new EMS() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N1() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3000
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

		//3100
		public class L_SBT : MapLoop
		{
			public L_SBT(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SBT() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SRE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
					new MSG() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_RAP(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_SCA(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3110
		public class L_RAP : MapLoop
		{
			public L_RAP(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new RAP() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new EMS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3120
		public class L_SCA : MapLoop
		{
			public L_SCA(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SCA() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//3130
		public class L_N1_1 : MapLoop
		{
			public L_N1_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new PER() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//4000
		public class L_DEG : MapLoop
		{
			public L_DEG(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DEG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 5 },
				});
			}
		}

		//5000
		public class L_SST : MapLoop
		{
			public L_SST(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new SST() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SSE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SUM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_N1_2(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//5100
		public class L_N1_2 : MapLoop
		{
			public L_N1_2(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new N1() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

		//6000
		public class L_PCL : MapLoop
		{
			public L_PCL(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new PCL() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new N3() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new N4() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new SSE() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 999999 },
					new L_DEG_1(this) { ReqDes = RequirementDesignator.Optional, MaxOccurs = 10 },
				});
			}
		}

		//6100
		public class L_DEG_1 : MapLoop
		{
			public L_DEG_1(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new DEG() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new SUM() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new FOS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 30 },
				});
			}
		}

		//7000
		public class L_ATV : MapLoop
		{
			public L_ATV(MapLoop parentLoop) : base(parentLoop)
			{
				Content.AddRange(new MapBaseEntity[] {
					new ATV() { ReqDes = RequirementDesignator.Mandatory, MaxOccurs = 1 },
					new EMS() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
					new DTP() { ReqDes = RequirementDesignator.Optional, MaxOccurs = 1 },
				});
			}
		}

	}
 }

