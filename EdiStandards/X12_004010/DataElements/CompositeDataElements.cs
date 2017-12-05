using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;

namespace EdiEngine.Standards.X12_004010.DataElements
{
	public class C001 : MapCompositeDataElement
	{
		public C001()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_0355 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1018 { ReqDes = RequirementDesignator.Optional },
				new     E_0649 { ReqDes = RequirementDesignator.Optional },
				new     E_0355 { ReqDes = RequirementDesignator.Optional },
				new     E_1018 { ReqDes = RequirementDesignator.Optional },
				new     E_0649 { ReqDes = RequirementDesignator.Optional },
				new     E_0355 { ReqDes = RequirementDesignator.Optional },
				new     E_1018 { ReqDes = RequirementDesignator.Optional },
				new     E_0649 { ReqDes = RequirementDesignator.Optional },
				new     E_0355 { ReqDes = RequirementDesignator.Optional },
				new     E_1018 { ReqDes = RequirementDesignator.Optional },
				new     E_0649 { ReqDes = RequirementDesignator.Optional },
				new     E_0355 { ReqDes = RequirementDesignator.Optional },
				new     E_1018 { ReqDes = RequirementDesignator.Optional },
				new     E_0649 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C002 : MapCompositeDataElement
	{
		public C002()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_0704 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0704 { ReqDes = RequirementDesignator.Optional },
				new     E_0704 { ReqDes = RequirementDesignator.Optional },
				new     E_0704 { ReqDes = RequirementDesignator.Optional },
				new     E_0704 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C003 : MapCompositeDataElement
	{
		public C003()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_0235 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0234 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1339 { ReqDes = RequirementDesignator.Optional },
				new     E_1339 { ReqDes = RequirementDesignator.Optional },
				new     E_1339 { ReqDes = RequirementDesignator.Optional },
				new     E_1339 { ReqDes = RequirementDesignator.Optional },
				new     E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C004 : MapCompositeDataElement
	{
		public C004()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1328 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1328 { ReqDes = RequirementDesignator.Optional },
				new     E_1328 { ReqDes = RequirementDesignator.Optional },
				new     E_1328 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C005 : MapCompositeDataElement
	{
		public C005()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1369 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1369 { ReqDes = RequirementDesignator.Optional },
				new     E_1369 { ReqDes = RequirementDesignator.Optional },
				new     E_1369 { ReqDes = RequirementDesignator.Optional },
				new     E_1369 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C006 : MapCompositeDataElement
	{
		public C006()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1361 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1361 { ReqDes = RequirementDesignator.Optional },
				new     E_1361 { ReqDes = RequirementDesignator.Optional },
				new     E_1361 { ReqDes = RequirementDesignator.Optional },
				new     E_1361 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C007 : MapCompositeDataElement
	{
		public C007()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_0522 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0522 { ReqDes = RequirementDesignator.Optional },
				new     E_1638 { ReqDes = RequirementDesignator.Optional },
				new     E_0935 { ReqDes = RequirementDesignator.Optional },
				new     E_0344 { ReqDes = RequirementDesignator.Optional },
				new     E_1637 { ReqDes = RequirementDesignator.Optional },
				new     E_0935 { ReqDes = RequirementDesignator.Optional },
				new     E_0352 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C022 : MapCompositeDataElement
	{
		public C022()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1270 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1271 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1250 { ReqDes = RequirementDesignator.Optional },
				new     E_1251 { ReqDes = RequirementDesignator.Optional },
				new     E_0782 { ReqDes = RequirementDesignator.Optional },
				new     E_0380 { ReqDes = RequirementDesignator.Optional },
				new     E_0799 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C023 : MapCompositeDataElement
	{
		public C023()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1331 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1332 { ReqDes = RequirementDesignator.Optional },
				new     E_1325 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C024 : MapCompositeDataElement
	{
		public C024()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1362 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1362 { ReqDes = RequirementDesignator.Optional },
				new     E_1362 { ReqDes = RequirementDesignator.Optional },
				new     E_0156 { ReqDes = RequirementDesignator.Optional },
				new     E_0026 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C030 : MapCompositeDataElement
	{
		public C030()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_0722 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1528 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C033 : MapCompositeDataElement
	{
		public C033()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1572 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1573 { ReqDes = RequirementDesignator.Mandatory },
			});
		}
	}
	public class C035 : MapCompositeDataElement
	{
		public C035()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1222 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0559 { ReqDes = RequirementDesignator.Optional },
				new     E_1073 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C036 : MapCompositeDataElement
	{
		public C036()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1395 { ReqDes = RequirementDesignator.Optional },
				new     E_0127 { ReqDes = RequirementDesignator.Optional },
				new     E_0127 { ReqDes = RequirementDesignator.Optional },
				new     E_0863 { ReqDes = RequirementDesignator.Optional },
				new     E_0864 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C037 : MapCompositeDataElement
	{
		public C037()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_0817 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0647 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C040 : MapCompositeDataElement
	{
		public C040()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_0128 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0127 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0128 { ReqDes = RequirementDesignator.Optional },
				new     E_0127 { ReqDes = RequirementDesignator.Optional },
				new     E_0128 { ReqDes = RequirementDesignator.Optional },
				new     E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C042 : MapCompositeDataElement
	{
		public C042()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_0426 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0127 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C043 : MapCompositeDataElement
	{
		public C043()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1271 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1271 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0098 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C045 : MapCompositeDataElement
	{
		public C045()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1321 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1321 { ReqDes = RequirementDesignator.Optional },
				new     E_1321 { ReqDes = RequirementDesignator.Optional },
				new     E_1321 { ReqDes = RequirementDesignator.Optional },
				new     E_1321 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C046 : MapCompositeDataElement
	{
		public C046()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_0122 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0122 { ReqDes = RequirementDesignator.Optional },
				new     E_0122 { ReqDes = RequirementDesignator.Optional },
				new     E_0122 { ReqDes = RequirementDesignator.Optional },
				new     E_0122 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C047 : MapCompositeDataElement
	{
		public C047()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1074 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1074 { ReqDes = RequirementDesignator.Optional },
				new     E_1074 { ReqDes = RequirementDesignator.Optional },
				new     E_1074 { ReqDes = RequirementDesignator.Optional },
				new     E_1074 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C048 : MapCompositeDataElement
	{
		public C048()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1082 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1680 { ReqDes = RequirementDesignator.Optional },
				new     E_1082 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
	public class C050 : MapCompositeDataElement
	{
		public C050()
		{
			Content.AddRange(new MapSimpleDataElement[] {
				new     E_1675 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1570 { ReqDes = RequirementDesignator.Mandatory },
				new     E_0799 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1565 { ReqDes = RequirementDesignator.Mandatory },
				new     E_1675 { ReqDes = RequirementDesignator.Optional },
				new     E_1570 { ReqDes = RequirementDesignator.Optional },
				new     E_0799 { ReqDes = RequirementDesignator.Optional },
				new     E_1565 { ReqDes = RequirementDesignator.Optional },
				new     E_1675 { ReqDes = RequirementDesignator.Optional },
				new     E_1570 { ReqDes = RequirementDesignator.Optional },
				new     E_0799 { ReqDes = RequirementDesignator.Optional },
				new     E_1565 { ReqDes = RequirementDesignator.Optional },
			});
		}
	}
}

