using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.DataElements;

namespace EdiEngine.Standards.X12_004010.Segments
{
	public class AAA : MapSegment
	{
		public AAA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0901 { ReqDes = RequirementDesignator.Optional },
				new E_0889 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ACD : MapSegment
	{
		public ACD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1636 { ReqDes = RequirementDesignator.Optional },
				new E_0650 { ReqDes = RequirementDesignator.Optional },
				new E_1262 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ACK : MapSegment
	{
		public ACK()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "C0405", "P0708", "P0910", "P1112", "P1314", "P1516", "P1718", "P1920", "P2122", "P2324", "P2526", "P2728", "C282729" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0668 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0326 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ACS : MapSegment
	{
		public ACS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0150 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0146 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ACT : MapSegment
	{
		public ACT()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "C0506", "C0705" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0508 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0107 { ReqDes = RequirementDesignator.Optional },
				new E_1216 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AD1 : MapSegment
	{
		public AD1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0426 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1129 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_0009 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ADI : MapSegment
	{
		public ADI()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1606 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ADJ : MapSegment
	{
		public ADJ()
		{
			SyntaxNotes.AddRange(new[] { "C1009", "C1109", "L131415", "L141315", "L151314", "C1209", "P0809", "L101112", "L111012", "L121011", "C1309", "C1409", "C1509", "P1617", "C1709" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0952 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ADT : MapSegment
	{
		public ADT()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0607", "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1619 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ADV : MapSegment
	{
		public ADV()
		{
			SyntaxNotes.AddRange(new[] { "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0559 { ReqDes = RequirementDesignator.Mandatory },
				new E_1000 { ReqDes = RequirementDesignator.Mandatory },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
				new E_0729 { ReqDes = RequirementDesignator.Optional },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ADX : MapSegment
	{
		public ADX()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0426 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AEI : MapSegment
	{
		public AEI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0040 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class AES : MapSegment
	{
		public AES()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1559 { ReqDes = RequirementDesignator.Mandatory },
				new E_1557 { ReqDes = RequirementDesignator.Mandatory },
				new E_1556 { ReqDes = RequirementDesignator.Mandatory },
				new E_1555 { ReqDes = RequirementDesignator.Mandatory },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AIN : MapSegment
	{
		public AIN()
		{
			SyntaxNotes.AddRange(new[] { "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1186 { ReqDes = RequirementDesignator.Mandatory },
				new E_0594 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_1685 { ReqDes = RequirementDesignator.Optional },
				new E_1687 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AK1 : MapSegment
	{
		public AK1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0479 { ReqDes = RequirementDesignator.Mandatory },
				new E_0028 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class AK2 : MapSegment
	{
		public AK2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0143 { ReqDes = RequirementDesignator.Mandatory },
				new E_0329 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class AK3 : MapSegment
	{
		public AK3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0721 { ReqDes = RequirementDesignator.Mandatory },
				new E_0719 { ReqDes = RequirementDesignator.Mandatory },
				new E_0447 { ReqDes = RequirementDesignator.Optional },
				new E_0720 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AK4 : MapSegment
	{
		public AK4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new C030 { ReqDes = RequirementDesignator.Mandatory },
				new E_0725 { ReqDes = RequirementDesignator.Optional },
				new E_0723 { ReqDes = RequirementDesignator.Mandatory },
				new E_0724 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AK5 : MapSegment
	{
		public AK5()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0717 { ReqDes = RequirementDesignator.Mandatory },
				new E_0718 { ReqDes = RequirementDesignator.Optional },
				new E_0718 { ReqDes = RequirementDesignator.Optional },
				new E_0718 { ReqDes = RequirementDesignator.Optional },
				new E_0718 { ReqDes = RequirementDesignator.Optional },
				new E_0718 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AK9 : MapSegment
	{
		public AK9()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0715 { ReqDes = RequirementDesignator.Mandatory },
				new E_0097 { ReqDes = RequirementDesignator.Mandatory },
				new E_0123 { ReqDes = RequirementDesignator.Mandatory },
				new E_0002 { ReqDes = RequirementDesignator.Mandatory },
				new E_0716 { ReqDes = RequirementDesignator.Optional },
				new E_0716 { ReqDes = RequirementDesignator.Optional },
				new E_0716 { ReqDes = RequirementDesignator.Optional },
				new E_0716 { ReqDes = RequirementDesignator.Optional },
				new E_0716 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AM1 : MapSegment
	{
		public AM1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Mandatory },
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AMT : MapSegment
	{
		public AMT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0478 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ANI : MapSegment
	{
		public ANI()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AOC : MapSegment
	{
		public AOC()
		{
			SyntaxNotes.AddRange(new[] { "R0304", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1620 { ReqDes = RequirementDesignator.Mandatory },
				new E_0609 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AOI : MapSegment
	{
		public AOI()
		{
			SyntaxNotes.AddRange(new[] { "P040506", "P0708", "P0809", "L101112", "P1213" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_1068 { ReqDes = RequirementDesignator.Mandatory },
				new E_1622 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_1606 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AOL : MapSegment
	{
		public AOL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1611 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
				new E_1612 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1614 { ReqDes = RequirementDesignator.Optional },
				new E_1614 { ReqDes = RequirementDesignator.Optional },
				new E_1614 { ReqDes = RequirementDesignator.Optional },
				new E_0752 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AOR : MapSegment
	{
		public AOR()
		{
			SyntaxNotes.AddRange(new[] { "P0809", "P1011", "P1213" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1615 { ReqDes = RequirementDesignator.Optional },
				new E_1616 { ReqDes = RequirementDesignator.Optional },
				new E_1617 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1618 { ReqDes = RequirementDesignator.Optional },
				new E_1618 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AP1 : MapSegment
	{
		public AP1()
		{
			SyntaxNotes.AddRange(new[] { "C0706" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1321 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0744 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class API : MapSegment
	{
		public API()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Mandatory },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0875 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_1469 { ReqDes = RequirementDesignator.Optional },
				new E_1336 { ReqDes = RequirementDesignator.Optional },
				new E_1262 { ReqDes = RequirementDesignator.Optional },
				new E_1201 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class APR : MapSegment
	{
		public APR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1011 { ReqDes = RequirementDesignator.Mandatory },
				new E_1011 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ARC : MapSegment
	{
		public ARC()
		{
			SyntaxNotes.AddRange(new[] { "E0203", "R0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0609 { ReqDes = RequirementDesignator.Mandatory },
				new E_1607 { ReqDes = RequirementDesignator.Optional },
				new E_1611 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ARS : MapSegment
	{
		public ARS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1070 { ReqDes = RequirementDesignator.Mandatory },
				new E_1078 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ASI : MapSegment
	{
		public ASI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0875 { ReqDes = RequirementDesignator.Mandatory },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ASL : MapSegment
	{
		public ASL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_1590 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ASM : MapSegment
	{
		public ASM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0107 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ASO : MapSegment
	{
		public ASO()
		{
			SyntaxNotes.AddRange(new[] { "C0614", "P1718" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1078 { ReqDes = RequirementDesignator.Mandatory },
				new E_1188 { ReqDes = RequirementDesignator.Mandatory },
				new E_1188 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_1635 { ReqDes = RequirementDesignator.Optional },
				new C007 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AST : MapSegment
	{
		public AST()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "P0708", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AT1 : MapSegment
	{
		public AT1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0213 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class AT2 : MapSegment
	{
		public AT2()
		{
			SyntaxNotes.AddRange(new[] { "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0080 { ReqDes = RequirementDesignator.Mandatory },
				new E_0211 { ReqDes = RequirementDesignator.Mandatory },
				new E_0187 { ReqDes = RequirementDesignator.Mandatory },
				new E_0188 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Mandatory },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0211 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0059 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AT3 : MapSegment
	{
		public AT3()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "C0402", "P0405", "E020607", "R020607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0058 { ReqDes = RequirementDesignator.Mandatory },
				new E_1600 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_1601 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1602 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AT4 : MapSegment
	{
		public AT4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0079 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class AT5 : MapSegment
	{
		public AT5()
		{
			SyntaxNotes.AddRange(new[] { "E0103", "E0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0560 { ReqDes = RequirementDesignator.Optional },
				new E_0153 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AT6 : MapSegment
	{
		public AT6()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0512 { ReqDes = RequirementDesignator.Mandatory },
				new E_0335 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AT7 : MapSegment
	{
		public AT7()
		{
			SyntaxNotes.AddRange(new[] { "E0103", "P0102", "P0304", "C0605", "C0706" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1650 { ReqDes = RequirementDesignator.Optional },
				new E_1651 { ReqDes = RequirementDesignator.Optional },
				new E_1652 { ReqDes = RequirementDesignator.Optional },
				new E_1651 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AT8 : MapSegment
	{
		public AT8()
		{
			SyntaxNotes.AddRange(new[] { "P010203", "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AT9 : MapSegment
	{
		public AT9()
		{
			SyntaxNotes.AddRange(new[] { "P040506", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0567 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ATA : MapSegment
	{
		public ATA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ATH : MapSegment
	{
		public ATH()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "C0305", "C0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0672 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ATN : MapSegment
	{
		public ATN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_1684 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ATR : MapSegment
	{
		public ATR()
		{
			SyntaxNotes.AddRange(new[] { "R0420", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1607 { ReqDes = RequirementDesignator.Mandatory },
				new E_1313 { ReqDes = RequirementDesignator.Mandatory },
				new E_0344 { ReqDes = RequirementDesignator.Mandatory },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_1608 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0752 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ATV : MapSegment
	{
		public ATV()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0790 { ReqDes = RequirementDesignator.Optional },
				new E_0790 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_1131 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AVA : MapSegment
	{
		public AVA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0895 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class AWD : MapSegment
	{
		public AWD()
		{
			SyntaxNotes.AddRange(new[] { "E0910", "R0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new C007 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class AXL : MapSegment
	{
		public AXL()
		{
			SyntaxNotes.AddRange(new[] { "C0403", "C0503", "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0090 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B1 : MapSegment
	{
		public B1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0145 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0558 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B10 : MapSegment
	{
		public B10()
		{
			SyntaxNotes.AddRange(new[] { "R0106", "E0105", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0071 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B11 : MapSegment
	{
		public B11()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "P0607", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0349 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0756 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B12 : MapSegment
	{
		public B12()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0024 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class B13 : MapSegment
	{
		public B13()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B2 : MapSegment
	{
		public B2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0375 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0147 { ReqDes = RequirementDesignator.Optional },
				new E_0086 { ReqDes = RequirementDesignator.Optional },
				new E_0460 { ReqDes = RequirementDesignator.Optional },
				new E_0501 { ReqDes = RequirementDesignator.Optional },
				new E_0335 { ReqDes = RequirementDesignator.Optional },
				new E_0591 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B2A : MapSegment
	{
		public B2A()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0346 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B3 : MapSegment
	{
		public B3()
		{
			SyntaxNotes.AddRange(new[] { "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0147 { ReqDes = RequirementDesignator.Optional },
				new E_0076 { ReqDes = RequirementDesignator.Mandatory },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0193 { ReqDes = RequirementDesignator.Mandatory },
				new E_0202 { ReqDes = RequirementDesignator.Optional },
				new E_0032 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0375 { ReqDes = RequirementDesignator.Optional },
				new E_0335 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B3A : MapSegment
	{
		public B3A()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0021 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B3B : MapSegment
	{
		public B3B()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0076 { ReqDes = RequirementDesignator.Mandatory },
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0193 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0202 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B4 : MapSegment
	{
		public B4()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0071 { ReqDes = RequirementDesignator.Optional },
				new E_0157 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0161 { ReqDes = RequirementDesignator.Optional },
				new E_0159 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0578 { ReqDes = RequirementDesignator.Optional },
				new E_0024 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0761 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B9 : MapSegment
	{
		public B9()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0146 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class B9A : MapSegment
	{
		public B9A()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1644 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class BA1 : MapSegment
	{
		public BA1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0645 { ReqDes = RequirementDesignator.Mandatory },
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0026 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0151 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0182 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BA2 : MapSegment
	{
		public BA2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0597 { ReqDes = RequirementDesignator.Mandatory },
				new E_0055 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0113 { ReqDes = RequirementDesignator.Mandatory },
				new E_0112 { ReqDes = RequirementDesignator.Mandatory },
				new E_0115 { ReqDes = RequirementDesignator.Optional },
				new E_0114 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0897 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BAA : MapSegment
	{
		public BAA()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BAK : MapSegment
	{
		public BAK()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0587 { ReqDes = RequirementDesignator.Mandatory },
				new E_0324 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0326 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BAL : MapSegment
	{
		public BAL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0951 { ReqDes = RequirementDesignator.Mandatory },
				new E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class BAT : MapSegment
	{
		public BAT()
		{
			SyntaxNotes.AddRange(new[] { "R0103" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0894 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BAU : MapSegment
	{
		public BAU()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0591 { ReqDes = RequirementDesignator.Mandatory },
				new E_0506 { ReqDes = RequirementDesignator.Mandatory },
				new E_0507 { ReqDes = RequirementDesignator.Mandatory },
				new E_0508 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BAX : MapSegment
	{
		public BAX()
		{
			SyntaxNotes.AddRange(new[] { "C1110", "C1211" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0579 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
				new E_0041 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1280 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BBC : MapSegment
	{
		public BBC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1017 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BC : MapSegment
	{
		public BC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCA : MapSegment
	{
		public BCA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0587 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Mandatory },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0327 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0326 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0092 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCD : MapSegment
	{
		public BCD()
		{
			SyntaxNotes.AddRange(new[] { "R071014", "P1314" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0475 { ReqDes = RequirementDesignator.Mandatory },
				new E_0305 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0478 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0076 { ReqDes = RequirementDesignator.Optional },
				new E_0424 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCH : MapSegment
	{
		public BCH()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0092 { ReqDes = RequirementDesignator.Mandatory },
				new E_0324 { ReqDes = RequirementDesignator.Mandatory },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0327 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0326 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1166 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
				new E_0587 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_1232 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCI : MapSegment
	{
		public BCI()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1336 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0755 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCM : MapSegment
	{
		public BCM()
		{
			SyntaxNotes.AddRange(new[] { "R0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_1308 { ReqDes = RequirementDesignator.Optional },
				new E_1193 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_1198 { ReqDes = RequirementDesignator.Optional },
				new E_1166 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCO : MapSegment
	{
		public BCO()
		{
			SyntaxNotes.AddRange(new[] { "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0586 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0846 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0587 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCP : MapSegment
	{
		public BCP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1308 { ReqDes = RequirementDesignator.Optional },
				new E_1166 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0327 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCQ : MapSegment
	{
		public BCQ()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCS : MapSegment
	{
		public BCS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0367 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_1166 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1193 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCT : MapSegment
	{
		public BCT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0683 { ReqDes = RequirementDesignator.Mandatory },
				new E_0684 { ReqDes = RequirementDesignator.Optional },
				new E_0685 { ReqDes = RequirementDesignator.Optional },
				new E_0686 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0684 { ReqDes = RequirementDesignator.Optional },
				new E_0685 { ReqDes = RequirementDesignator.Optional },
				new E_0686 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BCU : MapSegment
	{
		public BCU()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BDD : MapSegment
	{
		public BDD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0076 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BEG : MapSegment
	{
		public BEG()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0092 { ReqDes = RequirementDesignator.Mandatory },
				new E_0324 { ReqDes = RequirementDesignator.Mandatory },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0587 { ReqDes = RequirementDesignator.Optional },
				new E_1019 { ReqDes = RequirementDesignator.Optional },
				new E_1166 { ReqDes = RequirementDesignator.Optional },
				new E_1232 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BEN : MapSegment
	{
		public BEN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1130 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1069 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1187 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BEP : MapSegment
	{
		public BEP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1133 { ReqDes = RequirementDesignator.Mandatory },
				new E_1132 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class BFR : MapSegment
	{
		public BFR()
		{
			SyntaxNotes.AddRange(new[] { "R0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0675 { ReqDes = RequirementDesignator.Mandatory },
				new E_0676 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0783 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BFS : MapSegment
	{
		public BFS()
		{
			SyntaxNotes.AddRange(new[] { "C0102", "C0304", "C0506", "C0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1186 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BGF : MapSegment
	{
		public BGF()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0143 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class BGN : MapSegment
	{
		public BGN()
		{
			SyntaxNotes.AddRange(new[] { "C0504" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BGP : MapSegment
	{
		public BGP()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_1484 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0041 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BHT : MapSegment
	{
		public BHT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1005 { ReqDes = RequirementDesignator.Mandatory },
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BIA : MapSegment
	{
		public BIA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0755 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BIG : MapSegment
	{
		public BIG()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0076 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0327 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0076 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BIN : MapSegment
	{
		public BIN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0784 { ReqDes = RequirementDesignator.Mandatory },
				new E_0785 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class BIX : MapSegment
	{
		public BIX()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0831 { ReqDes = RequirementDesignator.Mandatory },
				new E_0832 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0834 { ReqDes = RequirementDesignator.Optional },
				new E_0927 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BJF : MapSegment
	{
		public BJF()
		{
			SyntaxNotes.AddRange(new[] { "C040506", "P0506", "C070506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0638 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BL : MapSegment
	{
		public BL()
		{
			SyntaxNotes.AddRange(new[] { "R0405", "P0506", "R0809", "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0747 { ReqDes = RequirementDesignator.Mandatory },
				new E_0573 { ReqDes = RequirementDesignator.Mandatory },
				new E_0573 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BLI : MapSegment
	{
		public BLI()
		{
			SyntaxNotes.AddRange(new[] { "P0506", "C0706", "P0809", "P1011", "P1213" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1161 { ReqDes = RequirementDesignator.Optional },
				new E_1161 { ReqDes = RequirementDesignator.Optional },
				new E_1161 { ReqDes = RequirementDesignator.Optional },
				new E_1161 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BLN : MapSegment
	{
		public BLN()
		{
			SyntaxNotes.AddRange(new[] { "C0605" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Mandatory },
				new E_1271 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BLR : MapSegment
	{
		public BLR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BLS : MapSegment
	{
		public BLS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0587 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BMA : MapSegment
	{
		public BMA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0331 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BMG : MapSegment
	{
		public BMG()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BMM : MapSegment
	{
		public BMM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0186 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_1094 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BMP : MapSegment
	{
		public BMP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0305 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0591 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BMS : MapSegment
	{
		public BMS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0819 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0796 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0796 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BNR : MapSegment
	{
		public BNR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0886 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BNX : MapSegment
	{
		public BNX()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0460 { ReqDes = RequirementDesignator.Optional },
				new E_0129 { ReqDes = RequirementDesignator.Optional },
				new E_0011 { ReqDes = RequirementDesignator.Optional },
				new E_0223 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BOL : MapSegment
	{
		public BOL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0145 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0160 { ReqDes = RequirementDesignator.Optional },
				new E_0226 { ReqDes = RequirementDesignator.Optional },
				new E_0501 { ReqDes = RequirementDesignator.Optional },
				new E_0146 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BOR : MapSegment
	{
		public BOR()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0755 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_0819 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BOS : MapSegment
	{
		public BOS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0613 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0781 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BOX : MapSegment
	{
		public BOX()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0594 { ReqDes = RequirementDesignator.Mandatory },
				new E_1162 { ReqDes = RequirementDesignator.Mandatory },
				new E_1163 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BPA : MapSegment
	{
		public BPA()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BPP : MapSegment
	{
		public BPP()
		{
			SyntaxNotes.AddRange(new[] { "R040506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_1164 { ReqDes = RequirementDesignator.Mandatory },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0755 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
				new E_0799 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BPR : MapSegment
	{
		public BPR()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "C0809", "P1213", "C1415", "P1819", "C2021" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0305 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0478 { ReqDes = RequirementDesignator.Mandatory },
				new E_0591 { ReqDes = RequirementDesignator.Mandatory },
				new E_0812 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Optional },
				new E_0507 { ReqDes = RequirementDesignator.Optional },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0509 { ReqDes = RequirementDesignator.Optional },
				new E_0510 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Optional },
				new E_0507 { ReqDes = RequirementDesignator.Optional },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1048 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Optional },
				new E_0507 { ReqDes = RequirementDesignator.Optional },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BPT : MapSegment
	{
		public BPT()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0755 { ReqDes = RequirementDesignator.Optional },
				new E_0648 { ReqDes = RequirementDesignator.Optional },
				new E_0649 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BQR : MapSegment
	{
		public BQR()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0586 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0379 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
				new E_0327 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BQT : MapSegment
	{
		public BQT()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0586 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0092 { ReqDes = RequirementDesignator.Optional },
				new E_0960 { ReqDes = RequirementDesignator.Optional },
				new E_1166 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
				new E_1232 { ReqDes = RequirementDesignator.Optional },
				new E_0327 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BR : MapSegment
	{
		public BR()
		{
			SyntaxNotes.AddRange(new[] { "C0504", "P0708", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BRA : MapSegment
	{
		public BRA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0962 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0412 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BRC : MapSegment
	{
		public BRC()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BRR : MapSegment
	{
		public BRR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BSC : MapSegment
	{
		public BSC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class BSD : MapSegment
	{
		public BSD()
		{
			SyntaxNotes.AddRange(new[] { "R0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1178 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1196 { ReqDes = RequirementDesignator.Optional },
				new E_1178 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BSF : MapSegment
	{
		public BSF()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "P0203", "E0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0687 { ReqDes = RequirementDesignator.Optional },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BSI : MapSegment
	{
		public BSI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0847 { ReqDes = RequirementDesignator.Mandatory },
				new E_0848 { ReqDes = RequirementDesignator.Optional },
				new E_0849 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BSN : MapSegment
	{
		public BSN()
		{
			SyntaxNotes.AddRange(new[] { "C0706" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0396 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
				new E_1005 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BSR : MapSegment
	{
		public BSR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0850 { ReqDes = RequirementDesignator.Mandatory },
				new E_0847 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0848 { ReqDes = RequirementDesignator.Optional },
				new E_0849 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BSS : MapSegment
	{
		public BSS()
		{
			SyntaxNotes.AddRange(new[] { "R0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0675 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0676 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BT1 : MapSegment
	{
		public BT1()
		{
			SyntaxNotes.AddRange(new[] { "P0608", "P0911" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0143 { ReqDes = RequirementDesignator.Mandatory },
				new E_0515 { ReqDes = RequirementDesignator.Mandatory },
				new E_0516 { ReqDes = RequirementDesignator.Mandatory },
				new E_0517 { ReqDes = RequirementDesignator.Optional },
				new E_0518 { ReqDes = RequirementDesignator.Mandatory },
				new E_0516 { ReqDes = RequirementDesignator.Optional },
				new E_0517 { ReqDes = RequirementDesignator.Optional },
				new E_0518 { ReqDes = RequirementDesignator.Optional },
				new E_0516 { ReqDes = RequirementDesignator.Optional },
				new E_0517 { ReqDes = RequirementDesignator.Optional },
				new E_0518 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BTA : MapSegment
	{
		public BTA()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0587 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BTC : MapSegment
	{
		public BTC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_1491 { ReqDes = RequirementDesignator.Mandatory },
				new E_1492 { ReqDes = RequirementDesignator.Mandatory },
				new E_1493 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_1011 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BTI : MapSegment
	{
		public BTI()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0818 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BTP : MapSegment
	{
		public BTP()
		{
			SyntaxNotes.AddRange(new[] { "C0807", "C0908" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0591 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BTR : MapSegment
	{
		public BTR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0755 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BTS : MapSegment
	{
		public BTS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0041 { ReqDes = RequirementDesignator.Mandatory },
				new E_0086 { ReqDes = RequirementDesignator.Mandatory },
				new E_0578 { ReqDes = RequirementDesignator.Mandatory },
				new E_0086 { ReqDes = RequirementDesignator.Mandatory },
				new E_0578 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Mandatory },
				new E_0082 { ReqDes = RequirementDesignator.Mandatory },
				new E_1272 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BUY : MapSegment
	{
		public BUY()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1084 { ReqDes = RequirementDesignator.Mandatory },
				new E_1091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BVA : MapSegment
	{
		public BVA()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "R0809", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1236 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0076 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_1062 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0592 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0429 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0055 { ReqDes = RequirementDesignator.Optional },
				new E_1094 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BVB : MapSegment
	{
		public BVB()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_1238 { ReqDes = RequirementDesignator.Optional },
				new E_1239 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BVP : MapSegment
	{
		public BVP()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "R0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1056 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_1062 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_1094 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BVS : MapSegment
	{
		public BVS()
		{
			SyntaxNotes.AddRange(new[] { "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1062 { ReqDes = RequirementDesignator.Optional },
				new E_1094 { ReqDes = RequirementDesignator.Optional },
				new E_0076 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class BW : MapSegment
	{
		public BW()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0298 { ReqDes = RequirementDesignator.Mandatory },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class BX : MapSegment
	{
		public BX()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0147 { ReqDes = RequirementDesignator.Optional },
				new E_0226 { ReqDes = RequirementDesignator.Optional },
				new E_0195 { ReqDes = RequirementDesignator.Optional },
				new E_0160 { ReqDes = RequirementDesignator.Optional },
				new E_0501 { ReqDes = RequirementDesignator.Optional },
				new E_0199 { ReqDes = RequirementDesignator.Optional },
				new E_0714 { ReqDes = RequirementDesignator.Optional },
				new E_0346 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C2 : MapSegment
	{
		public C2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0008 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0020 { ReqDes = RequirementDesignator.Optional },
				new E_0007 { ReqDes = RequirementDesignator.Optional },
				new E_0107 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C3 : MapSegment
	{
		public C3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0100 { ReqDes = RequirementDesignator.Mandatory },
				new E_0280 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C4 : MapSegment
	{
		public C4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0100 { ReqDes = RequirementDesignator.Mandatory },
				new E_0193 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class C8 : MapSegment
	{
		public C8()
		{
			SyntaxNotes.AddRange(new[] { "R0302" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0213 { ReqDes = RequirementDesignator.Optional },
				new E_0246 { ReqDes = RequirementDesignator.Optional },
				new E_0247 { ReqDes = RequirementDesignator.Optional },
				new E_1302 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C8C : MapSegment
	{
		public C8C()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0247 { ReqDes = RequirementDesignator.Mandatory },
				new E_0247 { ReqDes = RequirementDesignator.Optional },
				new E_0247 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CA1 : MapSegment
	{
		public CA1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1662 { ReqDes = RequirementDesignator.Mandatory },
				new E_1663 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CAD : MapSegment
	{
		public CAD()
		{
			SyntaxNotes.AddRange(new[] { "R0504", "C0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0387 { ReqDes = RequirementDesignator.Optional },
				new E_0368 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CAI : MapSegment
	{
		public CAI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1185 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CAL : MapSegment
	{
		public CAL()
		{
			SyntaxNotes.AddRange(new[] { "P1415" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0678 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0678 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CAS : MapSegment
	{
		public CAS()
		{
			SyntaxNotes.AddRange(new[] { "L050607", "C0605", "C0705", "L080910", "C0908", "C1008", "L111213", "C1211", "C1311", "L141516", "C1514", "C1614", "L171819", "C1817", "C1917" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1033 { ReqDes = RequirementDesignator.Mandatory },
				new E_1034 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1034 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1034 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1034 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1034 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1034 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CAT : MapSegment
	{
		public CAT()
		{
			SyntaxNotes.AddRange(new[] { "C0302", "P0405", "C0605", "C0704" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0755 { ReqDes = RequirementDesignator.Optional },
				new E_0756 { ReqDes = RequirementDesignator.Optional },
				new E_0799 { ReqDes = RequirementDesignator.Optional },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0799 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CB1 : MapSegment
	{
		public CB1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1309 { ReqDes = RequirementDesignator.Mandatory },
				new E_1310 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CBS : MapSegment
	{
		public CBS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class CCI : MapSegment
	{
		public CCI()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "L05060708", "C0605", "C0705", "C0805", "P0510" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0483 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CD : MapSegment
	{
		public CD()
		{
			SyntaxNotes.AddRange(new[] { "C0302", "C0402", "C0502", "P080910", "C11080910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0495 { ReqDes = RequirementDesignator.Mandatory },
				new E_0498 { ReqDes = RequirementDesignator.Optional },
				new E_0499 { ReqDes = RequirementDesignator.Optional },
				new E_0499 { ReqDes = RequirementDesignator.Optional },
				new E_0499 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
				new E_0259 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0697 { ReqDes = RequirementDesignator.Optional },
				new E_0690 { ReqDes = RequirementDesignator.Optional },
				new E_0260 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CD1 : MapSegment
	{
		public CD1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0024 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Mandatory },
				new E_0056 { ReqDes = RequirementDesignator.Mandatory },
				new E_0208 { ReqDes = RequirementDesignator.Optional },
				new E_0209 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0103 { ReqDes = RequirementDesignator.Mandatory },
				new E_0035 { ReqDes = RequirementDesignator.Mandatory },
				new E_0035 { ReqDes = RequirementDesignator.Optional },
				new E_0035 { ReqDes = RequirementDesignator.Optional },
				new E_0121 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0121 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0121 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0157 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class CD2 : MapSegment
	{
		public CD2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Mandatory },
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_1137 { ReqDes = RequirementDesignator.Mandatory },
				new E_1137 { ReqDes = RequirementDesignator.Optional },
				new E_1137 { ReqDes = RequirementDesignator.Optional },
				new E_1137 { ReqDes = RequirementDesignator.Optional },
				new E_1137 { ReqDes = RequirementDesignator.Optional },
				new E_1137 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CD3 : MapSegment
	{
		public CD3()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0708", "P0910", "C1105", "C1211", "C1405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0619 { ReqDes = RequirementDesignator.Optional },
				new E_0034 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0108 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0058 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0058 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0591 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CDA : MapSegment
	{
		public CDA()
		{
			SyntaxNotes.AddRange(new[] { "L101112131415", "C1110", "C1210", "C1310", "C1410", "C1510", "C1905" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1187 { ReqDes = RequirementDesignator.Optional },
				new E_1189 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1262 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CDD : MapSegment
	{
		public CDD()
		{
			SyntaxNotes.AddRange(new[] { "R0407", "C0711", "P0708", "P1011", "P1213" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0426 { ReqDes = RequirementDesignator.Mandatory },
				new E_0478 { ReqDes = RequirementDesignator.Mandatory },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0417 { ReqDes = RequirementDesignator.Optional },
				new E_0477 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0427 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CDI : MapSegment
	{
		public CDI()
		{
			SyntaxNotes.AddRange(new[] { "P0910", "C1211" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1552 { ReqDes = RequirementDesignator.Optional },
				new C045 { ReqDes = RequirementDesignator.Optional },
				new E_1549 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1089 { ReqDes = RequirementDesignator.Optional },
				new E_1681 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CDS : MapSegment
	{
		public CDS()
		{
			SyntaxNotes.AddRange(new[] { "C0304", "P0607", "P0809", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1008 { ReqDes = RequirementDesignator.Mandatory },
				new E_1009 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CED : MapSegment
	{
		public CED()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1012 { ReqDes = RequirementDesignator.Mandatory },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_1013 { ReqDes = RequirementDesignator.Optional },
				new E_1008 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CF1 : MapSegment
	{
		public CF1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0474 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CF2 : MapSegment
	{
		public CF2()
		{
			SyntaxNotes.AddRange(new[] { "C0709", "C0809", "L090708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0076 { ReqDes = RequirementDesignator.Mandatory },
				new E_0193 { ReqDes = RequirementDesignator.Mandatory },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0146 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CFT : MapSegment
	{
		public CFT()
		{
			SyntaxNotes.AddRange(new[] { "P1819", "P2021" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0755 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_1198 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1199 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CGS : MapSegment
	{
		public CGS()
		{
			SyntaxNotes.AddRange(new[] { "P0105", "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0058 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0150 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CHB : MapSegment
	{
		public CHB()
		{
			SyntaxNotes.AddRange(new[] { "P0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_1468 { ReqDes = RequirementDesignator.Optional },
				new E_1017 { ReqDes = RequirementDesignator.Optional },
				new E_1029 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0478 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0248 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CHR : MapSegment
	{
		public CHR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1007 { ReqDes = RequirementDesignator.Mandatory },
				new E_0221 { ReqDes = RequirementDesignator.Mandatory },
				new E_0649 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CI : MapSegment
	{
		public CI()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "P0809", "P1011", "P1314" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0772 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CIC : MapSegment
	{
		public CIC()
		{
			SyntaxNotes.AddRange(new[] { "E0305" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_1482 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CID : MapSegment
	{
		public CID()
		{
			SyntaxNotes.AddRange(new[] { "R01020405", "P0304", "C060304", "L070405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0738 { ReqDes = RequirementDesignator.Optional },
				new E_0750 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CIV : MapSegment
	{
		public CIV()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "P1213", "P1516" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1185 { ReqDes = RequirementDesignator.Mandatory },
				new E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_1096 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CL : MapSegment
	{
		public CL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0059 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class CL1 : MapSegment
	{
		public CL1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1315 { ReqDes = RequirementDesignator.Optional },
				new E_1314 { ReqDes = RequirementDesignator.Optional },
				new E_1352 { ReqDes = RequirementDesignator.Optional },
				new E_1345 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CLD : MapSegment
	{
		public CLD()
		{
			SyntaxNotes.AddRange(new[] { "C0504" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0622 { ReqDes = RequirementDesignator.Mandatory },
				new E_0382 { ReqDes = RequirementDesignator.Mandatory },
				new E_0103 { ReqDes = RequirementDesignator.Optional },
				new E_0357 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CLI : MapSegment
	{
		public CLI()
		{
			SyntaxNotes.AddRange(new[] { "R010203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_1196 { ReqDes = RequirementDesignator.Optional },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0562 { ReqDes = RequirementDesignator.Optional },
				new E_1166 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CLM : MapSegment
	{
		public CLM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1028 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1032 { ReqDes = RequirementDesignator.Optional },
				new E_1343 { ReqDes = RequirementDesignator.Optional },
				new C023 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1359 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1363 { ReqDes = RequirementDesignator.Optional },
				new E_1351 { ReqDes = RequirementDesignator.Optional },
				new C024 { ReqDes = RequirementDesignator.Optional },
				new E_1366 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1338 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1360 { ReqDes = RequirementDesignator.Optional },
				new E_1029 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1383 { ReqDes = RequirementDesignator.Optional },
				new E_1514 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CLP : MapSegment
	{
		public CLP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1028 { ReqDes = RequirementDesignator.Mandatory },
				new E_1029 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1032 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1331 { ReqDes = RequirementDesignator.Optional },
				new E_1325 { ReqDes = RequirementDesignator.Optional },
				new E_1352 { ReqDes = RequirementDesignator.Optional },
				new E_1354 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CLR : MapSegment
	{
		public CLR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CM : MapSegment
	{
		public CM()
		{
			SyntaxNotes.AddRange(new[] { "C0402" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0055 { ReqDes = RequirementDesignator.Optional },
				new E_0115 { ReqDes = RequirementDesignator.Optional },
				new E_0114 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0013 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0182 { ReqDes = RequirementDesignator.Optional },
				new E_0113 { ReqDes = RequirementDesignator.Optional },
				new E_0112 { ReqDes = RequirementDesignator.Optional },
				new E_0174 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0202 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CMA : MapSegment
	{
		public CMA()
		{
			SyntaxNotes.AddRange(new[] { "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0642 { ReqDes = RequirementDesignator.Mandatory },
				new E_0771 { ReqDes = RequirementDesignator.Optional },
				new E_0767 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_1392 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CN1 : MapSegment
	{
		public CN1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1166 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0332 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0338 { ReqDes = RequirementDesignator.Optional },
				new E_0799 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class COB : MapSegment
	{
		public COB()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1138 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1143 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class COM : MapSegment
	{
		public COM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0365 { ReqDes = RequirementDesignator.Mandatory },
				new E_0364 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class CON : MapSegment
	{
		public CON()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0846 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class CPR : MapSegment
	{
		public CPR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1053 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0212 { ReqDes = RequirementDesignator.Mandatory },
				new E_1054 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CR1 : MapSegment
	{
		public CR1()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_1316 { ReqDes = RequirementDesignator.Optional },
				new E_1317 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0166 { ReqDes = RequirementDesignator.Optional },
				new E_0166 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CR2 : MapSegment
	{
		public CR2()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "C0403", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1367 { ReqDes = RequirementDesignator.Optional },
				new E_1367 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1342 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CR3 : MapSegment
	{
		public CR3()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1322 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1335 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CR4 : MapSegment
	{
		public CR4()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "P0809", "P1011", "P1213" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1322 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1344 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1346 { ReqDes = RequirementDesignator.Optional },
				new E_1347 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CR5 : MapSegment
	{
		public CR5()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1322 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1348 { ReqDes = RequirementDesignator.Optional },
				new E_1348 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1349 { ReqDes = RequirementDesignator.Optional },
				new E_1350 { ReqDes = RequirementDesignator.Optional },
				new E_1350 { ReqDes = RequirementDesignator.Optional },
				new E_1350 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1382 { ReqDes = RequirementDesignator.Optional },
				new E_1348 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CR6 : MapSegment
	{
		public CR6()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P091011", "P151617" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0923 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1322 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_1137 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1384 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CR7 : MapSegment
	{
		public CR7()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0921 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class CR8 : MapSegment
	{
		public CR8()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1403 { ReqDes = RequirementDesignator.Mandatory },
				new E_1404 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class CRC : MapSegment
	{
		public CRC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1321 { ReqDes = RequirementDesignator.Mandatory },
				new E_1321 { ReqDes = RequirementDesignator.Optional },
				new E_1321 { ReqDes = RequirementDesignator.Optional },
				new E_1321 { ReqDes = RequirementDesignator.Optional },
				new E_1321 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CRD : MapSegment
	{
		public CRD()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "R0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0026 { ReqDes = RequirementDesignator.Mandatory },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0488 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CRI : MapSegment
	{
		public CRI()
		{
			SyntaxNotes.AddRange(new[] { "P010708", "C0901", "C1001" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0875 { ReqDes = RequirementDesignator.Optional },
				new E_1029 { ReqDes = RequirementDesignator.Optional },
				new E_1203 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_1032 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1129 { ReqDes = RequirementDesignator.Optional },
				new E_0009 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CRO : MapSegment
	{
		public CRO()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0612 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CRS : MapSegment
	{
		public CRS()
		{
			SyntaxNotes.AddRange(new[] { "C0605", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1147 { ReqDes = RequirementDesignator.Mandatory },
				new E_1141 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1148 { ReqDes = RequirementDesignator.Optional },
				new E_1258 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1142 { ReqDes = RequirementDesignator.Optional },
				new E_1150 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1131 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1152 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CRT : MapSegment
	{
		public CRT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0755 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_1196 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0562 { ReqDes = RequirementDesignator.Optional },
				new E_1308 { ReqDes = RequirementDesignator.Optional },
				new E_1193 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CRV : MapSegment
	{
		public CRV()
		{
			SyntaxNotes.AddRange(new[] { "C0406" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1540 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0750 { ReqDes = RequirementDesignator.Optional },
				new E_0488 { ReqDes = RequirementDesignator.Optional },
				new E_0246 { ReqDes = RequirementDesignator.Optional },
				new E_1546 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CS : MapSegment
	{
		public CS()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0327 { ReqDes = RequirementDesignator.Optional },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0560 { ReqDes = RequirementDesignator.Optional },
				new E_0433 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0336 { ReqDes = RequirementDesignator.Optional },
				new E_0560 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0336 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CSB : MapSegment
	{
		public CSB()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0988 { ReqDes = RequirementDesignator.Mandatory },
				new E_0989 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CSC : MapSegment
	{
		public CSC()
		{
			SyntaxNotes.AddRange(new[] { "P08091011", "P12131415", "P1819", "P2021", "P22232425" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1642 { ReqDes = RequirementDesignator.Mandatory },
				new E_0824 { ReqDes = RequirementDesignator.Optional },
				new E_0825 { ReqDes = RequirementDesignator.Optional },
				new C050 { ReqDes = RequirementDesignator.Optional },
				new C040 { ReqDes = RequirementDesignator.Optional },
				new E_1570 { ReqDes = RequirementDesignator.Optional },
				new E_0799 { ReqDes = RequirementDesignator.Optional },
				new E_0995 { ReqDes = RequirementDesignator.Optional },
				new C033 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CSD : MapSegment
	{
		public CSD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0152 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0058 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CSE : MapSegment
	{
		public CSE()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1141 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1142 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0790 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CSF : MapSegment
	{
		public CSF()
		{
			SyntaxNotes.AddRange(new[] { "E1617" });

			Content.AddRange(new MapBaseDataElement[] {
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_1167 { ReqDes = RequirementDesignator.Optional },
				new E_0942 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CSH : MapSegment
	{
		public CSH()
		{
			SyntaxNotes.AddRange(new[] { "C0203", "P0607", "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0563 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0560 { ReqDes = RequirementDesignator.Optional },
				new E_0566 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1004 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CSI : MapSegment
	{
		public CSI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1383 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class CSM : MapSegment
	{
		public CSM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0987 { ReqDes = RequirementDesignator.Mandatory },
				new E_0824 { ReqDes = RequirementDesignator.Optional },
				new E_0825 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CSS : MapSegment
	{
		public CSS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1020 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_1021 { ReqDes = RequirementDesignator.Mandatory },
				new E_1021 { ReqDes = RequirementDesignator.Optional },
				new E_1021 { ReqDes = RequirementDesignator.Optional },
				new E_1021 { ReqDes = RequirementDesignator.Optional },
				new E_1021 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CST : MapSegment
	{
		public CST()
		{
			SyntaxNotes.AddRange(new[] { "P0318" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0964 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CSU : MapSegment
	{
		public CSU()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1132 { ReqDes = RequirementDesignator.Optional },
				new E_1141 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CT : MapSegment
	{
		public CT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0301 { ReqDes = RequirementDesignator.Mandatory },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CTB : MapSegment
	{
		public CTB()
		{
			SyntaxNotes.AddRange(new[] { "R020406", "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0688 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CTC : MapSegment
	{
		public CTC()
		{
			SyntaxNotes.AddRange(new[] { "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_1002 { ReqDes = RequirementDesignator.Mandatory },
				new E_1003 { ReqDes = RequirementDesignator.Mandatory },
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_1095 { ReqDes = RequirementDesignator.Mandatory },
				new E_1108 { ReqDes = RequirementDesignator.Mandatory },
				new E_1095 { ReqDes = RequirementDesignator.Optional },
				new E_1108 { ReqDes = RequirementDesignator.Optional },
				new E_1006 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CTP : MapSegment
	{
		public CTP()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "C2021", "C2302", "C2402", "C2503" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0687 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0648 { ReqDes = RequirementDesignator.Optional },
				new E_0649 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0639 { ReqDes = RequirementDesignator.Optional },
				new E_0499 { ReqDes = RequirementDesignator.Optional },
				new E_0289 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CTT : MapSegment
	{
		public CTT()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0354 { ReqDes = RequirementDesignator.Mandatory },
				new E_0347 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CUR : MapSegment
	{
		public CUR()
		{
			SyntaxNotes.AddRange(new[] { "C0807", "C0907", "L101112", "C1110", "C1210", "L131415", "C1413", "C1513", "L161718", "C1716", "C1816", "L192021", "C2019", "C2119" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0098 { ReqDes = RequirementDesignator.Mandatory },
				new E_0100 { ReqDes = RequirementDesignator.Mandatory },
				new E_0280 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0669 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CV : MapSegment
	{
		public CV()
		{
			SyntaxNotes.AddRange(new[] { "C0504" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0322 { ReqDes = RequirementDesignator.Mandatory },
				new E_0482 { ReqDes = RequirementDesignator.Optional },
				new E_1014 { ReqDes = RequirementDesignator.Optional },
				new E_0519 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1015 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1016 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class CYC : MapSegment
	{
		public CYC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1095 { ReqDes = RequirementDesignator.Mandatory },
				new E_1108 { ReqDes = RequirementDesignator.Mandatory },
				new E_1010 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_1011 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class D9 : MapSegment
	{
		public D9()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0573 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Mandatory },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0573 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DAD : MapSegment
	{
		public DAD()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "C1009", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0305 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0509 { ReqDes = RequirementDesignator.Optional },
				new E_0510 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Optional },
				new E_0507 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DAI : MapSegment
	{
		public DAI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0916 { ReqDes = RequirementDesignator.Mandatory },
				new E_0490 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DAM : MapSegment
	{
		public DAM()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "L070506", "L100809", "L131112", "L161415" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1422 { ReqDes = RequirementDesignator.Optional },
				new E_0556 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_1422 { ReqDes = RequirementDesignator.Optional },
				new E_0556 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_1422 { ReqDes = RequirementDesignator.Optional },
				new E_0556 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_1422 { ReqDes = RequirementDesignator.Optional },
				new E_0556 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_1422 { ReqDes = RequirementDesignator.Optional },
				new E_0556 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DB : MapSegment
	{
		public DB()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DD : MapSegment
	{
		public DD()
		{
			SyntaxNotes.AddRange(new[] { "C0201", "P030405", "C0605", "C1009" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DDI : MapSegment
	{
		public DDI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class DED : MapSegment
	{
		public DED()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1511 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DEF : MapSegment
	{
		public DEF()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0998 { ReqDes = RequirementDesignator.Mandatory },
				new E_1264 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_1265 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DEG : MapSegment
	{
		public DEG()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1126 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DEL : MapSegment
	{
		public DEL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0076 { ReqDes = RequirementDesignator.Optional },
				new E_1237 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DEP : MapSegment
	{
		public DEP()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Mandatory },
				new E_0507 { ReqDes = RequirementDesignator.Mandatory },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DEX : MapSegment
	{
		public DEX()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0139 { ReqDes = RequirementDesignator.Optional },
				new E_1408 { ReqDes = RequirementDesignator.Optional },
				new E_1407 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DFI : MapSegment
	{
		public DFI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_1032 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DH : MapSegment
	{
		public DH()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0678 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class DIS : MapSegment
	{
		public DIS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0653 { ReqDes = RequirementDesignator.Mandatory },
				new E_0654 { ReqDes = RequirementDesignator.Mandatory },
				new E_0655 { ReqDes = RequirementDesignator.Mandatory },
				new E_0656 { ReqDes = RequirementDesignator.Mandatory },
				new E_0657 { ReqDes = RequirementDesignator.Mandatory },
				new E_0657 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DK : MapSegment
	{
		public DK()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0697 { ReqDes = RequirementDesignator.Mandatory },
				new E_0690 { ReqDes = RequirementDesignator.Mandatory },
				new E_0691 { ReqDes = RequirementDesignator.Mandatory },
				new E_0692 { ReqDes = RequirementDesignator.Optional },
				new E_0693 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0346 { ReqDes = RequirementDesignator.Optional },
				new E_0260 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DL : MapSegment
	{
		public DL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0542 { ReqDes = RequirementDesignator.Optional },
				new E_0542 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DLV : MapSegment
	{
		public DLV()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0330 { ReqDes = RequirementDesignator.Mandatory },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1193 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DM : MapSegment
	{
		public DM()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0262 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Mandatory },
				new E_0176 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Mandatory },
				new E_0615 { ReqDes = RequirementDesignator.Mandatory },
				new E_0616 { ReqDes = RequirementDesignator.Mandatory },
				new E_0118 { ReqDes = RequirementDesignator.Mandatory },
				new E_0177 { ReqDes = RequirementDesignator.Optional },
				new E_0257 { ReqDes = RequirementDesignator.Optional },
				new E_0011 { ReqDes = RequirementDesignator.Optional },
				new E_0615 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DMA : MapSegment
	{
		public DMA()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0607", "C0807", "C0903" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_1268 { ReqDes = RequirementDesignator.Optional },
				new E_0083 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0819 { ReqDes = RequirementDesignator.Optional },
				new E_0546 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DMG : MapSegment
	{
		public DMG()
		{
			SyntaxNotes.AddRange(new[] { "P0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1068 { ReqDes = RequirementDesignator.Optional },
				new E_1067 { ReqDes = RequirementDesignator.Optional },
				new E_1109 { ReqDes = RequirementDesignator.Optional },
				new E_1066 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0659 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DMI : MapSegment
	{
		public DMI()
		{
			SyntaxNotes.AddRange(new[] { "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0926 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0166 { ReqDes = RequirementDesignator.Optional },
				new E_0166 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0365 { ReqDes = RequirementDesignator.Optional },
				new E_0364 { ReqDes = RequirementDesignator.Optional },
				new E_0490 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DN : MapSegment
	{
		public DN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0432 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_1242 { ReqDes = RequirementDesignator.Optional },
				new E_1243 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DN1 : MapSegment
	{
		public DN1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DN2 : MapSegment
	{
		public DN2()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_1368 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DOS : MapSegment
	{
		public DOS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1166 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DP : MapSegment
	{
		public DP()
		{
			SyntaxNotes.AddRange(new[] { "L11021213" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1321 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0332 { ReqDes = RequirementDesignator.Optional },
				new E_0360 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DPN : MapSegment
	{
		public DPN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
				new E_1067 { ReqDes = RequirementDesignator.Optional },
				new E_0584 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DR : MapSegment
	{
		public DR()
		{
			SyntaxNotes.AddRange(new[] { "E0605", "R0605" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0697 { ReqDes = RequirementDesignator.Mandatory },
				new E_0690 { ReqDes = RequirementDesignator.Mandatory },
				new E_0691 { ReqDes = RequirementDesignator.Optional },
				new E_0690 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DRT : MapSegment
	{
		public DRT()
		{
			SyntaxNotes.AddRange(new[] { "E0304", "C0302", "C0402" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0322 { ReqDes = RequirementDesignator.Optional },
				new E_0221 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0259 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DSB : MapSegment
	{
		public DSB()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1149 { ReqDes = RequirementDesignator.Optional },
				new E_1154 { ReqDes = RequirementDesignator.Optional },
				new E_1161 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_1137 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DTM : MapSegment
	{
		public DTM()
		{
			SyntaxNotes.AddRange(new[] { "R020305", "C0403", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0374 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class DTP : MapSegment
	{
		public DTP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0374 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class DVI : MapSegment
	{
		public DVI()
		{
			SyntaxNotes.AddRange(new[] { "C0102", "P0405", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1423 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E01 : MapSegment
	{
		public E01()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0922 { ReqDes = RequirementDesignator.Mandatory },
				new E_0480 { ReqDes = RequirementDesignator.Mandatory },
				new E_0924 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class E03 : MapSegment
	{
		public E03()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0906 { ReqDes = RequirementDesignator.Mandatory },
				new E_0721 { ReqDes = RequirementDesignator.Mandatory },
				new E_0903 { ReqDes = RequirementDesignator.Mandatory },
				new E_0904 { ReqDes = RequirementDesignator.Mandatory },
				new E_0905 { ReqDes = RequirementDesignator.Mandatory },
				new E_0490 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E1 : MapSegment
	{
		public E1()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0459 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E10 : MapSegment
	{
		public E10()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0143 { ReqDes = RequirementDesignator.Mandatory },
				new E_0479 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
				new E_0490 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E13 : MapSegment
	{
		public E13()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0589 { ReqDes = RequirementDesignator.Mandatory },
				new E_0902 { ReqDes = RequirementDesignator.Optional },
				new E_0721 { ReqDes = RequirementDesignator.Optional },
				new E_0904 { ReqDes = RequirementDesignator.Optional },
				new E_0905 { ReqDes = RequirementDesignator.Optional },
				new E_0909 { ReqDes = RequirementDesignator.Optional },
				new E_0910 { ReqDes = RequirementDesignator.Optional },
				new E_0489 { ReqDes = RequirementDesignator.Optional },
				new E_0490 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E20 : MapSegment
	{
		public E20()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0721 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0490 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E22 : MapSegment
	{
		public E22()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0912 { ReqDes = RequirementDesignator.Mandatory },
				new E_0911 { ReqDes = RequirementDesignator.Mandatory },
				new E_0911 { ReqDes = RequirementDesignator.Optional },
				new E_0911 { ReqDes = RequirementDesignator.Optional },
				new E_0911 { ReqDes = RequirementDesignator.Optional },
				new E_0911 { ReqDes = RequirementDesignator.Optional },
				new E_0911 { ReqDes = RequirementDesignator.Optional },
				new E_0911 { ReqDes = RequirementDesignator.Optional },
				new E_0911 { ReqDes = RequirementDesignator.Optional },
				new E_0911 { ReqDes = RequirementDesignator.Optional },
				new E_0911 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E24 : MapSegment
	{
		public E24()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0911 { ReqDes = RequirementDesignator.Mandatory },
				new E_0725 { ReqDes = RequirementDesignator.Mandatory },
				new E_0904 { ReqDes = RequirementDesignator.Mandatory },
				new E_0491 { ReqDes = RequirementDesignator.Optional },
				new E_0490 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E26 : MapSegment
	{
		public E26()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0492 { ReqDes = RequirementDesignator.Mandatory },
				new E_0725 { ReqDes = RequirementDesignator.Mandatory },
				new E_0904 { ReqDes = RequirementDesignator.Mandatory },
				new E_0491 { ReqDes = RequirementDesignator.Optional },
				new E_0490 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E30 : MapSegment
	{
		public E30()
		{
			SyntaxNotes.AddRange(new[] { "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0725 { ReqDes = RequirementDesignator.Mandatory },
				new E_0913 { ReqDes = RequirementDesignator.Mandatory },
				new E_0914 { ReqDes = RequirementDesignator.Mandatory },
				new E_0915 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0490 { ReqDes = RequirementDesignator.Optional },
				new E_0725 { ReqDes = RequirementDesignator.Optional },
				new E_0916 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E34 : MapSegment
	{
		public E34()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0918 { ReqDes = RequirementDesignator.Mandatory },
				new E_0505 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class E4 : MapSegment
	{
		public E4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0019 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Mandatory },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E40 : MapSegment
	{
		public E40()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0487 { ReqDes = RequirementDesignator.Mandatory },
				new E_0490 { ReqDes = RequirementDesignator.Mandatory },
				new E_0568 { ReqDes = RequirementDesignator.Mandatory },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E5 : MapSegment
	{
		public E5()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0133 { ReqDes = RequirementDesignator.Mandatory },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class E6 : MapSegment
	{
		public E6()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0019 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0296 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
				new E_0578 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class E8 : MapSegment
	{
		public E8()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0042 { ReqDes = RequirementDesignator.Optional },
				new E_0748 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EA : MapSegment
	{
		public EA()
		{
			SyntaxNotes.AddRange(new[] { "P0217" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1402 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EB : MapSegment
	{
		public EB()
		{
			SyntaxNotes.AddRange(new[] { "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1390 { ReqDes = RequirementDesignator.Mandatory },
				new E_1207 { ReqDes = RequirementDesignator.Optional },
				new E_1365 { ReqDes = RequirementDesignator.Optional },
				new E_1336 { ReqDes = RequirementDesignator.Optional },
				new E_1204 { ReqDes = RequirementDesignator.Optional },
				new E_0615 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new C003 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EC : MapSegment
	{
		public EC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1176 { ReqDes = RequirementDesignator.Optional },
				new E_1176 { ReqDes = RequirementDesignator.Optional },
				new E_1176 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1201 { ReqDes = RequirementDesignator.Optional },
				new E_1149 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ED : MapSegment
	{
		public ED()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0322 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0079 { ReqDes = RequirementDesignator.Optional },
				new E_0186 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EFI : MapSegment
	{
		public EFI()
		{
			SyntaxNotes.AddRange(new[] { "C0504", "C0706", "C0908", "P1516" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0786 { ReqDes = RequirementDesignator.Mandatory },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_0797 { ReqDes = RequirementDesignator.Optional },
				new E_0799 { ReqDes = RequirementDesignator.Optional },
				new E_0802 { ReqDes = RequirementDesignator.Optional },
				new E_0799 { ReqDes = RequirementDesignator.Optional },
				new E_0801 { ReqDes = RequirementDesignator.Optional },
				new E_0799 { ReqDes = RequirementDesignator.Optional },
				new E_0800 { ReqDes = RequirementDesignator.Optional },
				new E_0789 { ReqDes = RequirementDesignator.Optional },
				new E_0803 { ReqDes = RequirementDesignator.Optional },
				new E_0804 { ReqDes = RequirementDesignator.Optional },
				new E_0787 { ReqDes = RequirementDesignator.Optional },
				new E_0788 { ReqDes = RequirementDesignator.Optional },
				new E_0799 { ReqDes = RequirementDesignator.Optional },
				new E_1570 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EI : MapSegment
	{
		public EI()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_1543 { ReqDes = RequirementDesignator.Optional },
				new E_0219 { ReqDes = RequirementDesignator.Optional },
				new E_1554 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EIA : MapSegment
	{
		public EIA()
		{
			SyntaxNotes.AddRange(new[] { "C0504" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EM : MapSegment
	{
		public EM()
		{
			SyntaxNotes.AddRange(new[] { "C0201", "C0403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_1429 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EMP : MapSegment
	{
		public EMP()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EMS : MapSegment
	{
		public EMS()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1176 { ReqDes = RequirementDesignator.Optional },
				new E_1149 { ReqDes = RequirementDesignator.Optional },
				new E_0584 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EMT : MapSegment
	{
		public EMT()
		{
			SyntaxNotes.AddRange(new[] { "P0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ENE : MapSegment
	{
		public ENE()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0709 { ReqDes = RequirementDesignator.Mandatory },
				new E_0365 { ReqDes = RequirementDesignator.Mandatory },
				new E_0364 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ENR : MapSegment
	{
		public ENR()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0607", "P1213", "P1516", "P1718" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0641 { ReqDes = RequirementDesignator.Mandatory },
				new E_1131 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1266 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
				new E_1144 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ENT : MapSegment
	{
		public ENT()
		{
			SyntaxNotes.AddRange(new[] { "P020304", "P050607", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EQ : MapSegment
	{
		public EQ()
		{
			SyntaxNotes.AddRange(new[] { "R0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1365 { ReqDes = RequirementDesignator.Optional },
				new C003 { ReqDes = RequirementDesignator.Optional },
				new E_1207 { ReqDes = RequirementDesignator.Optional },
				new E_1336 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ER : MapSegment
	{
		public ER()
		{
			SyntaxNotes.AddRange(new[] { "C0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0304 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0041 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0322 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ERI : MapSegment
	{
		public ERI()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0706 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0706 { ReqDes = RequirementDesignator.Mandatory },
				new E_0706 { ReqDes = RequirementDesignator.Optional },
				new E_0706 { ReqDes = RequirementDesignator.Optional },
				new E_1400 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ERP : MapSegment
	{
		public ERP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ES : MapSegment
	{
		public ES()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1488 { ReqDes = RequirementDesignator.Optional },
				new E_1489 { ReqDes = RequirementDesignator.Optional },
				new E_1490 { ReqDes = RequirementDesignator.Optional },
				new E_0519 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0617 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ESI : MapSegment
	{
		public ESI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0584 { ReqDes = RequirementDesignator.Optional },
				new E_1154 { ReqDes = RequirementDesignator.Optional },
				new E_1468 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ETD : MapSegment
	{
		public ETD()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0626 { ReqDes = RequirementDesignator.Mandatory },
				new E_0627 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0743 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class EXI : MapSegment
	{
		public EXI()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "P1011", "R1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new C040 { ReqDes = RequirementDesignator.Mandatory },
				new E_0467 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_0519 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F01 : MapSegment
	{
		public F01()
		{
			SyntaxNotes.AddRange(new[] { "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0544 { ReqDes = RequirementDesignator.Mandatory },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0280 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F02 : MapSegment
	{
		public F02()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0597 { ReqDes = RequirementDesignator.Optional },
				new E_0182 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F04 : MapSegment
	{
		public F04()
		{
			SyntaxNotes.AddRange(new[] { "P010203", "C0104", "P040506", "P0708", "C0709", "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F05 : MapSegment
	{
		public F05()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0538 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0478 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class F07 : MapSegment
	{
		public F07()
		{
			SyntaxNotes.AddRange(new[] { "C02030405", "L111213", "L131112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0557 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0556 { ReqDes = RequirementDesignator.Mandatory },
				new E_0540 { ReqDes = RequirementDesignator.Mandatory },
				new E_0541 { ReqDes = RequirementDesignator.Mandatory },
				new E_0555 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0542 { ReqDes = RequirementDesignator.Optional },
				new E_0542 { ReqDes = RequirementDesignator.Optional },
				new E_0550 { ReqDes = RequirementDesignator.Optional },
				new E_0551 { ReqDes = RequirementDesignator.Optional },
				new E_0552 { ReqDes = RequirementDesignator.Mandatory },
				new E_0553 { ReqDes = RequirementDesignator.Optional },
				new E_0831 { ReqDes = RequirementDesignator.Optional },
				new E_0556 { ReqDes = RequirementDesignator.Optional },
				new E_0540 { ReqDes = RequirementDesignator.Optional },
				new E_0541 { ReqDes = RequirementDesignator.Optional },
				new E_0548 { ReqDes = RequirementDesignator.Optional },
				new E_0538 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F09 : MapSegment
	{
		public F09()
		{
			SyntaxNotes.AddRange(new[] { "P0809", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0536 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0079 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0213 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F10 : MapSegment
	{
		public F10()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F11 : MapSegment
	{
		public F11()
		{
			SyntaxNotes.AddRange(new[] { "P0310", "P0409", "C0504" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0546 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0548 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F12 : MapSegment
	{
		public F12()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0475 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0543 { ReqDes = RequirementDesignator.Mandatory },
				new E_0543 { ReqDes = RequirementDesignator.Mandatory },
				new E_0927 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F13 : MapSegment
	{
		public F13()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0429 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0442 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class F14 : MapSegment
	{
		public F14()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0548 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class F6X : MapSegment
	{
		public F6X()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0539 { ReqDes = RequirementDesignator.Mandatory },
				new E_0833 { ReqDes = RequirementDesignator.Mandatory },
				new E_0838 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0076 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class F9 : MapSegment
	{
		public F9()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0573 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Mandatory },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0573 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FA1 : MapSegment
	{
		public FA1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0559 { ReqDes = RequirementDesignator.Mandatory },
				new E_1300 { ReqDes = RequirementDesignator.Optional },
				new E_0248 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FA2 : MapSegment
	{
		public FA2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1196 { ReqDes = RequirementDesignator.Mandatory },
				new E_1195 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class FAA : MapSegment
	{
		public FAA()
		{
			SyntaxNotes.AddRange(new[] { "P0722", "C2325", "P2425", "P2627" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0569 { ReqDes = RequirementDesignator.Mandatory },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1187 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FAC : MapSegment
	{
		public FAC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_1273 { ReqDes = RequirementDesignator.Optional },
				new E_0578 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FBB : MapSegment
	{
		public FBB()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "L040607", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0026 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FC : MapSegment
	{
		public FC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1224 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FCL : MapSegment
	{
		public FCL()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0605 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0426 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FDA : MapSegment
	{
		public FDA()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "E0405", "C0403", "C0503", "C0807" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1078 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1074 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
				new E_1429 { ReqDes = RequirementDesignator.Optional },
				new E_1429 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FGS : MapSegment
	{
		public FGS()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FH : MapSegment
	{
		public FH()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1069 { ReqDes = RequirementDesignator.Mandatory },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1213 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FIR : MapSegment
	{
		public FIR()
		{
			SyntaxNotes.AddRange(new[] { "C0605", "C1211" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Mandatory },
				new E_1271 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0478 { ReqDes = RequirementDesignator.Optional },
				new E_1197 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FIS : MapSegment
	{
		public FIS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FK : MapSegment
	{
		public FK()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "E0305" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0638 { ReqDes = RequirementDesignator.Optional },
				new E_0694 { ReqDes = RequirementDesignator.Optional },
				new E_0634 { ReqDes = RequirementDesignator.Optional },
				new E_0634 { ReqDes = RequirementDesignator.Optional },
				new E_0634 { ReqDes = RequirementDesignator.Optional },
				new E_0634 { ReqDes = RequirementDesignator.Optional },
				new E_0634 { ReqDes = RequirementDesignator.Optional },
				new E_0634 { ReqDes = RequirementDesignator.Optional },
				new E_0634 { ReqDes = RequirementDesignator.Optional },
				new E_0634 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FNA : MapSegment
	{
		public FNA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1267 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FOB : MapSegment
	{
		public FOB()
		{
			SyntaxNotes.AddRange(new[] { "C0302", "C0405", "C0706", "C0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0334 { ReqDes = RequirementDesignator.Optional },
				new E_0335 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0054 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FOS : MapSegment
	{
		public FOS()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "R0204" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1153 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FPT : MapSegment
	{
		public FPT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1187 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FSA : MapSegment
	{
		public FSA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0875 { ReqDes = RequirementDesignator.Mandatory },
				new E_1202 { ReqDes = RequirementDesignator.Optional },
				new E_1203 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_1204 { ReqDes = RequirementDesignator.Optional },
				new E_1161 { ReqDes = RequirementDesignator.Optional },
				new E_1161 { ReqDes = RequirementDesignator.Optional },
				new E_1161 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FST : MapSegment
	{
		public FST()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0680 { ReqDes = RequirementDesignator.Mandatory },
				new E_0681 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0783 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class FTH : MapSegment
	{
		public FTH()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1070 { ReqDes = RequirementDesignator.Optional },
				new E_1187 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G01 : MapSegment
	{
		public G01()
		{
			SyntaxNotes.AddRange(new[] { "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0076 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0424 { ReqDes = RequirementDesignator.Optional },
				new E_0474 { ReqDes = RequirementDesignator.Optional },
				new E_0472 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G05 : MapSegment
	{
		public G05()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "R010305", "P0304", "P0506", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0382 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G07 : MapSegment
	{
		public G07()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0407 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G08 : MapSegment
	{
		public G08()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0409 { ReqDes = RequirementDesignator.Optional },
				new E_0410 { ReqDes = RequirementDesignator.Optional },
				new E_0411 { ReqDes = RequirementDesignator.Optional },
				new E_0412 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G1 : MapSegment
	{
		public G1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0311 { ReqDes = RequirementDesignator.Mandatory },
				new E_0312 { ReqDes = RequirementDesignator.Optional },
				new E_0312 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G11 : MapSegment
	{
		public G11()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1178 { ReqDes = RequirementDesignator.Mandatory },
				new E_0729 { ReqDes = RequirementDesignator.Mandatory },
				new E_0729 { ReqDes = RequirementDesignator.Optional },
				new E_0729 { ReqDes = RequirementDesignator.Optional },
				new E_0729 { ReqDes = RequirementDesignator.Optional },
				new E_0729 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G12 : MapSegment
	{
		public G12()
		{
			SyntaxNotes.AddRange(new[] { "P010203", "C0706" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0422 { ReqDes = RequirementDesignator.Optional },
				new E_0945 { ReqDes = RequirementDesignator.Optional },
				new E_0945 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G13 : MapSegment
	{
		public G13()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "C0605" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0687 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G14 : MapSegment
	{
		public G14()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1300 { ReqDes = RequirementDesignator.Mandatory },
				new E_1300 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G15 : MapSegment
	{
		public G15()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_1113 { ReqDes = RequirementDesignator.Mandatory },
				new E_1522 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G17 : MapSegment
	{
		public G17()
		{
			SyntaxNotes.AddRange(new[] { "R0314", "R0405", "P0506", "P0708", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0358 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0237 { ReqDes = RequirementDesignator.Optional },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0417 { ReqDes = RequirementDesignator.Optional },
				new E_0382 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0439 { ReqDes = RequirementDesignator.Optional },
				new E_0440 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G18 : MapSegment
	{
		public G18()
		{
			SyntaxNotes.AddRange(new[] { "E0102", "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G19 : MapSegment
	{
		public G19()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0304", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0382 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0383 { ReqDes = RequirementDesignator.Optional },
				new E_0368 { ReqDes = RequirementDesignator.Optional },
				new E_0381 { ReqDes = RequirementDesignator.Optional },
				new E_0445 { ReqDes = RequirementDesignator.Optional },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G2 : MapSegment
	{
		public G2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0312 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G20 : MapSegment
	{
		public G20()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405", "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0357 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0397 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G21 : MapSegment
	{
		public G21()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0287 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0766 { ReqDes = RequirementDesignator.Mandatory },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G22 : MapSegment
	{
		public G22()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0288 { ReqDes = RequirementDesignator.Mandatory },
				new E_0420 { ReqDes = RequirementDesignator.Optional },
				new E_0289 { ReqDes = RequirementDesignator.Optional },
				new E_0003 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G23 : MapSegment
	{
		public G23()
		{
			SyntaxNotes.AddRange(new[] { "R0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0336 { ReqDes = RequirementDesignator.Mandatory },
				new E_0333 { ReqDes = RequirementDesignator.Mandatory },
				new E_0282 { ReqDes = RequirementDesignator.Optional },
				new E_0283 { ReqDes = RequirementDesignator.Optional },
				new E_0338 { ReqDes = RequirementDesignator.Optional },
				new E_0370 { ReqDes = RequirementDesignator.Optional },
				new E_0351 { ReqDes = RequirementDesignator.Optional },
				new E_0446 { ReqDes = RequirementDesignator.Optional },
				new E_0386 { ReqDes = RequirementDesignator.Optional },
				new E_0362 { ReqDes = RequirementDesignator.Optional },
				new E_0391 { ReqDes = RequirementDesignator.Optional },
				new E_0390 { ReqDes = RequirementDesignator.Optional },
				new E_0343 { ReqDes = RequirementDesignator.Optional },
				new E_0342 { ReqDes = RequirementDesignator.Optional },
				new E_0003 { ReqDes = RequirementDesignator.Optional },
				new E_0713 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G24 : MapSegment
	{
		public G24()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0341 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G25 : MapSegment
	{
		public G25()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0433 { ReqDes = RequirementDesignator.Mandatory },
				new E_0434 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G26 : MapSegment
	{
		public G26()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P040506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0290 { ReqDes = RequirementDesignator.Mandatory },
				new E_0432 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0292 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G27 : MapSegment
	{
		public G27()
		{
			SyntaxNotes.AddRange(new[] { "R0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0387 { ReqDes = RequirementDesignator.Optional },
				new E_0368 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G28 : MapSegment
	{
		public G28()
		{
			SyntaxNotes.AddRange(new[] { "R010203", "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0766 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G29 : MapSegment
	{
		public G29()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1520 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G3 : MapSegment
	{
		public G3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0315 { ReqDes = RequirementDesignator.Optional },
				new E_0317 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0201 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G30 : MapSegment
	{
		public G30()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1521 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G31 : MapSegment
	{
		public G31()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "C0704" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0382 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0398 { ReqDes = RequirementDesignator.Optional },
				new E_0417 { ReqDes = RequirementDesignator.Optional },
				new E_0107 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G32 : MapSegment
	{
		public G32()
		{
			SyntaxNotes.AddRange(new[] { "R020304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G33 : MapSegment
	{
		public G33()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G35 : MapSegment
	{
		public G35()
		{
			SyntaxNotes.AddRange(new[] { "L030102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0422 { ReqDes = RequirementDesignator.Optional },
				new E_1522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G36 : MapSegment
	{
		public G36()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0439 { ReqDes = RequirementDesignator.Mandatory },
				new E_0440 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0291 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G37 : MapSegment
	{
		public G37()
		{
			SyntaxNotes.AddRange(new[] { "C0302" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1523 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G38 : MapSegment
	{
		public G38()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0591 { ReqDes = RequirementDesignator.Optional },
				new E_1292 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G39 : MapSegment
	{
		public G39()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "P0203", "P050607", "P0607", "P0809", "P1011", "P1213", "P1415", "P1819", "P2324", "P2526" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0395 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0416 { ReqDes = RequirementDesignator.Optional },
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0357 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0397 { ReqDes = RequirementDesignator.Optional },
				new E_0398 { ReqDes = RequirementDesignator.Optional },
				new E_0876 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0395 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
				new E_0103 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G4 : MapSegment
	{
		public G4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0019 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Mandatory },
				new E_0459 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0570 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G40 : MapSegment
	{
		public G40()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0417 { ReqDes = RequirementDesignator.Optional },
				new E_0418 { ReqDes = RequirementDesignator.Mandatory },
				new E_0419 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0420 { ReqDes = RequirementDesignator.Optional },
				new E_0421 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G42 : MapSegment
	{
		public G42()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0423 { ReqDes = RequirementDesignator.Mandatory },
				new E_0341 { ReqDes = RequirementDesignator.Mandatory },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G43 : MapSegment
	{
		public G43()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0771 { ReqDes = RequirementDesignator.Mandatory },
				new E_0767 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0687 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G45 : MapSegment
	{
		public G45()
		{
			SyntaxNotes.AddRange(new[] { "R010205", "P0506", "P0809", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0766 { ReqDes = RequirementDesignator.Optional },
				new E_0341 { ReqDes = RequirementDesignator.Optional },
				new E_0769 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0357 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0432 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
				new E_0359 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G46 : MapSegment
	{
		public G46()
		{
			SyntaxNotes.AddRange(new[] { "E030506", "P0304", "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0340 { ReqDes = RequirementDesignator.Mandatory },
				new E_0331 { ReqDes = RequirementDesignator.Mandatory },
				new E_0359 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0378 { ReqDes = RequirementDesignator.Optional },
				new E_0332 { ReqDes = RequirementDesignator.Optional },
				new E_0769 { ReqDes = RequirementDesignator.Optional },
				new E_0770 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G47 : MapSegment
	{
		public G47()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0613 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G48 : MapSegment
	{
		public G48()
		{
			SyntaxNotes.AddRange(new[] { "R0107", "P0102", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0076 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0614 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0424 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G49 : MapSegment
	{
		public G49()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G5 : MapSegment
	{
		public G5()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0708", "P0910", "P1112", "P1516" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0186 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Mandatory },
				new E_0187 { ReqDes = RequirementDesignator.Mandatory },
				new E_0167 { ReqDes = RequirementDesignator.Optional },
				new E_0571 { ReqDes = RequirementDesignator.Optional },
				new E_0232 { ReqDes = RequirementDesignator.Optional },
				new E_0572 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0041 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G50 : MapSegment
	{
		public G50()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0473 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0324 { ReqDes = RequirementDesignator.Mandatory },
				new E_0441 { ReqDes = RequirementDesignator.Optional },
				new E_0474 { ReqDes = RequirementDesignator.Optional },
				new E_0472 { ReqDes = RequirementDesignator.Optional },
				new E_0092 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G51 : MapSegment
	{
		public G51()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0773 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0768 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0766 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G53 : MapSegment
	{
		public G53()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0875 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G54 : MapSegment
	{
		public G54()
		{
			SyntaxNotes.AddRange(new[] { "R0304", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G55 : MapSegment
	{
		public G55()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "P0708", "P0910", "P1112", "P1415", "P232425", "P262728", "P2930" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0357 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0878 { ReqDes = RequirementDesignator.Optional },
				new E_0878 { ReqDes = RequirementDesignator.Optional },
				new E_0879 { ReqDes = RequirementDesignator.Optional },
				new E_0880 { ReqDes = RequirementDesignator.Optional },
				new E_0881 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0397 { ReqDes = RequirementDesignator.Optional },
				new E_0395 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0395 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
				new E_0103 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G61 : MapSegment
	{
		public G61()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0366 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
				new E_0365 { ReqDes = RequirementDesignator.Optional },
				new E_0364 { ReqDes = RequirementDesignator.Optional },
				new E_0443 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G62 : MapSegment
	{
		public G62()
		{
			SyntaxNotes.AddRange(new[] { "R0103", "P0102", "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0432 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0176 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G63 : MapSegment
	{
		public G63()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0615 { ReqDes = RequirementDesignator.Mandatory },
				new E_0616 { ReqDes = RequirementDesignator.Mandatory },
				new E_0257 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G66 : MapSegment
	{
		public G66()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0146 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0399 { ReqDes = RequirementDesignator.Optional },
				new E_0400 { ReqDes = RequirementDesignator.Optional },
				new E_0387 { ReqDes = RequirementDesignator.Optional },
				new E_0433 { ReqDes = RequirementDesignator.Optional },
				new E_0434 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G68 : MapSegment
	{
		public G68()
		{
			SyntaxNotes.AddRange(new[] { "R0405", "P0506", "P0708", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0330 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0237 { ReqDes = RequirementDesignator.Optional },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0417 { ReqDes = RequirementDesignator.Optional },
				new E_0258 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0439 { ReqDes = RequirementDesignator.Optional },
				new E_0440 { ReqDes = RequirementDesignator.Optional },
				new E_0857 { ReqDes = RequirementDesignator.Optional },
				new E_0858 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G69 : MapSegment
	{
		public G69()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0369 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G70 : MapSegment
	{
		public G70()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0357 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0444 { ReqDes = RequirementDesignator.Optional },
				new E_0381 { ReqDes = RequirementDesignator.Optional },
				new E_0445 { ReqDes = RequirementDesignator.Optional },
				new E_0441 { ReqDes = RequirementDesignator.Optional },
				new E_0397 { ReqDes = RequirementDesignator.Optional },
				new E_0416 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G72 : MapSegment
	{
		public G72()
		{
			SyntaxNotes.AddRange(new[] { "R03050809", "E050809", "P0607", "P0910", "C1103" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0340 { ReqDes = RequirementDesignator.Mandatory },
				new E_0331 { ReqDes = RequirementDesignator.Mandatory },
				new E_0341 { ReqDes = RequirementDesignator.Optional },
				new E_0769 { ReqDes = RequirementDesignator.Optional },
				new E_0359 { ReqDes = RequirementDesignator.Optional },
				new E_0339 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0360 { ReqDes = RequirementDesignator.Optional },
				new E_0332 { ReqDes = RequirementDesignator.Optional },
				new E_0828 { ReqDes = RequirementDesignator.Optional },
				new E_0770 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G73 : MapSegment
	{
		public G73()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0369 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G76 : MapSegment
	{
		public G76()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "C0704" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0330 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0398 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0417 { ReqDes = RequirementDesignator.Optional },
				new E_0107 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G82 : MapSegment
	{
		public G82()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0478 { ReqDes = RequirementDesignator.Mandatory },
				new E_0861 { ReqDes = RequirementDesignator.Mandatory },
				new E_0860 { ReqDes = RequirementDesignator.Mandatory },
				new E_0862 { ReqDes = RequirementDesignator.Mandatory },
				new E_0860 { ReqDes = RequirementDesignator.Mandatory },
				new E_0871 { ReqDes = RequirementDesignator.Mandatory },
				new E_0872 { ReqDes = RequirementDesignator.Mandatory },
				new E_0873 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0323 { ReqDes = RequirementDesignator.Optional },
				new E_0146 { ReqDes = RequirementDesignator.Optional },
				new E_0625 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G83 : MapSegment
	{
		public G83()
		{
			SyntaxNotes.AddRange(new[] { "R0405", "P0506", "C0709", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0204 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0766 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0237 { ReqDes = RequirementDesignator.Optional },
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0878 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G84 : MapSegment
	{
		public G84()
		{
			SyntaxNotes.AddRange(new[] { "R0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0361 { ReqDes = RequirementDesignator.Optional },
				new E_0865 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G85 : MapSegment
	{
		public G85()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0866 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G86 : MapSegment
	{
		public G86()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0867 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G87 : MapSegment
	{
		public G87()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0868 { ReqDes = RequirementDesignator.Mandatory },
				new E_0478 { ReqDes = RequirementDesignator.Mandatory },
				new E_0861 { ReqDes = RequirementDesignator.Mandatory },
				new E_0866 { ReqDes = RequirementDesignator.Mandatory },
				new E_0869 { ReqDes = RequirementDesignator.Mandatory },
				new E_0870 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G88 : MapSegment
	{
		public G88()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0872 { ReqDes = RequirementDesignator.Optional },
				new E_0873 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0323 { ReqDes = RequirementDesignator.Optional },
				new E_0862 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G89 : MapSegment
	{
		public G89()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0204 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0766 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0237 { ReqDes = RequirementDesignator.Optional },
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G91 : MapSegment
	{
		public G91()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0259 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G92 : MapSegment
	{
		public G92()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0670 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0324 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G93 : MapSegment
	{
		public G93()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0417 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class G94 : MapSegment
	{
		public G94()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0293 { ReqDes = RequirementDesignator.Optional },
				new E_0770 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class G95 : MapSegment
	{
		public G95()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0293 { ReqDes = RequirementDesignator.Optional },
				new E_0422 { ReqDes = RequirementDesignator.Mandatory },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GA : MapSegment
	{
		public GA()
		{
			SyntaxNotes.AddRange(new[] { "P1415", "P1617" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1275 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_1576 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0642 { ReqDes = RequirementDesignator.Optional },
				new E_0899 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1276 { ReqDes = RequirementDesignator.Optional },
				new E_1277 { ReqDes = RequirementDesignator.Optional },
				new E_1278 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_1004 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GDP : MapSegment
	{
		public GDP()
		{
			SyntaxNotes.AddRange(new[] { "P1819", "P2021" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0739 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_1603 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GE : MapSegment
	{
		public GE()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0097 { ReqDes = RequirementDesignator.Mandatory },
				new E_0028 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class GF : MapSegment
	{
		public GF()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0506", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GH : MapSegment
	{
		public GH()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0354 { ReqDes = RequirementDesignator.Optional },
				new E_0691 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GID : MapSegment
	{
		public GID()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
				new E_1068 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GR : MapSegment
	{
		public GR()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "P1011", "P1516" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1262 { ReqDes = RequirementDesignator.Mandatory },
				new E_1307 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0953 { ReqDes = RequirementDesignator.Optional },
				new E_1086 { ReqDes = RequirementDesignator.Optional },
				new E_0953 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GR2 : MapSegment
	{
		public GR2()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "R0304", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0041 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0041 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GR4 : MapSegment
	{
		public GR4()
		{
			SyntaxNotes.AddRange(new[] { "R0405", "P0506", "P0708", "R0809", "P0910", "C1110" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1395 { ReqDes = RequirementDesignator.Mandatory },
				new E_0040 { ReqDes = RequirementDesignator.Mandatory },
				new E_1396 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GR5 : MapSegment
	{
		public GR5()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0152 { ReqDes = RequirementDesignator.Mandatory },
				new E_0752 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GRI : MapSegment
	{
		public GRI()
		{
			SyntaxNotes.AddRange(new[] { "R0204060810", "C0304", "C0506", "C0708", "C0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1260 { ReqDes = RequirementDesignator.Mandatory },
				new E_1261 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1004 { ReqDes = RequirementDesignator.Optional },
				new E_0488 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class GRP : MapSegment
	{
		public GRP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
				new E_1370 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class GS : MapSegment
	{
		public GS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0479 { ReqDes = RequirementDesignator.Mandatory },
				new E_G142 { ReqDes = RequirementDesignator.Mandatory },
				new E_G124 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_9830 { ReqDes = RequirementDesignator.Mandatory },
				new E_0028 { ReqDes = RequirementDesignator.Mandatory },
				new E_0455 { ReqDes = RequirementDesignator.Mandatory },
				new E_0480 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class GY : MapSegment
	{
		public GY()
		{
			SyntaxNotes.AddRange(new[] { "C0503", "C0605", "P091011", "C12091011", "P1314" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0262 { ReqDes = RequirementDesignator.Mandatory },
				new E_0699 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0259 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0697 { ReqDes = RequirementDesignator.Optional },
				new E_0690 { ReqDes = RequirementDesignator.Optional },
				new E_0260 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class H1 : MapSegment
	{
		public H1()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0062 { ReqDes = RequirementDesignator.Mandatory },
				new E_0209 { ReqDes = RequirementDesignator.Optional },
				new E_0208 { ReqDes = RequirementDesignator.Optional },
				new E_0064 { ReqDes = RequirementDesignator.Optional },
				new E_0063 { ReqDes = RequirementDesignator.Optional },
				new E_0200 { ReqDes = RequirementDesignator.Optional },
				new E_0077 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0254 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class H2 : MapSegment
	{
		public H2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0064 { ReqDes = RequirementDesignator.Mandatory },
				new E_0274 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class H3 : MapSegment
	{
		public H3()
		{
			SyntaxNotes.AddRange(new[] { "E0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0153 { ReqDes = RequirementDesignator.Optional },
				new E_0241 { ReqDes = RequirementDesignator.Optional },
				new E_0242 { ReqDes = RequirementDesignator.Optional },
				new E_0257 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class H5 : MapSegment
	{
		public H5()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0240 { ReqDes = RequirementDesignator.Mandatory },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class H6 : MapSegment
	{
		public H6()
		{
			SyntaxNotes.AddRange(new[] { "R0107", "C0201" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0560 { ReqDes = RequirementDesignator.Optional },
				new E_0560 { ReqDes = RequirementDesignator.Optional },
				new E_0406 { ReqDes = RequirementDesignator.Optional },
				new E_0399 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0108 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class HC : MapSegment
	{
		public HC()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1255 { ReqDes = RequirementDesignator.Mandatory },
				new E_1256 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class HCP : MapSegment
	{
		public HCP()
		{
			SyntaxNotes.AddRange(new[] { "R0113", "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1473 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0901 { ReqDes = RequirementDesignator.Optional },
				new E_1526 { ReqDes = RequirementDesignator.Optional },
				new E_1527 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class HCR : MapSegment
	{
		public HCR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0901 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class HD : MapSegment
	{
		public HD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0875 { ReqDes = RequirementDesignator.Mandatory },
				new E_1203 { ReqDes = RequirementDesignator.Optional },
				new E_1205 { ReqDes = RequirementDesignator.Optional },
				new E_1204 { ReqDes = RequirementDesignator.Optional },
				new E_1207 { ReqDes = RequirementDesignator.Optional },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_1209 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1211 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class HI : MapSegment
	{
		public HI()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P1011", "P1718", "P2425", "P3132", "P3839", "P4546", "P5253", "P5960", "P6667", "P7374", "P8081" });

			Content.AddRange(new MapBaseDataElement[] {
				new C022 { ReqDes = RequirementDesignator.Mandatory },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
				new C022 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class HL : MapSegment
	{
		public HL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0628 { ReqDes = RequirementDesignator.Mandatory },
				new E_0734 { ReqDes = RequirementDesignator.Optional },
				new E_0735 { ReqDes = RequirementDesignator.Mandatory },
				new E_0736 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class HLH : MapSegment
	{
		public HLH()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1212 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1213 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class HS : MapSegment
	{
		public HS()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1252 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class HSD : MapSegment
	{
		public HSD()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "C0605" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_1167 { ReqDes = RequirementDesignator.Optional },
				new E_0615 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0678 { ReqDes = RequirementDesignator.Optional },
				new E_0679 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IC : MapSegment
	{
		public IC()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0167 { ReqDes = RequirementDesignator.Optional },
				new E_0571 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0567 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0845 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ICH : MapSegment
	{
		public ICH()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1068 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_1149 { ReqDes = RequirementDesignator.Optional },
				new E_1069 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1588 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ICM : MapSegment
	{
		public ICM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0594 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_1214 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ID : MapSegment
	{
		public ID()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0556 { ReqDes = RequirementDesignator.Mandatory },
				new E_0540 { ReqDes = RequirementDesignator.Mandatory },
				new E_0541 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class ID1 : MapSegment
	{
		public ID1()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "P0203", "P1112", "P1314", "P1920", "P212223", "C2625", "P262728", "C2925", "P293031", "C3225", "P323334" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0766 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Mandatory },
				new E_0357 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0065 { ReqDes = RequirementDesignator.Mandatory },
				new E_0189 { ReqDes = RequirementDesignator.Mandatory },
				new E_0677 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0712 { ReqDes = RequirementDesignator.Optional },
				new E_0729 { ReqDes = RequirementDesignator.Optional },
				new E_0730 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
				new E_0432 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0814 { ReqDes = RequirementDesignator.Optional },
				new E_0851 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0855 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0863 { ReqDes = RequirementDesignator.Optional },
				new E_0864 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0863 { ReqDes = RequirementDesignator.Optional },
				new E_0864 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0863 { ReqDes = RequirementDesignator.Optional },
				new E_0864 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ID2 : MapSegment
	{
		public ID2()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0878 { ReqDes = RequirementDesignator.Optional },
				new E_0878 { ReqDes = RequirementDesignator.Optional },
				new E_0874 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0874 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ID3 : MapSegment
	{
		public ID3()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "P0203", "P06070809", "P1011", "P1213", "C14151617", "P15161718", "P2021" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0677 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0967 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0677 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0814 { ReqDes = RequirementDesignator.Optional },
				new E_0851 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ID4 : MapSegment
	{
		public ID4()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0074 { ReqDes = RequirementDesignator.Optional },
				new E_0108 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IDB : MapSegment
	{
		public IDB()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1262 { ReqDes = RequirementDesignator.Mandatory },
				new E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0953 { ReqDes = RequirementDesignator.Optional },
				new E_1086 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IDC : MapSegment
	{
		public IDC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1204 { ReqDes = RequirementDesignator.Mandatory },
				new E_1215 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IEA : MapSegment
	{
		public IEA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0I16 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I12 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class IGI : MapSegment
	{
		public IGI()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1678 { ReqDes = RequirementDesignator.Mandatory },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1100 { ReqDes = RequirementDesignator.Optional },
				new E_1679 { ReqDes = RequirementDesignator.Optional },
				new E_1138 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class III : MapSegment
	{
		public III()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "L030405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1136 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0752 { ReqDes = RequirementDesignator.Optional },
				new E_0752 { ReqDes = RequirementDesignator.Optional },
				new E_0752 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IIS : MapSegment
	{
		public IIS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0I44 { ReqDes = RequirementDesignator.Optional },
				new E_0I45 { ReqDes = RequirementDesignator.Optional },
				new E_0I46 { ReqDes = RequirementDesignator.Optional },
				new E_0I47 { ReqDes = RequirementDesignator.Optional },
				new E_0I48 { ReqDes = RequirementDesignator.Optional },
				new E_0I49 { ReqDes = RequirementDesignator.Optional },
				new E_0I50 { ReqDes = RequirementDesignator.Optional },
				new E_0I51 { ReqDes = RequirementDesignator.Optional },
				new E_0I52 { ReqDes = RequirementDesignator.Optional },
				new E_0I53 { ReqDes = RequirementDesignator.Optional },
				new E_0I54 { ReqDes = RequirementDesignator.Optional },
				new E_0I55 { ReqDes = RequirementDesignator.Optional },
				new E_0I61 { ReqDes = RequirementDesignator.Optional },
				new E_0I64 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IM : MapSegment
	{
		public IM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0533 { ReqDes = RequirementDesignator.Optional },
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0534 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IMA : MapSegment
	{
		public IMA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0748 { ReqDes = RequirementDesignator.Mandatory },
				new E_0153 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0257 { ReqDes = RequirementDesignator.Optional },
				new E_0257 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IMM : MapSegment
	{
		public IMM()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "C0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1253 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1254 { ReqDes = RequirementDesignator.Optional },
				new E_0755 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IMP : MapSegment
	{
		public IMP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1460 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IN1 : MapSegment
	{
		public IN1()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1065 { ReqDes = RequirementDesignator.Mandatory },
				new E_1107 { ReqDes = RequirementDesignator.Mandatory },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1069 { ReqDes = RequirementDesignator.Optional },
				new E_1131 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IN2 : MapSegment
	{
		public IN2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1104 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class INC : MapSegment
	{
		public INC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0336 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IND : MapSegment
	{
		public IND()
		{
			SyntaxNotes.AddRange(new[] { "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_1096 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0819 { ReqDes = RequirementDesignator.Optional },
				new E_1476 { ReqDes = RequirementDesignator.Optional },
				new E_0819 { ReqDes = RequirementDesignator.Optional },
				new E_0819 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class INQ : MapSegment
	{
		public INQ()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0485 { ReqDes = RequirementDesignator.Mandatory },
				new E_1187 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class INR : MapSegment
	{
		public INR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Mandatory },
				new E_0701 { ReqDes = RequirementDesignator.Mandatory },
				new E_1201 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class INS : MapSegment
	{
		public INS()
		{
			SyntaxNotes.AddRange(new[] { "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1069 { ReqDes = RequirementDesignator.Mandatory },
				new E_0875 { ReqDes = RequirementDesignator.Optional },
				new E_1203 { ReqDes = RequirementDesignator.Optional },
				new E_1216 { ReqDes = RequirementDesignator.Optional },
				new E_1218 { ReqDes = RequirementDesignator.Optional },
				new E_1219 { ReqDes = RequirementDesignator.Optional },
				new E_0584 { ReqDes = RequirementDesignator.Optional },
				new E_1220 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1165 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class INT : MapSegment
	{
		public INT()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0547 { ReqDes = RequirementDesignator.Mandatory },
				new E_0953 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class INV : MapSegment
	{
		public INV()
		{
			SyntaxNotes.AddRange(new[] { "E020304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class INX : MapSegment
	{
		public INX()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "R0305", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1550 { ReqDes = RequirementDesignator.Mandatory },
				new C036 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class IRA : MapSegment
	{
		public IRA()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1376 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IRP : MapSegment
	{
		public IRP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0I58 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I59 { ReqDes = RequirementDesignator.Optional },
				new E_0I60 { ReqDes = RequirementDesignator.Optional },
				new E_0I61 { ReqDes = RequirementDesignator.Optional },
				new E_0I62 { ReqDes = RequirementDesignator.Optional },
				new E_0I63 { ReqDes = RequirementDesignator.Optional },
				new E_0678 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IS1 : MapSegment
	{
		public IS1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0322 { ReqDes = RequirementDesignator.Mandatory },
				new E_1487 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IS2 : MapSegment
	{
		public IS2()
		{
			SyntaxNotes.AddRange(new[] { "C1716" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0304 { ReqDes = RequirementDesignator.Mandatory },
				new E_0190 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0041 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0042 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ISA : MapSegment
	{
		public ISA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0I01 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I02 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I03 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I04 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I05 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I06 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I05 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I07 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I08 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I09 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I10 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I11 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I12 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I13 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I14 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I15 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class ISC : MapSegment
	{
		public ISC()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0304 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0607 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0041 { ReqDes = RequirementDesignator.Optional },
				new E_0042 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ISD : MapSegment
	{
		public ISD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0304 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class ISR : MapSegment
	{
		public ISR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0368 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ISS : MapSegment
	{
		public ISS()
		{
			SyntaxNotes.AddRange(new[] { "R010305", "P0102", "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0382 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IT1 : MapSegment
	{
		public IT1()
		{
			SyntaxNotes.AddRange(new[] { "P020304", "P0607", "P0809", "P1011", "P1213", "P1415", "P1617", "P1819", "P2021", "P2223", "P2425" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0358 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0639 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IT3 : MapSegment
	{
		public IT3()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "R01030405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0382 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0368 { ReqDes = RequirementDesignator.Optional },
				new E_0383 { ReqDes = RequirementDesignator.Optional },
				new E_0371 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IT8 : MapSegment
	{
		public IT8()
		{
			SyntaxNotes.AddRange(new[] { "R0102030507", "P0809", "P1011", "P1213", "P1415", "P1617", "P1819", "P2021", "P2223", "P2425", "P2627" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0563 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0566 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ITA : MapSegment
	{
		public ITA()
		{
			SyntaxNotes.AddRange(new[] { "L02031314", "C0809", "P1011", "C1502", "C1712" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0248 { ReqDes = RequirementDesignator.Mandatory },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0560 { ReqDes = RequirementDesignator.Optional },
				new E_0331 { ReqDes = RequirementDesignator.Mandatory },
				new E_0341 { ReqDes = RequirementDesignator.Optional },
				new E_0359 { ReqDes = RequirementDesignator.Optional },
				new E_0360 { ReqDes = RequirementDesignator.Optional },
				new E_0378 { ReqDes = RequirementDesignator.Optional },
				new E_0332 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0150 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_0662 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ITC : MapSegment
	{
		public ITC()
		{
			SyntaxNotes.AddRange(new[] { "C0302", "C0402", "E0509", "C0605", "C0705", "C0805", "E1011", "L100509", "L110509" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1629 { ReqDes = RequirementDesignator.Mandatory },
				new E_0701 { ReqDes = RequirementDesignator.Optional },
				new E_1201 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0703 { ReqDes = RequirementDesignator.Optional },
				new E_0604 { ReqDes = RequirementDesignator.Optional },
				new E_1321 { ReqDes = RequirementDesignator.Optional },
				new E_1633 { ReqDes = RequirementDesignator.Optional },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0261 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ITD : MapSegment
	{
		public ITD()
		{
			SyntaxNotes.AddRange(new[] { "L03040513", "L08040513", "L091011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0336 { ReqDes = RequirementDesignator.Optional },
				new E_0333 { ReqDes = RequirementDesignator.Optional },
				new E_0338 { ReqDes = RequirementDesignator.Optional },
				new E_0370 { ReqDes = RequirementDesignator.Optional },
				new E_0351 { ReqDes = RequirementDesignator.Optional },
				new E_0446 { ReqDes = RequirementDesignator.Optional },
				new E_0386 { ReqDes = RequirementDesignator.Optional },
				new E_0362 { ReqDes = RequirementDesignator.Optional },
				new E_0388 { ReqDes = RequirementDesignator.Optional },
				new E_0389 { ReqDes = RequirementDesignator.Optional },
				new E_0342 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0765 { ReqDes = RequirementDesignator.Optional },
				new E_0107 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class IV1 : MapSegment
	{
		public IV1()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "C0502" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class JCT : MapSegment
	{
		public JCT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0573 { ReqDes = RequirementDesignator.Mandatory },
				new E_0573 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1560 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class JID : MapSegment
	{
		public JID()
		{
			SyntaxNotes.AddRange(new[] { "C0403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0286 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class JIL : MapSegment
	{
		public JIL()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "C0703" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class JIT : MapSegment
	{
		public JIT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class JL : MapSegment
	{
		public JL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
				new E_0459 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class JS : MapSegment
	{
		public JS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_1561 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_1561 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class K1 : MapSegment
	{
		public K1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0061 { ReqDes = RequirementDesignator.Mandatory },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class K2 : MapSegment
	{
		public K2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class K3 : MapSegment
	{
		public K3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0449 { ReqDes = RequirementDesignator.Mandatory },
				new E_1333 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L0 : MapSegment
	{
		public L0()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405", "P0607", "P0809", "C1104", "P1315" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0213 { ReqDes = RequirementDesignator.Optional },
				new E_0220 { ReqDes = RequirementDesignator.Optional },
				new E_0221 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0211 { ReqDes = RequirementDesignator.Optional },
				new E_0458 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0056 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0211 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L1 : MapSegment
	{
		public L1()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "R040506", "P1415", "P1718" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0213 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0058 { ReqDes = RequirementDesignator.Optional },
				new E_0191 { ReqDes = RequirementDesignator.Optional },
				new E_0117 { ReqDes = RequirementDesignator.Optional },
				new E_0120 { ReqDes = RequirementDesignator.Optional },
				new E_0150 { ReqDes = RequirementDesignator.Optional },
				new E_0121 { ReqDes = RequirementDesignator.Optional },
				new E_0039 { ReqDes = RequirementDesignator.Optional },
				new E_0016 { ReqDes = RequirementDesignator.Optional },
				new E_0276 { ReqDes = RequirementDesignator.Optional },
				new E_0257 { ReqDes = RequirementDesignator.Optional },
				new E_0074 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0372 { ReqDes = RequirementDesignator.Optional },
				new E_0220 { ReqDes = RequirementDesignator.Optional },
				new E_0221 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L10 : MapSegment
	{
		public L10()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0081 { ReqDes = RequirementDesignator.Mandatory },
				new E_0187 { ReqDes = RequirementDesignator.Mandatory },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L11 : MapSegment
	{
		public L11()
		{
			SyntaxNotes.AddRange(new[] { "R0103", "P0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L12 : MapSegment
	{
		public L12()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0592 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L13 : MapSegment
	{
		public L13()
		{
			SyntaxNotes.AddRange(new[] { "P0809", "P1011", "P1516" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0023 { ReqDes = RequirementDesignator.Mandatory },
				new E_0022 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_1578 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_1589 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L1A : MapSegment
	{
		public L1A()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L3 : MapSegment
	{
		public L3()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0304", "P0910", "C1201", "P1415" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0058 { ReqDes = RequirementDesignator.Optional },
				new E_0191 { ReqDes = RequirementDesignator.Optional },
				new E_0117 { ReqDes = RequirementDesignator.Optional },
				new E_0150 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0171 { ReqDes = RequirementDesignator.Optional },
				new E_0074 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L4 : MapSegment
	{
		public L4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0082 { ReqDes = RequirementDesignator.Mandatory },
				new E_0189 { ReqDes = RequirementDesignator.Mandatory },
				new E_0065 { ReqDes = RequirementDesignator.Mandatory },
				new E_0090 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L5 : MapSegment
	{
		public L5()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "C0706", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0213 { ReqDes = RequirementDesignator.Optional },
				new E_0079 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0023 { ReqDes = RequirementDesignator.Optional },
				new E_0103 { ReqDes = RequirementDesignator.Optional },
				new E_0087 { ReqDes = RequirementDesignator.Optional },
				new E_0088 { ReqDes = RequirementDesignator.Optional },
				new E_0023 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0595 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L7 : MapSegment
	{
		public L7()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0213 { ReqDes = RequirementDesignator.Optional },
				new E_0168 { ReqDes = RequirementDesignator.Optional },
				new E_0171 { ReqDes = RequirementDesignator.Optional },
				new E_0172 { ReqDes = RequirementDesignator.Optional },
				new E_0169 { ReqDes = RequirementDesignator.Optional },
				new E_0170 { ReqDes = RequirementDesignator.Optional },
				new E_0059 { ReqDes = RequirementDesignator.Optional },
				new E_0173 { ReqDes = RequirementDesignator.Optional },
				new E_0046 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0119 { ReqDes = RequirementDesignator.Optional },
				new E_0227 { ReqDes = RequirementDesignator.Optional },
				new E_0294 { ReqDes = RequirementDesignator.Optional },
				new E_0295 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L7A : MapSegment
	{
		public L7A()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0930 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0965 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0660 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L8 : MapSegment
	{
		public L8()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P030405", "P0607", "C0908" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0220 { ReqDes = RequirementDesignator.Optional },
				new E_0221 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0150 { ReqDes = RequirementDesignator.Optional },
				new E_0276 { ReqDes = RequirementDesignator.Optional },
				new E_0016 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class L9 : MapSegment
	{
		public L9()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0150 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class LAD : MapSegment
	{
		public LAD()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0304", "P0506", "P0708", "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0211 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0395 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0079 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LC : MapSegment
	{
		public LC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0875 { ReqDes = RequirementDesignator.Mandatory },
				new E_1203 { ReqDes = RequirementDesignator.Optional },
				new E_1205 { ReqDes = RequirementDesignator.Optional },
				new E_1204 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1161 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LC1 : MapSegment
	{
		public LC1()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "C0911", "C1011", "L110910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0021 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0021 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1664 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LCD : MapSegment
	{
		public LCD()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Mandatory },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LCT : MapSegment
	{
		public LCT()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "L06070809", "C0706", "C0806", "C0906", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0211 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0395 { ReqDes = RequirementDesignator.Optional },
				new E_0090 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0399 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LDT : MapSegment
	{
		public LDT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0345 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0344 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LE : MapSegment
	{
		public LE()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0447 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class LEP : MapSegment
	{
		public LEP()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0806 { ReqDes = RequirementDesignator.Optional },
				new E_0807 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LEQ : MapSegment
	{
		public LEQ()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_1095 { ReqDes = RequirementDesignator.Mandatory },
				new E_1108 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0280 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LET : MapSegment
	{
		public LET()
		{
			SyntaxNotes.AddRange(new[] { "R0204" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0752 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_1585 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LFG : MapSegment
	{
		public LFG()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
				new E_0215 { ReqDes = RequirementDesignator.Mandatory },
				new E_0277 { ReqDes = RequirementDesignator.Mandatory },
				new E_0218 { ReqDes = RequirementDesignator.Mandatory },
				new E_0254 { ReqDes = RequirementDesignator.Optional },
				new E_1577 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LFH : MapSegment
	{
		public LFH()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0808 { ReqDes = RequirementDesignator.Mandatory },
				new E_0809 { ReqDes = RequirementDesignator.Mandatory },
				new E_0809 { ReqDes = RequirementDesignator.Optional },
				new E_1023 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LFI : MapSegment
	{
		public LFI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
				new E_0578 { ReqDes = RequirementDesignator.Mandatory },
				new E_1271 { ReqDes = RequirementDesignator.Mandatory },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0041 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LH : MapSegment
	{
		public LH()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0213 { ReqDes = RequirementDesignator.Mandatory },
				new E_0758 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0759 { ReqDes = RequirementDesignator.Optional },
				new E_0760 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LH1 : MapSegment
	{
		public LH1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0080 { ReqDes = RequirementDesignator.Mandatory },
				new E_0277 { ReqDes = RequirementDesignator.Optional },
				new E_0200 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0595 { ReqDes = RequirementDesignator.Optional },
				new E_0665 { ReqDes = RequirementDesignator.Optional },
				new E_0254 { ReqDes = RequirementDesignator.Optional },
				new E_1375 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LH2 : MapSegment
	{
		public LH2()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "P0809", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0215 { ReqDes = RequirementDesignator.Optional },
				new E_0983 { ReqDes = RequirementDesignator.Optional },
				new E_0218 { ReqDes = RequirementDesignator.Optional },
				new E_0222 { ReqDes = RequirementDesignator.Optional },
				new E_0759 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LH3 : MapSegment
	{
		public LH3()
		{
			SyntaxNotes.AddRange(new[] { "P0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0224 { ReqDes = RequirementDesignator.Optional },
				new E_0984 { ReqDes = RequirementDesignator.Optional },
				new E_0985 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LH4 : MapSegment
	{
		public LH4()
		{
			SyntaxNotes.AddRange(new[] { "P0812" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0238 { ReqDes = RequirementDesignator.Optional },
				new E_0364 { ReqDes = RequirementDesignator.Optional },
				new E_0254 { ReqDes = RequirementDesignator.Optional },
				new E_0230 { ReqDes = RequirementDesignator.Optional },
				new E_0230 { ReqDes = RequirementDesignator.Optional },
				new E_0230 { ReqDes = RequirementDesignator.Optional },
				new E_0271 { ReqDes = RequirementDesignator.Optional },
				new E_0267 { ReqDes = RequirementDesignator.Optional },
				new E_0805 { ReqDes = RequirementDesignator.Optional },
				new E_0986 { ReqDes = RequirementDesignator.Optional },
				new E_0364 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LH6 : MapSegment
	{
		public LH6()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0272 { ReqDes = RequirementDesignator.Optional },
				new E_0273 { ReqDes = RequirementDesignator.Optional },
				new E_0273 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LHE : MapSegment
	{
		public LHE()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0224 { ReqDes = RequirementDesignator.Mandatory },
				new E_0218 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0759 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LHR : MapSegment
	{
		public LHR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LHT : MapSegment
	{
		public LHT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0215 { ReqDes = RequirementDesignator.Optional },
				new E_0218 { ReqDes = RequirementDesignator.Optional },
				new E_0222 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LIC : MapSegment
	{
		public LIC()
		{
			SyntaxNotes.AddRange(new[] { "C0807" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0156 { ReqDes = RequirementDesignator.Mandatory },
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0546 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LID : MapSegment
	{
		public LID()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LIE : MapSegment
	{
		public LIE()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1466 { ReqDes = RequirementDesignator.Mandatory },
				new E_1465 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LIN : MapSegment
	{
		public LIN()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "P0607", "P0809", "P1011", "P1213", "P1415", "P1617", "P1819", "P2021", "P2223", "P2425", "P2627", "P2829", "P3031" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LM : MapSegment
	{
		public LM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0559 { ReqDes = RequirementDesignator.Mandatory },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LN : MapSegment
	{
		public LN()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1081 { ReqDes = RequirementDesignator.Optional },
				new E_1085 { ReqDes = RequirementDesignator.Optional },
				new E_1086 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LN1 : MapSegment
	{
		public LN1()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "L161718192021", "C1716", "C1816", "C1916", "C2016", "C2116" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_1101 { ReqDes = RequirementDesignator.Mandatory },
				new E_1093 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1076 { ReqDes = RequirementDesignator.Optional },
				new E_1103 { ReqDes = RequirementDesignator.Optional },
				new E_1086 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LN2 : MapSegment
	{
		public LN2()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P1112", "P1314", "C1615", "C1715" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1101 { ReqDes = RequirementDesignator.Mandatory },
				new E_1093 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_1085 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1080 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new C040 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LOC : MapSegment
	{
		public LOC()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "C1110", "C2726", "C4342", "C5958", "C7574", "C9190", "P106107" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0729 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LOD : MapSegment
	{
		public LOD()
		{
			SyntaxNotes.AddRange(new[] { "R01030506", "C0201", "E0103", "C0405", "E0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1632 { ReqDes = RequirementDesignator.Optional },
				new E_1321 { ReqDes = RequirementDesignator.Optional },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
				new E_1630 { ReqDes = RequirementDesignator.Optional },
				new E_1631 { ReqDes = RequirementDesignator.Optional },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LP : MapSegment
	{
		public LP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0024 { ReqDes = RequirementDesignator.Optional },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0242 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LQ : MapSegment
	{
		public LQ()
		{
			SyntaxNotes.AddRange(new[] { "C0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LRQ : MapSegment
	{
		public LRQ()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1070 { ReqDes = RequirementDesignator.Optional },
				new E_1079 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1080 { ReqDes = RequirementDesignator.Optional },
				new E_1081 { ReqDes = RequirementDesignator.Optional },
				new C048 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1093 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1085 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LS : MapSegment
	{
		public LS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0447 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class LS1 : MapSegment
	{
		public LS1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0670 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LT : MapSegment
	{
		public LT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1069 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LTE : MapSegment
	{
		public LTE()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "R0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0708 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LTR : MapSegment
	{
		public LTR()
		{
			SyntaxNotes.AddRange(new[] { "L0403", "L1920", "L242223", "L252223", "L262223" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Mandatory },
				new E_1271 { ReqDes = RequirementDesignator.Mandatory },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0157 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
				new E_1068 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LUC : MapSegment
	{
		public LUC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1103 { ReqDes = RequirementDesignator.Mandatory },
				new E_1081 { ReqDes = RequirementDesignator.Mandatory },
				new C048 { ReqDes = RequirementDesignator.Optional },
				new E_0054 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LUI : MapSegment
	{
		public LUI()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "L040203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1303 { ReqDes = RequirementDesignator.Optional },
				new E_1476 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class LV : MapSegment
	{
		public LV()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_1379 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class LX : MapSegment
	{
		public LX()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class M0 : MapSegment
	{
		public M0()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0250 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M1 : MapSegment
	{
		public M1()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0026 { ReqDes = RequirementDesignator.Mandatory },
				new E_0014 { ReqDes = RequirementDesignator.Optional },
				new E_0074 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1004 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1004 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M10 : MapSegment
	{
		public M10()
		{
			SyntaxNotes.AddRange(new[] { "P0410", "R0504" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0026 { ReqDes = RequirementDesignator.Mandatory },
				new E_0597 { ReqDes = RequirementDesignator.Optional },
				new E_0182 { ReqDes = RequirementDesignator.Optional },
				new E_0055 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0256 { ReqDes = RequirementDesignator.Mandatory },
				new E_0897 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M11 : MapSegment
	{
		public M11()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "P1113", "C1514", "C1815", "C1918" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0598 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0599 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Mandatory },
				new E_0188 { ReqDes = RequirementDesignator.Mandatory },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0582 { ReqDes = RequirementDesignator.Optional },
				new E_0600 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_1302 { ReqDes = RequirementDesignator.Optional },
				new E_1578 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M12 : MapSegment
	{
		public M12()
		{
			SyntaxNotes.AddRange(new[] { "E0206", "C0608", "P0809", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0581 { ReqDes = RequirementDesignator.Mandatory },
				new E_0601 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0602 { ReqDes = RequirementDesignator.Optional },
				new E_0603 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0182 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M13 : MapSegment
	{
		public M13()
		{
			SyntaxNotes.AddRange(new[] { "P0810" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Mandatory },
				new E_0580 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0393 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M14 : MapSegment
	{
		public M14()
		{
			SyntaxNotes.AddRange(new[] { "P0608" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0598 { ReqDes = RequirementDesignator.Mandatory },
				new E_0392 { ReqDes = RequirementDesignator.Mandatory },
				new E_0601 { ReqDes = RequirementDesignator.Optional },
				new E_0581 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M15 : MapSegment
	{
		public M15()
		{
			SyntaxNotes.AddRange(new[] { "R0410", "C1110" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1497 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Mandatory },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M2 : MapSegment
	{
		public M2()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0139 { ReqDes = RequirementDesignator.Mandatory },
				new E_0138 { ReqDes = RequirementDesignator.Optional },
				new E_0137 { ReqDes = RequirementDesignator.Optional },
				new E_0335 { ReqDes = RequirementDesignator.Optional },
				new E_0136 { ReqDes = RequirementDesignator.Optional },
				new E_0032 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M20 : MapSegment
	{
		public M20()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0598 { ReqDes = RequirementDesignator.Mandatory },
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0309 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M21 : MapSegment
	{
		public M21()
		{
			SyntaxNotes.AddRange(new[] { "P0708", "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0581 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0598 { ReqDes = RequirementDesignator.Mandatory },
				new E_1428 { ReqDes = RequirementDesignator.Optional },
				new E_0603 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M3 : MapSegment
	{
		public M3()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "C0403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0132 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M7 : MapSegment
	{
		public M7()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0225 { ReqDes = RequirementDesignator.Mandatory },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class M7A : MapSegment
	{
		public M7A()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0225 { ReqDes = RequirementDesignator.Mandatory },
				new E_0225 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MAN : MapSegment
	{
		public MAN()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "C0605" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0088 { ReqDes = RequirementDesignator.Mandatory },
				new E_0087 { ReqDes = RequirementDesignator.Mandatory },
				new E_0087 { ReqDes = RequirementDesignator.Optional },
				new E_0088 { ReqDes = RequirementDesignator.Optional },
				new E_0087 { ReqDes = RequirementDesignator.Optional },
				new E_0087 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MBL : MapSegment
	{
		public MBL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0598 { ReqDes = RequirementDesignator.Mandatory },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0056 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MC : MapSegment
	{
		public MC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0150 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Mandatory },
				new E_0118 { ReqDes = RequirementDesignator.Mandatory },
				new E_0276 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MCD : MapSegment
	{
		public MCD()
		{
			SyntaxNotes.AddRange(new[] { "C0403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MCT : MapSegment
	{
		public MCT()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0150 { ReqDes = RequirementDesignator.Mandatory },
				new E_0981 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0974 { ReqDes = RequirementDesignator.Optional },
				new E_0276 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MEA : MapSegment
	{
		public MEA()
		{
			SyntaxNotes.AddRange(new[] { "R03192022", "C1904", "C2004", "L21031920", "E2203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0737 { ReqDes = RequirementDesignator.Optional },
				new E_0738 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
				new E_0935 { ReqDes = RequirementDesignator.Optional },
				new E_0936 { ReqDes = RequirementDesignator.Optional },
				new E_0752 { ReqDes = RequirementDesignator.Optional },
				new E_1373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MI : MapSegment
	{
		public MI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1393 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MI1 : MapSegment
	{
		public MI1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1661 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MIA : MapSegment
	{
		public MIA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MIC : MapSegment
	{
		public MIC()
		{
			SyntaxNotes.AddRange(new[] { "P0722" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1097 { ReqDes = RequirementDesignator.Mandatory },
				new E_1100 { ReqDes = RequirementDesignator.Optional },
				new E_1099 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1656 { ReqDes = RequirementDesignator.Optional },
				new E_1105 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1102 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0336 { ReqDes = RequirementDesignator.Optional },
				new E_1098 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_1657 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MIN : MapSegment
	{
		public MIN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0633 { ReqDes = RequirementDesignator.Mandatory },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MIR : MapSegment
	{
		public MIR()
		{
			SyntaxNotes.AddRange(new[] { "P0722" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1097 { ReqDes = RequirementDesignator.Mandatory },
				new E_1209 { ReqDes = RequirementDesignator.Mandatory },
				new E_1099 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1102 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MIS : MapSegment
	{
		public MIS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0197 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0348 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MIT : MapSegment
	{
		public MIT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0931 { ReqDes = RequirementDesignator.Optional },
				new E_0932 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MKS : MapSegment
	{
		public MKS()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1304 { ReqDes = RequirementDesignator.Optional },
				new E_1148 { ReqDes = RequirementDesignator.Optional },
				new E_1258 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MLS : MapSegment
	{
		public MLS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1171 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1297 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MNC : MapSegment
	{
		public MNC()
		{
			SyntaxNotes.AddRange(new[] { "P0809", "P1213", "P1415" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Optional },
				new E_1093 { ReqDes = RequirementDesignator.Optional },
				new E_1101 { ReqDes = RequirementDesignator.Optional },
				new E_1085 { ReqDes = RequirementDesignator.Optional },
				new E_1086 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_1626 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0107 { ReqDes = RequirementDesignator.Optional },
				new E_1265 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0750 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_1074 { ReqDes = RequirementDesignator.Optional },
				new E_1076 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MOA : MapSegment
	{
		public MOA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MPI : MapSegment
	{
		public MPI()
		{
			SyntaxNotes.AddRange(new[] { "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1201 { ReqDes = RequirementDesignator.Mandatory },
				new E_0584 { ReqDes = RequirementDesignator.Mandatory },
				new E_1595 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1596 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MPP : MapSegment
	{
		public MPP()
		{
			SyntaxNotes.AddRange(new[] { "P030405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Mandatory },
				new E_1193 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1579 { ReqDes = RequirementDesignator.Optional },
				new E_1322 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MRC : MapSegment
	{
		public MRC()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0098 { ReqDes = RequirementDesignator.Mandatory },
				new E_0196 { ReqDes = RequirementDesignator.Mandatory },
				new E_1079 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1079 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1079 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MS : MapSegment
	{
		public MS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0559 { ReqDes = RequirementDesignator.Mandatory },
				new E_0560 { ReqDes = RequirementDesignator.Mandatory },
				new E_0058 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0058 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MS1 : MapSegment
	{
		public MS1()
		{
			SyntaxNotes.AddRange(new[] { "L010203", "C0201", "C0301", "P0405", "E0104", "C0604", "C0705" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_1654 { ReqDes = RequirementDesignator.Optional },
				new E_1655 { ReqDes = RequirementDesignator.Optional },
				new E_1280 { ReqDes = RequirementDesignator.Optional },
				new E_1280 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MS2 : MapSegment
	{
		public MS2()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "C0402" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_0761 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MS3 : MapSegment
	{
		public MS3()
		{
			SyntaxNotes.AddRange(new[] { "C0503" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0133 { ReqDes = RequirementDesignator.Mandatory },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MS4 : MapSegment
	{
		public MS4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0090 { ReqDes = RequirementDesignator.Mandatory },
				new E_0082 { ReqDes = RequirementDesignator.Mandatory },
				new E_0065 { ReqDes = RequirementDesignator.Mandatory },
				new E_0189 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class MS5 : MapSegment
	{
		public MS5()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "L050104" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0074 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0074 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MS6 : MapSegment
	{
		public MS6()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MSG : MapSegment
	{
		public MSG()
		{
			SyntaxNotes.AddRange(new[] { "C0302" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0933 { ReqDes = RequirementDesignator.Mandatory },
				new E_0934 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MSS : MapSegment
	{
		public MSS()
		{
			SyntaxNotes.AddRange(new[] { "R010206", "E0106" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0820 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0259 { ReqDes = RequirementDesignator.Optional },
				new E_1472 { ReqDes = RequirementDesignator.Optional },
				new E_0821 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class MTX : MapSegment
	{
		public MTX()
		{
			SyntaxNotes.AddRange(new[] { "C0102", "C0302" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0363 { ReqDes = RequirementDesignator.Optional },
				new E_1551 { ReqDes = RequirementDesignator.Optional },
				new E_1551 { ReqDes = RequirementDesignator.Optional },
				new E_0934 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N1 : MapSegment
	{
		public N1()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0098 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0706 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N10 : MapSegment
	{
		public N10()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "P0613", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0087 { ReqDes = RequirementDesignator.Optional },
				new E_0023 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0602 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0599 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N11 : MapSegment
	{
		public N11()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0614 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N12 : MapSegment
	{
		public N12()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0829 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class N2 : MapSegment
	{
		public N2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N3 : MapSegment
	{
		public N3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0166 { ReqDes = RequirementDesignator.Mandatory },
				new E_0166 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N4 : MapSegment
	{
		public N4()
		{
			SyntaxNotes.AddRange(new[] { "C0605" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N5 : MapSegment
	{
		public N5()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0567 { ReqDes = RequirementDesignator.Optional },
				new E_0233 { ReqDes = RequirementDesignator.Optional },
				new E_0203 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
				new E_0216 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0643 { ReqDes = RequirementDesignator.Optional },
				new E_0644 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N7 : MapSegment
	{
		public N7()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0516", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0167 { ReqDes = RequirementDesignator.Optional },
				new E_0232 { ReqDes = RequirementDesignator.Optional },
				new E_0205 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0102 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0319 { ReqDes = RequirementDesignator.Optional },
				new E_0219 { ReqDes = RequirementDesignator.Optional },
				new E_0567 { ReqDes = RequirementDesignator.Optional },
				new E_0571 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0761 { ReqDes = RequirementDesignator.Optional },
				new E_0056 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0024 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N7A : MapSegment
	{
		public N7A()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1042 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_1043 { ReqDes = RequirementDesignator.Optional },
				new E_1044 { ReqDes = RequirementDesignator.Optional },
				new E_1043 { ReqDes = RequirementDesignator.Optional },
				new E_1043 { ReqDes = RequirementDesignator.Optional },
				new E_1045 { ReqDes = RequirementDesignator.Optional },
				new E_1046 { ReqDes = RequirementDesignator.Optional },
				new E_1047 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N7B : MapSegment
	{
		public N7B()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1024 { ReqDes = RequirementDesignator.Optional },
				new E_1025 { ReqDes = RequirementDesignator.Optional },
				new E_1026 { ReqDes = RequirementDesignator.Optional },
				new E_1030 { ReqDes = RequirementDesignator.Optional },
				new E_1031 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N8 : MapSegment
	{
		public N8()
		{
			SyntaxNotes.AddRange(new[] { "P030405", "P0607", "P0809", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0186 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0231 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0186 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0573 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N8A : MapSegment
	{
		public N8A()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1378 { ReqDes = RequirementDesignator.Optional },
				new E_0186 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0573 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class N9 : MapSegment
	{
		public N9()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "C0605", "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new C040 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class NA : MapSegment
	{
		public NA()
		{
			SyntaxNotes.AddRange(new[] { "C0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0231 { ReqDes = RequirementDesignator.Optional },
				new E_0219 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0567 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0845 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class NCA : MapSegment
	{
		public NCA()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0887 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class NCD : MapSegment
	{
		public NCD()
		{
			SyntaxNotes.AddRange(new[] { "R0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0936 { ReqDes = RequirementDesignator.Optional },
				new E_0888 { ReqDes = RequirementDesignator.Optional },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0750 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class NM1 : MapSegment
	{
		public NM1()
		{
			SyntaxNotes.AddRange(new[] { "P0809", "C1110" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0098 { ReqDes = RequirementDesignator.Mandatory },
				new E_1065 { ReqDes = RequirementDesignator.Mandatory },
				new E_1035 { ReqDes = RequirementDesignator.Optional },
				new E_1036 { ReqDes = RequirementDesignator.Optional },
				new E_1037 { ReqDes = RequirementDesignator.Optional },
				new E_1038 { ReqDes = RequirementDesignator.Optional },
				new E_1039 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0706 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class NTE : MapSegment
	{
		public NTE()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0363 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class NX1 : MapSegment
	{
		public NX1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0098 { ReqDes = RequirementDesignator.Mandatory },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class NX2 : MapSegment
	{
		public NX2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1106 { ReqDes = RequirementDesignator.Mandatory },
				new E_0166 { ReqDes = RequirementDesignator.Mandatory },
				new E_1096 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class OBI : MapSegment
	{
		public OBI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0811 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class OD : MapSegment
	{
		public OD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class OI : MapSegment
	{
		public OI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1032 { ReqDes = RequirementDesignator.Optional },
				new E_1383 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1351 { ReqDes = RequirementDesignator.Optional },
				new E_1360 { ReqDes = RequirementDesignator.Optional },
				new E_1363 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class OID : MapSegment
	{
		public OID()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "C0302", "P0405", "P0607", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class OPS : MapSegment
	{
		public OPS()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0520" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1132 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class OPX : MapSegment
	{
		public OPX()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1135 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class OQS : MapSegment
	{
		public OQS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1041 { ReqDes = RequirementDesignator.Mandatory },
				new E_0330 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class OTI : MapSegment
	{
		public OTI()
		{
			SyntaxNotes.AddRange(new[] { "C0908" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0110 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0142 { ReqDes = RequirementDesignator.Optional },
				new E_0124 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0028 { ReqDes = RequirementDesignator.Optional },
				new E_0329 { ReqDes = RequirementDesignator.Optional },
				new E_0143 { ReqDes = RequirementDesignator.Optional },
				new E_0480 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0346 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0305 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class P1 : MapSegment
	{
		public P1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0108 { ReqDes = RequirementDesignator.Optional },
				new E_0109 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Mandatory },
				new E_0111 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0021 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class P2 : MapSegment
	{
		public P2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0108 { ReqDes = RequirementDesignator.Optional },
				new E_0032 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class P4 : MapSegment
	{
		public P4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0310 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class P5 : MapSegment
	{
		public P5()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0115 { ReqDes = RequirementDesignator.Mandatory },
				new E_0309 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class PAD : MapSegment
	{
		public PAD()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0521 { ReqDes = RequirementDesignator.Optional },
				new E_0670 { ReqDes = RequirementDesignator.Optional },
				new E_0648 { ReqDes = RequirementDesignator.Optional },
				new E_0649 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PAI : MapSegment
	{
		public PAI()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PAL : MapSegment
	{
		public PAL()
		{
			SyntaxNotes.AddRange(new[] { "P0506", "C0710", "C0810", "C0910", "L10070809", "P1112", "P1314" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0883 { ReqDes = RequirementDesignator.Optional },
				new E_0884 { ReqDes = RequirementDesignator.Optional },
				new E_0885 { ReqDes = RequirementDesignator.Optional },
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0395 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0384 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0385 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0399 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PAM : MapSegment
	{
		public PAM()
		{
			SyntaxNotes.AddRange(new[] { "P010203", "R021928", "P1819", "C2120", "P2021", "L212223", "C2221", "C2321", "L242526", "C2524", "P2728" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_1004 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PAS : MapSegment
	{
		public PAS()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1077 { ReqDes = RequirementDesignator.Mandatory },
				new E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1090 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PAT : MapSegment
	{
		public PAT()
		{
			SyntaxNotes.AddRange(new[] { "P0506", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1069 { ReqDes = RequirementDesignator.Optional },
				new E_1384 { ReqDes = RequirementDesignator.Optional },
				new E_0584 { ReqDes = RequirementDesignator.Optional },
				new E_1220 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PAY : MapSegment
	{
		public PAY()
		{
			SyntaxNotes.AddRange(new[] { "P0722", "P2338" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1374 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1087 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1092 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PBI : MapSegment
	{
		public PBI()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "E0506", "E0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_0817 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0449 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0449 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PCL : MapSegment
	{
		public PCL()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0304", "C0605", "R0107" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1126 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PCR : MapSegment
	{
		public PCR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0959 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class PCS : MapSegment
	{
		public PCS()
		{
			SyntaxNotes.AddRange(new[] { "R0104", "C0204", "C0302", "C0709", "C0807" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1029 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1172 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0889 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1225 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0553 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PCT : MapSegment
	{
		public PCT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1004 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class PD : MapSegment
	{
		public PD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0344 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1196 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1401 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PDD : MapSegment
	{
		public PDD()
		{
			SyntaxNotes.AddRange(new[] { "R020304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1401 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PDE : MapSegment
	{
		public PDE()
		{
			SyntaxNotes.AddRange(new[] { "P0318" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_1280 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PDL : MapSegment
	{
		public PDL()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "E0304", "P0708", "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0591 { ReqDes = RequirementDesignator.Mandatory },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0478 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Optional },
				new E_0507 { ReqDes = RequirementDesignator.Optional },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PDP : MapSegment
	{
		public PDP()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1188 { ReqDes = RequirementDesignator.Mandatory },
				new E_0023 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PDR : MapSegment
	{
		public PDR()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1074 { ReqDes = RequirementDesignator.Mandatory },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0689 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PDS : MapSegment
	{
		public PDS()
		{
			SyntaxNotes.AddRange(new[] { "P0506", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1496 { ReqDes = RequirementDesignator.Mandatory },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new C040 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PEN : MapSegment
	{
		public PEN()
		{
			SyntaxNotes.AddRange(new[] { "R0204" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0640 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1224 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1296 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1262 { ReqDes = RequirementDesignator.Optional },
				new E_0875 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PER : MapSegment
	{
		public PER()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0366 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0365 { ReqDes = RequirementDesignator.Optional },
				new E_0364 { ReqDes = RequirementDesignator.Optional },
				new E_0365 { ReqDes = RequirementDesignator.Optional },
				new E_0364 { ReqDes = RequirementDesignator.Optional },
				new E_0365 { ReqDes = RequirementDesignator.Optional },
				new E_0364 { ReqDes = RequirementDesignator.Optional },
				new E_0443 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PEX : MapSegment
	{
		public PEX()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1071 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0963 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0441 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PI : MapSegment
	{
		public PI()
		{
			SyntaxNotes.AddRange(new[] { "C1412", "C1513" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0436 { ReqDes = RequirementDesignator.Optional },
				new E_0930 { ReqDes = RequirementDesignator.Optional },
				new E_0168 { ReqDes = RequirementDesignator.Optional },
				new E_0965 { ReqDes = RequirementDesignator.Optional },
				new E_0660 { ReqDes = RequirementDesignator.Optional },
				new E_0169 { ReqDes = RequirementDesignator.Optional },
				new E_0173 { ReqDes = RequirementDesignator.Optional },
				new E_0172 { ReqDes = RequirementDesignator.Optional },
				new E_0660 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0629 { ReqDes = RequirementDesignator.Optional },
				new E_0629 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PID : MapSegment
	{
		public PID()
		{
			SyntaxNotes.AddRange(new[] { "C0403", "R0405", "C0703", "C0804", "C0905" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0349 { ReqDes = RequirementDesignator.Mandatory },
				new E_0750 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0752 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0819 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PIN : MapSegment
	{
		public PIN()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PKD : MapSegment
	{
		public PKD()
		{
			SyntaxNotes.AddRange(new[] { "C0201", "C0302" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0103 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0754 { ReqDes = RequirementDesignator.Optional },
				new E_0102 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PKG : MapSegment
	{
		public PKG()
		{
			SyntaxNotes.AddRange(new[] { "C0403", "R040506", "C0501" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0349 { ReqDes = RequirementDesignator.Optional },
				new E_0753 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0754 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0400 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PKL : MapSegment
	{
		public PKL()
		{
			SyntaxNotes.AddRange(new[] { "C0508", "C0608", "C0708", "L08050607", "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0677 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0384 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0385 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PL : MapSegment
	{
		public PL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
				new E_1311 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PLA : MapSegment
	{
		public PLA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0098 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_1203 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PLB : MapSegment
	{
		public PLB()
		{
			SyntaxNotes.AddRange(new[] { "P0608", "P0911", "P1214", "P1517", "P1820" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new C042 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new C042 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new C042 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new C042 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new C042 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new C042 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PLC : MapSegment
	{
		public PLC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PLD : MapSegment
	{
		public PLD()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0406 { ReqDes = RequirementDesignator.Mandatory },
				new E_0399 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PLI : MapSegment
	{
		public PLI()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1262 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0953 { ReqDes = RequirementDesignator.Mandatory },
				new E_1131 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1086 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PM : MapSegment
	{
		public PM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0507 { ReqDes = RequirementDesignator.Mandatory },
				new E_0508 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PO1 : MapSegment
	{
		public PO1()
		{
			SyntaxNotes.AddRange(new[] { "C0302", "C0504", "P0607", "P0809", "P1011", "P1213", "P1415", "P1617", "P1819", "P2021", "P2223", "P2425" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0330 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0639 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PO3 : MapSegment
	{
		public PO3()
		{
			SyntaxNotes.AddRange(new[] { "L040305" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0371 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0639 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PO4 : MapSegment
	{
		public PO4()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "C0506", "P0607", "P0809", "C1013", "C1113", "C1213", "L13101112", "C1716", "C1804" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0357 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0103 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0384 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0385 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0810 { ReqDes = RequirementDesignator.Optional },
				new E_0752 { ReqDes = RequirementDesignator.Optional },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class POC : MapSegment
	{
		public POC()
		{
			SyntaxNotes.AddRange(new[] { "C030405", "C2120", "P2223", "P2425", "P2627", "P2829", "P3031", "P3233", "P3435", "P3637", "P3839", "P4041" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0670 { ReqDes = RequirementDesignator.Mandatory },
				new E_0330 { ReqDes = RequirementDesignator.Optional },
				new E_0671 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0639 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class POD : MapSegment
	{
		public POD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class PPA : MapSegment
	{
		public PPA()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0309 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Mandatory },
				new E_1654 { ReqDes = RequirementDesignator.Optional },
				new E_1280 { ReqDes = RequirementDesignator.Optional },
				new E_1655 { ReqDes = RequirementDesignator.Optional },
				new E_1280 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PPD : MapSegment
	{
		public PPD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0012 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0263 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PPL : MapSegment
	{
		public PPL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1309 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1401 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PPY : MapSegment
	{
		public PPY()
		{
			SyntaxNotes.AddRange(new[] { "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1188 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PR : MapSegment
	{
		public PR()
		{
			SyntaxNotes.AddRange(new[] { "C0302", "C040203", "P060708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0699 { ReqDes = RequirementDesignator.Mandatory },
				new E_0023 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0259 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0697 { ReqDes = RequirementDesignator.Optional },
				new E_0690 { ReqDes = RequirementDesignator.Optional },
				new E_0260 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PR1 : MapSegment
	{
		public PR1()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "R0507", "C060504", "P0910", "R1012", "C111009" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0023 { ReqDes = RequirementDesignator.Mandatory },
				new E_0022 { ReqDes = RequirementDesignator.Mandatory },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PR2 : MapSegment
	{
		public PR2()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0001 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0692 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRC : MapSegment
	{
		public PRC()
		{
			SyntaxNotes.AddRange(new[] { "R04050608", "P0708", "P101112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0374 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_0953 { ReqDes = RequirementDesignator.Optional },
				new E_0953 { ReqDes = RequirementDesignator.Optional },
				new E_0953 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRD : MapSegment
	{
		public PRD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1085 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_1086 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRF : MapSegment
	{
		public PRF()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0324 { ReqDes = RequirementDesignator.Mandatory },
				new E_0328 { ReqDes = RequirementDesignator.Optional },
				new E_0327 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new E_0092 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRI : MapSegment
	{
		public PRI()
		{
			SyntaxNotes.AddRange(new[] { "P0809", "P101112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0436 { ReqDes = RequirementDesignator.Mandatory },
				new E_0168 { ReqDes = RequirementDesignator.Mandatory },
				new E_0171 { ReqDes = RequirementDesignator.Mandatory },
				new E_0493 { ReqDes = RequirementDesignator.Optional },
				new E_0173 { ReqDes = RequirementDesignator.Optional },
				new E_0172 { ReqDes = RequirementDesignator.Optional },
				new E_0169 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0697 { ReqDes = RequirementDesignator.Optional },
				new E_0690 { ReqDes = RequirementDesignator.Optional },
				new E_0691 { ReqDes = RequirementDesignator.Optional },
				new E_0260 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRJ : MapSegment
	{
		public PRJ()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRM : MapSegment
	{
		public PRM()
		{
			SyntaxNotes.AddRange(new[] { "C090708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0301 { ReqDes = RequirementDesignator.Optional },
				new E_0322 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_1494 { ReqDes = RequirementDesignator.Optional },
				new E_1490 { ReqDes = RequirementDesignator.Optional },
				new E_0177 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRR : MapSegment
	{
		public PRR()
		{
			SyntaxNotes.AddRange(new[] { "C0204", "C0302", "R0405", "C0608", "C0706", "C0911", "C1009" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1229 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1233 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRS : MapSegment
	{
		public PRS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0682 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRT : MapSegment
	{
		public PRT()
		{
			SyntaxNotes.AddRange(new[] { "C0302" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1225 { ReqDes = RequirementDesignator.Mandatory },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PRV : MapSegment
	{
		public PRV()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1221 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new C035 { ReqDes = RequirementDesignator.Optional },
				new E_1223 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PS : MapSegment
	{
		public PS()
		{
			SyntaxNotes.AddRange(new[] { "L030414", "C0403", "C1403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0746 { ReqDes = RequirementDesignator.Mandatory },
				new E_0241 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0573 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0745 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PS1 : MapSegment
	{
		public PS1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PSA : MapSegment
	{
		public PSA()
		{
			SyntaxNotes.AddRange(new[] { "C0504" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0826 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PSC : MapSegment
	{
		public PSC()
		{
			SyntaxNotes.AddRange(new[] { "P0722", "L26414243", "C4126", "C4226", "C4326", "L442224", "C4441", "C4648", "C4746" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0846 { ReqDes = RequirementDesignator.Mandatory },
				new E_1230 { ReqDes = RequirementDesignator.Mandatory },
				new E_1230 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0367 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1231 { ReqDes = RequirementDesignator.Optional },
				new E_0560 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1079 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PSD : MapSegment
	{
		public PSD()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "E0323" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0939 { ReqDes = RequirementDesignator.Optional },
				new E_0940 { ReqDes = RequirementDesignator.Optional },
				new E_0942 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0943 { ReqDes = RequirementDesignator.Optional },
				new E_0944 { ReqDes = RequirementDesignator.Optional },
				new E_0945 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1167 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PT : MapSegment
	{
		public PT()
		{
			SyntaxNotes.AddRange(new[] { "E0702", "P0405", "C0502", "P070809", "C10070809", "C1102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0495 { ReqDes = RequirementDesignator.Mandatory },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0459 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0259 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0697 { ReqDes = RequirementDesignator.Optional },
				new E_0690 { ReqDes = RequirementDesignator.Optional },
				new E_0260 { ReqDes = RequirementDesignator.Optional },
				new E_0706 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PTD : MapSegment
	{
		public PTD()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0521 { ReqDes = RequirementDesignator.Mandatory },
				new E_0648 { ReqDes = RequirementDesignator.Optional },
				new E_0649 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0486 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PTF : MapSegment
	{
		public PTF()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0963 { ReqDes = RequirementDesignator.Optional },
				new E_0441 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PUN : MapSegment
	{
		public PUN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PWK : MapSegment
	{
		public PWK()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0755 { ReqDes = RequirementDesignator.Mandatory },
				new E_0756 { ReqDes = RequirementDesignator.Optional },
				new E_0757 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new C002 { ReqDes = RequirementDesignator.Optional },
				new E_1525 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PYD : MapSegment
	{
		public PYD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_1685 { ReqDes = RequirementDesignator.Optional },
				new E_1688 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PYM : MapSegment
	{
		public PYM()
		{
			SyntaxNotes.AddRange(new[] { "R0106", "P0203", "C0301", "C0403", "C0503" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0263 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0615 { ReqDes = RequirementDesignator.Optional },
				new E_0650 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class PYT : MapSegment
	{
		public PYT()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "C0302", "C0504", "C0604", "C0807" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0386 { ReqDes = RequirementDesignator.Optional },
				new E_0336 { ReqDes = RequirementDesignator.Optional },
				new E_0765 { ReqDes = RequirementDesignator.Optional },
				new E_0338 { ReqDes = RequirementDesignator.Optional },
				new E_0338 { ReqDes = RequirementDesignator.Optional },
				new E_0336 { ReqDes = RequirementDesignator.Optional },
				new E_0351 { ReqDes = RequirementDesignator.Optional },
				new E_0351 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class Q2 : MapSegment
	{
		public Q2()
		{
			SyntaxNotes.AddRange(new[] { "P070816", "C1011", "P1415" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0597 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0055 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0897 { ReqDes = RequirementDesignator.Optional },
				new E_0182 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class Q3 : MapSegment
	{
		public Q3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class Q5 : MapSegment
	{
		public Q5()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "C0706", "P1112", "C1312", "P1415", "C1615" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0157 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1280 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1280 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0108 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class Q7 : MapSegment
	{
		public Q7()
		{
			SyntaxNotes.AddRange(new[] { "C0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0033 { ReqDes = RequirementDesignator.Mandatory },
				new E_0211 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class Q8 : MapSegment
	{
		public Q8()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0033 { ReqDes = RequirementDesignator.Mandatory },
				new E_0211 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0079 { ReqDes = RequirementDesignator.Optional },
				new E_0853 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class QTY : MapSegment
	{
		public QTY()
		{
			SyntaxNotes.AddRange(new[] { "R0218", "E0218" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0673 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class R1 : MapSegment
	{
		public R1()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "P0809", "P1011", "P1213" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0005 { ReqDes = RequirementDesignator.Mandatory },
				new E_0004 { ReqDes = RequirementDesignator.Mandatory },
				new E_0005 { ReqDes = RequirementDesignator.Mandatory },
				new E_0004 { ReqDes = RequirementDesignator.Optional },
				new E_0005 { ReqDes = RequirementDesignator.Optional },
				new E_0004 { ReqDes = RequirementDesignator.Optional },
				new E_0005 { ReqDes = RequirementDesignator.Optional },
				new E_0004 { ReqDes = RequirementDesignator.Optional },
				new E_0005 { ReqDes = RequirementDesignator.Optional },
				new E_0004 { ReqDes = RequirementDesignator.Optional },
				new E_0005 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class R2 : MapSegment
	{
		public R2()
		{
			SyntaxNotes.AddRange(new[] { "C0807" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0133 { ReqDes = RequirementDesignator.Mandatory },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0177 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0296 { ReqDes = RequirementDesignator.Optional },
				new E_0296 { ReqDes = RequirementDesignator.Optional },
				new E_0076 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0056 { ReqDes = RequirementDesignator.Optional },
				new E_0742 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class R2A : MapSegment
	{
		public R2A()
		{
			SyntaxNotes.AddRange(new[] { "C0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0133 { ReqDes = RequirementDesignator.Mandatory },
				new E_1431 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0056 { ReqDes = RequirementDesignator.Optional },
				new E_0001 { ReqDes = RequirementDesignator.Optional },
				new E_0742 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class R2B : MapSegment
	{
		public R2B()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0638 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class R2C : MapSegment
	{
		public R2C()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0666 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0634 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class R2D : MapSegment
	{
		public R2D()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0150 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class R3 : MapSegment
	{
		public R3()
		{
			SyntaxNotes.AddRange(new[] { "C1110", "C1211" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0133 { ReqDes = RequirementDesignator.Mandatory },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0076 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class R4 : MapSegment
	{
		public R4()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0115 { ReqDes = RequirementDesignator.Mandatory },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0114 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0174 { ReqDes = RequirementDesignator.Optional },
				new E_0113 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class R9 : MapSegment
	{
		public R9()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0192 { ReqDes = RequirementDesignator.Optional },
				new E_0177 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RA : MapSegment
	{
		public RA()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0629 { ReqDes = RequirementDesignator.Optional },
				new E_0631 { ReqDes = RequirementDesignator.Optional },
				new E_0637 { ReqDes = RequirementDesignator.Optional },
				new E_0856 { ReqDes = RequirementDesignator.Optional },
				new E_0500 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RAB : MapSegment
	{
		public RAB()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
				new E_0629 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0630 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0488 { ReqDes = RequirementDesignator.Optional },
				new E_0637 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RAP : MapSegment
	{
		public RAP()
		{
			SyntaxNotes.AddRange(new[] { "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1155 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_1413 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RAT : MapSegment
	{
		public RAT()
		{
			SyntaxNotes.AddRange(new[] { "P3752", "P5657", "C5854" });

			Content.AddRange(new MapBaseDataElement[] {
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_1089 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Mandatory },
				new E_0954 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1072 { ReqDes = RequirementDesignator.Optional },
				new E_1088 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RB : MapSegment
	{
		public RB()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0632 { ReqDes = RequirementDesignator.Mandatory },
				new E_0060 { ReqDes = RequirementDesignator.Mandatory },
				new E_0630 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0488 { ReqDes = RequirementDesignator.Optional },
				new E_0259 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class RC : MapSegment
	{
		public RC()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "C0406", "C0504", "R0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1228 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RCD : MapSegment
	{
		public RCD()
		{
			SyntaxNotes.AddRange(new[] { "R021834", "P0203", "P1819", "P343550", "P515267", "P686984", "P8586101", "P102103118" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0663 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0664 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0667 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0412 { ReqDes = RequirementDesignator.Optional },
				new E_0667 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0412 { ReqDes = RequirementDesignator.Optional },
				new E_0667 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0412 { ReqDes = RequirementDesignator.Optional },
				new E_0667 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0412 { ReqDes = RequirementDesignator.Optional },
				new E_0667 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0412 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RD : MapSegment
	{
		public RD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0632 { ReqDes = RequirementDesignator.Mandatory },
				new E_0060 { ReqDes = RequirementDesignator.Mandatory },
				new E_0259 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class RDD : MapSegment
	{
		public RDD()
		{
			SyntaxNotes.AddRange(new[] { "C0403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0638 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0638 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RDI : MapSegment
	{
		public RDI()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0098 { ReqDes = RequirementDesignator.Mandatory },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RDM : MapSegment
	{
		public RDM()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "P0809", "P1213", "P1415" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0756 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0364 { ReqDes = RequirementDesignator.Optional },
				new C040 { ReqDes = RequirementDesignator.Optional },
				new C040 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RDR : MapSegment
	{
		public RDR()
		{
			SyntaxNotes.AddRange(new[] { "E0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1292 { ReqDes = RequirementDesignator.Optional },
				new E_1293 { ReqDes = RequirementDesignator.Optional },
				new E_1294 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RDT : MapSegment
	{
		public RDT()
		{
			SyntaxNotes.AddRange(new[] { "C0102", "L030405", "C0605" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0795 { ReqDes = RequirementDesignator.Optional },
				new E_0796 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class REA : MapSegment
	{
		public REA()
		{
			SyntaxNotes.AddRange(new[] { "C0504", "P1112", "P1328" });

			Content.AddRange(new MapBaseDataElement[] {
				new C047 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1078 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1075 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1070 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class REC : MapSegment
	{
		public REC()
		{
			SyntaxNotes.AddRange(new[] { "C0602", "L08060709102627", "P0809", "C0906", "C1009", "C2627" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0689 { ReqDes = RequirementDesignator.Mandatory },
				new E_0726 { ReqDes = RequirementDesignator.Optional },
				new E_0448 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0815 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0816 { ReqDes = RequirementDesignator.Optional },
				new E_0363 { ReqDes = RequirementDesignator.Optional },
				new E_0003 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RED : MapSegment
	{
		public RED()
		{
			SyntaxNotes.AddRange(new[] { "E0206", "R0206", "P030506", "C0403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
				new E_1609 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class REF : MapSegment
	{
		public REF()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "P0607", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new C040 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class REL : MapSegment
	{
		public REL()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1069 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class REN : MapSegment
	{
		public REN()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0635 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0635 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class REP : MapSegment
	{
		public REP()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405", "C0503", "C0608", "C0706", "C1012", "C1110", "P1314", "L141516", "P1514", "C1719", "C1817" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1226 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1227 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1226 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0553 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class REQ : MapSegment
	{
		public REQ()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1397 { ReqDes = RequirementDesignator.Optional },
				new E_1398 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RET : MapSegment
	{
		public RET()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1201 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0546 { ReqDes = RequirementDesignator.Optional },
				new E_1075 { ReqDes = RequirementDesignator.Optional },
				new E_1166 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RH : MapSegment
	{
		public RH()
		{
			SyntaxNotes.AddRange(new[] { "C0302" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0375 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RIC : MapSegment
	{
		public RIC()
		{
			SyntaxNotes.AddRange(new[] { "C0504", "P0607", "C0908", "P1011", "C1312", "P1415" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0647 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0478 { ReqDes = RequirementDesignator.Mandatory },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Optional },
				new E_0507 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Optional },
				new E_0507 { ReqDes = RequirementDesignator.Optional },
				new E_0508 { ReqDes = RequirementDesignator.Optional },
				new E_0569 { ReqDes = RequirementDesignator.Optional },
				new E_0506 { ReqDes = RequirementDesignator.Optional },
				new E_0507 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RLD : MapSegment
	{
		public RLD()
		{
			SyntaxNotes.AddRange(new[] { "C0402" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1083 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RLT : MapSegment
	{
		public RLT()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P070809", "C2524" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1093 { ReqDes = RequirementDesignator.Optional },
				new E_1085 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1193 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RMR : MapSegment
	{
		public RMR()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0482 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0426 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RMT : MapSegment
	{
		public RMT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0426 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RO : MapSegment
	{
		public RO()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "C0506", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1185 { ReqDes = RequirementDesignator.Mandatory },
				new E_0611 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1187 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RP : MapSegment
	{
		public RP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0875 { ReqDes = RequirementDesignator.Mandatory },
				new E_1205 { ReqDes = RequirementDesignator.Optional },
				new E_1203 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1295 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1296 { ReqDes = RequirementDesignator.Optional },
				new E_0151 { ReqDes = RequirementDesignator.Optional },
				new E_1204 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RPA : MapSegment
	{
		public RPA()
		{
			SyntaxNotes.AddRange(new[] { "R020319" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0562 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RQS : MapSegment
	{
		public RQS()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "R0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RRA : MapSegment
	{
		public RRA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0701 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RS : MapSegment
	{
		public RS()
		{
			SyntaxNotes.AddRange(new[] { "C0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
				new E_0856 { ReqDes = RequirementDesignator.Optional },
				new E_0500 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RSC : MapSegment
	{
		public RSC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1180 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1181 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RSD : MapSegment
	{
		public RSD()
		{
			SyntaxNotes.AddRange(new[] { "P0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1069 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RST : MapSegment
	{
		public RST()
		{
			SyntaxNotes.AddRange(new[] { "E0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0281 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RT : MapSegment
	{
		public RT()
		{
			SyntaxNotes.AddRange(new[] { "P0506", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0122 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0838 { ReqDes = RequirementDesignator.Optional },
				new E_1062 { ReqDes = RequirementDesignator.Optional },
				new E_0295 { ReqDes = RequirementDesignator.Optional },
				new E_0294 { ReqDes = RequirementDesignator.Optional },
				new E_1244 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0166 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RT1 : MapSegment
	{
		public RT1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0837 { ReqDes = RequirementDesignator.Mandatory },
				new E_0060 { ReqDes = RequirementDesignator.Mandatory },
				new E_0377 { ReqDes = RequirementDesignator.Optional },
				new E_1245 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_0169 { ReqDes = RequirementDesignator.Optional },
				new E_1246 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RTE : MapSegment
	{
		public RTE()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1387 { ReqDes = RequirementDesignator.Mandatory },
				new E_0953 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RTS : MapSegment
	{
		public RTS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RTT : MapSegment
	{
		public RTT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0122 { ReqDes = RequirementDesignator.Mandatory },
				new E_0060 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class RU1 : MapSegment
	{
		public RU1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0535 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0537 { ReqDes = RequirementDesignator.Optional },
				new E_0545 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0574 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RU2 : MapSegment
	{
		public RU2()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "C05060708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0535 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0584 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RU3 : MapSegment
	{
		public RU3()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405", "P0607", "P0809", "P1011", "P1213", "P1415", "P1617", "P1819", "P2021", "P2223", "P2425", "P2627", "P2829" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
				new E_0585 { ReqDes = RequirementDesignator.Optional },
				new E_0590 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class RYL : MapSegment
	{
		public RYL()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_1035 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class S1 : MapSegment
	{
		public S1()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0165 { ReqDes = RequirementDesignator.Mandatory },
				new E_0459 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0190 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class S2 : MapSegment
	{
		public S2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0165 { ReqDes = RequirementDesignator.Mandatory },
				new E_0166 { ReqDes = RequirementDesignator.Mandatory },
				new E_0166 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class S5 : MapSegment
	{
		public S5()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0165 { ReqDes = RequirementDesignator.Mandatory },
				new E_0163 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0382 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0190 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class S9 : MapSegment
	{
		public S9()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0165 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Mandatory },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0163 { ReqDes = RequirementDesignator.Mandatory },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SA : MapSegment
	{
		public SA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0459 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SAC : MapSegment
	{
		public SAC()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "P0304", "P0607", "P0910", "C1110", "L130204", "C1413", "C1615" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0248 { ReqDes = RequirementDesignator.Mandatory },
				new E_1300 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_1301 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0378 { ReqDes = RequirementDesignator.Optional },
				new E_0332 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0331 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0770 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0819 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SAL : MapSegment
	{
		public SAL()
		{
			SyntaxNotes.AddRange(new[] { "P030405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0543 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SB : MapSegment
	{
		public SB()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0496 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class SBR : MapSegment
	{
		public SBR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1138 { ReqDes = RequirementDesignator.Mandatory },
				new E_1069 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_1336 { ReqDes = RequirementDesignator.Optional },
				new E_1143 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0584 { ReqDes = RequirementDesignator.Optional },
				new E_1032 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SBT : MapSegment
	{
		public SBT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1158 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_1159 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SC : MapSegment
	{
		public SC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0496 { ReqDes = RequirementDesignator.Mandatory },
				new E_0497 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class SCA : MapSegment
	{
		public SCA()
		{
			SyntaxNotes.AddRange(new[] { "P0102", "L030407", "C0504", "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0950 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SCD : MapSegment
	{
		public SCD()
		{
			SyntaxNotes.AddRange(new[] { "C0403", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0584 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0584 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_1068 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SCH : MapSegment
	{
		public SCH()
		{
			SyntaxNotes.AddRange(new[] { "C0304", "L080910", "C0908", "C1008" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0326 { ReqDes = RequirementDesignator.Optional },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SCL : MapSegment
	{
		public SCL()
		{
			SyntaxNotes.AddRange(new[] { "C0302", "C0504", "C0605", "C0704" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0969 { ReqDes = RequirementDesignator.Mandatory },
				new E_0119 { ReqDes = RequirementDesignator.Optional },
				new E_0119 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0970 { ReqDes = RequirementDesignator.Optional },
				new E_0972 { ReqDes = RequirementDesignator.Optional },
				new E_0972 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SCM : MapSegment
	{
		public SCM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0484 { ReqDes = RequirementDesignator.Optional },
				new E_0003 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SCN : MapSegment
	{
		public SCN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SCO : MapSegment
	{
		public SCO()
		{
			SyntaxNotes.AddRange(new[] { "P06070809", "C1804" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0023 { ReqDes = RequirementDesignator.Mandatory },
				new E_0022 { ReqDes = RequirementDesignator.Mandatory },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0567 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0233 { ReqDes = RequirementDesignator.Optional },
				new E_0203 { ReqDes = RequirementDesignator.Optional },
				new E_0241 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
				new E_1140 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_1168 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SCP : MapSegment
	{
		public SCP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0558 { ReqDes = RequirementDesignator.Mandatory },
				new E_1658 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SCS : MapSegment
	{
		public SCS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SCT : MapSegment
	{
		public SCT()
		{
			SyntaxNotes.AddRange(new[] { "P030405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1141 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1139 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SD1 : MapSegment
	{
		public SD1()
		{
			SyntaxNotes.AddRange(new[] { "L030506", "C0503", "R0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0349 { ReqDes = RequirementDesignator.Mandatory },
				new E_0821 { ReqDes = RequirementDesignator.Mandatory },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SDP : MapSegment
	{
		public SDP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0678 { ReqDes = RequirementDesignator.Mandatory },
				new E_0679 { ReqDes = RequirementDesignator.Mandatory },
				new E_0678 { ReqDes = RequirementDesignator.Optional },
				new E_0679 { ReqDes = RequirementDesignator.Optional },
				new E_0678 { ReqDes = RequirementDesignator.Optional },
				new E_0679 { ReqDes = RequirementDesignator.Optional },
				new E_0678 { ReqDes = RequirementDesignator.Optional },
				new E_0679 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SDQ : MapSegment
	{
		public SDQ()
		{
			SyntaxNotes.AddRange(new[] { "P0506", "P0708", "P0910", "P1112", "P1314", "P1516", "P1718", "P1920", "P2122" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SE : MapSegment
	{
		public SE()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0096 { ReqDes = RequirementDesignator.Mandatory },
				new E_0329 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class SER : MapSegment
	{
		public SER()
		{
			SyntaxNotes.AddRange(new[] { "R0304", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0236 { ReqDes = RequirementDesignator.Optional },
				new E_0107 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SES : MapSegment
	{
		public SES()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "P0809", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1139 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1131 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SFC : MapSegment
	{
		public SFC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1241 { ReqDes = RequirementDesignator.Mandatory },
				new E_1240 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class SG : MapSegment
	{
		public SG()
		{
			SyntaxNotes.AddRange(new[] { "R010203", "C0605" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0157 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_0035 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SHD : MapSegment
	{
		public SHD()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "C0203", "C0103", "P0405", "P0607", "C1314" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0382 { ReqDes = RequirementDesignator.Optional },
				new E_0413 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0398 { ReqDes = RequirementDesignator.Optional },
				new E_0417 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0368 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SHP : MapSegment
	{
		public SHP()
		{
			SyntaxNotes.AddRange(new[] { "C0102", "L030405", "C0403", "C0503" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SHR : MapSegment
	{
		public SHR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0152 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SI : MapSegment
	{
		public SI()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "P0607", "P0809", "P1011", "P1213", "P1415", "P1617", "P1819", "P2021" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0559 { ReqDes = RequirementDesignator.Mandatory },
				new E_1000 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1000 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SID : MapSegment
	{
		public SID()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0023 { ReqDes = RequirementDesignator.Mandatory },
				new E_0022 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0708 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SII : MapSegment
	{
		public SII()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SIN : MapSegment
	{
		public SIN()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "P040506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1201 { ReqDes = RequirementDesignator.Mandatory },
				new E_1594 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SL1 : MapSegment
	{
		public SL1()
		{
			SyntaxNotes.AddRange(new[] { "R0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0284 { ReqDes = RequirementDesignator.Mandatory },
				new E_0171 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0320 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0146 { ReqDes = RequirementDesignator.Optional },
				new E_0982 { ReqDes = RequirementDesignator.Optional },
				new E_0210 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SLI : MapSegment
	{
		public SLI()
		{
			SyntaxNotes.AddRange(new[] { "P1011", "P1213", "P2021" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1262 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0953 { ReqDes = RequirementDesignator.Mandatory },
				new E_1086 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0107 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SLN : MapSegment
	{
		public SLN()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "C2120", "C2220", "P2324", "P2526", "P2728", "P2930", "P3132", "P3334", "P3536", "P3738", "P3940", "P4142" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Mandatory },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0662 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0639 { ReqDes = RequirementDesignator.Optional },
				new E_0662 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SMA : MapSegment
	{
		public SMA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0852 { ReqDes = RequirementDesignator.Mandatory },
				new E_0166 { ReqDes = RequirementDesignator.Mandatory },
				new E_0019 { ReqDes = RequirementDesignator.Mandatory },
				new E_0156 { ReqDes = RequirementDesignator.Mandatory },
				new E_0116 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class SMB : MapSegment
	{
		public SMB()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0813 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0813 { ReqDes = RequirementDesignator.Optional },
				new E_0813 { ReqDes = RequirementDesignator.Optional },
				new E_0813 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_0638 { ReqDes = RequirementDesignator.Optional },
				new E_0813 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SMD : MapSegment
	{
		public SMD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0284 { ReqDes = RequirementDesignator.Mandatory },
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0108 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SMO : MapSegment
	{
		public SMO()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0253 { ReqDes = RequirementDesignator.Optional },
				new E_0321 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0511 { ReqDes = RequirementDesignator.Optional },
				new E_0512 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SMR : MapSegment
	{
		public SMR()
		{
			SyntaxNotes.AddRange(new[] { "R0203", "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0309 { ReqDes = RequirementDesignator.Mandatory },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SMS : MapSegment
	{
		public SMS()
		{
			SyntaxNotes.AddRange(new[] { "P0611" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0573 { ReqDes = RequirementDesignator.Mandatory },
				new E_0638 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0674 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SN1 : MapSegment
	{
		public SN1()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0382 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0646 { ReqDes = RequirementDesignator.Optional },
				new E_0330 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0728 { ReqDes = RequirementDesignator.Optional },
				new E_0668 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SOI : MapSegment
	{
		public SOI()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1186 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SOM : MapSegment
	{
		public SOM()
		{
			SyntaxNotes.AddRange(new[] { "P0506", "P0910", "P1213" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1307 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0104 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1307 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1307 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SP : MapSegment
	{
		public SP()
		{
			SyntaxNotes.AddRange(new[] { "R0103" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1257 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1133 { ReqDes = RequirementDesignator.Optional },
				new E_1134 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SPA : MapSegment
	{
		public SPA()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405", "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0546 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SPI : MapSegment
	{
		public SPI()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0786 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0790 { ReqDes = RequirementDesignator.Optional },
				new E_0791 { ReqDes = RequirementDesignator.Optional },
				new E_0792 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0755 { ReqDes = RequirementDesignator.Optional },
				new E_0786 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
				new E_1322 { ReqDes = RequirementDesignator.Optional },
				new E_1401 { ReqDes = RequirementDesignator.Optional },
				new E_1005 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SPK : MapSegment
	{
		public SPK()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1415 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SPO : MapSegment
	{
		public SPO()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0324 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0647 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SPR : MapSegment
	{
		public SPR()
		{
			SyntaxNotes.AddRange(new[] { "R02030507", "C0701" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0707 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
				new E_0708 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SPS : MapSegment
	{
		public SPS()
		{
			SyntaxNotes.AddRange(new[] { "P0520" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0609 { ReqDes = RequirementDesignator.Optional },
				new E_0949 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0942 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SPY : MapSegment
	{
		public SPY()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0999 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SR : MapSegment
	{
		public SR()
		{
			SyntaxNotes.AddRange(new[] { "C0403", "C0908" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_1430 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0003 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SRA : MapSegment
	{
		public SRA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0739 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class SRD : MapSegment
	{
		public SRD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0295 { ReqDes = RequirementDesignator.Mandatory },
				new E_0119 { ReqDes = RequirementDesignator.Mandatory },
				new E_0295 { ReqDes = RequirementDesignator.Optional },
				new E_0119 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Mandatory },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SRE : MapSegment
	{
		public SRE()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1160 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class SRM : MapSegment
	{
		public SRM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SRT : MapSegment
	{
		public SRT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0259 { ReqDes = RequirementDesignator.Mandatory },
				new E_0001 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Mandatory },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0632 { ReqDes = RequirementDesignator.Optional },
				new E_0320 { ReqDes = RequirementDesignator.Optional },
				new E_0320 { ReqDes = RequirementDesignator.Optional },
				new E_0630 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0633 { ReqDes = RequirementDesignator.Optional },
				new E_0488 { ReqDes = RequirementDesignator.Optional },
				new E_0150 { ReqDes = RequirementDesignator.Optional },
				new E_0276 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SS : MapSegment
	{
		public SS()
		{
			SyntaxNotes.AddRange(new[] { "P0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0500 { ReqDes = RequirementDesignator.Optional },
				new E_0698 { ReqDes = RequirementDesignator.Mandatory },
				new E_0695 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0616 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0437 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SSC : MapSegment
	{
		public SSC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Mandatory },
				new E_1251 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_1485 { ReqDes = RequirementDesignator.Mandatory },
				new E_0322 { ReqDes = RequirementDesignator.Mandatory },
				new E_0488 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SSD : MapSegment
	{
		public SSD()
		{
			SyntaxNotes.AddRange(new[] { "C0403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0647 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SSE : MapSegment
	{
		public SSE()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SSS : MapSegment
	{
		public SSS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0248 { ReqDes = RequirementDesignator.Mandatory },
				new E_0559 { ReqDes = RequirementDesignator.Mandatory },
				new E_0560 { ReqDes = RequirementDesignator.Mandatory },
				new E_0561 { ReqDes = RequirementDesignator.Optional },
				new E_0359 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SST : MapSegment
	{
		public SST()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_1131 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ST : MapSegment
	{
		public ST()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0143 { ReqDes = RequirementDesignator.Mandatory },
				new E_0329 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class STA : MapSegment
	{
		public STA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0950 { ReqDes = RequirementDesignator.Mandatory },
				new E_0739 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0738 { ReqDes = RequirementDesignator.Optional },
				new E_0737 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
				new E_0935 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class STC : MapSegment
	{
		public STC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new C043 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0591 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0429 { ReqDes = RequirementDesignator.Optional },
				new C043 { ReqDes = RequirementDesignator.Optional },
				new C043 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class STP : MapSegment
	{
		public STP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0790 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Mandatory },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class STS : MapSegment
	{
		public STS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0I40 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I41 { ReqDes = RequirementDesignator.Mandatory },
				new E_0I42 { ReqDes = RequirementDesignator.Mandatory },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0I43 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SUM : MapSegment
	{
		public SUM()
		{
			SyntaxNotes.AddRange(new[] { "C0401", "C0501", "C0601", "P0708", "P1314" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1141 { ReqDes = RequirementDesignator.Optional },
				new E_1142 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
				new E_1144 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1145 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0607 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1558 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SUP : MapSegment
	{
		public SUP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0749 { ReqDes = RequirementDesignator.Mandatory },
				new E_0246 { ReqDes = RequirementDesignator.Optional },
				new E_0003 { ReqDes = RequirementDesignator.Optional },
				new E_0744 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SV : MapSegment
	{
		public SV()
		{
			SyntaxNotes.AddRange(new[] { "C0201", "C0301" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0034 { ReqDes = RequirementDesignator.Optional },
				new E_0034 { ReqDes = RequirementDesignator.Optional },
				new E_0072 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SV1 : MapSegment
	{
		public SV1()
		{
			SyntaxNotes.AddRange(new[] { "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new C003 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1331 { ReqDes = RequirementDesignator.Optional },
				new E_1365 { ReqDes = RequirementDesignator.Optional },
				new C004 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1340 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1364 { ReqDes = RequirementDesignator.Optional },
				new E_1341 { ReqDes = RequirementDesignator.Optional },
				new E_1327 { ReqDes = RequirementDesignator.Optional },
				new E_1334 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0116 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1337 { ReqDes = RequirementDesignator.Optional },
				new E_1360 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SV2 : MapSegment
	{
		public SV2()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new C003 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1371 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1345 { ReqDes = RequirementDesignator.Optional },
				new E_1337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SV3 : MapSegment
	{
		public SV3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new C003 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1331 { ReqDes = RequirementDesignator.Optional },
				new C006 { ReqDes = RequirementDesignator.Optional },
				new E_1358 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1327 { ReqDes = RequirementDesignator.Optional },
				new E_1360 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new C004 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SV4 : MapSegment
	{
		public SV4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new C003 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1329 { ReqDes = RequirementDesignator.Optional },
				new E_1338 { ReqDes = RequirementDesignator.Optional },
				new E_1356 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1370 { ReqDes = RequirementDesignator.Optional },
				new E_1319 { ReqDes = RequirementDesignator.Optional },
				new E_1320 { ReqDes = RequirementDesignator.Optional },
				new E_1330 { ReqDes = RequirementDesignator.Optional },
				new E_1327 { ReqDes = RequirementDesignator.Optional },
				new E_1384 { ReqDes = RequirementDesignator.Optional },
				new E_1337 { ReqDes = RequirementDesignator.Optional },
				new E_1357 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SV5 : MapSegment
	{
		public SV5()
		{
			SyntaxNotes.AddRange(new[] { "R1011", "C1210" });

			Content.AddRange(new MapBaseDataElement[] {
				new C003 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0594 { ReqDes = RequirementDesignator.Optional },
				new E_0923 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SV6 : MapSegment
	{
		public SV6()
		{
			SyntaxNotes.AddRange(new[] { "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new C003 { ReqDes = RequirementDesignator.Mandatory },
				new E_1332 { ReqDes = RequirementDesignator.Optional },
				new E_1331 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new C004 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SV7 : MapSegment
	{
		public SV7()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1355 { ReqDes = RequirementDesignator.Optional },
				new E_1207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0750 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SVC : MapSegment
	{
		public SVC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new C003 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C003 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SVD : MapSegment
	{
		public SVD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new C003 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class SW : MapSegment
	{
		public SW()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0257 { ReqDes = RequirementDesignator.Mandatory },
				new E_0495 { ReqDes = RequirementDesignator.Mandatory },
				new E_0498 { ReqDes = RequirementDesignator.Mandatory },
				new E_0499 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0638 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class T1 : MapSegment
	{
		public T1()
		{
			SyntaxNotes.AddRange(new[] { "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0186 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0229 { ReqDes = RequirementDesignator.Optional },
				new E_0461 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class T2 : MapSegment
	{
		public T2()
		{
			SyntaxNotes.AddRange(new[] { "P0506", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0079 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0462 { ReqDes = RequirementDesignator.Optional },
				new E_0463 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class T3 : MapSegment
	{
		public T3()
		{
			SyntaxNotes.AddRange(new[] { "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0133 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class T6 : MapSegment
	{
		public T6()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0060 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class T8 : MapSegment
	{
		public T8()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0299 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class TAX : MapSegment
	{
		public TAX()
		{
			SyntaxNotes.AddRange(new[] { "R0103", "P0203", "P0405", "P0607", "P0809", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0325 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0441 { ReqDes = RequirementDesignator.Optional },
				new E_1179 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TBA : MapSegment
	{
		public TBA()
		{
			SyntaxNotes.AddRange(new[] { "P0116" });

			Content.AddRange(new MapBaseDataElement[] {
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TBI : MapSegment
	{
		public TBI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TC2 : MapSegment
	{
		public TC2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0023 { ReqDes = RequirementDesignator.Mandatory },
				new E_0022 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class TCD : MapSegment
	{
		public TCD()
		{
			SyntaxNotes.AddRange(new[] { "P0405", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new E_0739 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0662 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TD1 : MapSegment
	{
		public TD1()
		{
			SyntaxNotes.AddRange(new[] { "C0102", "C0304", "C0607", "P0708", "P0910" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0103 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0023 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0079 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TD3 : MapSegment
	{
		public TD3()
		{
			SyntaxNotes.AddRange(new[] { "E0110", "C0203", "C0405", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0102 { ReqDes = RequirementDesignator.Optional },
				new E_0407 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0024 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TD4 : MapSegment
	{
		public TD4()
		{
			SyntaxNotes.AddRange(new[] { "R010204", "C0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0208 { ReqDes = RequirementDesignator.Optional },
				new E_0209 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TD5 : MapSegment
	{
		public TD5()
		{
			SyntaxNotes.AddRange(new[] { "R0204050612", "C0203", "C0708", "C1011", "C1312", "C1413", "C1512" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0133 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0387 { ReqDes = RequirementDesignator.Optional },
				new E_0368 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0731 { ReqDes = RequirementDesignator.Optional },
				new E_0732 { ReqDes = RequirementDesignator.Optional },
				new E_0733 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0284 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TDS : MapSegment
	{
		public TDS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0610 { ReqDes = RequirementDesignator.Mandatory },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TED : MapSegment
	{
		public TED()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0647 { ReqDes = RequirementDesignator.Mandatory },
				new E_0003 { ReqDes = RequirementDesignator.Optional },
				new E_0721 { ReqDes = RequirementDesignator.Optional },
				new E_0719 { ReqDes = RequirementDesignator.Optional },
				new E_0722 { ReqDes = RequirementDesignator.Optional },
				new E_0725 { ReqDes = RequirementDesignator.Optional },
				new E_0724 { ReqDes = RequirementDesignator.Optional },
				new E_0961 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TEM : MapSegment
	{
		public TEM()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TER : MapSegment
	{
		public TER()
		{
			SyntaxNotes.AddRange(new[] { "R020304", "E020304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0687 { ReqDes = RequirementDesignator.Mandatory },
				new E_1632 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TF : MapSegment
	{
		public TF()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0168 { ReqDes = RequirementDesignator.Mandatory },
				new E_0171 { ReqDes = RequirementDesignator.Mandatory },
				new E_0493 { ReqDes = RequirementDesignator.Optional },
				new E_0173 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TFA : MapSegment
	{
		public TFA()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0122 { ReqDes = RequirementDesignator.Mandatory },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
				new E_0971 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TFD : MapSegment
	{
		public TFD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0122 { ReqDes = RequirementDesignator.Mandatory },
				new E_0971 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class TFM : MapSegment
	{
		public TFM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0060 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class TFR : MapSegment
	{
		public TFR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0976 { ReqDes = RequirementDesignator.Mandatory },
				new E_0975 { ReqDes = RequirementDesignator.Optional },
				new E_0977 { ReqDes = RequirementDesignator.Optional },
				new E_0977 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TFS : MapSegment
	{
		public TFS()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0818 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class THE : MapSegment
	{
		public THE()
		{
			SyntaxNotes.AddRange(new[] { "R0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TI : MapSegment
	{
		public TI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0407 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TIA : MapSegment
	{
		public TIA()
		{
			SyntaxNotes.AddRange(new[] { "R0304052122", "C0605", "E2122" });

			Content.AddRange(new MapBaseDataElement[] {
				new C037 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0449 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TID : MapSegment
	{
		public TID()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1173 { ReqDes = RequirementDesignator.Mandatory },
				new E_1174 { ReqDes = RequirementDesignator.Optional },
				new E_1175 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1297 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1178 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TIS : MapSegment
	{
		public TIS()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1420 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TLN : MapSegment
	{
		public TLN()
		{
			SyntaxNotes.AddRange(new[] { "P1213", "P1617" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0508 { ReqDes = RequirementDesignator.Mandatory },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1187 { ReqDes = RequirementDesignator.Optional },
				new E_1187 { ReqDes = RequirementDesignator.Optional },
				new E_1189 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1262 { ReqDes = RequirementDesignator.Optional },
				new E_0263 { ReqDes = RequirementDesignator.Optional },
				new E_0650 { ReqDes = RequirementDesignator.Optional },
				new E_0261 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0263 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0263 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TMD : MapSegment
	{
		public TMD()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "C0902" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0750 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_0937 { ReqDes = RequirementDesignator.Optional },
				new E_0938 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TOA : MapSegment
	{
		public TOA()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1591 { ReqDes = RequirementDesignator.Mandatory },
				new E_1553 { ReqDes = RequirementDesignator.Optional },
				new E_0546 { ReqDes = RequirementDesignator.Optional },
				new E_1592 { ReqDes = RequirementDesignator.Optional },
				new E_1592 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TOO : MapSegment
	{
		public TOO()
		{
			SyntaxNotes.AddRange(new[] { "P0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new C005 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TOV : MapSegment
	{
		public TOV()
		{
			SyntaxNotes.AddRange(new[] { "P020304", "P0506" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1599 { ReqDes = RequirementDesignator.Mandatory },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TPB : MapSegment
	{
		public TPB()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "C0301", "C0403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1634 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TPD : MapSegment
	{
		public TPD()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0349 { ReqDes = RequirementDesignator.Mandatory },
				new E_0023 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TRF : MapSegment
	{
		public TRF()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0673 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class TRN : MapSegment
	{
		public TRN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0481 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0509 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TRS : MapSegment
	{
		public TRS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0369 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1499 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TS : MapSegment
	{
		public TS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0978 { ReqDes = RequirementDesignator.Optional },
				new E_0169 { ReqDes = RequirementDesignator.Optional },
				new E_0973 { ReqDes = RequirementDesignator.Optional },
				new E_0980 { ReqDes = RequirementDesignator.Optional },
				new E_0122 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TS2 : MapSegment
	{
		public TS2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TS3 : MapSegment
	{
		public TS3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_1331 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TSD : MapSegment
	{
		public TSD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0219 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TSI : MapSegment
	{
		public TSI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1554 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TSP : MapSegment
	{
		public TSP()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1312 { ReqDes = RequirementDesignator.Mandatory },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_1313 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TST : MapSegment
	{
		public TST()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1155 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1131 { ReqDes = RequirementDesignator.Optional },
				new E_1131 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1156 { ReqDes = RequirementDesignator.Optional },
				new E_1157 { ReqDes = RequirementDesignator.Optional },
				new E_0819 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TSU : MapSegment
	{
		public TSU()
		{
			SyntaxNotes.AddRange(new[] { "C0807" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1270 { ReqDes = RequirementDesignator.Mandatory },
				new E_1271 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TT : MapSegment
	{
		public TT()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Mandatory },
				new E_0449 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class TUD : MapSegment
	{
		public TUD()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0705 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TXI : MapSegment
	{
		public TXI()
		{
			SyntaxNotes.AddRange(new[] { "R020306", "P0405", "C0803" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0963 { ReqDes = RequirementDesignator.Mandatory },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0955 { ReqDes = RequirementDesignator.Optional },
				new E_0956 { ReqDes = RequirementDesignator.Optional },
				new E_0441 { ReqDes = RequirementDesignator.Optional },
				new E_0662 { ReqDes = RequirementDesignator.Optional },
				new E_0828 { ReqDes = RequirementDesignator.Optional },
				new E_0325 { ReqDes = RequirementDesignator.Optional },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TXN : MapSegment
	{
		public TXN()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0455 { ReqDes = RequirementDesignator.Mandatory },
				new E_0143 { ReqDes = RequirementDesignator.Mandatory },
				new E_0480 { ReqDes = RequirementDesignator.Mandatory },
				new E_0306 { ReqDes = RequirementDesignator.Mandatory },
				new E_0124 { ReqDes = RequirementDesignator.Optional },
				new E_0142 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class TXP : MapSegment
	{
		public TXP()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0325 { ReqDes = RequirementDesignator.Mandatory },
				new E_1049 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0817 { ReqDes = RequirementDesignator.Mandatory },
				new E_1051 { ReqDes = RequirementDesignator.Mandatory },
				new E_0817 { ReqDes = RequirementDesignator.Optional },
				new E_1051 { ReqDes = RequirementDesignator.Optional },
				new E_0817 { ReqDes = RequirementDesignator.Optional },
				new E_1051 { ReqDes = RequirementDesignator.Optional },
				new E_1050 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class UC : MapSegment
	{
		public UC()
		{
			SyntaxNotes.AddRange(new[] { "C0403" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class UCS : MapSegment
	{
		public UCS()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0349 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class UD : MapSegment
	{
		public UD()
		{
			SyntaxNotes.AddRange(new[] { "L101112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0546 { ReqDes = RequirementDesignator.Mandatory },
				new E_0546 { ReqDes = RequirementDesignator.Optional },
				new E_1209 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_1123 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
				new E_1123 { ReqDes = RequirementDesignator.Optional },
				new E_0554 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class UDA : MapSegment
	{
		public UDA()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "C050304", "C060304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1123 { ReqDes = RequirementDesignator.Mandatory },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0673 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class UIT : MapSegment
	{
		public UIT()
		{
			SyntaxNotes.AddRange(new[] { "C1716" });

			Content.AddRange(new MapBaseDataElement[] {
				new C001 { ReqDes = RequirementDesignator.Mandatory },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_0639 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class UM : MapSegment
	{
		public UM()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1525 { ReqDes = RequirementDesignator.Mandatory },
				new E_1322 { ReqDes = RequirementDesignator.Optional },
				new E_1365 { ReqDes = RequirementDesignator.Optional },
				new C023 { ReqDes = RequirementDesignator.Optional },
				new C024 { ReqDes = RequirementDesignator.Optional },
				new E_1338 { ReqDes = RequirementDesignator.Optional },
				new E_1213 { ReqDes = RequirementDesignator.Optional },
				new E_0923 { ReqDes = RequirementDesignator.Optional },
				new E_1363 { ReqDes = RequirementDesignator.Optional },
				new E_1514 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class UQS : MapSegment
	{
		public UQS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class UR : MapSegment
	{
		public UR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1318 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class USD : MapSegment
	{
		public USD()
		{
			SyntaxNotes.AddRange(new[] { "E0304", "L03202122", "L042223", "P0520", "C210520", "L243940", "C3924", "C4024" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0662 { ReqDes = RequirementDesignator.Mandatory },
				new E_0350 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new C001 { ReqDes = RequirementDesignator.Optional },
				new E_0740 { ReqDes = RequirementDesignator.Optional },
				new E_0741 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class UWI : MapSegment
	{
		public UWI()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_1627 { ReqDes = RequirementDesignator.Mandatory },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0611 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class V1 : MapSegment
	{
		public V1()
		{
			SyntaxNotes.AddRange(new[] { "R0102", "C0801" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0597 { ReqDes = RequirementDesignator.Optional },
				new E_0182 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0055 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0249 { ReqDes = RequirementDesignator.Optional },
				new E_0854 { ReqDes = RequirementDesignator.Optional },
				new E_0897 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class V2 : MapSegment
	{
		public V2()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0506", "P0708", "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0093 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class V3 : MapSegment
	{
		public V3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0318 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0316 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class V4 : MapSegment
	{
		public V4()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0877 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class V5 : MapSegment
	{
		public V5()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0897 { ReqDes = RequirementDesignator.Mandatory },
				new E_0597 { ReqDes = RequirementDesignator.Mandatory },
				new E_0026 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class V9 : MapSegment
	{
		public V9()
		{
			SyntaxNotes.AddRange(new[] { "P1011", "C1304", "C1509" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0304 { ReqDes = RequirementDesignator.Mandatory },
				new E_0106 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0641 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1274 { ReqDes = RequirementDesignator.Optional },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0086 { ReqDes = RequirementDesignator.Optional },
				new E_0086 { ReqDes = RequirementDesignator.Optional },
				new E_0086 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VAD : MapSegment
	{
		public VAD()
		{
			SyntaxNotes.AddRange(new[] { "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0539 { ReqDes = RequirementDesignator.Mandatory },
				new E_0076 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0118 { ReqDes = RequirementDesignator.Optional },
				new E_0838 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0647 { ReqDes = RequirementDesignator.Optional },
				new E_0647 { ReqDes = RequirementDesignator.Optional },
				new E_0647 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VAR : MapSegment
	{
		public VAR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0608 { ReqDes = RequirementDesignator.Optional },
				new E_0608 { ReqDes = RequirementDesignator.Optional },
				new E_0608 { ReqDes = RequirementDesignator.Optional },
				new E_0608 { ReqDes = RequirementDesignator.Optional },
				new E_0608 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VAT : MapSegment
	{
		public VAT()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P060708", "C0805", "C1110" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0522 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0750 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0822 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0352 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VC : MapSegment
	{
		public VC()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0539 { ReqDes = RequirementDesignator.Mandatory },
				new E_0836 { ReqDes = RequirementDesignator.Optional },
				new E_0837 { ReqDes = RequirementDesignator.Optional },
				new E_0838 { ReqDes = RequirementDesignator.Optional },
				new E_0001 { ReqDes = RequirementDesignator.Optional },
				new E_0839 { ReqDes = RequirementDesignator.Optional },
				new E_0833 { ReqDes = RequirementDesignator.Optional },
				new E_0308 { ReqDes = RequirementDesignator.Optional },
				new E_0835 { ReqDes = RequirementDesignator.Optional },
				new E_0583 { ReqDes = RequirementDesignator.Optional },
				new E_0877 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VC1 : MapSegment
	{
		public VC1()
		{
			SyntaxNotes.AddRange(new[] { "C0605", "P1314" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0397 { ReqDes = RequirementDesignator.Optional },
				new E_0397 { ReqDes = RequirementDesignator.Optional },
				new E_1110 { ReqDes = RequirementDesignator.Optional },
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0100 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0090 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0184 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VDI : MapSegment
	{
		public VDI()
		{
			SyntaxNotes.AddRange(new[] { "C0702", "L02070809", "E0708", "C0802", "C0902", "C1110", "P1213", "C1415" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1136 { ReqDes = RequirementDesignator.Optional },
				new C046 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0954 { ReqDes = RequirementDesignator.Optional },
				new E_0782 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1470 { ReqDes = RequirementDesignator.Optional },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0344 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0649 { ReqDes = RequirementDesignator.Optional },
				new E_1072 { ReqDes = RequirementDesignator.Optional },
				new E_1085 { ReqDes = RequirementDesignator.Optional },
				new E_1085 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VEH : MapSegment
	{
		public VEH()
		{
			SyntaxNotes.AddRange(new[] { "L040507", "C0504", "C060405", "C0704" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0554 { ReqDes = RequirementDesignator.Optional },
				new E_0539 { ReqDes = RequirementDesignator.Optional },
				new E_1095 { ReqDes = RequirementDesignator.Optional },
				new E_0559 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_0751 { ReqDes = RequirementDesignator.Optional },
				new E_0082 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VID : MapSegment
	{
		public VID()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0040 { ReqDes = RequirementDesignator.Mandatory },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0567 { ReqDes = RequirementDesignator.Optional },
				new E_0065 { ReqDes = RequirementDesignator.Optional },
				new E_0189 { ReqDes = RequirementDesignator.Optional },
				new E_0024 { ReqDes = RequirementDesignator.Optional },
				new E_0322 { ReqDes = RequirementDesignator.Optional },
				new E_0056 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VR : MapSegment
	{
		public VR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0353 { ReqDes = RequirementDesignator.Mandatory },
				new E_0171 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0066 { ReqDes = RequirementDesignator.Mandatory },
				new E_0067 { ReqDes = RequirementDesignator.Mandatory },
				new E_0100 { ReqDes = RequirementDesignator.Mandatory },
				new E_0168 { ReqDes = RequirementDesignator.Optional },
				new E_0173 { ReqDes = RequirementDesignator.Optional },
				new E_0046 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class VRC : MapSegment
	{
		public VRC()
		{
			SyntaxNotes.AddRange(new[] { "P0102" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_1426 { ReqDes = RequirementDesignator.Optional },
				new E_1425 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W01 : MapSegment
	{
		public W01()
		{
			SyntaxNotes.AddRange(new[] { "R0304", "P0405", "P0607", "P1011", "P1516" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0330 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0059 { ReqDes = RequirementDesignator.Optional },
				new E_0121 { ReqDes = RequirementDesignator.Optional },
				new E_0023 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0416 { ReqDes = RequirementDesignator.Optional },
				new E_0451 { ReqDes = RequirementDesignator.Optional },
				new E_0286 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W03 : MapSegment
	{
		public W03()
		{
			SyntaxNotes.AddRange(new[] { "C0203", "P0405", "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0382 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W04 : MapSegment
	{
		public W04()
		{
			SyntaxNotes.AddRange(new[] { "R0304", "P0405", "P0607", "P1011", "P1415" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0382 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0059 { ReqDes = RequirementDesignator.Optional },
				new E_0121 { ReqDes = RequirementDesignator.Optional },
				new E_0023 { ReqDes = RequirementDesignator.Optional },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0416 { ReqDes = RequirementDesignator.Optional },
				new E_0844 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W05 : MapSegment
	{
		public W05()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0473 { ReqDes = RequirementDesignator.Mandatory },
				new E_0285 { ReqDes = RequirementDesignator.Mandatory },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0472 { ReqDes = RequirementDesignator.Optional },
				new E_0474 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W06 : MapSegment
	{
		public W06()
		{
			SyntaxNotes.AddRange(new[] { "P0708" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0514 { ReqDes = RequirementDesignator.Mandatory },
				new E_0285 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0531 { ReqDes = RequirementDesignator.Optional },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0474 { ReqDes = RequirementDesignator.Optional },
				new E_0472 { ReqDes = RequirementDesignator.Optional },
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0891 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W07 : MapSegment
	{
		public W07()
		{
			SyntaxNotes.AddRange(new[] { "R0304", "P0405", "P0607", "P1011" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0413 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0451 { ReqDes = RequirementDesignator.Optional },
				new E_0893 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W08 : MapSegment
	{
		public W08()
		{
			SyntaxNotes.AddRange(new[] { "R0204", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0387 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0407 { ReqDes = RequirementDesignator.Optional },
				new E_0400 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W09 : MapSegment
	{
		public W09()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0040 { ReqDes = RequirementDesignator.Mandatory },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0003 { ReqDes = RequirementDesignator.Optional },
				new E_1122 { ReqDes = RequirementDesignator.Optional },
				new E_0488 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W1 : MapSegment
	{
		public W1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0042 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class W10 : MapSegment
	{
		public W10()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0400 { ReqDes = RequirementDesignator.Optional },
				new E_0406 { ReqDes = RequirementDesignator.Optional },
				new E_0399 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0225 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0408 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W12 : MapSegment
	{
		public W12()
		{
			SyntaxNotes.AddRange(new[] { "R0607", "P0708", "P101112", "P131415", "P1718", "P2122" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0368 { ReqDes = RequirementDesignator.Mandatory },
				new E_0330 { ReqDes = RequirementDesignator.Optional },
				new E_0382 { ReqDes = RequirementDesignator.Optional },
				new E_0383 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0451 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0892 { ReqDes = RequirementDesignator.Optional },
				new E_0893 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W13 : MapSegment
	{
		public W13()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0380 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0412 { ReqDes = RequirementDesignator.Mandatory },
				new E_0451 { ReqDes = RequirementDesignator.Optional },
				new E_0853 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W14 : MapSegment
	{
		public W14()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0413 { ReqDes = RequirementDesignator.Mandatory },
				new E_0382 { ReqDes = RequirementDesignator.Optional },
				new E_0452 { ReqDes = RequirementDesignator.Optional },
				new E_0414 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W15 : MapSegment
	{
		public W15()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0031 { ReqDes = RequirementDesignator.Optional },
				new E_0031 { ReqDes = RequirementDesignator.Optional },
				new E_0353 { ReqDes = RequirementDesignator.Optional },
				new E_0640 { ReqDes = RequirementDesignator.Optional },
				new E_0306 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W17 : MapSegment
	{
		public W17()
		{
			SyntaxNotes.AddRange(new[] { "P0607", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0514 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0394 { ReqDes = RequirementDesignator.Mandatory },
				new E_0285 { ReqDes = RequirementDesignator.Optional },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0176 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0474 { ReqDes = RequirementDesignator.Optional },
				new E_0472 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W18 : MapSegment
	{
		public W18()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0456 { ReqDes = RequirementDesignator.Mandatory },
				new E_0408 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W19 : MapSegment
	{
		public W19()
		{
			SyntaxNotes.AddRange(new[] { "R0405", "P0506", "P0708", "C101112", "C131415", "P1718" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0181 { ReqDes = RequirementDesignator.Mandatory },
				new E_0477 { ReqDes = RequirementDesignator.Mandatory },
				new E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new E_0438 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
				new E_0451 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0529 { ReqDes = RequirementDesignator.Optional },
				new E_0235 { ReqDes = RequirementDesignator.Optional },
				new E_0234 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W2 : MapSegment
	{
		public W2()
		{
			SyntaxNotes.AddRange(new[] { "P0910", "P1112" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0022 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Mandatory },
				new E_0578 { ReqDes = RequirementDesignator.Mandatory },
				new E_0577 { ReqDes = RequirementDesignator.Optional },
				new E_0177 { ReqDes = RequirementDesignator.Optional },
				new E_0240 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0502 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0761 { ReqDes = RequirementDesignator.Optional },
				new E_0219 { ReqDes = RequirementDesignator.Optional },
				new E_0301 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W20 : MapSegment
	{
		public W20()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P040506", "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0356 { ReqDes = RequirementDesignator.Optional },
				new E_0357 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0395 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0397 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W27 : MapSegment
	{
		public W27()
		{
			SyntaxNotes.AddRange(new[] { "R0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0387 { ReqDes = RequirementDesignator.Optional },
				new E_0146 { ReqDes = RequirementDesignator.Optional },
				new E_0040 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0368 { ReqDes = RequirementDesignator.Optional },
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0890 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W28 : MapSegment
	{
		public W28()
		{
			SyntaxNotes.AddRange(new[] { "P020304", "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0604 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0187 { ReqDes = RequirementDesignator.Optional },
				new E_0188 { ReqDes = RequirementDesignator.Optional },
				new E_0466 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W3 : MapSegment
	{
		public W3()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0186 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0576 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0575 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W4 : MapSegment
	{
		public W4()
		{
			SyntaxNotes.AddRange(new[] { "R0204", "P0203", "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0576 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0573 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W5 : MapSegment
	{
		public W5()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W6 : MapSegment
	{
		public W6()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0152 { ReqDes = RequirementDesignator.Mandatory },
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0152 { ReqDes = RequirementDesignator.Optional },
				new E_0152 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W66 : MapSegment
	{
		public W66()
		{
			SyntaxNotes.AddRange(new[] { "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0146 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
				new E_0399 { ReqDes = RequirementDesignator.Optional },
				new E_0400 { ReqDes = RequirementDesignator.Optional },
				new E_0387 { ReqDes = RequirementDesignator.Optional },
				new E_0433 { ReqDes = RequirementDesignator.Optional },
				new E_0434 { ReqDes = RequirementDesignator.Optional },
				new E_0625 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class W76 : MapSegment
	{
		public W76()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405", "C0603" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0330 { ReqDes = RequirementDesignator.Mandatory },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0183 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0398 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class WGP : MapSegment
	{
		public WGP()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
				new E_0081 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class WS : MapSegment
	{
		public WS()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0678 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class X01 : MapSegment
	{
		public X01()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0309 { ReqDes = RequirementDesignator.Mandatory },
				new E_0310 { ReqDes = RequirementDesignator.Mandatory },
				new E_0897 { ReqDes = RequirementDesignator.Optional },
				new E_0597 { ReqDes = RequirementDesignator.Optional },
				new E_0182 { ReqDes = RequirementDesignator.Optional },
				new E_0055 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class X02 : MapSegment
	{
		public X02()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0598 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0598 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class X1 : MapSegment
	{
		public X1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0083 { ReqDes = RequirementDesignator.Optional },
				new E_0050 { ReqDes = RequirementDesignator.Optional },
				new E_0051 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0052 { ReqDes = RequirementDesignator.Optional },
				new E_0048 { ReqDes = RequirementDesignator.Optional },
				new E_0026 { ReqDes = RequirementDesignator.Optional },
				new E_0141 { ReqDes = RequirementDesignator.Optional },
				new E_0210 { ReqDes = RequirementDesignator.Optional },
				new E_0080 { ReqDes = RequirementDesignator.Optional },
				new E_0148 { ReqDes = RequirementDesignator.Optional },
				new E_0047 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
				new E_1306 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class X2 : MapSegment
	{
		public X2()
		{
			SyntaxNotes.AddRange(new[] { "C0504", "C0604" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0070 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0070 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class X4 : MapSegment
	{
		public X4()
		{
			SyntaxNotes.AddRange(new[] { "P0304", "P0810", "R1516", "C1706" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0598 { ReqDes = RequirementDesignator.Optional },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0581 { ReqDes = RequirementDesignator.Optional },
				new E_0601 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0035 { ReqDes = RequirementDesignator.Mandatory },
				new E_0598 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class X7 : MapSegment
	{
		public X7()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0061 { ReqDes = RequirementDesignator.Mandatory },
				new E_0061 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class XD : MapSegment
	{
		public XD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0617 { ReqDes = RequirementDesignator.Mandatory },
				new E_0619 { ReqDes = RequirementDesignator.Optional },
				new E_0620 { ReqDes = RequirementDesignator.Optional },
				new E_0621 { ReqDes = RequirementDesignator.Optional },
				new E_0621 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0322 { ReqDes = RequirementDesignator.Optional },
				new E_0901 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class XH : MapSegment
	{
		public XH()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0100 { ReqDes = RequirementDesignator.Mandatory },
				new E_0645 { ReqDes = RequirementDesignator.Optional },
				new E_0150 { ReqDes = RequirementDesignator.Optional },
				new E_0610 { ReqDes = RequirementDesignator.Optional },
				new E_0503 { ReqDes = RequirementDesignator.Optional },
				new E_0504 { ReqDes = RequirementDesignator.Optional },
				new E_0212 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class XPO : MapSegment
	{
		public XPO()
		{
			SyntaxNotes.AddRange(new[] { "P0304" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0324 { ReqDes = RequirementDesignator.Mandatory },
				new E_0324 { ReqDes = RequirementDesignator.Optional },
				new E_0066 { ReqDes = RequirementDesignator.Optional },
				new E_0067 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class XQ : MapSegment
	{
		public XQ()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0305 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Mandatory },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class Y1 : MapSegment
	{
		public Y1()
		{
			SyntaxNotes.AddRange(new[] { "P0209" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0135 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0098 { ReqDes = RequirementDesignator.Optional },
				new E_0019 { ReqDes = RequirementDesignator.Optional },
				new E_0156 { ReqDes = RequirementDesignator.Optional },
				new E_0375 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class Y2 : MapSegment
	{
		public Y2()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0095 { ReqDes = RequirementDesignator.Mandatory },
				new E_0078 { ReqDes = RequirementDesignator.Optional },
				new E_0056 { ReqDes = RequirementDesignator.Optional },
				new E_0024 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0177 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0464 { ReqDes = RequirementDesignator.Optional },
				new E_0465 { ReqDes = RequirementDesignator.Optional },
				new E_0466 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class Y3 : MapSegment
	{
		public Y3()
		{
			SyntaxNotes.AddRange(new[] { "C0908" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0013 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0112 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0337 { ReqDes = RequirementDesignator.Optional },
				new E_0091 { ReqDes = RequirementDesignator.Optional },
				new E_0375 { ReqDes = RequirementDesignator.Optional },
				new E_0623 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class Y4 : MapSegment
	{
		public Y4()
		{
			SyntaxNotes.AddRange(new[] { "P0809" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0013 { ReqDes = RequirementDesignator.Optional },
				new E_0013 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0154 { ReqDes = RequirementDesignator.Optional },
				new E_0095 { ReqDes = RequirementDesignator.Optional },
				new E_0024 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0309 { ReqDes = RequirementDesignator.Optional },
				new E_0310 { ReqDes = RequirementDesignator.Optional },
				new E_0056 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class Y5 : MapSegment
	{
		public Y5()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0013 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class Y6 : MapSegment
	{
		public Y6()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0313 { ReqDes = RequirementDesignator.Optional },
				new E_0151 { ReqDes = RequirementDesignator.Mandatory },
				new E_0275 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class Y7 : MapSegment
	{
		public Y7()
		{
			SyntaxNotes.AddRange(new[] { "P0203" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0467 { ReqDes = RequirementDesignator.Optional },
				new E_0470 { ReqDes = RequirementDesignator.Optional },
				new E_0471 { ReqDes = RequirementDesignator.Optional },
				new E_0468 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class YNQ : MapSegment
	{
		public YNQ()
		{
			SyntaxNotes.AddRange(new[] { "E010910", "P0304", "C0908" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_1321 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Mandatory },
				new E_1250 { ReqDes = RequirementDesignator.Optional },
				new E_1251 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
				new E_1270 { ReqDes = RequirementDesignator.Optional },
				new E_1271 { ReqDes = RequirementDesignator.Optional },
				new E_0933 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ZA : MapSegment
	{
		public ZA()
		{
			SyntaxNotes.AddRange(new[] { "P0203", "P0405", "P0607" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0859 { ReqDes = RequirementDesignator.Mandatory },
				new E_0380 { ReqDes = RequirementDesignator.Optional },
				new E_0355 { ReqDes = RequirementDesignator.Optional },
				new E_0374 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0128 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ZC1 : MapSegment
	{
		public ZC1()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Optional },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0244 { ReqDes = RequirementDesignator.Mandatory },
				new E_0243 { ReqDes = RequirementDesignator.Mandatory },
				new E_0202 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Mandatory },
				new E_0091 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class ZD : MapSegment
	{
		public ZD()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0143 { ReqDes = RequirementDesignator.Mandatory },
				new E_0145 { ReqDes = RequirementDesignator.Optional },
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0244 { ReqDes = RequirementDesignator.Optional },
				new E_0243 { ReqDes = RequirementDesignator.Optional },
				new E_0202 { ReqDes = RequirementDesignator.Mandatory },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ZR : MapSegment
	{
		public ZR()
		{
			Content.AddRange(new MapBaseDataElement[] {
				new E_0762 { ReqDes = RequirementDesignator.Mandatory },
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0186 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_0003 { ReqDes = RequirementDesignator.Optional },
				new E_0140 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
				new E_1127 { ReqDes = RequirementDesignator.Optional },
				new E_1127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0127 { ReqDes = RequirementDesignator.Optional },
				new E_0202 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class ZT : MapSegment
	{
		public ZT()
		{
			SyntaxNotes.AddRange(new[] { "P0405" });

			Content.AddRange(new MapBaseDataElement[] {
				new E_0214 { ReqDes = RequirementDesignator.Mandatory },
				new E_0206 { ReqDes = RequirementDesignator.Mandatory },
				new E_0207 { ReqDes = RequirementDesignator.Mandatory },
				new E_0186 { ReqDes = RequirementDesignator.Optional },
				new E_0373 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
}

