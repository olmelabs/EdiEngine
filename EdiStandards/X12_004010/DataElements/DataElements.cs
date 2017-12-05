using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;

namespace EdiEngine.Standards.X12_004010.DataElements
{
	public class E_0001 : MapSimpleDataElement
	{
		public E_0001()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 13;
		}
	}
	public class E_0002 : MapSimpleDataElement
	{
		public E_0002()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0003 : MapSimpleDataElement
	{
		public E_0003()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 60;
		}
	}
	public class E_0004 : MapSimpleDataElement
	{
		public E_0004()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_0005 : MapSimpleDataElement
	{
		public E_0005()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 5;
		}
	}
	public class E_0007 : MapSimpleDataElement
	{
		public E_0007()
		{
			DataType = DataType.AN;
			MinLength = 6;
			MaxLength = 17;
		}
	}
	public class E_0008 : MapSimpleDataElement
	{
		public E_0008()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "E","R" });
		}
	}
	public class E_0009 : MapSimpleDataElement
	{
		public E_0009()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "C1","D1","D2","D3","D4","D5","D6","E1","E2","E3","E4","E5","E6","L1","L2","L3","L4","L5","L6","L7","L8","L9","LA" });
		}
	}
	public class E_0011 : MapSimpleDataElement
	{
		public E_0011()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","J","M","P","Q","R","S","T","U","V","W","X","Y" });
		}
	}
	public class E_0012 : MapSimpleDataElement
	{
		public E_0012()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 84;
		}
	}
	public class E_0013 : MapSimpleDataElement
	{
		public E_0013()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 17;
		}
	}
	public class E_0014 : MapSimpleDataElement
	{
		public E_0014()
		{
			DataType = DataType.N0;
			MinLength = 2;
			MaxLength = 8;
		}
	}
	public class E_0016 : MapSimpleDataElement
	{
		public E_0016()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","P" });
		}
	}
	public class E_0019 : MapSimpleDataElement
	{
		public E_0019()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 30;
		}
	}
	public class E_0020 : MapSimpleDataElement
	{
		public E_0020()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 9;
		}
	}
	public class E_0021 : MapSimpleDataElement
	{
		public E_0021()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0022 : MapSimpleDataElement
	{
		public E_0022()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0023 : MapSimpleDataElement
	{
		public E_0023()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "2","3","A","B","C","D","E","F","G","H","I","J","K","L","M","N","P","Q","S","T","U","V","Z" });
		}
	}
	public class E_0024 : MapSimpleDataElement
	{
		public E_0024()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_0026 : MapSimpleDataElement
	{
		public E_0026()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0028 : MapSimpleDataElement
	{
		public E_0028()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0031 : MapSimpleDataElement
	{
		public E_0031()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 22;
		}
	}
	public class E_0032 : MapSimpleDataElement
	{
		public E_0032()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0033 : MapSimpleDataElement
	{
		public E_0033()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","D","E","O","P","W" });
		}
	}
	public class E_0034 : MapSimpleDataElement
	{
		public E_0034()
		{
			DataType = DataType.N1;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0035 : MapSimpleDataElement
	{
		public E_0035()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0039 : MapSimpleDataElement
	{
		public E_0039()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","I","S","Z" });
		}
	}
	public class E_0040 : MapSimpleDataElement
	{
		public E_0040()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "20","2B","2D","2E","2F","2G","40","4B","AC","AF","AL","AP","AT","BC","BE","BF","BG","BH","BJ","BK","BO","BR","BX","CA","CB","CC","CD","CG","CH","CI","CJ","CK","CL","CM","CN","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CZ","DD","DF","DT","DX","ET","FF","FH","FN","FP","FR","FS","FT","FX","GS","HB","HC","HO","HP","HT","HV","HY","ID","IX","LO","LS","LU","NX","OB","OT","OV","PL","PP","PT","PU","RA","RC","RD","RE","RF","RG","RI","RO","RR","RS","RT","SA","SC","SD","SK","SL","SR","SS","ST","SV","TA","TB","TC","TF","TG","TH","TI","TJ","TK","TL","TM","TN","TO","TP","TQ","TR","TT","TU","TV","TW","UA","UB","UC","UD","UE","UL","UP","VA","VE","VL","VR","VS","VT","WR","WY" });
		}
	}
	public class E_0041 : MapSimpleDataElement
	{
		public E_0041()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0042 : MapSimpleDataElement
	{
		public E_0042()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0046 : MapSimpleDataElement
	{
		public E_0046()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_0047 : MapSimpleDataElement
	{
		public E_0047()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","M" });
		}
	}
	public class E_0048 : MapSimpleDataElement
	{
		public E_0048()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4" });
		}
	}
	public class E_0050 : MapSimpleDataElement
	{
		public E_0050()
		{
			DataType = DataType.AN;
			MinLength = 6;
			MaxLength = 12;
		}
	}
	public class E_0051 : MapSimpleDataElement
	{
		public E_0051()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","P" });
		}
	}
	public class E_0052 : MapSimpleDataElement
	{
		public E_0052()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","2","3","4","5","6","7","8","9","G","V" });
		}
	}
	public class E_0054 : MapSimpleDataElement
	{
		public E_0054()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BY","FE","IM","IR","LR","PP","SE","SR","ZZ" });
		}
	}
	public class E_0055 : MapSimpleDataElement
	{
		public E_0055()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 10;
		}
	}
	public class E_0056 : MapSimpleDataElement
	{
		public E_0056()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AI","BB","CS","CY","DD","DR","HA","HH","HL","HP","MC","MD","NC","PH","PP","RD","RE","RR" });
		}
	}
	public class E_0058 : MapSimpleDataElement
	{
		public E_0058()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0059 : MapSimpleDataElement
	{
		public E_0059()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 5;
		}
	}
	public class E_0060 : MapSimpleDataElement
	{
		public E_0060()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0061 : MapSimpleDataElement
	{
		public E_0061()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0062 : MapSimpleDataElement
	{
		public E_0062()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 10;
		}
	}
	public class E_0063 : MapSimpleDataElement
	{
		public E_0063()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 24;
		}
	}
	public class E_0064 : MapSimpleDataElement
	{
		public E_0064()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 30;
		}
	}
	public class E_0065 : MapSimpleDataElement
	{
		public E_0065()
		{
			DataType = DataType.R8;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0066 : MapSimpleDataElement
	{
		public E_0066()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","31","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","50","53","54","55","56","57","58","59","6","61","62","63","64","7","71","72","73","74","75","76","77","78","8","81","82","9","90","91","92","93","94","95","96","97","98","99","A","A1","A2","A3","A4","A5","A6","AA","AB","AC","AD","AE","AL","AP","BC","BD","BE","BG","BP","BS","C","C1","C2","C5","CA","CB","CC","CD","CE","CF","CI","CL","CM","CP","CR","CS","CT","D","DG","DL","DN","DP","DS","E","EC","EH","EI","EP","EQ","ER","ES","F","FA","FB","FC","FD","FI","FJ","FN","G","GA","GC","HC","HN","I","J","K","L","LC","LD","LE","LI","LN","M3","M4","M5","M6","MA","MB","MC","MD","MI","MK","ML","MN","MP","MR","N","NA","ND","NI","NO","OC","OP","PA","PB","PC","PI","PP","PR","RA","RB","RC","RD","RE","RT","S","SA","SB","SD","SF","SI","SJ","SL","SP","ST","SV","SW","TA","TC","TZ","UC","UL","UM","UP","UR","US","WR","XV","XX","ZC","ZN","ZY","ZZ" });
		}
	}
	public class E_0067 : MapSimpleDataElement
	{
		public E_0067()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 80;
		}
	}
	public class E_0070 : MapSimpleDataElement
	{
		public E_0070()
		{
			DataType = DataType.AN;
			MinLength = 6;
			MaxLength = 30;
		}
	}
	public class E_0071 : MapSimpleDataElement
	{
		public E_0071()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0072 : MapSimpleDataElement
	{
		public E_0072()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "D","I","N" });
		}
	}
	public class E_0073 : MapSimpleDataElement
	{
		public E_0073()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","F" });
		}
	}
	public class E_0074 : MapSimpleDataElement
	{
		public E_0074()
		{
			DataType = DataType.N2;
			MinLength = 2;
			MaxLength = 12;
		}
	}
	public class E_0076 : MapSimpleDataElement
	{
		public E_0076()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 22;
		}
	}
	public class E_0077 : MapSimpleDataElement
	{
		public E_0077()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0078 : MapSimpleDataElement
	{
		public E_0078()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","R","S","W" });
		}
	}
	public class E_0079 : MapSimpleDataElement
	{
		public E_0079()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 50;
		}
	}
	public class E_0080 : MapSimpleDataElement
	{
		public E_0080()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0081 : MapSimpleDataElement
	{
		public E_0081()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0082 : MapSimpleDataElement
	{
		public E_0082()
		{
			DataType = DataType.R8;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0083 : MapSimpleDataElement
	{
		public E_0083()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","D","E","F","G","I","J","M","N","P","S","T" });
		}
	}
	public class E_0086 : MapSimpleDataElement
	{
		public E_0086()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0087 : MapSimpleDataElement
	{
		public E_0087()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 48;
		}
	}
	public class E_0088 : MapSimpleDataElement
	{
		public E_0088()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AI","CA","CP","DZ","GM","L","MC","PB","R","S","SI","SM","SR","SS","UC","UP","W","X","ZZ" });
		}
	}
	public class E_0090 : MapSimpleDataElement
	{
		public E_0090()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","E","N","X" });
		}
	}
	public class E_0091 : MapSimpleDataElement
	{
		public E_0091()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "6","7","A","AC","AE","AF","AH","AR","B","BP","BU","C","CE","D","DA","DW","E","ED","F","FA","FL","GG","GR","GS","H","HH","I","J","K","L","LA","LT","M","MB","MP","N","O","P","PA","PG","PL","PP","PR","PT","Q","R","RC","RR","S","SB","SC","SD","SE","SR","SS","ST","T","TA","TC","TT","U","VA","VE","VL","W","WP","X","Y","Y1","Y2","ZZ" });
		}
	}
	public class E_0092 : MapSimpleDataElement
	{
		public E_0092()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AB","AC","AO","BD","BE","BH","BK","BL","BQ","BY","CA","CC","CF","CN","CO","CP","CR","DR","DS","EO","FH","IN","JL","KA","KB","KC","KD","KE","KG","KI","KN","KO","KP","KQ","KR","KS","KT","LB","LS","NE","NO","NP","NS","OS","PR","RA","RC","RE","RL","RN","RO","RR","RT","RU","RW","SA","SO","SP","SS","ST","SW","TC","TM","TR","UD","UE","US","WO","ZZ" });
		}
	}
	public class E_0093 : MapSimpleDataElement
	{
		public E_0093()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 60;
		}
	}
	public class E_0095 : MapSimpleDataElement
	{
		public E_0095()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0096 : MapSimpleDataElement
	{
		public E_0096()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0097 : MapSimpleDataElement
	{
		public E_0097()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0098 : MapSimpleDataElement
	{
		public E_0098()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0100 : MapSimpleDataElement
	{
		public E_0100()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_0102 : MapSimpleDataElement
	{
		public E_0102()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "L","N","R","S","T" });
		}
	}
	public class E_0103 : MapSimpleDataElement
	{
		public E_0103()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 5;
		}
	}
	public class E_0104 : MapSimpleDataElement
	{
		public E_0104()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4" });
		}
	}
	public class E_0106 : MapSimpleDataElement
	{
		public E_0106()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 25;
		}
	}
	public class E_0107 : MapSimpleDataElement
	{
		public E_0107()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","8","A","AA","AB","AC","AD","AE","AF","AG","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y" });
		}
	}
	public class E_0108 : MapSimpleDataElement
	{
		public E_0108()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AT","BC","CA","CB","CC","CP","CR","CS","CT","DB","DT","H","IB","IR","J","LD","LL","M","O","OC","OT","P","PB","RB","RC","RD","RG","RR","S","SD","U","V" });
		}
	}
	public class E_0109 : MapSimpleDataElement
	{
		public E_0109()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0110 : MapSimpleDataElement
	{
		public E_0110()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BA","BC","BE","BP","BR","GA","GC","GE","GP","GR","IA","IC","IE","IP","IR","TA","TC","TE","TP","TR" });
		}
	}
	public class E_0111 : MapSimpleDataElement
	{
		public E_0111()
		{
			DataType = DataType.TM;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_0112 : MapSimpleDataElement
	{
		public E_0112()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 14;
		}
	}
	public class E_0113 : MapSimpleDataElement
	{
		public E_0113()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0114 : MapSimpleDataElement
	{
		public E_0114()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 24;
		}
	}
	public class E_0115 : MapSimpleDataElement
	{
		public E_0115()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","V","W","Y" });
		}
	}
	public class E_0116 : MapSimpleDataElement
	{
		public E_0116()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 15;
		}
	}
	public class E_0117 : MapSimpleDataElement
	{
		public E_0117()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0118 : MapSimpleDataElement
	{
		public E_0118()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0119 : MapSimpleDataElement
	{
		public E_0119()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0120 : MapSimpleDataElement
	{
		public E_0120()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 9;
		}
	}
	public class E_0121 : MapSimpleDataElement
	{
		public E_0121()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "A","BHR","C","CTR","DMA","DMB","DMC","E","ECR","F","H","I","L","M","N","O","Q","QUO","R","S","T","U","V","X","Y" });
		}
	}
	public class E_0122 : MapSimpleDataElement
	{
		public E_0122()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AE","AF","AV","B0","B1","BF","BL","BR","C5","CE","CF","CM","CO","CP","CS","CT","CW","DD","DE","DI","DP","DR","DS","DV","EI","ER","FA","FB","FC","FF","FI","FL","FN","FR","FT","FV","GT","HD","HM","HN","HX","HY","IA","IM","IN","KG","KL","KP","KT","LA","LB","LF","LI","LL","LP","LR","LS","LT","LV","MA","MB","MC","MD","ME","MF","MG","MH","MI","MM","MN","MO","MP","MR","MS","MT","MU","MV","MW","MX","NA","NB","ND","NE","NM","NP","NV","OP","OS","OT","P0","P1","P8","P9","PA","PB","PC","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PW","PX","PY","PZ","QY","RA","RB","RC","RL","RP","RT","S0","S1","SA","SB","SC","SD","SE","SF","SG","SH","SP","ST","SU","SY","TB","TC","TD","TN","TP","TR","VA","VH","VM","VP","VR","VS","VT","VU","VV","WK","WM","XP","YR" });
		}
	}
	public class E_0123 : MapSimpleDataElement
	{
		public E_0123()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0124 : MapSimpleDataElement
	{
		public E_0124()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 15;
		}
	}
	public class E_0127 : MapSimpleDataElement
	{
		public E_0127()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0128 : MapSimpleDataElement
	{
		public E_0128()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0129 : MapSimpleDataElement
	{
		public E_0129()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 13;
		}
	}
	public class E_0132 : MapSimpleDataElement
	{
		public E_0132()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","H","R","S","T","U" });
		}
	}
	public class E_0133 : MapSimpleDataElement
	{
		public E_0133()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","D","H","I","JD","JO","M","O","R","S","V","X","Z" });
		}
	}
	public class E_0135 : MapSimpleDataElement
	{
		public E_0135()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0136 : MapSimpleDataElement
	{
		public E_0136()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 30;
		}
	}
	public class E_0137 : MapSimpleDataElement
	{
		public E_0137()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0138 : MapSimpleDataElement
	{
		public E_0138()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 6;
		}
	}
	public class E_0139 : MapSimpleDataElement
	{
		public E_0139()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CH","DD","GA","IF","LC","MB","NC","OA","SA","SB","SD","ST","ZZ" });
		}
	}
	public class E_0140 : MapSimpleDataElement
	{
		public E_0140()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 4;
		}
	}
	public class E_0141 : MapSimpleDataElement
	{
		public E_0141()
		{
			DataType = DataType.AN;
			MinLength = 7;
			MaxLength = 10;
		}
	}
	public class E_0142 : MapSimpleDataElement
	{
		public E_0142()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 15;
		}
	}
	public class E_0143 : MapSimpleDataElement
	{
		public E_0143()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "100","101","104","105","106","107","108","109","110","111","112","113","114","115","116","120","121","124","125","126","127","128","129","130","131","135","138","139","140","141","142","143","144","146","147","148","149","150","151","152","153","154","155","157","159","160","161","163","170","175","176","180","185","186","188","189","190","191","194","195","196","197","198","199","200","201","202","203","204","205","206","207","208","210","211","212","213","214","215","216","217","218","219","220","222","223","224","225","242","244","248","249","250","251","252","255","256","260","261","262","263","264","265","266","267","268","270","271","272","273","275","276","277","278","280","285","286","288","290","300","301","302","303","304","305","306","307","308","309","310","311","312","313","314","315","316","317","319","321","322","323","324","325","326","350","352","353","354","355","356","357","358","360","361","362","402","404","407","408","410","411","414","416","417","418","419","420","421","422","423","424","425","426","427","429","431","432","433","434","435","436","437","440","451","452","453","455","456","460","461","462","463","464","465","466","467","468","469","470","475","480","485","486","490","491","492","494","499","500","501","503","504","511","517","521","527","536","540","561","567","568","601","602","620","622","625","650","715","805","806","810","811","812","813","814","815","816","818","819","820","821","822","823","824","826","827","828","829","830","831","832","833","834","835","836","837","838","839","840","841","842","843","844","845","846","847","848","849","850","851","852","853","854","855","856","857","858","859","860","861","862","863","864","865","866","867","868","869","870","871","872","874","875","876","877","878","879","880","881","882","883","884","885","886","887","888","889","890","891","892","893","894","895","896","901","905","920","924","925","926","928","940","941","942","943","944","945","946","947","980","990","994","995","996","997","998","999" });
		}
	}
	public class E_0145 : MapSimpleDataElement
	{
		public E_0145()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0146 : MapSimpleDataElement
	{
		public E_0146()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "11","BP","CA","CC","CD","CF","DE","DF","FO","HP","MX","NC","NR","PA","PB","PC","PD","PE","PL","PO","PP","PS","PU","RC","RF","RS","TP","WC" });
		}
	}
	public class E_0147 : MapSimpleDataElement
	{
		public E_0147()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" });
		}
	}
	public class E_0148 : MapSimpleDataElement
	{
		public E_0148()
		{
			DataType = DataType.R9;
			MinLength = 2;
			MaxLength = 9;
		}
	}
	public class E_0150 : MapSimpleDataElement
	{
		public E_0150()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_0151 : MapSimpleDataElement
	{
		public E_0151()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_0152 : MapSimpleDataElement
	{
		public E_0152()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "045","15","170","25","35","45","510","520","550","555","565","570","585","665","670","675","761","A1M","A3M","A5M","AAS","AB","ADL","AFN","AGG","AGS","AIB","AK","ALP","ALT","AMM","ANC","APD","APL","ARC","ARG","ARR","ART","ASY","AT","AUX","AV","AW","BA","BCP","BKA","BL","BLK","BLS","BN","BNS","BOX","BU2","BU4","BUA","BW","CA2","CA4","CAR","CC","CCB","CCH","CCS","CD","CDD","CE","CF","CFC","CFL","CGC","CGR","CGT","CH","CHN","CI","CIP","CIS","CLN","CLS","CM","CMD","CNL","CNS","CO","CON","COR","COU","COV","CPC","CPM","CR","CRL","CSD","CSP","CTL","CTM","CTR","CUF","CW","CX","CY","DA","DBL","DBP","DCS","DDN","DDP","DDS","DDZ","DE","DEL","DEP","DET","DEZ","DFD","DFM","DFS","DIS","DLP","DLR","DM","DN","DNC","DNF","DNT","DOC","DOV","DPB","DPD","DPE","DPL","DPT","DPU","DR","DRO","DRU","DS","DSK","DSM","DSR","DSV","DT","DTB","DTP","DTV","DU","DV","DW","DWP","EAX","ECR","ECS","ED","EDD","EDO","EE","EED","EL","ELS","EMR","EMT","END","EP","ER","ERS","ERT","EV","EW","EX","EXC","EXD","EXL","EXO","EXP","EXQ","EXT","EXU","EXZ","EZE","FA","FAK","FAS","FB","FC","FCS","FD","FFC","FFS","FG","FL","FLS","FP","FPT","FR","FRZ","FS","FST","FTR","GI","GMS","GOC","GSP","GSS","HAL","HAN","HBR","HDH","HDW","HE","HEA","HES","HET","HH","HM","HMA","HMI","HO","HOL","HOR","HOS","HOX","HP","HQT","HR","HRS","HT","HTI","HV","HW","HZC","HZD","IB","IC","ID","IDC","IDL","IIH","IM","IMP","IMS","INT","IP","IPU","IR","IS","ITS","JIT","JLX","JS","KEG","KMD","LAB","LAY","LB","LBL","LBR","LBT","LC","LC2","LC4","LCL","LD","LEC","LF","LFD","LHS","LIE","LMD","LME","LN","LP","LPD","LR","LS","LT","LTE","LTT","LYC","MAT","MC","MEN","MES","MET","MF","MIN","MNS","MOT","MP","MR","MRF","MSS","MTE","MVS","NC","ND","NE","NH","NHC","NHL","NI","NP","NPR","NS","NSV","NT","NW","NX","OAH","OBL","OCA","OCL","OCN","OCS","OCV","ODI","OEH","OFH","OFU","OHC","OIL","ONC","ONS","OOB","OOD","OOL","OPR","OPT","OS","OSB","OST","OTC","OTD","OTH","OTO","OTS","OUC","OUW","OV","OVR","OWC","OWR","PAJ","PAV","PB","PD","PDS","PDY","PER","PFH","PG","PHR","PI","PIR","PMM","PMR","PMS","PMT","POC","PPD","PRL","PRT","PS","PSG","PSS","PTS","PUC","PUD","PUK","PUP","PVB","PVD","PVI","PVL","PVP","PVS","PVT","PW","PYS","RA","RB","RC","RCC","RCL","RDH","RDR","REP","RES","RFM","RIE","RLS","RM","RMC","RMP","RMS","RO","RPD","RR","RRR","RS","RSP","RSS","RSV","RT","RWR","SAS","SAT","SB","SC","SCC","SCL","SD","SDL","SDS","SE","SEC","SED","SEE","SER","SEV","SFB","SFD","SFE","SFT","SGL","SH","SHH","SHL","SHW","SI","SK","SKT","SLC","SM","SMP","SMS","SNM","SNS","SNT","SOC","SOL","SP","SPC","SPR","SPT","SPU","SR","SRG","SRS","SSC","SSN","SSU","ST","STA","STD","STO","STP","STR","SUA","SUB","SUP","SVS","SW","TA","TC","TDC","TDP","TER","TF","TLS","TMS","TMV","TN","TOF","TPS","TRA","TRK","TRL","TRM","TRN","TRP","TRS","TRT","TS","TSC","TSP","TSS","TT","TV","UB","UFC","UI","UL","UN","UP","UPK","UR","URC","US","UTL","VAC","VAN","VCL","VFN","VIS","VN","VSO","VT","VTS","WB","WBB","WCT","WD","WDS","WE","WFG","WH","WI","WM","WO","WRB","WRI","WTV","WW","XP","XT","ZZZ" });
		}
	}
	public class E_0153 : MapSimpleDataElement
	{
		public E_0153()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 30;
		}
	}
	public class E_0154 : MapSimpleDataElement
	{
		public E_0154()
		{
			DataType = DataType.AN;
			MinLength = 6;
			MaxLength = 9;
		}
	}
	public class E_0156 : MapSimpleDataElement
	{
		public E_0156()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0157 : MapSimpleDataElement
	{
		public E_0157()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "2","3","A","A1","A2","A3","A4","AA","AC","AD","AE","AF","AG","AH","AI","AJ","AL","AM","AN","AO","AP","AR","AV","AW","B","BA","BC","BD","BE","BF","BR","C","C1","C2","CA","CB","CC","CD","CI","CO","CR","CS","CT","CU","CV","D","DA","DC","DN","DP","DR","DS","DT","E","EA","ED","EE","EI","EP","ER","F","FP","FT","G","GI","GO","H","HA","HE","HF","HG","HH","HI","HR","I","IB","IR","J","K","L","LD","LP","MT","N","NC","ND","NF","NH","NO","NP","NR","NS","NT","NU","O","OA","OB","OF","OH","ON","P","PA","PB","PC","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PW","PX","R","RA","RB","RC","RD","RI","RL","RN","S","SA","SB","SC","SD","SI","SN","T","TC","TM","TO","U","UA","UB","UC","UD","UE","UP","UR","UV","UW","V","VA","VD","W","WH","WR","X","X1","X2","X3","X4","X5","X6","X7","X8","X9","XA","XB","Y","Z","ZZ" });
		}
	}
	public class E_0159 : MapSimpleDataElement
	{
		public E_0159()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 5;
		}
	}
	public class E_0160 : MapSimpleDataElement
	{
		public E_0160()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","P","R","S" });
		}
	}
	public class E_0161 : MapSimpleDataElement
	{
		public E_0161()
		{
			DataType = DataType.TM;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_0163 : MapSimpleDataElement
	{
		public E_0163()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AL","CL","CN","CU","DR","DT","HT","IN","LD","LE","PA","PL","PU","RT","SL","SU","TL","UL","WL" });
		}
	}
	public class E_0165 : MapSimpleDataElement
	{
		public E_0165()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0166 : MapSimpleDataElement
	{
		public E_0166()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 55;
		}
	}
	public class E_0167 : MapSimpleDataElement
	{
		public E_0167()
		{
			DataType = DataType.N0;
			MinLength = 3;
			MaxLength = 8;
		}
	}
	public class E_0168 : MapSimpleDataElement
	{
		public E_0168()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0169 : MapSimpleDataElement
	{
		public E_0169()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 16;
		}
	}
	public class E_0170 : MapSimpleDataElement
	{
		public E_0170()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0171 : MapSimpleDataElement
	{
		public E_0171()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0172 : MapSimpleDataElement
	{
		public E_0172()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0173 : MapSimpleDataElement
	{
		public E_0173()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0174 : MapSimpleDataElement
	{
		public E_0174()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 30;
		}
	}
	public class E_0176 : MapSimpleDataElement
	{
		public E_0176()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5","6","7","8","9","A","B","C","CB","CE","D","E","ED","EP","F","G","H","I","J","K","L","LD","LP","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" });
		}
	}
	public class E_0177 : MapSimpleDataElement
	{
		public E_0177()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0181 : MapSimpleDataElement
	{
		public E_0181()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "03","04","05","06","07","51","52","53","54","55","56","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AN","AP","AR","AS","AT","AU","AV","AW","AX","AY","BA","BD","BK","BM","BN","BR","BS","BT","CD","CO","CR","CS","PC","TC","UD" });
		}
	}
	public class E_0182 : MapSimpleDataElement
	{
		public E_0182()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 28;
		}
	}
	public class E_0183 : MapSimpleDataElement
	{
		public E_0183()
		{
			DataType = DataType.R8;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0184 : MapSimpleDataElement
	{
		public E_0184()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","C","D","E","F","G","H","L","M","N","R","S","T","U","V","X" });
		}
	}
	public class E_0186 : MapSimpleDataElement
	{
		public E_0186()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0187 : MapSimpleDataElement
	{
		public E_0187()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","A1","A2","A3","A4","B","C","CD","CE","D","DR","E","F","FR","G","H","I","J","K","L","LC","M","N","ND","NI","NR","NT","O","P","PA","Q","R","RG","RN","RT","S","SF","SI","SK","SO","T","U","V","W","WA","WB","WG","WJ","X","Y","Z" });
		}
	}
	public class E_0188 : MapSimpleDataElement
	{
		public E_0188()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "E","G","K","L","M","O","S","T" });
		}
	}
	public class E_0189 : MapSimpleDataElement
	{
		public E_0189()
		{
			DataType = DataType.R8;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0190 : MapSimpleDataElement
	{
		public E_0190()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","P" });
		}
	}
	public class E_0191 : MapSimpleDataElement
	{
		public E_0191()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0192 : MapSimpleDataElement
	{
		public E_0192()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","R","S" });
		}
	}
	public class E_0193 : MapSimpleDataElement
	{
		public E_0193()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0195 : MapSimpleDataElement
	{
		public E_0195()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","F","G","M","T","V" });
		}
	}
	public class E_0196 : MapSimpleDataElement
	{
		public E_0196()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0197 : MapSimpleDataElement
	{
		public E_0197()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AH","AS","BH","BS","NC","NH","NS" });
		}
	}
	public class E_0199 : MapSimpleDataElement
	{
		public E_0199()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","M","N","R" });
		}
	}
	public class E_0200 : MapSimpleDataElement
	{
		public E_0200()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0201 : MapSimpleDataElement
	{
		public E_0201()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "BNR","DCP","DNP","DPP","FCP","FNP","FPP","LGR","OBR","TCR","TNR","TPR" });
		}
	}
	public class E_0202 : MapSimpleDataElement
	{
		public E_0202()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AD","AI","AR","B1","BA","BD","BE","BO","CA","CM","CO","CP","CS","CT","CU","D1","DC","DE","DP","DS","EM","MB","MD","MR","NC","ND","PD","RB","RC","RD","RE","RL","SC","SP","TL","WC" });
		}
	}
	public class E_0203 : MapSimpleDataElement
	{
		public E_0203()
		{
			DataType = DataType.N0;
			MinLength = 2;
			MaxLength = 4;
		}
	}
	public class E_0204 : MapSimpleDataElement
	{
		public E_0204()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0205 : MapSimpleDataElement
	{
		public E_0205()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0206 : MapSimpleDataElement
	{
		public E_0206()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0207 : MapSimpleDataElement
	{
		public E_0207()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0208 : MapSimpleDataElement
	{
		public E_0208()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "4","6","9","A","C","D","E","F","I","R","T","U","X" });
		}
	}
	public class E_0209 : MapSimpleDataElement
	{
		public E_0209()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0210 : MapSimpleDataElement
	{
		public E_0210()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "D","I" });
		}
	}
	public class E_0211 : MapSimpleDataElement
	{
		public E_0211()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AMM","BAG","BAL","BBL","BDL","BEM","BIC","BIN","BKG","BLK","BOB","BOT","BOX","BRG","BSK","BXI","BXT","CAB","CAG","CAN","CAR","CAS","CBC","CBY","CCS","CHE","CHS","CLD","CNA","CNB","CNC","CND","CNE","CNF","CNT","CNX","COL","CON","COR","CRD","CRT","CSK","CTN","CUB","CYL","DBK","DRK","DRM","DSK","DTB","DUF","ENV","FIR","FLO","FLX","FRM","FSK","FWR","GOH","HED","HGH","HPR","HPT","HRB","HRK","HTB","JAR","JUG","KEG","KIT","KRK","KTB","LBK","LIF","LOG","LSE","LUG","LVN","MLV","MRP","MSV","MXD","NOL","OVW","PAL","PCK","PCS","PIR","PKG","PLF","PLN","PLT","POV","PRK","QTR","RAL","RCK","REL","ROL","RVR","SAK","SBC","SCS","SHK","SHT","SID","SKD","SKE","SLP","SLV","SPI","SPL","SVN","TBE","TBN","TKR","TKT","TLD","TNK","TRC","TRI","TRK","TRU","TRY","TSS","TTC","TUB","UNP","UNT","VEH","VPK","WHE","WLC","WRP" });
		}
	}
	public class E_0212 : MapSimpleDataElement
	{
		public E_0212()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 17;
		}
	}
	public class E_0213 : MapSimpleDataElement
	{
		public E_0213()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0214 : MapSimpleDataElement
	{
		public E_0214()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","E","H","P" });
		}
	}
	public class E_0215 : MapSimpleDataElement
	{
		public E_0215()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0216 : MapSimpleDataElement
	{
		public E_0216()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "M" });
		}
	}
	public class E_0218 : MapSimpleDataElement
	{
		public E_0218()
		{
			DataType = DataType.AN;
			MinLength = 14;
			MaxLength = 40;
		}
	}
	public class E_0219 : MapSimpleDataElement
	{
		public E_0219()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0220 : MapSimpleDataElement
	{
		public E_0220()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 11;
		}
	}
	public class E_0221 : MapSimpleDataElement
	{
		public E_0221()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AR","BA","BX","CC","CF","CM","DK","DM","DR","EA","FR","FT","GC","GL","KG","LB","LC","LH","LR","MR","MT","MV","NB","NC","ND","NG","NL","NN","NP","NR","NT","NU","NV","OR","PK","PR","RV","SP","ST","SY","TD","TH","TN","TR","VA","VC","VM" });
		}
	}
	public class E_0222 : MapSimpleDataElement
	{
		public E_0222()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 25;
		}
	}
	public class E_0223 : MapSimpleDataElement
	{
		public E_0223()
		{
			DataType = DataType.N0;
			MinLength = 5;
			MaxLength = 5;
		}
	}
	public class E_0224 : MapSimpleDataElement
	{
		public E_0224()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 25;
		}
	}
	public class E_0225 : MapSimpleDataElement
	{
		public E_0225()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 15;
		}
	}
	public class E_0226 : MapSimpleDataElement
	{
		public E_0226()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","S" });
		}
	}
	public class E_0227 : MapSimpleDataElement
	{
		public E_0227()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0229 : MapSimpleDataElement
	{
		public E_0229()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0230 : MapSimpleDataElement
	{
		public E_0230()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0231 : MapSimpleDataElement
	{
		public E_0231()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","F","G","H","K","L","M","N","R","S","T","X" });
		}
	}
	public class E_0232 : MapSimpleDataElement
	{
		public E_0232()
		{
			DataType = DataType.N0;
			MinLength = 2;
			MaxLength = 6;
		}
	}
	public class E_0233 : MapSimpleDataElement
	{
		public E_0233()
		{
			DataType = DataType.N0;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0234 : MapSimpleDataElement
	{
		public E_0234()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 48;
		}
	}
	public class E_0235 : MapSimpleDataElement
	{
		public E_0235()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ","D1","D2","D3","D4","D5","DD","DE","DF","DG","DI","DL","DM","DN","DO","DP","DQ","DR","DS","DT","DU","DV","DW","DX","DY","DZ","E1","E2","E3","E4","E5","E6","EA","EB","EC","ED","EE","EF","EG","EH","EI","EJ","EK","EL","EM","EN","EP","EQ","ER","ES","EU","EX","EZ","F1","F2","F3","F4","F5","F6","F7","F8","F9","FA","FB","FC","FD","FE","FF","FG","FI","FL","FM","FN","FP","FS","FT","FW","GA","GC","GD","GE","GI","GK","GN","GQ","GR","GS","GU","HC","HD","HI","HN","IA","IB","IC","ID","IE","IF","IG","IM","IN","IP","IQ","IR","IS","IT","IV","IW","IZ","JA","JB","JC","JD","JN","JP","JS","KA","KB","KD","KE","KF","KG","KI","KJ","KK","KL","KM","KN","KP","L1","L2","L3","L4","L5","LA","LB","LC","LD","LG","LP","LR","LS","LT","LU","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","MM","MN","MO","MP","MQ","MR","MS","MT","MU","MV","MW","MX","N1","N2","N3","N4","N5","N6","NC","ND","NE","NH","NM","NR","NU","NW","NZ","OA","OB","OC","OD","OE","OF","OG","OH","OI","OL","ON","OO","OP","OR","OT","P1","P2","P3","P4","P5","P7","P8","P9","PA","PB","PC","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PW","PX","PY","PZ","R1","R2","RA","RB","RC","RD","RE","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RR","RS","RT","RU","RV","RW","RY","RZ","S2","S3","S4","S5","S6","S7","S8","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SK","SL","SM","SN","SO","SP","SQ","SR","SS","ST","SU","SV","SW","SX","SY","SZ","T2","T3","TA","TB","TC","TD","TE","TF","TG","TH","TI","TJ","TM","TN","TP","TR","TS","TT","TU","TV","TW","TX","TY","TZ","U2","U3","U5","U6","UA","UB","UC","UD","UE","UF","UG","UH","UI","UJ","UK","UL","UM","UN","UO","UP","UQ","UR","US","UT","UV","UX","VA","VB","VC","VE","VI","VM","VN","VO","VP","VS","VT","VU","VV","VX","W1","W2","W5","W6","W7","WA","WC","WL","WR","WS","XA","XC","XP","XQ","XZ","YP","ZB","ZR","ZZ" });
		}
	}
	public class E_0236 : MapSimpleDataElement
	{
		public E_0236()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "ACT","AGC","ALT","AWP","BBP","BCH","C01","C02","C03","C04","C05","C06","C07","C08","C09","C10","C11","C12","C13","C14","C15","C16","C17","C18","C19","C20","C21","C22","C23","C24","C25","C26","C27","C28","C29","C30","CAN","CAT","CDF","CDV","CHG","CON","CUP","CUS","D01","D02","D03","DAP","DIS","DPR","DSC","DSD","DSP","EDM","EDP","EDS","EDW","ELC","EST","EUP","FCH","FCP","FDS","FET","FGP","FSP","FUL","FUP","GAP","GDP","GOV","GSP","GTP","ICL","IND","INS","INV","LAR","LPP","LPR","MAP","MAS","MAX","MIN","MNC","MNR","MOD","MPR","MSR","MXR","N01","N02","N03","N04","N05","N06","N07","N08","N09","N10","N11","N12","N13","N14","N15","N16","N17","N18","N19","N20","N21","N22","N23","N24","N25","N26","N27","N28","N29","N30","N31","NET","OAP","OPP","PAP","PAQ","PBQ","PBR","PHS","PIE","PLT","PPA","PPD","PRF","PRO","PRP","PUR","QTE","REG","RES","RPA","RPM","RPP","RSH","RTL","SAC","SDP","SFP","SHD","SLP","SPC","SPE","STA","SUM","SWP","THP","TOT","TRF","UCP","ULC","WAR","WHL","WSP","ZNP" });
		}
	}
	public class E_0237 : MapSimpleDataElement
	{
		public E_0237()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0238 : MapSimpleDataElement
	{
		public E_0238()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0240 : MapSimpleDataElement
	{
		public E_0240()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 5;
			AllowedValues.AddRange(new[] { "145","145A","145S","145X","150","150X","155","155A","155S","34617","34618","34619","435","435A","435S","439","CMD1A","CMD1S","CSR5" });
		}
	}
	public class E_0241 : MapSimpleDataElement
	{
		public E_0241()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 4;
			AllowedValues.AddRange(new[] { "B","BC","D","HDN","HDNC","HSC","M","MN","MNU" });
		}
	}
	public class E_0242 : MapSimpleDataElement
	{
		public E_0242()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 7;
			AllowedValues.AddRange(new[] { "V40","VC","VD40","VDOI","VO","VOI","VS","VS10" });
		}
	}
	public class E_0243 : MapSimpleDataElement
	{
		public E_0243()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0244 : MapSimpleDataElement
	{
		public E_0244()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0246 : MapSimpleDataElement
	{
		public E_0246()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 4;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","AM","CB","CC","CP","DC","DV","EE","ER","GS","HD","HN","IS","NF" });
		}
	}
	public class E_0247 : MapSimpleDataElement
	{
		public E_0247()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 60;
		}
	}
	public class E_0248 : MapSimpleDataElement
	{
		public E_0248()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","N","P","Q","R","S" });
		}
	}
	public class E_0249 : MapSimpleDataElement
	{
		public E_0249()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "F","M","O","R","S" });
		}
	}
	public class E_0250 : MapSimpleDataElement
	{
		public E_0250()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 40;
		}
	}
	public class E_0253 : MapSimpleDataElement
	{
		public E_0253()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","F","N","P","T" });
		}
	}
	public class E_0254 : MapSimpleDataElement
	{
		public E_0254()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0256 : MapSimpleDataElement
	{
		public E_0256()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","P","S","T","V","W","X","Y","Z" });
		}
	}
	public class E_0257 : MapSimpleDataElement
	{
		public E_0257()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","I","N","R","S" });
		}
	}
	public class E_0258 : MapSimpleDataElement
	{
		public E_0258()
		{
			DataType = DataType.N4;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0259 : MapSimpleDataElement
	{
		public E_0259()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","T","W","X" });
		}
	}
	public class E_0260 : MapSimpleDataElement
	{
		public E_0260()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 30;
		}
	}
	public class E_0261 : MapSimpleDataElement
	{
		public E_0261()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A" });
		}
	}
	public class E_0262 : MapSimpleDataElement
	{
		public E_0262()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","D","F","I","L","O","P","T","U" });
		}
	}
	public class E_0263 : MapSimpleDataElement
	{
		public E_0263()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "00","01","02","03","04","05","07","08","09","10","11","12","13","14","15","16","17","18","19","20" });
		}
	}
	public class E_0267 : MapSimpleDataElement
	{
		public E_0267()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0271 : MapSimpleDataElement
	{
		public E_0271()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "I" });
		}
	}
	public class E_0272 : MapSimpleDataElement
	{
		public E_0272()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2" });
		}
	}
	public class E_0273 : MapSimpleDataElement
	{
		public E_0273()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 25;
		}
	}
	public class E_0274 : MapSimpleDataElement
	{
		public E_0274()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0275 : MapSimpleDataElement
	{
		public E_0275()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0276 : MapSimpleDataElement
	{
		public E_0276()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 25;
		}
	}
	public class E_0277 : MapSimpleDataElement
	{
		public E_0277()
		{
			DataType = DataType.AN;
			MinLength = 6;
			MaxLength = 6;
		}
	}
	public class E_0280 : MapSimpleDataElement
	{
		public E_0280()
		{
			DataType = DataType.R;
			MinLength = 4;
			MaxLength = 10;
		}
	}
	public class E_0281 : MapSimpleDataElement
	{
		public E_0281()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0282 : MapSimpleDataElement
	{
		public E_0282()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0283 : MapSimpleDataElement
	{
		public E_0283()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04" });
		}
	}
	public class E_0284 : MapSimpleDataElement
	{
		public E_0284()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","09","3D","9A","AC","AE","AM","BC","CB","CE","CG","CX","D1","D2","D3","DC","DF","DR","DS","DT","ES","ET","FC","G2","GP","GT","IA","IE","IX","ME","MW","ND","NF","NH","NM","NS","ON","PA","PB","PC","PI","PM","PN","PO","PR","PS","R1","R2","R3","R4","R5","R6","R7","R8","RS","SA","SC","SD","SE","SG","SH","SI","SM","SP","ST","ZZ" });
		}
	}
	public class E_0285 : MapSimpleDataElement
	{
		public E_0285()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 22;
		}
	}
	public class E_0286 : MapSimpleDataElement
	{
		public E_0286()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","ZZ" });
		}
	}
	public class E_0287 : MapSimpleDataElement
	{
		public E_0287()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","D" });
		}
	}
	public class E_0288 : MapSimpleDataElement
	{
		public E_0288()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","F","N","Y","Z" });
		}
	}
	public class E_0289 : MapSimpleDataElement
	{
		public E_0289()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0290 : MapSimpleDataElement
	{
		public E_0290()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02" });
		}
	}
	public class E_0291 : MapSimpleDataElement
	{
		public E_0291()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "001","002","003" });
		}
	}
	public class E_0292 : MapSimpleDataElement
	{
		public E_0292()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "001","002" });
		}
	}
	public class E_0293 : MapSimpleDataElement
	{
		public E_0293()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","99" });
		}
	}
	public class E_0294 : MapSimpleDataElement
	{
		public E_0294()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0295 : MapSimpleDataElement
	{
		public E_0295()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","D","F","K","L","M","T","X" });
		}
	}
	public class E_0296 : MapSimpleDataElement
	{
		public E_0296()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 4;
		}
	}
	public class E_0298 : MapSimpleDataElement
	{
		public E_0298()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 4;
		}
	}
	public class E_0299 : MapSimpleDataElement
	{
		public E_0299()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 80;
		}
	}
	public class E_0301 : MapSimpleDataElement
	{
		public E_0301()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0304 : MapSimpleDataElement
	{
		public E_0304()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AAD","ACA","ACC","ADR","ALR","ALV","ANO","APU","ARD","ARI","ARR","ASO","BAD","BFR","BHV","BLG","BOH","CCT","CG1","COC","CRD","CSL","CTU","DDL","DEC","DEL","DEP","DFL","DRM","DSI","EAD","EDD","EFT","ERD","ETA","EWI","EWL","FOL","FTE","HAR","HMI","HRE","IBD","ICH","ICR","IGT","INC","INV","IRD","IRI","ITS","MAL","MWY","NOB","NOT","OCA","OGT","OID","OIR","ORI","OSI","OTS","PAC","PCO","PEN","PFP","POS","PRB","RAM","REC","REJ","REP","RET","RLO","RMT","RYD","SAD","SAT","SDD","SLD","SPD","SPT","STA","STI","STN","STP","STS","STU","SUS","TDL","TMA","TMD","TOD","TPL","TRN","TRP","UNS","WAI","WGH","WIT","WYB","ZZX","ZZY","ZZZ" });
		}
	}
	public class E_0305 : MapSimpleDataElement
	{
		public E_0305()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","X","Z" });
		}
	}
	public class E_0306 : MapSimpleDataElement
	{
		public E_0306()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","31","32","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","50","51","52","53","54","55","56","57","58","59","6","60","61","62","63","64","65","66","67","68","69","7","70","71","72","73","74","75","76","77","78","79","8","80","81","82","83","84","85","86","87","88","89","9","90","A","A1","A2","A3","A4","A5","A6","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AL","AP","AQ","AR","AS","AT","AV","AW","AX","B","BD","BI","BO","C","C1","C2","CA","CB","CC","CD","CE","CF","CG","CL","CM","CN","CO","CP","CS","CT","CU","CV","CX","D","D1","D2","DA","DB","DC","DD","DE","DF","DG","DH","DI","DJ","DK","DL","DP","DR","DS","DT","DX","E","EA","EB","EC","ED","EE","EN","EP","ER","EV","EX","F","F1","FA","FC","FI","FO","FR","G","GR","H","HR","I","I1","IA","IM","IN","IS","IT","J","JA","JO","JU","K","KA","L","LC","LQ","M","ME","MO","N","NA","ND","NP","NS","O","OD","OP","OR","OT","P","P1","PA","PB","PC","PD","PF","PI","PJ","PO","PP","PR","PS","PT","PU","PV","Q","R","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RD","RE","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RQ","RR","RS","RT","RU","RV","RW","RX","S","S1","S2","SA","SB","SC","SD","SE","SL","SR","SS","SU","SV","SZ","T","TD","TE","TG","TN","TP","TR","TS","TU","U","V","VA","W","W1","WD","WI","WQ","WV","X","Y","Z" });
		}
	}
	public class E_0308 : MapSimpleDataElement
	{
		public E_0308()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "Y" });
		}
	}
	public class E_0309 : MapSimpleDataElement
	{
		public E_0309()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "10","11","12","13","14","18","19","20","21","22","27","28","29","30","31","32","33","34","35","36","38","39","40","41","42","43","44","45","46","47","48","49","50","52","53","54","55","57","58","59","60","93","94","A","A1","AA","AC","AP","AR","B","B1","BE","BL","BS","C","C2","CA","CB","CC","CD","CE","CI","CL","CO","CR","CS","CY","D","DC","DE","DL","DO","DP","DR","DT","E","EA","EL","F","FA","FE","FF","FI","FR","FS","FT","FV","GL","H","I","IA","IB","IM","IP","IS","IT","K","KE","KL","KP","L","LO","M","MI","MS","MZ","NS","O","OA","OF","OL","OP","OR","OV","P","PA","PB","PC","PD","PE","PF","PG","PH","PL","PO","PP","PQ","PR","PS","PT","PU","RA","RC","RE","RG","RJ","RL","RS","RT","SA","SB","SC","SD","SE","SG","SH","SL","SN","SP","SS","ST","SW","TA","TC","TL","TM","TN","TP","TR","TX","UN","UR","UT","VA","VI","VS","W","WF","WH","WI","ZN","ZZ" });
		}
	}
	public class E_0310 : MapSimpleDataElement
	{
		public E_0310()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0311 : MapSimpleDataElement
	{
		public E_0311()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AD","AM","CS","RJ","ST" });
		}
	}
	public class E_0312 : MapSimpleDataElement
	{
		public E_0312()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "I","L","N","O","T" });
		}
	}
	public class E_0313 : MapSimpleDataElement
	{
		public E_0313()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BC","CA","FN","LO","NR","PP","RC","RV","SH","SO" });
		}
	}
	public class E_0315 : MapSimpleDataElement
	{
		public E_0315()
		{
			DataType = DataType.R5;
			MinLength = 2;
			MaxLength = 5;
		}
	}
	public class E_0316 : MapSimpleDataElement
	{
		public E_0316()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 24;
		}
	}
	public class E_0317 : MapSimpleDataElement
	{
		public E_0317()
		{
			DataType = DataType.N0;
			MinLength = 3;
			MaxLength = 10;
		}
	}
	public class E_0318 : MapSimpleDataElement
	{
		public E_0318()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 24;
		}
	}
	public class E_0319 : MapSimpleDataElement
	{
		public E_0319()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 6;
		}
	}
	public class E_0320 : MapSimpleDataElement
	{
		public E_0320()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0321 : MapSimpleDataElement
	{
		public E_0321()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5","6","7" });
		}
	}
	public class E_0322 : MapSimpleDataElement
	{
		public E_0322()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "E","L","T" });
		}
	}
	public class E_0323 : MapSimpleDataElement
	{
		public E_0323()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0324 : MapSimpleDataElement
	{
		public E_0324()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 22;
		}
	}
	public class E_0325 : MapSimpleDataElement
	{
		public E_0325()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_0326 : MapSimpleDataElement
	{
		public E_0326()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 45;
		}
	}
	public class E_0327 : MapSimpleDataElement
	{
		public E_0327()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0328 : MapSimpleDataElement
	{
		public E_0328()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0329 : MapSimpleDataElement
	{
		public E_0329()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 9;
		}
	}
	public class E_0330 : MapSimpleDataElement
	{
		public E_0330()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0331 : MapSimpleDataElement
	{
		public E_0331()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","15","18","20","21","25","CA","CC","PP","ZZ" });
		}
	}
	public class E_0332 : MapSimpleDataElement
	{
		public E_0332()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0333 : MapSimpleDataElement
	{
		public E_0333()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "09","1","10","11","12","13","14","15","16","2","3","4","5","6","7","8","ZZ" });
		}
	}
	public class E_0334 : MapSimpleDataElement
	{
		public E_0334()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","ZZ" });
		}
	}
	public class E_0335 : MapSimpleDataElement
	{
		public E_0335()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "CAF","CFR","CIF","CIP","CPT","DAF","DDP","DDU","DEQ","DES","DOM","DUP","EXQ","EXS","EXW","FAS","FCA","FCI","FCP","FOB","FOR","FOT","NPF","PPF","ZZZ" });
		}
	}
	public class E_0336 : MapSimpleDataElement
	{
		public E_0336()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","52","54","55","56","57","58","61","63","64","65","CA","CO","NC","PP","ZZ" });
		}
	}
	public class E_0337 : MapSimpleDataElement
	{
		public E_0337()
		{
			DataType = DataType.TM;
			MinLength = 4;
			MaxLength = 8;
		}
	}
	public class E_0338 : MapSimpleDataElement
	{
		public E_0338()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0339 : MapSimpleDataElement
	{
		public E_0339()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0340 : MapSimpleDataElement
	{
		public E_0340()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "1","10","100","101","105","106","107","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","31","32","33","34","4","40","41","42","43","44","45","46","47","48","490","491","499","5","50","501","502","503","504","505","506","507","508","509","51","510","511","512","513","514","515","516","517","518","519","52","520","521","522","523","524","525","526","527","53","537","54","55","550","560","561","562","565","566","57","58","6","60","61","62","63","64","65","66","67","68","70","80","81","88","90","91","92","93","94","95","96","97","990","999" });
		}
	}
	public class E_0341 : MapSimpleDataElement
	{
		public E_0341()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 16;
		}
	}
	public class E_0342 : MapSimpleDataElement
	{
		public E_0342()
		{
			DataType = DataType.R5;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0343 : MapSimpleDataElement
	{
		public E_0343()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0344 : MapSimpleDataElement
	{
		public E_0344()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AD","AM","AN","AP","AY","BD","BM","BW","CC","CY","DA","DW","DY","EL","F1","F2","FY","HR","ID","KK","KL","LN","LT","MD","MI","MO","MS","MT","NX","PA","PD","PM","PR","Q1","Q2","Q3","Q4","QY","SA","SD","SH","SM","SP","TY","WK","WW","WY","YD","ZZ" });
		}
	}
	public class E_0345 : MapSimpleDataElement
	{
		public E_0345()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AP","AR","AS","AT","AU","AV","AW","AX","AY","AZ","BA","BB","BC","BD","BE","BF","BG" });
		}
	}
	public class E_0346 : MapSimpleDataElement
	{
		public E_0346()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","AN","AT","BD","BG","BH","BL","BN","BR","BT","CD","CF","CI","CL","CO","DL","DO","DT","EP","FA","FR","HR","IS","LB","LS","LT","MF","PC","PI","PL","PP","PS","R1","R2","R3","R4","RD","RO","RP","RQ","RR","RS","S1","S2","SI","SL","SP","SS","T1","T2","T3","T4","TF","TG","TM","TQ","ZZ" });
		}
	}
	public class E_0347 : MapSimpleDataElement
	{
		public E_0347()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0348 : MapSimpleDataElement
	{
		public E_0348()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_0349 : MapSimpleDataElement
	{
		public E_0349()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "F","S","X" });
		}
	}
	public class E_0350 : MapSimpleDataElement
	{
		public E_0350()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_0351 : MapSimpleDataElement
	{
		public E_0351()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0352 : MapSimpleDataElement
	{
		public E_0352()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 80;
		}
	}
	public class E_0353 : MapSimpleDataElement
	{
		public E_0353()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "00","01","02","03","04","05","06","07","08","10","11","12","13","14","15","16","17","18","19","20","21","22","24","25","26","27","28","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","5C","77","CN","CO","EX","GR","PR","RH","RV","SU","ZZ" });
		}
	}
	public class E_0354 : MapSimpleDataElement
	{
		public E_0354()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0355 : MapSimpleDataElement
	{
		public E_0355()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","1A","1B","1C","1D","1E","1F","1G","1H","1I","1J","1K","1L","1M","1N","1O","1P","1Q","1R","1X","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2F","2G","2H","2I","2J","2K","2L","2M","2N","2P","2Q","2R","2U","2V","2W","2X","2Y","2Z","30","31","32","33","34","35","36","37","38","39","3B","3C","3E","3F","3G","3H","3I","40","41","43","44","45","46","47","48","4A","4B","4C","4D","4E","4F","4G","4H","4I","4J","4K","4L","4M","4N","4O","4P","4Q","4R","4S","4T","4U","4V","4W","4X","50","51","52","53","54","56","57","58","59","5A","5B","5C","5E","5F","5G","5H","5I","5J","5K","5P","5Q","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","76","77","78","79","80","81","82","83","84","85","86","87","89","8C","8D","8P","8R","8S","8U","90","91","92","93","94","95","96","97","98","99","A8","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B0","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","C0","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ","D2","D3","D5","D8","D9","DA","DB","DC","DD","DE","DF","DG","DH","DI","DJ","DK","DL","DM","DN","DO","DP","DQ","DR","DS","DT","DU","DW","DX","DY","DZ","E1","E3","E4","E5","E7","E8","E9","EA","EB","EC","ED","EE","EF","EG","EH","EJ","EM","EP","EQ","EV","EX","EY","EZ","F1","F2","F3","F4","F5","F6","F9","FA","FB","FC","FD","FE","FF","FG","FH","FJ","FK","FL","FM","FO","FP","FR","FS","FT","FZ","G2","G3","G4","G5","G7","GA","GB","GC","GD","GE","GF","GG","GH","GI","GJ","GK","GL","GM","GN","GO","GP","GQ","GR","GS","GT","GU","GV","GW","GX","GY","GZ","H1","H2","H4","HA","HB","HC","HD","HE","HF","HG","HH","HI","HJ","HK","HL","HM","HN","HO","HP","HQ","HR","HS","HT","HU","HV","HW","HY","HZ","IA","IB","IC","IE","IF","IH","II","IK","IL","IM","IN","IP","IT","IU","IV","IW","J2","JA","JB","JE","JG","JK","JM","JO","JR","JU","K1","K2","K3","K4","K5","K6","K7","K9","KA","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KO","KP","KQ","KR","KS","KT","KU","KV","KW","KX","L2","LA","LB","LC","LE","LF","LG","LH","LI","LJ","LK","LL","LM","LN","LO","LP","LQ","LR","LS","LT","LX","LY","M0","M1","M2","M3","M4","M5","M6","M7","M8","M9","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","ML","MM","MN","MO","MP","MQ","MR","MS","MT","MU","MV","MW","MX","MY","MZ","N1","N2","N3","N4","N6","N7","N9","NA","NB","NC","ND","NE","NF","NG","NH","NI","NJ","NL","NM","NN","NQ","NR","NS","NT","NU","NV","NW","NX","NY","OA","OC","ON","OP","OT","OZ","P0","P1","P2","P3","P4","P5","P6","P7","P8","P9","PA","PB","PC","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PW","PX","PY","PZ","Q1","Q2","Q3","Q4","Q5","Q6","Q7","QA","QB","QC","QD","QE","QH","QK","QR","QS","QT","QU","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RD","RE","RG","RH","RK","RL","RM","RN","RO","RP","RS","RT","RU","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SK","SL","SM","SN","SO","SP","SQ","SR","SS","ST","SV","SW","SX","SY","SZ","T0","T1","T2","T3","T4","T5","T6","T7","T8","T9","TA","TB","TC","TD","TE","TF","TG","TH","TI","TJ","TK","TL","TM","TN","TO","TP","TQ","TR","TS","TT","TU","TV","TW","TX","TY","TZ","U1","U2","U3","U5","UA","UB","UC","UD","UE","UF","UH","UL","UM","UN","UP","UQ","UR","US","UT","UU","UV","UW","UX","UY","UZ","V1","V2","VA","VC","VI","VP","VR","VS","W2","WA","WB","WD","WE","WG","WH","WI","WK","WM","WP","WR","WW","X1","X2","X3","X4","X5","X6","X7","X8","X9","XP","Y1","Y2","Y3","Y4","YD","YL","YR","YT","Z1","Z2","Z3","Z4","Z5","Z6","Z8","ZA","ZB","ZC","ZP","ZZ" });
		}
	}
	public class E_0356 : MapSimpleDataElement
	{
		public E_0356()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0357 : MapSimpleDataElement
	{
		public E_0357()
		{
			DataType = DataType.R8;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0358 : MapSimpleDataElement
	{
		public E_0358()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0359 : MapSimpleDataElement
	{
		public E_0359()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0360 : MapSimpleDataElement
	{
		public E_0360()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0361 : MapSimpleDataElement
	{
		public E_0361()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0362 : MapSimpleDataElement
	{
		public E_0362()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0363 : MapSimpleDataElement
	{
		public E_0363()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AAA","AAB","AAC","AAD","AAE","AAF","ABN","ACC","ACI","ACN","ACS","ACT","ADD","AES","AET","ALG","ALL","ALT","AMN","AOO","APN","APS","BBD","BBF","BBH","BBN","BBO","BBT","BFD","BOL","BUR","CAA","CAB","CAC","CAD","CAE","CAF","CAG","CAH","CAI","CAJ","CAK","CAL","CAM","CAN","CAO","CAP","CAQ","CAR","CAS","CAT","CAU","CAV","CAW","CAX","CAZ","CBA","CBB","CBC","CBH","CBI","CCA","CCB","CCC","CCD","CCE","CCF","CCG","CCN","CDD","CER","CHG","CIG","CLN","CLR","CMP","CMT","COD","COM","CON","CRA","CRK","CRN","CUS","DCP","DEE","DEL","DEP","DFR","DFS","DGN","DME","DOD","DOI","ECD","ECM","ECN","ECT","EED","EFD","ELE","EMC","EMD","ENR","ERN","EVL","EXE","EXR","EXT","FEE","FUT","GEN","GPI","GSI","HHI","ICN","IDT","IID","IIE","IIR","IMP","INS","INT","INV","IVC","JVD","LAB","LBD","LBS","LEN","LIN","LIQ","LLA","LLB","LLC","LOC","LOI","LSD","MCD","MDO","MED","MFG","MKN","MMD","MSD","NCD","NPD","NTR","OBI","OBL","OCA","OCC","OCL","OCP","OCR","ODT","OLS","OPO","ORA","ORE","ORI","OTH","OTN","OTS","PAY","PCS","PDS","PED","PEN","PES","PID","PKG","PMT","POB","POC","POL","PPC","PRI","PRN","PRO","PRR","PSY","PUR","QUL","QUT","RDI","REC","REG","REP","REV","RFL","RHB","RLA","RLH","RNH","RNI","ROU","RPT","RST","RVC","SAN","SCN","SDD","SET","SFM","SMD","SOB","SOW","SPH","SPT","SPV","SSA","SSC","SSD","SSE","SSG","SSH","SSI","SSS","SST","TAF","TCF","TDA","TES","TIL","TLF","TLR","TPO","TRA","TRE","TRF","TRS","TSD","TSF","TST","UPI","VEC","VNN","WHI","WRP","ZZZ" });
		}
	}
	public class E_0364 : MapSimpleDataElement
	{
		public E_0364()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 80;
		}
	}
	public class E_0365 : MapSimpleDataElement
	{
		public E_0365()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AP","AS","AU","BN","BT","CA","CP","DN","ED","EM","EX","FT","FU","FX","HF","HP","IT","MN","NP","OF","OT","PA","PC","PP","PS","SP","TE","TL","TM","TN","TX","UR","VM","WC","WF","WP" });
		}
	}
	public class E_0366 : MapSimpleDataElement
	{
		public E_0366()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1A","1B","1C","1D","1E","1F","1G","1H","3A","A1","A2","A3","A4","A5","AA","AB","AC","AD","AE","AF","AG","AH","AI","AL","AM","AN","AP","AR","AS","AT","AU","AV","BA","BB","BC","BD","BI","BJ","BK","BL","BM","BP","BS","BU","C2","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CR","CS","CT","CU","CV","CW","CX","CY","CZ","DA","DC","DD","DE","DF","DI","DM","DN","DV","E1","E2","EA","EB","EC","ED","EF","EG","EM","EN","EO","EP","ES","EV","EX","FA","FB","FC","FD","FF","FL","FM","FN","FO","FP","FQ","FR","GA","GB","GC","GE","GR","HM","HR","IC","IO","IP","IS","KA","KB","KC","KP","KT","LD","MA","MB","MC","MD","ME","MG","MK","ML","MM","NA","NC","NP","NT","OA","OC","OD","OS","OW","PA","PB","PC","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PW","PX","PY","PZ","QA","QC","QI","QM","QP","QR","QY","RA","RB","RC","RD","RE","RF","RG","RP","RQ","RS","RZ","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SK","SL","SM","SN","SO","SP","SQ","SR","SS","ST","SU","SV","SW","SY","TA","TB","TC","TD","TE","TH","TM","TN","TP","TR","TY","UG","UP","UQ","UR","VM","VP","WH","WI","WR","ZZ" });
		}
	}
	public class E_0367 : MapSimpleDataElement
	{
		public E_0367()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0368 : MapSimpleDataElement
	{
		public E_0368()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AN","AP","AS","AU","AV","BK","BM","BO","BP","BT","BW","CA","CB","CC","CD","CE","CF","CI","CK","CL","CM","CN","CO","CP","CS","CT","CU","DA","DD","DE","DI","DO","DP","DR","DS","EC","ED","EW","EX","FS","HQ","IC","ID","IN","IP","IS","LM","LS","LW","MC","NF","NN","NS","NY","OB","OF","OP","OR","PA","PC","PD","PH","PI","PK","PL","PN","PO","PP","PR","PS","PT","QN","QP","RC","RD","RI","RT","RW","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SK","SL","SP","SQ","SS","ST","SU","UB","UN","UR","WS","ZZ" });
		}
	}
	public class E_0369 : MapSimpleDataElement
	{
		public E_0369()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 45;
		}
	}
	public class E_0370 : MapSimpleDataElement
	{
		public E_0370()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0371 : MapSimpleDataElement
	{
		public E_0371()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AQ","BB","BD","C1","C2","C3","C4","C5","C6","DC","EV","FE","GU","GW","LD","MC","MP","PC","PQ","PS","QH","QO","QP","QT","SC","UM","UP","WD","WO","ZZ" });
		}
	}
	public class E_0372 : MapSimpleDataElement
	{
		public E_0372()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "F","L" });
		}
	}
	public class E_0373 : MapSimpleDataElement
	{
		public E_0373()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0374 : MapSimpleDataElement
	{
		public E_0374()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "001","002","003","004","005","006","007","008","009","010","011","012","013","014","015","016","017","018","019","020","021","022","023","024","025","026","027","028","029","030","031","032","033","034","035","036","037","038","039","040","041","042","043","044","045","046","047","048","049","050","051","052","053","054","055","056","057","058","059","060","061","062","063","064","065","066","067","068","069","070","071","072","073","074","075","076","077","078","079","080","081","082","083","084","085","086","087","088","089","090","091","092","093","094","095","096","097","098","099","100","101","102","103","104","105","106","107","108","109","110","111","112","113","114","115","116","118","119","120","121","122","124","125","126","127","128","129","130","131","132","133","134","135","136","137","138","139","140","141","142","143","144","145","146","147","148","149","150","151","152","153","154","155","156","157","158","159","160","161","162","163","164","165","166","167","168","169","170","171","172","173","174","175","176","177","178","179","180","181","182","183","184","185","186","187","188","189","190","191","192","193","194","195","196","197","198","199","200","201","202","203","204","205","206","207","208","209","210","211","212","213","214","215","216","217","218","219","220","221","222","223","224","225","226","227","228","229","230","231","232","233","234","235","236","237","238","239","240","241","242","243","244","245","246","247","248","249","250","251","252","253","254","255","256","257","258","259","260","261","262","263","264","265","266","267","268","269","270","271","272","273","274","275","276","277","278","279","280","281","282","283","284","285","286","287","288","289","290","291","292","293","294","295","296","297","298","299","300","301","302","303","304","305","306","307","308","309","310","311","312","313","314","315","316","317","318","319","320","321","322","323","324","325","326","327","328","329","330","331","332","333","334","335","336","337","338","339","340","341","342","343","344","345","346","347","348","349","350","351","352","353","354","355","356","357","358","359","360","361","362","363","364","365","366","367","368","369","370","371","372","373","374","375","376","377","378","379","380","381","382","383","384","385","386","387","388","389","390","391","392","393","394","395","396","397","398","399","400","401","402","403","404","405","406","408","409","410","411","412","413","414","415","416","417","418","419","420","421","422","423","424","425","426","427","428","429","430","431","432","433","434","435","436","437","438","439","440","441","442","443","444","445","446","447","448","449","450","451","452","453","454","455","456","457","458","459","460","461","462","463","464","465","466","467","468","469","470","471","472","473","474","475","476","477","478","479","480","481","482","483","484","485","486","487","488","489","490","491","492","493","494","495","496","497","498","499","500","501","502","503","504","505","506","507","508","509","510","511","512","513","514","515","516","517","518","519","520","521","522","523","524","525","526","527","528","529","530","531","532","533","534","535","536","537","538","539","540","541","542","543","544","545","546","547","548","549","550","551","552","553","554","555","556","557","558","559","560","561","562","563","564","565","566","567","568","569","570","571","572","573","574","575","576","577","578","579","580","581","582","583","584","585","586","587","589","590","591","592","593","594","595","596","597","598","599","600","601","602","603","604","606","607","608","609","610","611","612","613","614","615","616","617","618","619","620","621","622","623","624","625","626","627","629","630","631","632","633","634","635","636","637","638","640","641","642","643","644","646","647","648","649","650","651","652","653","655","656","657","658","659","660","661","662","663","664","665","666","667","668","669","670","671","672","673","674","675","681","682","683","684","685","686","687","688","689","690","691","692","693","694","695","696","697","699","700","701","702","703","704","705","706","707","708","709","710","711","712","713","714","715","716","717","718","719","720","721","722","723","724","725","726","727","728","729","730","731","732","733","734","736","737","738","739","740","741","742","743","744","745","746","750","751","752","753","754","755","756","757","758","760","770","771","773","774","776","778","779","780","781","782","783","784","785","786","789","800","801","802","803","804","805","806","807","808","809","810","811","812","813","814","815","816","817","818","820","821","822","823","824","825","826","827","828","830","831","832","840","841","842","843","844","845","846","847","848","849","850","851","853","854","855","856","857","858","859","860","861","862","863","864","865","866","867","868","869","870","871","872","873","874","875","876","877","878","879","880","881","882","883","884","885","900","901","903","904","905","906","907","908","909","910","911","912","913","914","915","916","917","918","919","920","921","922","923","924","925","926","927","928","929","930","931","932","933","934","935","936","937","938","939","940","941","942","943","944","945","946","947","948","949","950","951","952","953","954","955","956","957","960","961","962","963","964","965","966","967","968","969","970","971","972","973","974","975","976","977","978","979","980","981","982","983","984","985","986","987","988","989","992","993","994","995","996","997","998","999","AA1","AA2","AA3","AA4","AA5","AA6","AA7","AA8","AA9","AAA","AAB","AAD","AAE","AAF","AAG","AAH","AAI","AAJ","AAK","AAL","AAM","AAN","AAO","AAP","AAQ","AAR","AAS","AAT","AAU","AAV","AAW","AAX","AAY","AAZ","AB1","AB2","AB3","AB4","AB5","AB6","AB7","AB8","AB9","ABA","ABB","ABC","ABD","ABE","ABG","ABH","ABI","ABK","ABL","ABM","ABN","ABO","ABP","ABQ","ABR","ABS","ABT","ABU","ABV","ABW","ABX","ABY","ACA","ACB","ACK","ADB","ADC","ADD","ADL","ADM","ADR","ARD","CAD","CCR","CDT","CEA","CEB","CEC","CED","CEE","CEF","CEH","CEJ","CEK","CEL","CEM","CEN","CEO","CLO","CLU","COM","CON","CUR","DDO","DEE","DET","DFF","DFS","DIS","DOI","DSP","ECD","ECF","ECS","ECT","EPP","ESC","ESF","ESS","EST","ETP","EXO","EXP","FFI","GRD","ICF","IDG","III","IMP","INC","INT","KEV","KEW","LAS","LCC","LEA","LEL","LIQ","LLP","LOG","LPC","LSC","LTP","MRR","MSD","NAM","NFD","NRG","NSD","ORG","PBC","PDV","PLS","PPP","PRD","PRR","PTD","RAP","RES","RFD","RFF","RFO","RNT","RRM","RRT","RSD","RSS","RTO","SCV","SDD","STN","TSR","TSS","TST","VAT","VLU","W01","W02","W03","W05","W06","W07","W08","W09","W10","W11","W12","W13","WAY","YXX","YXY","ZZZ" });
		}
	}
	public class E_0375 : MapSimpleDataElement
	{
		public E_0375()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1A","1B","2A","2B","B1","B2","B3","B4","B5","BA","BB","BC","BD","BE","BF","BG","BH","BK","BL","BM","BN","BO","BP","BR","BW","BX","BY","DB","DD","DM","DO","DP","DR","EC","H1","H2","HA","HB","HC","HD","HE","HF","HG","HH","HK","HL","HM","HN","HP","HR","HW","HX","HY","MB","MD","ML","MM","MO","MP","MR","ND","OC","OD","OM","OR","OT","OV","PB","PD","PH","PM","PP","PR","RB","RD","RM","RO","RP","RR" });
		}
	}
	public class E_0377 : MapSimpleDataElement
	{
		public E_0377()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","M","N" });
		}
	}
	public class E_0378 : MapSimpleDataElement
	{
		public E_0378()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","Z" });
		}
	}
	public class E_0379 : MapSimpleDataElement
	{
		public E_0379()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AB","BF","BI","BW","DQ","OM","RE","RT","UQ" });
		}
	}
	public class E_0380 : MapSimpleDataElement
	{
		public E_0380()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0381 : MapSimpleDataElement
	{
		public E_0381()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","P","Q","S","T","X" });
		}
	}
	public class E_0382 : MapSimpleDataElement
	{
		public E_0382()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0383 : MapSimpleDataElement
	{
		public E_0383()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0384 : MapSimpleDataElement
	{
		public E_0384()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0385 : MapSimpleDataElement
	{
		public E_0385()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0386 : MapSimpleDataElement
	{
		public E_0386()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0387 : MapSimpleDataElement
	{
		public E_0387()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 35;
		}
	}
	public class E_0388 : MapSimpleDataElement
	{
		public E_0388()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0389 : MapSimpleDataElement
	{
		public E_0389()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0390 : MapSimpleDataElement
	{
		public E_0390()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0391 : MapSimpleDataElement
	{
		public E_0391()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0392 : MapSimpleDataElement
	{
		public E_0392()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_0393 : MapSimpleDataElement
	{
		public E_0393()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17" });
		}
	}
	public class E_0394 : MapSimpleDataElement
	{
		public E_0394()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0395 : MapSimpleDataElement
	{
		public E_0395()
		{
			DataType = DataType.R8;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0396 : MapSimpleDataElement
	{
		public E_0396()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 30;
		}
	}
	public class E_0397 : MapSimpleDataElement
	{
		public E_0397()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0398 : MapSimpleDataElement
	{
		public E_0398()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0399 : MapSimpleDataElement
	{
		public E_0399()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5" });
		}
	}
	public class E_0400 : MapSimpleDataElement
	{
		public E_0400()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","ZZ" });
		}
	}
	public class E_0406 : MapSimpleDataElement
	{
		public E_0406()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0407 : MapSimpleDataElement
	{
		public E_0407()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04" });
		}
	}
	public class E_0408 : MapSimpleDataElement
	{
		public E_0408()
		{
			DataType = DataType.R4;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0409 : MapSimpleDataElement
	{
		public E_0409()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0410 : MapSimpleDataElement
	{
		public E_0410()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0411 : MapSimpleDataElement
	{
		public E_0411()
		{
			DataType = DataType.R7;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0412 : MapSimpleDataElement
	{
		public E_0412()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","16" });
		}
	}
	public class E_0413 : MapSimpleDataElement
	{
		public E_0413()
		{
			DataType = DataType.R7;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0414 : MapSimpleDataElement
	{
		public E_0414()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0416 : MapSimpleDataElement
	{
		public E_0416()
		{
			DataType = DataType.N0;
			MinLength = 6;
			MaxLength = 6;
		}
	}
	public class E_0417 : MapSimpleDataElement
	{
		public E_0417()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0418 : MapSimpleDataElement
	{
		public E_0418()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0419 : MapSimpleDataElement
	{
		public E_0419()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0420 : MapSimpleDataElement
	{
		public E_0420()
		{
			DataType = DataType.N2;
			MinLength = 2;
			MaxLength = 7;
		}
	}
	public class E_0421 : MapSimpleDataElement
	{
		public E_0421()
		{
			DataType = DataType.N2;
			MinLength = 2;
			MaxLength = 7;
		}
	}
	public class E_0422 : MapSimpleDataElement
	{
		public E_0422()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","10","11","12","13","14","15","16","17","18","19","20","21","22","23","25","26","28","32","33","34","35","36","37","39","40","41","42","44","45","46","49","51","59","60","61","62","63","64","69","70","71","72","79","81","82","83","84","88","99","A1","A2","A3","A4","A5","B1","B2","B3","C1","C2","C3","C4","WR","ZZ" });
		}
	}
	public class E_0423 : MapSimpleDataElement
	{
		public E_0423()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07" });
		}
	}
	public class E_0424 : MapSimpleDataElement
	{
		public E_0424()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 22;
		}
	}
	public class E_0426 : MapSimpleDataElement
	{
		public E_0426()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","98","99","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AB","AC","AE","AF","AG","AH","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BR","BS","C1","C2","C3","C4","C5","C6","C7","C8","C9","CB","CE","CK","CM","CO","CP","CQ","CR","CS","CT","CU","CV","CW","D1","D2","D3","D4","D5","D6","D7","D8","D9","DA","DB","DC","DD","DE","DF","DG","DH","DI","DJ","DK","DL","DM","DO","DP","DR","DS","DT","DV","DW","DX","E1","E2","E3","E4","E5","E6","E7","E8","E9","EE","ER","EX","F1","F3","F4","F5","F6","F7","F8","F9","FA","FB","FC","FI","FR","FT","G1","G2","G3","G4","G5","G6","G7","G8","G9","GA","GB","GC","GD","GE","GF","GG","GH","GJ","GK","GL","GM","GN","GO","GR","H1","H2","H3","H4","H5","H6","H7","H8","H9","HA","HB","HC","HD","HE","HF","HG","HI","IA","IC","IE","IF","IL","IP","IR","IS","J1","J2","J3","J4","J5","J6","J7","J8","J9","JE","K1","K2","K3","L1","L2","L3","L4","L5","L6","L7","L8","L9","LA","LE","LF","LO","LP","LS","M1","M2","M3","M4","MA","MC","ML","NA","NB","NC","ND","NR","OA","OB","OL","PA","PD","PF","PI","PL","PM","PO","PP","PR","PT","R1","R2","R3","RA","RD","RE","RM","SC","SD","SF","SL","SP","TA","TD","TL","UB","UL","VC","VD","VO","W6","W8","W9","WA","WB","WC","WH","WO","WR","WS","WT","WU","WW","ZZ" });
		}
	}
	public class E_0427 : MapSimpleDataElement
	{
		public E_0427()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0429 : MapSimpleDataElement
	{
		public E_0429()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 16;
		}
	}
	public class E_0432 : MapSimpleDataElement
	{
		public E_0432()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","67","68","69","70","71","72","73","74","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","98","99","AA","AB","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","CA","CB","CE","CL","EP","KA","LA","LC","LD","LP","PE","SE","TA","TR" });
		}
	}
	public class E_0433 : MapSimpleDataElement
	{
		public E_0433()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04" });
		}
	}
	public class E_0434 : MapSimpleDataElement
	{
		public E_0434()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0436 : MapSimpleDataElement
	{
		public E_0436()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BR","DR","GR","OP","RR","TP" });
		}
	}
	public class E_0437 : MapSimpleDataElement
	{
		public E_0437()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "M" });
		}
	}
	public class E_0438 : MapSimpleDataElement
	{
		public E_0438()
		{
			DataType = DataType.AN;
			MinLength = 12;
			MaxLength = 12;
		}
	}
	public class E_0439 : MapSimpleDataElement
	{
		public E_0439()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 16;
		}
	}
	public class E_0440 : MapSimpleDataElement
	{
		public E_0440()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 16;
		}
	}
	public class E_0441 : MapSimpleDataElement
	{
		public E_0441()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X" });
		}
	}
	public class E_0442 : MapSimpleDataElement
	{
		public E_0442()
		{
			DataType = DataType.AN;
			MinLength = 16;
			MaxLength = 16;
		}
	}
	public class E_0443 : MapSimpleDataElement
	{
		public E_0443()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_0444 : MapSimpleDataElement
	{
		public E_0444()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AQ","BO","BX","NS","SA","SX" });
		}
	}
	public class E_0445 : MapSimpleDataElement
	{
		public E_0445()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "DF","DG","DN","EB","GS","IP","NI","PS","SP","ZZ" });
		}
	}
	public class E_0446 : MapSimpleDataElement
	{
		public E_0446()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0447 : MapSimpleDataElement
	{
		public E_0447()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0448 : MapSimpleDataElement
	{
		public E_0448()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16" });
		}
	}
	public class E_0449 : MapSimpleDataElement
	{
		public E_0449()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 80;
		}
	}
	public class E_0451 : MapSimpleDataElement
	{
		public E_0451()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0452 : MapSimpleDataElement
	{
		public E_0452()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0455 : MapSimpleDataElement
	{
		public E_0455()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "T","X" });
		}
	}
	public class E_0456 : MapSimpleDataElement
	{
		public E_0456()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04" });
		}
	}
	public class E_0458 : MapSimpleDataElement
	{
		public E_0458()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 25;
		}
	}
	public class E_0459 : MapSimpleDataElement
	{
		public E_0459()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 30;
		}
	}
	public class E_0460 : MapSimpleDataElement
	{
		public E_0460()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","D","E","F","G","H","M","N","O","R","S","T" });
		}
	}
	public class E_0461 : MapSimpleDataElement
	{
		public E_0461()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "X","XX","XXX" });
		}
	}
	public class E_0462 : MapSimpleDataElement
	{
		public E_0462()
		{
			DataType = DataType.N2;
			MinLength = 2;
			MaxLength = 4;
		}
	}
	public class E_0463 : MapSimpleDataElement
	{
		public E_0463()
		{
			DataType = DataType.N2;
			MinLength = 2;
			MaxLength = 4;
		}
	}
	public class E_0464 : MapSimpleDataElement
	{
		public E_0464()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_0465 : MapSimpleDataElement
	{
		public E_0465()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "I" });
		}
	}
	public class E_0466 : MapSimpleDataElement
	{
		public E_0466()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0467 : MapSimpleDataElement
	{
		public E_0467()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0468 : MapSimpleDataElement
	{
		public E_0468()
		{
			DataType = DataType.N0;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_0470 : MapSimpleDataElement
	{
		public E_0470()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0471 : MapSimpleDataElement
	{
		public E_0471()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0472 : MapSimpleDataElement
	{
		public E_0472()
		{
			DataType = DataType.N0;
			MinLength = 6;
			MaxLength = 6;
		}
	}
	public class E_0473 : MapSimpleDataElement
	{
		public E_0473()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","C","D","E","F","G","L","N","R","S","T","X" });
		}
	}
	public class E_0474 : MapSimpleDataElement
	{
		public E_0474()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 22;
		}
	}
	public class E_0475 : MapSimpleDataElement
	{
		public E_0475()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 22;
		}
	}
	public class E_0477 : MapSimpleDataElement
	{
		public E_0477()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0478 : MapSimpleDataElement
	{
		public E_0478()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","D" });
		}
	}
	public class E_0479 : MapSimpleDataElement
	{
		public E_0479()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AD","AF","AG","AH","AI","AK","AL","AN","AO","AR","AS","AT","AW","BC","BE","BF","BL","BS","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CM","CN","CO","CP","CR","CS","CT","CV","D3","D4","D5","DA","DD","DF","DI","DM","DS","DX","EC","ED","EF","EI","ER","ES","EV","EX","FA","FB","FC","FG","FH","FR","FT","GA","GB","GC","GE","GF","GL","GP","GR","GT","HB","HC","HI","HN","HP","HR","HS","IA","IB","IC","ID","IE","IG","II","IJ","IL","IM","IN","IO","IP","IR","IS","KM","LA","LB","LI","LN","LR","LS","LT","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","ML","MM","MN","MO","MP","MQ","MR","MS","MT","MV","MW","MX","MY","NC","NL","NP","NT","OC","OG","OR","OW","PA","PB","PC","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PQ","PR","PS","PT","PU","PV","PY","PZ","QA","QG","QM","QO","QW","RA","RB","RC","RD","RE","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RQ","RR","RS","RT","RU","RV","RW","RX","RY","RZ","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SL","SM","SN","SO","SP","SQ","SR","SS","ST","SU","SV","SW","TA","TC","TD","TF","TI","TM","TN","TO","TP","TR","TS","TT","TX","UA","UB","UC","UD","UI","UP","UW","VA","VB","VC","VD","VE","VH","VI","VS","WA","WB","WG","WI","WL","WR","WT" });
		}
	}
	public class E_0480 : MapSimpleDataElement
	{
		public E_0480()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0481 : MapSimpleDataElement
	{
		public E_0481()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_0482 : MapSimpleDataElement
	{
		public E_0482()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AJ","ER","FL","NS","PA","PI","PO","PP","PR" });
		}
	}
	public class E_0483 : MapSimpleDataElement
	{
		public E_0483()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "I","S","T","U","V" });
		}
	}
	public class E_0484 : MapSimpleDataElement
	{
		public E_0484()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","N","P" });
		}
	}
	public class E_0485 : MapSimpleDataElement
	{
		public E_0485()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_0486 : MapSimpleDataElement
	{
		public E_0486()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AI","AO","CD","DC","DM","MD","TI","TO" });
		}
	}
	public class E_0487 : MapSimpleDataElement
	{
		public E_0487()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","D","F","I","R" });
		}
	}
	public class E_0488 : MapSimpleDataElement
	{
		public E_0488()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0489 : MapSimpleDataElement
	{
		public E_0489()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0490 : MapSimpleDataElement
	{
		public E_0490()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0491 : MapSimpleDataElement
	{
		public E_0491()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","C","S" });
		}
	}
	public class E_0492 : MapSimpleDataElement
	{
		public E_0492()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0493 : MapSimpleDataElement
	{
		public E_0493()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0495 : MapSimpleDataElement
	{
		public E_0495()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0496 : MapSimpleDataElement
	{
		public E_0496()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0497 : MapSimpleDataElement
	{
		public E_0497()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0498 : MapSimpleDataElement
	{
		public E_0498()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_0499 : MapSimpleDataElement
	{
		public E_0499()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0500 : MapSimpleDataElement
	{
		public E_0500()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0501 : MapSimpleDataElement
	{
		public E_0501()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "10","14","15","16","17","20","24","25","26","27","30","34","35","36","37","90" });
		}
	}
	public class E_0502 : MapSimpleDataElement
	{
		public E_0502()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0503 : MapSimpleDataElement
	{
		public E_0503()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_0504 : MapSimpleDataElement
	{
		public E_0504()
		{
			DataType = DataType.N2;
			MinLength = 2;
			MaxLength = 9;
		}
	}
	public class E_0505 : MapSimpleDataElement
	{
		public E_0505()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 80;
		}
	}
	public class E_0506 : MapSimpleDataElement
	{
		public E_0506()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","ZZ" });
		}
	}
	public class E_0507 : MapSimpleDataElement
	{
		public E_0507()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 12;
		}
	}
	public class E_0508 : MapSimpleDataElement
	{
		public E_0508()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 35;
		}
	}
	public class E_0509 : MapSimpleDataElement
	{
		public E_0509()
		{
			DataType = DataType.AN;
			MinLength = 10;
			MaxLength = 10;
		}
	}
	public class E_0510 : MapSimpleDataElement
	{
		public E_0510()
		{
			DataType = DataType.AN;
			MinLength = 9;
			MaxLength = 9;
		}
	}
	public class E_0511 : MapSimpleDataElement
	{
		public E_0511()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","C","D","E","F","G","H","I","X" });
		}
	}
	public class E_0512 : MapSimpleDataElement
	{
		public E_0512()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","E","I","N" });
		}
	}
	public class E_0514 : MapSimpleDataElement
	{
		public E_0514()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","F","J","K","N","O","P","R","S","X","Y" });
		}
	}
	public class E_0515 : MapSimpleDataElement
	{
		public E_0515()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0516 : MapSimpleDataElement
	{
		public E_0516()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4" });
		}
	}
	public class E_0517 : MapSimpleDataElement
	{
		public E_0517()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 5;
		}
	}
	public class E_0518 : MapSimpleDataElement
	{
		public E_0518()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 11;
		}
	}
	public class E_0519 : MapSimpleDataElement
	{
		public E_0519()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","A","D","H","O" });
		}
	}
	public class E_0521 : MapSimpleDataElement
	{
		public E_0521()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","CC","CO","CS","DL","DS","FG","GD","GP","GR","IA","IB","OF","ON","OT","PA","PB","PL","PM","PO","PP","RA","RB","RC","RP","RT","RU","RV","SA","SC","SD","SH","SM","SS","SU","TD","WL" });
		}
	}
	public class E_0522 : MapSimpleDataElement
	{
		public E_0522()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","0A","0B","0C","0D","0E","0F","0G","0H","0I","0J","0K","0L","0M","0N","0P","0Q","0R","0S","0T","0U","1","10","11","12","13","14","15","16","17","18","19","1A","1B","1C","1D","1E","1F","1G","1H","1J","1K","1L","1M","1N","1P","1Q","1R","1S","1T","1U","1V","1W","1X","1Y","1Z","2","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2D","2E","2F","2G","2H","2I","2J","2K","2L","2M","2N","2P","2Q","2R","2S","2T","2U","2V","2W","2X","2Y","2Z","3","30","31","32","33","34","35","36","37","38","39","3A","3B","3C","3D","3E","3F","3G","3H","3I","3J","3K","3L","3M","3N","3O","3P","3Q","3R","3S","3T","3U","3V","3W","3X","3Y","3Z","4","40","41","42","43","44","45","46","47","48","49","4A","4B","4C","4D","4E","4F","4G","4H","4I","4J","4K","4L","4M","4N","4O","4P","4Q","4R","4S","4T","4U","4V","4W","4X","4Y","4Z","5","50","51","52","53","54","55","56","57","58","59","5A","5B","5C","5D","5E","5F","5G","5H","5I","5J","5K","5L","5M","5N","5O","5P","5Q","5R","5S","5T","5U","5V","5W","5X","5Y","5Z","6","60","61","62","63","64","65","66","67","68","69","6A","6B","6C","6D","6E","6F","6G","6H","6I","6J","6K","6L","6M","6N","6O","6P","6Q","6R","6S","6T","6U","6V","6W","6X","6Y","6Z","7","70","71","72","73","74","75","76","77","78","79","7A","7B","7C","7D","7E","7F","7G","7H","7I","7J","7K","7L","7M","7N","7O","7P","7Q","7R","7S","7T","7U","7V","7W","7X","7Y","7Z","8","80","81","82","83","84","85","86","87","88","89","8A","8B","8C","8D","8E","8F","8G","8H","8I","8J","8K","8L","8M","8N","8O","8P","8Q","8R","8S","8T","8U","8V","8W","8X","8Y","8Z","9","90","91","92","93","94","95","96","97","98","99","9A","9B","9C","9D","9E","9F","9G","9H","9I","9J","9K","9L","9M","9N","9O","9P","9Q","9R","9S","9T","9U","9V","9W","9X","9Y","9Z","A","A0","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AAA","AAB","AAC","AAD","AAE","AAF","AAG","AAH","AAI","AAJ","AAK","AAL","AAM","AAN","AAO","AAP","AAQ","AAR","AAS","AAT","AAU","AAV","AAW","AAX","AAY","AAZ","AB","ABA","ABB","ABC","ABD","ABE","ABF","ABG","ABH","ABI","ABJ","ABK","ABL","ABM","ABN","ABO","ABP","ABQ","ABR","ABS","ABT","ABU","ABV","ABW","ABX","ABY","ABZ","AC","ACA","ACB","ACC","ACD","ACE","ACF","ACG","ACH","ACI","ACJ","ACK","ACL","ACM","ACN","ACO","ACP","ACQ","ACR","ACS","ACT","ACU","ACV","ACW","ACX","ACY","ACZ","AD","ADA","ADB","ADC","ADD","ADE","ADF","ADG","ADH","ADI","ADJ","ADK","ADL","ADM","ADN","ADO","ADP","ADQ","ADR","ADS","ADT","ADW","ADX","ADY","ADZ","AE","AEB","AEC","AED","AEE","AEF","AEG","AEH","AEI","AEJ","AEK","AEL","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AVE","AW","AX","AY","AZ","B","B0","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BAA","BAB","BAC","BAD","BAE","BAF","BAG","BAH","BAI","BAJ","BAK","BAL","BAM","BAN","BAO","BAP","BAQ","BAR","BAS","BAT","BAU","BAV","BAW","BAX","BAY","BAZ","BB","BBA","BBB","BBC","BBD","BBE","BBF","BBG","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","C","C0","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ","D","D0","D1","D2","D3","D4","D5","D6","D7","D8","D9","DA","DB","DC","DD","DE","DF","DG","DH","DI","DJ","DK","DL","DM","DN","DO","DP","DQ","DR","DS","DT","DU","DV","DW","DX","DY","DZ","E","E0","E1","E2","E3","E4","E5","E6","E7","E8","E9","EA","EB","EC","ED","EE","EF","EG","EH","EI","EJ","EK","EL","EM","EN","EO","EP","EQ","ER","ES","ET","EU","EV","EW","EX","EY","EZ","F","F0","F1","F2","F3","F4","F5","F6","F7","F8","F9","FA","FB","FBA","FC","FD","FE","FF","FG","FH","FI","FJ","FK","FL","FM","FN","FO","FP","FQ","FR","FS","FT","FU","FV","FW","FX","FY","FZ","G","G0","G1","G2","G3","G4","G5","G6","G7","G8","G9","GA","GB","GC","GD","GE","GF","GG","GH","GI","GJ","GK","GL","GM","GN","GO","GP","GQ","GR","GS","GT","GU","GV","GW","GX","GY","GZ","H","H0","H1","H2","H3","H4","H5","H6","H7","H8","H9","HA","HB","HC","HD","HE","HF","HG","HH","HI","HJ","HK","HL","HM","HN","HO","HP","HQ","HR","HS","HT","HU","HV","HW","HX","HY","HZ","I","I0","I1","I2","I3","I4","I5","I6","I7","I8","I9","IA","IB","IC","ID","IE","IF","IG","IH","II","IJ","IK","IL","IM","IN","IO","IP","IQ","IR","IS","IT","IU","IV","IW","IX","IY","IZ","J","J0","J1","J2","J3","J4","J5","J6","J7","J8","J9","JA","JB","JC","JD","JE","JF","JG","JH","JI","JJ","JK","JL","JM","JN","JO","JP","JQ","JR","JS","JT","JU","JV","JW","JX","JY","JZ","K","K0","K1","K2","K3","K4","K5","K6","K7","K8","K9","KA","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KN","KO","KP","KQ","KR","KS","KT","KU","KV","KW","KX","KY","KZ","L","L0","L1","L2","L3","L4","L5","L6","L7","L8","L9","LA","LB","LC","LD","LE","LF","LG","LH","LI","LJ","LK","LL","LM","LN","LO","LOW","LP","LQ","LR","LS","LT","LU","LV","LW","LX","LY","LZ","M","M0","M1","M2","M3","M4","M5","M6","M7","M8","M9","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","ML","MM","MN","MO","MP","MQ","MR","MS","MT","MU","MV","MW","MX","MY","MZ","N","N0","N1","N2","N3","N4","N5","N6","N7","N8","N9","NA","NB","NC","ND","NE","NF","NG","NH","NI","NJ","NK","NL","NM","NN","NO","NP","NQ","NR","NS","NT","NU","NV","NW","NX","NY","NZ","O","O0","O1","O2","O3","O4","O5","O6","O7","O8","O9","OA","OB","OC","OD","OE","OF","OG","OH","OI","OJ","OK","OL","OM","ON","OO","OP","OQ","OR","OS","OT","OU","OV","OW","OX","OY","OZ","P","P0","P1","P2","P3","P4","P5","P6","P7","P8","P9","PA","PB","PC","PCC","PCS","PCV","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PW","PX","PY","PZ","Q","Q0","Q1","Q2","Q3","Q4","Q5","Q6","Q7","Q8","Q9","QA","QB","QC","QD","QE","QF","QG","QH","QI","QJ","QK","QL","QM","QN","QO","QP","QQ","QR","QS","QT","QU","QV","QW","QX","QY","QZ","R","R0","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RD","RE","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RQ","RR","RS","RT","RU","RV","RW","RX","RY","RZ","S","S0","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SK","SL","SM","SN","SO","SOF","SP","SQ","SR","SS","ST","SU","SV","SW","SX","SY","SZ","T","T0","T1","T2","T3","T4","T5","T6","T7","T8","T9","TA","TB","TC","TD","TE","TF","TG","TH","TI","TJ","TK","TL","TM","TN","TO","TP","TQ","TR","TS","TT","TU","TW","TX","TY","TZ","U","U0","U1","U2","U3","U4","U5","U6","U7","U8","U9","UA","UB","UC","UD","UE","UF","UG","UH","UI","UJ","UK","UL","UM","UN","UO","UP","UPF","UQ","UR","US","UT","UU","UV","UW","UX","UY","UZ","V","V0","V1","V2","V3","V4","V5","V6","V7","V8","V9","VA","VB","VC","VD","VE","VES","VF","VG","VH","VI","VJ","VK","VL","VM","VN","VO","VP","VQ","VR","VS","VT","VU","VV","VW","VX","VY","VZ","W","W0","W1","W2","W3","W4","W5","W6","W7","W8","W9","WA","WB","WC","WD","WE","WF","WG","WH","WI","WJ","WK","WL","WM","WN","WO","WP","WQ","WR","WS","WT","WU","WV","WW","WX","WY","WZ","X","X0","X1","X2","X3","X4","X5","X6","X7","X8","X9","XA","XB","XC","XD","XE","XF","XG","XH","XI","XJ","XK","XL","XM","XN","XO","XP","XQ","XR","XS","XT","XU","XV","XW","XX","XY","XZ","Y","Y1","Y2","Y3","Y4","Y5","Y6","Y7","Y8","Y9","YA","YB","YC","YD","YE","YF","YG","YH","YI","YJ","YK","YL","YM","YN","YO","YQ","YR","YS","YT","YU","YV","YW","YX","YY","YZ","Z","Z0","Z1","Z2","Z3","Z4","Z5","Z6","Z7","Z8","Z9","ZA","ZB","ZC","ZD","ZE","ZF","ZG","ZH","ZI","ZJ","ZK","ZL","ZM","ZN","ZO","ZP","ZQ","ZR","ZS","ZT","ZU","ZV","ZW","ZX","ZY","ZZ" });
		}
	}
	public class E_0529 : MapSimpleDataElement
	{
		public E_0529()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AD","AJ","BO","CM","DM","DP","DU","IT","PA","QU","RC","RD","RE","RT","SA","WH" });
		}
	}
	public class E_0531 : MapSimpleDataElement
	{
		public E_0531()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0533 : MapSimpleDataElement
	{
		public E_0533()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","N","P","S" });
		}
	}
	public class E_0534 : MapSimpleDataElement
	{
		public E_0534()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CO","IC","IP","ML","RO","SD","SU" });
		}
	}
	public class E_0535 : MapSimpleDataElement
	{
		public E_0535()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","S","T" });
		}
	}
	public class E_0536 : MapSimpleDataElement
	{
		public E_0536()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "99","CA","CN","DE","FR","HT","PO","RD","RO","SH","TH","VS","WA" });
		}
	}
	public class E_0537 : MapSimpleDataElement
	{
		public E_0537()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","R" });
		}
	}
	public class E_0538 : MapSimpleDataElement
	{
		public E_0538()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "DS","LA","MA","PR","RC","RE","RL","SA","TR" });
		}
	}
	public class E_0539 : MapSimpleDataElement
	{
		public E_0539()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 25;
		}
	}
	public class E_0540 : MapSimpleDataElement
	{
		public E_0540()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0541 : MapSimpleDataElement
	{
		public E_0541()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0542 : MapSimpleDataElement
	{
		public E_0542()
		{
			DataType = DataType.N1;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0543 : MapSimpleDataElement
	{
		public E_0543()
		{
			DataType = DataType.N2;
			MinLength = 3;
			MaxLength = 6;
		}
	}
	public class E_0544 : MapSimpleDataElement
	{
		public E_0544()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "D","N" });
		}
	}
	public class E_0545 : MapSimpleDataElement
	{
		public E_0545()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_0546 : MapSimpleDataElement
	{
		public E_0546()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","44","45","46","47","48","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","AA","AB","AC","AD","AR","C1","C2","C3","CC","CD","CE","CF","CH","CI","CL","CO","CR","CT","DC","DN","DS","EF","ES","EW","EX","F0","F1","F2","F3","F4","F5","F6","F7","F8","F9","FL","FP","FT","FX","IA","LA","MT","NA","NP","NR","NT","OF","OH","PD","PF","PM","PP","PR","PW","RA","RC","RE","RQ","RS","RV","SP","SR","SS","SU","UT","WD","WI","WP" });
		}
	}
	public class E_0547 : MapSimpleDataElement
	{
		public E_0547()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","J","K","L","M","N","P","Q","S","W","X" });
		}
	}
	public class E_0548 : MapSimpleDataElement
	{
		public E_0548()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AOG","CAC","CCD","CDC","CDI","CFO","CFT","CIB","CIC","CNG","CNL","CSD","CSO","CSR","CTA","DAM","DDO","DMN","DNH","DNI","DNR","DNS","DOA","DPS","DSA","DUP","FIS","GSA","GWL","IAW","ICC","INC","INF","MAN","MDD","NCA","NCR","NDI","NFT","NLI","NNI","NRC","OCC","OTH","RAC","RAD","RUC","RUD","SMA","SNA","SRD","SRE","VDC","VDD","VDI","VDQ","VDS","VIS","VRP" });
		}
	}
	public class E_0550 : MapSimpleDataElement
	{
		public E_0550()
		{
			DataType = DataType.N2;
			MinLength = 3;
			MaxLength = 6;
		}
	}
	public class E_0551 : MapSimpleDataElement
	{
		public E_0551()
		{
			DataType = DataType.N2;
			MinLength = 2;
			MaxLength = 15;
		}
	}
	public class E_0552 : MapSimpleDataElement
	{
		public E_0552()
		{
			DataType = DataType.N2;
			MinLength = 3;
			MaxLength = 15;
		}
	}
	public class E_0553 : MapSimpleDataElement
	{
		public E_0553()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0554 : MapSimpleDataElement
	{
		public E_0554()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0555 : MapSimpleDataElement
	{
		public E_0555()
		{
			DataType = DataType.AN;
			MinLength = 5;
			MaxLength = 6;
		}
	}
	public class E_0556 : MapSimpleDataElement
	{
		public E_0556()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0557 : MapSimpleDataElement
	{
		public E_0557()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 16;
		}
	}
	public class E_0558 : MapSimpleDataElement
	{
		public E_0558()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","N","R","U" });
		}
	}
	public class E_0559 : MapSimpleDataElement
	{
		public E_0559()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","93","94","A1","A2","A3","A4","AA","AB","AC","AD","AE","AG","AH","AI","AJ","AL","AM","AP","AQ","AS","AT","AW","AX","AY","BE","BF","BI","CA","CB","CC","CE","CI","CL","CM","CO","CR","CS","CU","CX","DA","DD","DE","DF","DI","DL","DN","DO","DR","DS","DX","DY","DZ","EI","EP","ES","ET","EU","EX","FA","FC","FD","FG","FH","FI","GC","GS","GU","HC","HI","HS","HU","IA","IB","IC","IM","IN","IS","JA","LA","LB","LI","MA","MB","MC","ME","MI","MP","MS","MV","NA","NB","NC","NE","NF","NG","NI","NR","NS","NT","NU","NW","OI","OP","OS","PA","PC","SA","SE","SL","SP","ST","TA","TB","TC","TD","TI","TM","TP","TR","TX","UC","UN","VI","WH","ZZ" });
		}
	}
	public class E_0560 : MapSimpleDataElement
	{
		public E_0560()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 10;
			AllowedValues.AddRange(new[] { "A0010","A0020","A0030","AC","AD","AF","AG","AM","AO","B0020","B0040","BH","BI","BOP","C0012","C0032","C0036","C0038","C1","C2","CA","CC","CD","CH","CI","CM","CN","CO","CS","CT","CU","CY","CZ","D0020","D0024","D0031","D0032","D1","D2","DA","DE","DH","DI","DL","DS","DV","E0030","EG","EM","EN","ER","EU","EX","F1","FG","FS","G0010","G0052","GI","GP","GU","H1","HC","HH","HS","I0012","I0013","I0021","I0022","IC","ID","IG","IK","IL","IM","IN","IO","IP","IQ","IR","IS","IT","KO","L1","LA","LL","LS","M0010","M0042","MI","ML","MNTAN","MNTMN","MNTON","N0020","N0021","N0032","NC","OA","ON","OP","P0012","P0014","P0016","P0018","P0022","PA","PB","PC","PE","PF","PL","PLI","PM","PO","PP","PSF","R0072","R0076","R0077","R0110","RD","RE","RM","RP","S0014","S0016","S0022","S0024","S0050","S0052","S0054","S0056","S0080","S1","S2","S3","SD","SG","SH","SJ","SLP","SPI","SR","SS","ST","SU","SV","SW","T0070","T1","TC","TE","TH","TM","TO","UN","US","V1","V2","W0010","WC","WH","X0010","XP","XX","YY","ZZ" });
		}
	}
	public class E_0561 : MapSimpleDataElement
	{
		public E_0561()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 45;
		}
	}
	public class E_0562 : MapSimpleDataElement
	{
		public E_0562()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","AB","AC","AD","AE","AR","B","BL","BO","CB","CR","D","DR","DT","E","ES","F","G","I","IN","O","OI","OT","P","PA","PO","RF","RR","RS","SA","SP","SR","T","TR","UA","UT","VA","W" });
		}
	}
	public class E_0563 : MapSimpleDataElement
	{
		public E_0563()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "8A","AI","AS","B","BC","BK","C","D","E","EI","F","FT","GS","IP","IS","K","LS","MY","N","NS","O","P","P2","P3","P4","Q","QB","QE","QI","QM","QP","R","S","SC","SE","SF","SG","SI","SP","SQ","SS","ST","SU","SV","SW","T","UC","UL","UP","W","WY","Y","YI","Z" });
		}
	}
	public class E_0566 : MapSimpleDataElement
	{
		public E_0566()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","B0","B1","B2","B3","B4","X","Y","ZZ" });
		}
	}
	public class E_0567 : MapSimpleDataElement
	{
		public E_0567()
		{
			DataType = DataType.N0;
			MinLength = 4;
			MaxLength = 5;
		}
	}
	public class E_0568 : MapSimpleDataElement
	{
		public E_0568()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "ABS","DMR","IND","NON","PUR","SCP","STD" });
		}
	}
	public class E_0569 : MapSimpleDataElement
	{
		public E_0569()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "01","03","05","06","07","08","1","10","11","12","13","14","2","3","AG","ALC","ANN","AP","BA","CB","CC","CDM","CDS","CM","CRU","DA","DC","EC","EPC","LTD","MUT","PRI","RD","REL","RS","SG","SKA","Z","ZB1","ZB2" });
		}
	}
	public class E_0570 : MapSimpleDataElement
	{
		public E_0570()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "P","R" });
		}
	}
	public class E_0571 : MapSimpleDataElement
	{
		public E_0571()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","M" });
		}
	}
	public class E_0572 : MapSimpleDataElement
	{
		public E_0572()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "D","F","I","S","W" });
		}
	}
	public class E_0573 : MapSimpleDataElement
	{
		public E_0573()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0574 : MapSimpleDataElement
	{
		public E_0574()
		{
			DataType = DataType.AN;
			MinLength = 14;
			MaxLength = 14;
		}
	}
	public class E_0575 : MapSimpleDataElement
	{
		public E_0575()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "S" });
		}
	}
	public class E_0576 : MapSimpleDataElement
	{
		public E_0576()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 12;
		}
	}
	public class E_0577 : MapSimpleDataElement
	{
		public E_0577()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0578 : MapSimpleDataElement
	{
		public E_0578()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AG","AH","AI","AJ","AK","AL","D","E","L","O","W" });
		}
	}
	public class E_0579 : MapSimpleDataElement
	{
		public E_0579()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","J","L","P","R","S","T","Y" });
		}
	}
	public class E_0580 : MapSimpleDataElement
	{
		public E_0580()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","D","N","R","S" });
		}
	}
	public class E_0581 : MapSimpleDataElement
	{
		public E_0581()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0582 : MapSimpleDataElement
	{
		public E_0582()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "00","01","10","11","12","13","14","15","16","17","18","19","20" });
		}
	}
	public class E_0583 : MapSimpleDataElement
	{
		public E_0583()
		{
			DataType = DataType.AN;
			MinLength = 6;
			MaxLength = 10;
		}
	}
	public class E_0584 : MapSimpleDataElement
	{
		public E_0584()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AE","AF","AG","AH","AO","AP","AU","CA","CO","CT","DC","DD","DI","DQ","DR","DS","FA","FB","FC","FO","FT","HD","IA","IR","L1","LA","LE","LF","LM","LS","LU","LW","LX","NE","OS","OT","PA","PE","PT","PV","PW","RA","RB","RC","RD","RE","RI","RM","RP","RT","RU","RW","SA","SB","SE","SL","SU","TE","TF","TM","TP","TR","UK","VO","ZZ" });
		}
	}
	public class E_0585 : MapSimpleDataElement
	{
		public E_0585()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AB","AL","CL","DH","GU","HO","JD","LO","MC","ML","MO","OP","PD","RD","RF","SD","SU","VC","WK" });
		}
	}
	public class E_0586 : MapSimpleDataElement
	{
		public E_0586()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 45;
		}
	}
	public class E_0587 : MapSimpleDataElement
	{
		public E_0587()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AC","AD","AE","AH","AK","AP","AT","NA","RD","RF","RJ","RN","RO","RV","ZZ" });
		}
	}
	public class E_0589 : MapSimpleDataElement
	{
		public E_0589()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0590 : MapSimpleDataElement
	{
		public E_0590()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2" });
		}
	}
	public class E_0591 : MapSimpleDataElement
	{
		public E_0591()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "ACH","BKW","BOP","CAS","CCC","CCF","CCH","CDA","CHK","CLH","CPC","CWT","DCC","DCD","DDP","DEB","DLC","DLD","DPC","DPD","DXC","DXD","DYC","DYD","DZC","DZD","EBX","EXC","FEW","FWT","NON","PAC","PBD","PDC","PDD","PDE","PRO","REV","SCC","SCD","SDC","SDD","SPC","SPD","SWT","SXC","SXD","SYC","SZC","SZD","TRA","VIS","X12","ZZZ" });
		}
	}
	public class E_0592 : MapSimpleDataElement
	{
		public E_0592()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","C","D","E","I","L","P" });
		}
	}
	public class E_0594 : MapSimpleDataElement
	{
		public E_0594()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","B","C","H","Q","S","U","Z" });
		}
	}
	public class E_0595 : MapSimpleDataElement
	{
		public E_0595()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6" });
		}
	}
	public class E_0597 : MapSimpleDataElement
	{
		public E_0597()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0598 : MapSimpleDataElement
	{
		public E_0598()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0599 : MapSimpleDataElement
	{
		public E_0599()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "BAG","BBL","BDL","BIC","BIN","BKT","BLE","BOX","BSK","CAN","CAR","CAS","CBC","CBY","CCS","CHS","CNT","COL","COR","CRT","CSK","CTN","CYL","DBK","DRM","GAL","HED","HMP","KEG","LBK","LOG","LUG","LVN","PAL","PCL","PCS","PKG","PLT","POV","QTR","REL","ROL","SAK","SHT","SID","SKD","TBE","TBN","TIN","TNK","UNT","VPK","WDC" });
		}
	}
	public class E_0600 : MapSimpleDataElement
	{
		public E_0600()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 17;
		}
	}
	public class E_0601 : MapSimpleDataElement
	{
		public E_0601()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0602 : MapSimpleDataElement
	{
		public E_0602()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 8;
		}
	}
	public class E_0603 : MapSimpleDataElement
	{
		public E_0603()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 25;
		}
	}
	public class E_0604 : MapSimpleDataElement
	{
		public E_0604()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","N","W" });
		}
	}
	public class E_0605 : MapSimpleDataElement
	{
		public E_0605()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4" });
		}
	}
	public class E_0607 : MapSimpleDataElement
	{
		public E_0607()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0608 : MapSimpleDataElement
	{
		public E_0608()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","ZZ" });
		}
	}
	public class E_0609 : MapSimpleDataElement
	{
		public E_0609()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0610 : MapSimpleDataElement
	{
		public E_0610()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0611 : MapSimpleDataElement
	{
		public E_0611()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","18","19","20","21","22","23","24","25","26","ZZ" });
		}
	}
	public class E_0612 : MapSimpleDataElement
	{
		public E_0612()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","Z" });
		}
	}
	public class E_0613 : MapSimpleDataElement
	{
		public E_0613()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 16;
		}
	}
	public class E_0614 : MapSimpleDataElement
	{
		public E_0614()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0615 : MapSimpleDataElement
	{
		public E_0615()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","31","32","33","34","35","36","4","5","6","7","8","Z" });
		}
	}
	public class E_0616 : MapSimpleDataElement
	{
		public E_0616()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0617 : MapSimpleDataElement
	{
		public E_0617()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AI","BE","BO","CR","DC","HF","HT","IP","NO","NU","OS","PL","PU","RE","SB","TR","TS","WG" });
		}
	}
	public class E_0619 : MapSimpleDataElement
	{
		public E_0619()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0620 : MapSimpleDataElement
	{
		public E_0620()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0621 : MapSimpleDataElement
	{
		public E_0621()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0622 : MapSimpleDataElement
	{
		public E_0622()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0623 : MapSimpleDataElement
	{
		public E_0623()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","AD","AS","AT","CD","CS","CT","ED","ES","ET","GM","HD","HS","HT","LT","MD","MS","MT","ND","NS","NT","PD","PS","PT","TD","TS","TT","UT" });
		}
	}
	public class E_0625 : MapSimpleDataElement
	{
		public E_0625()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4" });
		}
	}
	public class E_0626 : MapSimpleDataElement
	{
		public E_0626()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","P","R","T","U","V","W","X","Y","ZZ" });
		}
	}
	public class E_0627 : MapSimpleDataElement
	{
		public E_0627()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","S","X","Z" });
		}
	}
	public class E_0628 : MapSimpleDataElement
	{
		public E_0628()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0629 : MapSimpleDataElement
	{
		public E_0629()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","L","N","P","S" });
		}
	}
	public class E_0630 : MapSimpleDataElement
	{
		public E_0630()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0631 : MapSimpleDataElement
	{
		public E_0631()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0632 : MapSimpleDataElement
	{
		public E_0632()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","D","E","F","L","M","N","P","R","S","T" });
		}
	}
	public class E_0633 : MapSimpleDataElement
	{
		public E_0633()
		{
			DataType = DataType.N1;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0634 : MapSimpleDataElement
	{
		public E_0634()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0635 : MapSimpleDataElement
	{
		public E_0635()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5","6","9","A","C","D","F","G","H","I","P","Q","S","T","W" });
		}
	}
	public class E_0637 : MapSimpleDataElement
	{
		public E_0637()
		{
			DataType = DataType.N4;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0638 : MapSimpleDataElement
	{
		public E_0638()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0639 : MapSimpleDataElement
	{
		public E_0639()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AP","AW","BD","BR","BW","CA","CP","CR","CT","DI","DP","DR","DS","EC","EH","ES","FB","FO","FX","HF","HP","HT","KA","KP","KR","LC","LD","LE","LM","LR","ME","ML","NC","NE","NQ","NS","NT","PA","PB","PD","PE","PF","PG","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PU","PV","PY","QE","QH","QR","QS","QT","RC","RD","RE","RM","RS","RT","SA","SC","SM","SR","ST","SW","TB","TC","TD","TE","TF","TM","TP","TT","UM","VQ","WC","WD","WE","WH","WI","WM" });
		}
	}
	public class E_0640 : MapSimpleDataElement
	{
		public E_0640()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","33","34","35","36","37","38","39","3M","40","41","60","62","63","64","65","66","67","68","69","6A","6C","6N","6R","6S","70","71","72","73","74","75","76","77","78","79","80","81","82","83","85","87","88","91","94","95","97","98","99","A0","A1","A3","A4","A5","A6","A7","AA","AB","AC","AD","AE","AF","AG","AI","AM","AN","AP","AQ","AR","AS","AT","AV","AW","AZ","BA","BB","BD","BF","BH","BJ","BK","BL","BM","BN","BO","BP","BR","BS","BT","BU","BV","BW","C0","C1","C2","C3","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CR","CS","CT","CU","CV","CW","CX","CY","CZ","D1","D4","DA","DB","DC","DD","DE","DF","DG","DH","DI","DK","DL","DN","DO","DP","DQ","DR","DS","DT","DU","EA","EB","EF","EI","EM","EP","ER","EX","FA","FB","FC","FD","FE","FF","FG","FI","FL","FM","FN","FP","FR","FS","FT","GA","GI","GR","HP","I1","IA","IB","IC","ID","IE","IF","II","IM","IN","IO","IR","IU","IW","IX","IZ","JM","JO","JR","JS","JU","JX","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KN","KS","KT","LC","LD","LE","LF","LN","LO","LP","LR","LV","M1","MA","MB","MC","MD","ME","MF","MI","ML","MM","MP","MR","MS","MU","N1","N2","N3","N4","N5","N6","N7","N8","NA","NB","NC","ND","NE","NF","NG","NH","NI","NJ","NK","NL","NM","NO","NP","NQ","NR","NT","NU","OC","OF","OP","OR","P1","PA","PB","PC","PD","PE","PF","PG","PI","PL","PM","PO","PP","PR","PS","PT","PU","PV","PW","PX","PZ","QA","QB","QC","QD","QE","QF","QG","QH","QJ","QK","QL","QP","QR","R1","R2","R3","R4","R5","R6","R7","R8","RA","RB","RC","RD","RE","RF","RG","RH","RK","RM","RP","RQ","RS","RT","RU","RZ","S1","S2","S3","S4","SA","SB","SC","SD","SE","SF","SG","SH","SL","SM","SO","SP","SQ","SR","SS","ST","SU","SV","TD","TG","TH","TI","TJ","TK","TP","TR","TS","TT","TX","U1","U2","U4","U5","U9","UA","UC","UD","UF","UI","UM","UO","UP","UR","UT","V1","VH","VJ","VL","VM","VN","VO","VP","VQ","VR","W1","W4","W5","WA","WC","WD","WH","WO","WS","WT","X1","XA","XB","XC","XD","XX","XY","XZ","YI","YR","ZA","ZB","ZC","ZD","ZE","ZF","ZG","ZH","ZI","ZJ","ZK","ZL","ZM","ZN","ZO","ZP","ZQ","ZR","ZS","ZT","ZU","ZW","ZZ" });
		}
	}
	public class E_0641 : MapSimpleDataElement
	{
		public E_0641()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "001","002","003","004","005","006","007","008","009","010","011","012","013","014","015","016","017","018","019","020","021","022","023","024","025","026","027","028","029","030","031","035","036","037","038","039","040","041","042","043","044","045","046","047","048","049","050","051","052","053","054","055","056","057","058","059","060","061","062","063","064","A01","A02","A03","A04","A05","A06","A07","A08","A09","A10","A11","A12","A13","A14","A15","A16","A17","A18","A19","A20","A21","A22","A23","A24","A25","A26","A27","A28","A29","A30","A31","A32","A33","A34","A36","A37","A38","A39","A40","A41","A42","A43","A45","A46","A49","A50","A51","A52","A53","A55","A58","A59","A61","A63","A64","A65","A73","A74","A75","A76","A77","A78","A79","A80","A81","A82","A83","A84","A85","A91","A95","A96","A98","A99","ABN","ACC","ACD","AFR","AGC","AGD","ANA","ANL","API","B01","B02","B03","B04","B05","B06","B07","B08","B09","B10","B11","B12","B13","B14","B15","B16","B17","B18","B19","B20","B21","B22","B23","B24","B25","B26","B27","B28","B29","B30","B31","B32","B33","B34","B35","B36","B37","B38","B39","B40","B41","B42","B43","B44","B45","B46","B47","B48","B49","B50","B51","B52","B53","B54","B55","B56","B57","BPR","BW2","BWL","BWT","BWW","C01","C02","C03","C04","C05","C06","C07","C08","C09","C10","C11","C12","C13","C14","C15","C16","C17","C18","C19","C20","CBD","CDE","CHA","CIE","CIM","CLA","CLP","CLR","COS","D01","D02","D03","D04","D05","D06","D07","D08","D09","D10","D11","D12","D13","D14","D15","D16","D17","D18","D19","D20","D21","D22","D23","D24","D25","D26","D27","D28","D29","D30","D31","D32","D33","D34","D50","D51","D52","D53","D54","D55","D56","D57","D58","D59","D60","D61","D62","D63","DEF","EB1","EB2","EB3","EB4","EB5","EB6","EB7","EB8","EB9","EBA","ENR","ERR","EXD","F73","F74","FCS","FRB","FZD","HIT","HZM","IBF","INC","INF","INP","INS","IOC","IRS","IV1","IV2","JOW","JVP","LIQ","LSH","MAS","MIN","MP2","MPL","MPT","MPW","MTC","NGP","NNM","NOR","NWD","P01","P02","P03","P04","P05","P06","P07","PAA","PAL","POA","REJ","RFM","RFR","RUN","S01","SCH","SFR","SGR","SOW","STM","T01","T02","T03","T04","T05","T06","T07","TDR","THT","TIL","TP2","TPL","TPT","TPW","UCD","UND","VAN","W01","W02","W03","W04","W05","W06","W07","W08","W09","W10","W11","W12","W13","W14","W15","W16","WAD","WLC","WLT","WLW","WTP","ZZZ" });
		}
	}
	public class E_0642 : MapSimpleDataElement
	{
		public E_0642()
		{
			DataType = DataType.N0;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_0643 : MapSimpleDataElement
	{
		public E_0643()
		{
			DataType = DataType.N2;
			MinLength = 2;
			MaxLength = 4;
		}
	}
	public class E_0644 : MapSimpleDataElement
	{
		public E_0644()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","M","O","S" });
		}
	}
	public class E_0645 : MapSimpleDataElement
	{
		public E_0645()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","Y" });
		}
	}
	public class E_0646 : MapSimpleDataElement
	{
		public E_0646()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0647 : MapSimpleDataElement
	{
		public E_0647()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "001","002","003","004","005","006","007","008","009","010","011","012","024","026","027","028","029","036","500","801","802","803","804","805","806","807","808","809","810","811","812","813","814","815","817","818","819","820","821","822","823","824","825","826","827","828","829","830","831","832","833","834","847","848","849","A","ASA","ASV","AVE","B","C","CAL","CHK","COV","CUR","D","DBL","DDT","DRC","DTE","DUP","E","F","G","H","HUG","HUL","I","ICA","ICG","IDC","IDN","IID","IMD","INC","INF","IPR","IQT","IWT","J","K","L","LOC","M","MA","MB","MBL","MC","MD","MDN","ME","MF","MG","MH","MI","MID","MJ","MK","ML","MM","MN","MP","MQ","MQT","MWT","N","NAU","NCL","NCR","NDP","NDT","NIF","NOC","NOD","NRA","O","OTH","P","PND","POI","PPD","PRM","Q","QTY","R","RAT","RTE","RTN","RU","S","SCA","SCD","SEV","SPL","STA","STP","STR","T","TRN","TYP","U","UAU","UCN","UKN","UNP","UNV","V","VIN","VND","VOS","ZDS","ZZZ" });
		}
	}
	public class E_0648 : MapSimpleDataElement
	{
		public E_0648()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "CSD","CSR","DIS","ILP","PSP","SEL" });
		}
	}
	public class E_0649 : MapSimpleDataElement
	{
		public E_0649()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0650 : MapSimpleDataElement
	{
		public E_0650()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","24","25","26","27","33","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","ZZ" });
		}
	}
	public class E_0653 : MapSimpleDataElement
	{
		public E_0653()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AMT","CSH","DOR","DPU","DSH","DSV","POR","PPU","PSH","PSV","UNT","ZZZ" });
		}
	}
	public class E_0654 : MapSimpleDataElement
	{
		public E_0654()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CA","PC","UN","ZZ" });
		}
	}
	public class E_0655 : MapSimpleDataElement
	{
		public E_0655()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0656 : MapSimpleDataElement
	{
		public E_0656()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "DAT","DOF" });
		}
	}
	public class E_0657 : MapSimpleDataElement
	{
		public E_0657()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0659 : MapSimpleDataElement
	{
		public E_0659()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B" });
		}
	}
	public class E_0660 : MapSimpleDataElement
	{
		public E_0660()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0662 : MapSimpleDataElement
	{
		public E_0662()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","D","I","O","S" });
		}
	}
	public class E_0663 : MapSimpleDataElement
	{
		public E_0663()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0664 : MapSimpleDataElement
	{
		public E_0664()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0665 : MapSimpleDataElement
	{
		public E_0665()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "P","R" });
		}
	}
	public class E_0666 : MapSimpleDataElement
	{
		public E_0666()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","H","M","N","P","R" });
		}
	}
	public class E_0667 : MapSimpleDataElement
	{
		public E_0667()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0668 : MapSimpleDataElement
	{
		public E_0668()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AC","AR","BP","DR","IA","IB","IC","ID","IE","IF","IH","IP","IQ","IR","IS","IW","R1","R2","R3","R4","R5","R6","R7","R8","SP" });
		}
	}
	public class E_0669 : MapSimpleDataElement
	{
		public E_0669()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "IMF","LNF","LNS","NYC","PHI","ZUR" });
		}
	}
	public class E_0670 : MapSimpleDataElement
	{
		public E_0670()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AI","CA","CB","CC","CE","CF","CG","CH","CI","CT","DI","MU","NC","OA","OC","PC","PQ","PR","QD","QI","RA","RB","RC","RE","RM","RQ","RS","RZ","TI" });
		}
	}
	public class E_0671 : MapSimpleDataElement
	{
		public E_0671()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0672 : MapSimpleDataElement
	{
		public E_0672()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "FI","GS","LB","LM","MT","PQ","PR","ZZ" });
		}
	}
	public class E_0673 : MapSimpleDataElement
	{
		public E_0673()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","1A","1B","1C","1D","1E","1F","1G","1H","1I","1J","1K","1L","1M","1N","1O","1P","1Q","1R","1S","1T","1U","1V","1W","1X","1Y","1Z","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2D","2E","2F","2G","2H","2I","2J","2K","2L","2M","2N","2O","2P","2Q","2R","2S","2T","2U","2V","2W","2X","2Y","2Z","30","31","32","33","34","35","36","37","38","39","3A","3B","3C","3D","3E","3F","3G","3H","3I","3J","3K","3L","3M","3N","3P","3Q","3R","3S","3T","3U","3V","3W","3X","3Y","40","41","42","43","45","46","47","48","49","4A","4B","4C","4D","4E","4F","4G","4H","4I","4J","4K","4L","4M","4N","4O","4P","4Q","4R","4S","4T","4U","50","51","52","53","54","55","56","57","58","5A","5B","5C","5D","5E","5F","5G","5H","5I","5J","5K","5L","5M","5N","5O","5P","5Q","5R","5S","5T","5U","5V","5W","5X","5Y","5Z","60","61","62","63","64","65","66","67","68","69","6A","6B","6C","6D","6E","6F","6G","6H","6I","6J","6K","6L","6M","6N","6O","6P","6Q","6R","6S","6T","6U","6V","6W","6X","6Z","70","72","73","74","75","76","77","78","79","7A","7B","7C","7D","7E","7F","7G","7H","7I","7J","7K","7L","7M","7N","7O","7P","7Q","7R","7S","7T","7U","7V","7W","7X","7Y","7Z","80","81","82","83","84","85","86","87","88","89","8A","8B","8C","8D","8E","8F","8G","8H","8I","8J","8K","8L","8M","8N","8O","8P","8Q","8R","8S","90","91","92","93","94","95","96","97","98","99","9A","9C","9D","9E","9F","9H","9J","9K","9L","9M","9N","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B1","B2","B3","B4","B5","B6","B7","B8","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BQ","BR","BW","C0","CA","CB","CC","CD","CE","CF","CG","CH","CI","CL","CN","CO","CP","CR","CS","CW","CY","CZ","D1","D3","DA","DB","DC","DD","DE","DF","DG","DI","DN","DO","DP","DR","DS","DT","DY","E1","E2","E3","E4","E5","EA","EB","EC","ED","EE","EM","EP","EQ","ER","ES","ET","EW","F1","FA","FB","FC","FD","FE","FF","FG","FH","FI","FJ","FK","FL","FM","FR","FS","FT","GA","GB","GC","GE","GF","GI","GL","GP","GQ","GR","GS","GT","GU","GV","GW","GX","GZ","HA","HB","HC","HD","HE","HF","HG","HH","HI","HJ","HK","HL","HM","HN","HO","HP","HR","HS","II","IN","IP","IQ","IS","IT","JA","JB","JC","JD","JE","JF","JG","JH","JI","JJ","JK","JL","JM","JN","JO","JP","JQ","JR","JS","JT","K6","KA","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KN","KO","KP","KQ","KR","KS","KU","KV","KW","KX","KY","KZ","L2","L3","L4","L5","L6","L7","LA","LB","LC","LE","LG","LH","LI","LK","LL","LM","LN","LO","LP","LQ","LR","LS","LT","LV","LW","LX","LY","M1","M2","MA","MD","ME","MF","MI","MM","MN","MO","MQ","MX","N1","N2","N3","N4","N5","N6","NA","NB","NC","ND","NE","NF","NG","NL","NN","NO","NP","NQ","NR","NS","NT","NU","NV","NW","OC","OD","OF","OG","OH","OI","OL","ON","OO","OR","OT","OU","OV","OW","P1","P3","P4","P5","P6","P7","P8","P9","PA","PB","PC","PD","PE","PF","PG","PK","PL","PO","PP","PQ","PR","PS","PT","PW","PX","Q1","Q2","Q3","Q4","QA","QB","QC","QD","QE","QF","QH","QI","QJ","QL","QM","QN","QO","QP","QQ","QR","QS","QU","QV","QW","QX","R3","R5","R6","R9","RA","RB","RC","RD","RE","RF","RG","RH","RJ","RL","RM","RN","RQ","RS","RT","RW","RY","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SG","SH","SI","SJ","SK","SL","SM","SN","SO","SP","SQ","SR","SS","ST","SU","SV","SW","SX","SY","T1","T2","T3","T4","T5","T6","T7","TA","TB","TC","TD","TE","TG","TH","TI","TJ","TK","TM","TN","TO","TP","TR","TS","TT","TU","TV","TW","TX","TY","UA","UG","UL","UO","US","UU","V1","V2","V3","V4","V5","VA","VB","VC","VD","VE","VF","VG","VH","VI","VJ","VK","VL","VM","VN","VP","VR","VS","VT","VV","VY","WA","WB","WC","WD","WE","WG","WL","WO","WP","WR","WT","WV","WW","WX","WY","X1","XA","XB","XC","XD","XE","XG","XI","XJ","XL","XN","XO","XT","XU","XV","XX","XY","XZ","YA","YB","YC","YD","YE","YF","YG","YH","YJ","YK","YL","YM","YN","YP","YQ","YR","YS","YT","YW","YX","YY","Z1","Z2","Z3","Z4","Z6","ZA","ZB","ZC","ZD","ZE","ZF","ZG","ZH","ZI","ZJ","ZK","ZL","ZM","ZN","ZO","ZP","ZR","ZS" });
		}
	}
	public class E_0674 : MapSimpleDataElement
	{
		public E_0674()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","L","O","P","Y" });
		}
	}
	public class E_0675 : MapSimpleDataElement
	{
		public E_0675()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AD","AS","BB","DL","JS","KB","PD","PR","PS","SH","ZZ" });
		}
	}
	public class E_0676 : MapSimpleDataElement
	{
		public E_0676()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","D","R" });
		}
	}
	public class E_0677 : MapSimpleDataElement
	{
		public E_0677()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0678 : MapSimpleDataElement
	{
		public E_0678()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","J","K","L","M","N","O","P","Q","R","S","SA","SB","SC","SD","SG","SL","SP","SX","SY","SZ","T","U","V","W","X","Y","Z" });
		}
	}
	public class E_0679 : MapSimpleDataElement
	{
		public E_0679()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","Y","Z" });
		}
	}
	public class E_0680 : MapSimpleDataElement
	{
		public E_0680()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","K","L","M","N","P","Q","S","T","U","V","W","X","Z" });
		}
	}
	public class E_0681 : MapSimpleDataElement
	{
		public E_0681()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","D","F","M","Q","S","T","W","X","Z" });
		}
	}
	public class E_0682 : MapSimpleDataElement
	{
		public E_0682()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","D","E","F","G","H","I","J","K","L","M","N","P","Q","R","S","T","U","W","X","Y" });
		}
	}
	public class E_0683 : MapSimpleDataElement
	{
		public E_0683()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CP","PC","PS","RC","SC" });
		}
	}
	public class E_0684 : MapSimpleDataElement
	{
		public E_0684()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0685 : MapSimpleDataElement
	{
		public E_0685()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0686 : MapSimpleDataElement
	{
		public E_0686()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0687 : MapSimpleDataElement
	{
		public E_0687()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AG","AI","AP","AS","BG","BR","CB","CN","CO","CR","CX","CY","DE","DF","DI","DR","EX","FS","GA","GM","GR","GV","HS","ID","IN","IR","JB","LC","MC","MF","ML","OE","OF","ON","PF","PH","PT","PY","RS","SA","SB","SE","ST","TR","WA","WC","WH","WS" });
		}
	}
	public class E_0688 : MapSimpleDataElement
	{
		public E_0688()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","DO","DW","NR","NS","OR","SP","SR","WO" });
		}
	}
	public class E_0689 : MapSimpleDataElement
	{
		public E_0689()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17" });
		}
	}
	public class E_0690 : MapSimpleDataElement
	{
		public E_0690()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 11;
		}
	}
	public class E_0691 : MapSimpleDataElement
	{
		public E_0691()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0692 : MapSimpleDataElement
	{
		public E_0692()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","Y","Z" });
		}
	}
	public class E_0693 : MapSimpleDataElement
	{
		public E_0693()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","D","G","M","P","S","T" });
		}
	}
	public class E_0694 : MapSimpleDataElement
	{
		public E_0694()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0695 : MapSimpleDataElement
	{
		public E_0695()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","L","M","N" });
		}
	}
	public class E_0697 : MapSimpleDataElement
	{
		public E_0697()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0698 : MapSimpleDataElement
	{
		public E_0698()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "P","S","U" });
		}
	}
	public class E_0699 : MapSimpleDataElement
	{
		public E_0699()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "M","P" });
		}
	}
	public class E_0701 : MapSimpleDataElement
	{
		public E_0701()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83" });
		}
	}
	public class E_0703 : MapSimpleDataElement
	{
		public E_0703()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","C","D","E","F" });
		}
	}
	public class E_0704 : MapSimpleDataElement
	{
		public E_0704()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","CH","CO","DM","NT","ON","OR","PV","SG" });
		}
	}
	public class E_0705 : MapSimpleDataElement
	{
		public E_0705()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03" });
		}
	}
	public class E_0706 : MapSimpleDataElement
	{
		public E_0706()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97" });
		}
	}
	public class E_0707 : MapSimpleDataElement
	{
		public E_0707()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","A3","A4","A5","A6","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AS","BA","BC","BE","C2","CH","CL","CO","CP","CR","CT","DP","DQ","DS","EA","EC","EE","EI","FA","IF","IN","LT","PA","PC","PD","PF","PK","PR","PS","PT","PU","PY","RC","RO","RS","RT","SD","SE","SF","SN","SP","SS","ST","TC","TR","TS","TT","UT","WR","WT" });
		}
	}
	public class E_0708 : MapSimpleDataElement
	{
		public E_0708()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","31","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","50","6","7","8","9","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y" });
		}
	}
	public class E_0709 : MapSimpleDataElement
	{
		public E_0709()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "PP","SC" });
		}
	}
	public class E_0712 : MapSimpleDataElement
	{
		public E_0712()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0713 : MapSimpleDataElement
	{
		public E_0713()
		{
			DataType = DataType.N0;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0714 : MapSimpleDataElement
	{
		public E_0714()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_0715 : MapSimpleDataElement
	{
		public E_0715()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","E","M","P","R","W","X" });
		}
	}
	public class E_0716 : MapSimpleDataElement
	{
		public E_0716()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","3","4","5","6" });
		}
	}
	public class E_0717 : MapSimpleDataElement
	{
		public E_0717()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","E","M","R","W","X" });
		}
	}
	public class E_0718 : MapSimpleDataElement
	{
		public E_0718()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","15","16","17","19","2","20","21","22","23","24","25","26","27","3","4","5","6","7","8","9" });
		}
	}
	public class E_0719 : MapSimpleDataElement
	{
		public E_0719()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0720 : MapSimpleDataElement
	{
		public E_0720()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8" });
		}
	}
	public class E_0721 : MapSimpleDataElement
	{
		public E_0721()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0722 : MapSimpleDataElement
	{
		public E_0722()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0723 : MapSimpleDataElement
	{
		public E_0723()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "1","10","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_0724 : MapSimpleDataElement
	{
		public E_0724()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 99;
		}
	}
	public class E_0725 : MapSimpleDataElement
	{
		public E_0725()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0726 : MapSimpleDataElement
	{
		public E_0726()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","20" });
		}
	}
	public class E_0728 : MapSimpleDataElement
	{
		public E_0728()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "B","D","E","L","M","O","P","R","S","U","ZZ" });
		}
	}
	public class E_0729 : MapSimpleDataElement
	{
		public E_0729()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0730 : MapSimpleDataElement
	{
		public E_0730()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0731 : MapSimpleDataElement
	{
		public E_0731()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BS","SB","SC","SD","SF","SS","ZZ" });
		}
	}
	public class E_0732 : MapSimpleDataElement
	{
		public E_0732()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AD","CD","CW","HO","SD","SH","WD","WW","ZZ" });
		}
	}
	public class E_0733 : MapSimpleDataElement
	{
		public E_0733()
		{
			DataType = DataType.R4;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0734 : MapSimpleDataElement
	{
		public E_0734()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0735 : MapSimpleDataElement
	{
		public E_0735()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","19","2","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2D","2E","2F","2G","2H","2I","2J","2K","2L","3","30","31","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","50","51","52","53","54","55","56","57","58","59","6","60","61","62","7","8","9","A","AD","AG","AL","AP","AS","B","BD","BE","BP","C","CB","CC","CE","CH","CI","CL","CN","CO","CT","D","DG","DP","E","ED","EL","EM","EV","EX","F","FC","FG","FI","FL","FR","G","GC","GP","GW","H","I","IA","IB","IC","IN","J","JU","K","L","M","ML","NI","NS","O","OS","P","PA","PB","PC","PD","PH","PL","PP","PR","PS","PT","PY","Q","R","RA","RB","RC","RD","RE","RF","RM","RP","S","SA","SB","SC","SD","SE","SH","SI","SL","SP","SR","SS","SY","T","TI","TS","U","UT","V","W","WB","WC","WL","WP","WR","X","Y","ZZ" });
		}
	}
	public class E_0736 : MapSimpleDataElement
	{
		public E_0736()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1" });
		}
	}
	public class E_0737 : MapSimpleDataElement
	{
		public E_0737()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "9L","AA","AB","AC","AE","AF","AG","AH","AI","AJ","AK","AM","AN","AO","AP","AQ","AR","AV","BA","BB","BC","BD","BL","BM","BN","BO","BP","BR","BT","BZ","C1","CA","CB","CC","CF","CG","CH","CJ","CK","CL","CM","CN","CO","CP","CQ","CS","CT","CU","CV","CW","CY","DE","DN","DT","EA","EE","EF","EL","EN","FC","FD","FH","FJ","FV","FZ","GC","GL","GO","GP","HC","HR","ID","IN","IR","LC","LD","LG","LL","LM","LP","LS","LT","MP","MR","NC","NE","NX","OD","OG","OL","OP","P1","PA","PB","PC","PD","PI","PJ","PK","PL","PM","PO","PR","PS","PT","PU","PY","QR","QV","R1","R2","RA","RG","RL","RN","RO","RP","RQ","RS","RT","SA","SB","SC","SD","SE","SF","SH","SJ","SK","SL","SM","SP","SR","ST","SU","SZ","TA","TD","TE","TI","TL","TO","TP","TR","TS","TT","VT","WA","WR","WT","ZA","ZP" });
		}
	}
	public class E_0738 : MapSimpleDataElement
	{
		public E_0738()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","18","19","1F","2","20","21","22","23","24","25","26","27","28","29","2F","3","30","31","32","33","34","35","36","37","38","39","3A","3B","3C","3D","3E","3F","3G","3H","3I","3J","4","40","41","42","43","44","4F","5","5F","6","6F","7","8","8F","A","A1","A2","A3","A4","A5","A6","A7","A9","AA","AAP","AB","ABO","ABR","ABS","AC","ACN","AD","ADH","ADM","AE","AF","AG","AGE","AGI","AH","AI","AJ","AK","AL","ALK","ALN","ALP","AM","AMI","AMW","AN","AOX","AP","API","APP","AS","ASH","ASY","AT","AU","AV","AVT","AW","AX","AY","AZ","B","B1","B2","B3","B4","B5","B6","BA","BB","BC","BD","BDP","BE","BF","BG","BH","BHF","BHS","BIC","BJ","BK","BL","BN","BND","BO","BOR","BP","BQ","BR","BRS","BSW","BT","BU","BUD","BW","BX","C","C0","C1","C2","C3","C4","CA","CAU","CC","CCF","CCG","CD","CE","CF","CG","CGR","CH","CHA","CHC","CHG","CHL","CI","CIV","CJ","CK","CL","CLA","CLB","CLN","CM","CN","CO","COH","COL","CON","COR","COS","COT","CP","CPF","CPS","CQ","CR","CRF","CRL","CRN","CRT","CS","CSC","CSR","CST","CT","CTG","CTT","CU","CUT","CW","CWT","CX","CY","CYB","D","D1","D2","D3","D4","D5","D7","DA","DAT","DB","DC","DCT","DD","DE","DEM","DF","DG","DH","DI","DIR","DIS","DJ","DL","DM","DME","DMF","DN","DP","DPM","DR","DRY","DS","DT","DU","DW","DWP","DY","E","E0","E1","EA","EB","EC","ED","EE","EF","EG","EH","EI","EJ","EL","ELC","ELE","ELI","ELL","ELO","ELP","ELS","ELT","ELV","ELW","ELX","EM","EN","EP","EPL","ES","EVL","EVR","EW","EX","EXH","EXT","F","F1","F2","F3","F4","F5","F6","F7","F8","F9","FA","FB","FBP","FC","FD","FE","FF","FG","FH","FI","FIL","FIN","FIT","FJ","FK","FL","FLD","FLN","FLP","FLV","FML","FMZ","FN","FNL","FNS","FOA","FOH","FOI","FOR","FP","FPV","FQ","FR","FS","FSI","FT","FU","FUD","FV","FW","FX","FY","FZ","G","G1","G2","G3","G4","GA","GB","GC","GD","GE","GEL","GF","GG","GGR","GH","GI","GIR","GJ","GK","GL","GLE","GM","GN","GO","GOR","GP","GQ","GR","GRA","GRI","GS","GT","GW","H1","H2O","H8","H9","HA","HAR","HAZ","HB","HC","HCG","HD","HE","HF","HG","HH","HHW","HI","HIB","HJ","HK","HL","HM","HO","HOC","HP","HR","HT","HTE","HVM","HWS","HYD","HZ","HZC","I","IA","IB","IC","ID","IDE","IE","IF","IG","IGA","IGR","IH","IHV","II","IJ","IK","IL","IM","IMP","IN","IND","INS","IO","IP","IPI","IQ","IR","IRA","IS","IT","IU","IV","IW","IX","IY","IZ","JA","JOM","KA","KB","KN","L","L0","L1","LA","LAI","LB","LC","LC5","LCG","LD","LD5","LDH","LE","LEF","LF","LG","LIR","LIV","LL","LLD","LM","LN","LO","LOI","LOS","LOW","LP","LPG","LPL","LPR","LS","LSK","LSS","LT","LTD","LW","M","M1","M2","M3","M4","M5","M6","MA","MAT","MB","MC","MCN","MD","ME","MEF","MEL","MER","MF","MG","MH","MHI","MI","MIC","MJ","MK","MM","MN","MO","MOI","MOR","MP","MPR","MQ","MR","MS","MT","MTD","MU","MUL","MV","MW","MX","MY","N","NA","NB","NC","ND","NEU","NF","NG","NH","NI","NIL","NJ","NK","NL","NM","NNW","NO","NOC","NON","NOR","NOX","NP","NS","NU","NV","O","O1","OA","OAP","OB","OBT","OC","OCG","OCR","OD","ODR","OE","OF","OG","OH","OI","OIL","OJ","OK","OL","OLE","OM","ON","OO","OP","OQ","OR","ORC","OS","OT","OTE","OTH","OTT","OV","OW","OX","OXI","OXS","OY","P1","PA","PAR","PB","PBD","PC","PD","PDE","PDG","PE","PER","PF","PFO","PG","PH","PHA","PHW","PI","PIC","PJ","PK","PL","PM","PN","PO","POC","POD","POP","PP","PPS","PQ","PR","PRE","PRF","PRI","PRL","PRO","PRQ","PRY","PS","PSA","PSP","PSW","PT","PU","PV","PW","PWA","PWE","PWF","PX","PY","PZ","Q","QA","QB","QC","QD","QE","QF","QL","QUR","R","R1","R10","R18","R2","R3","R4","R7","R8","RA","RAD","RAF","RB","RC","RD","RE","REA","RED","REF","REI","REL","RES","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","ROH","ROX","RP","RQ","RR","RS","RSZ","RT","RTB","RU","RUD","RV","RVP","RW","RX","RY","S","S1","S10","S12","S18","S2","S3","S4","S5","S6","S7","S8","S9","SA","SAP","SB","SC","SCH","SD","SE","SEV","SF","SG","SH","SHA","SI","SIL","SJ","SK","SL","SLD","SLI","SM","SMB","SMD","SN","SO","SOD","SOF","SP","SPG","SPR","SQ","SR","SS","ST","STA","STL","STP","SU","SUM","SUR","SUT","SV","SVL","SW","SX","SXX","SY","SZ","T","T1","T2","T3","T4","T5","T50","T90","TA","TAS","TB","TC","TCL","TD","TDP","TE","TEE","TES","TEX","TF","TG","TH","TI","TJ","TK","TL","TM","TN","TO","TOA","TOR","TOX","TP","TPF","TPL","TPQ","TPS","TQ","TR","TRA","TRC","TRD","TRN","TS","TSZ","TT","TTL","TU","TUR","TV","TVD","TW","TWD","TX","TY","U","UA","UCB","UG","UNI","UNK","VAD","VAP","VCG","VH","VIN","VIS","VO","VOC","VOL","VOT","VOV","VOW","VSO","VW","VWT","WA","WB","WC","WD","WDE","WE","WEL","WF","WH","WI","WL","WM","WOD","WPF","WPL","WPS","WR","WRA","WSK","WT","WTB","WU","WX","X","XA","XH","XP","XQ","XZ","YA","YB","YC","YD","ZA","ZAL","ZAS","ZB","ZBI","ZBT","ZBZ","ZC","ZCA","ZCB","ZCD","ZCE","ZCO","ZCR","ZCU","ZD","ZET","ZF","ZFE","ZFL","ZFS","ZG","ZGE","ZH","ZHP","ZHS","ZHX","ZIB","ZIP","ZMG","ZMN","ZMO","ZMT","ZN","ZNB","ZNI","ZNP","ZO","ZOC","ZP","ZPB","ZPP","ZPT","ZR","ZS","ZSB","ZSE","ZSI","ZSN","ZTA","ZTB","ZTE","ZTI","ZV","ZW","ZZN","ZZR","ZZZ" });
		}
	}
	public class E_0739 : MapSimpleDataElement
	{
		public E_0739()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 18;
		}
	}
	public class E_0740 : MapSimpleDataElement
	{
		public E_0740()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 18;
		}
	}
	public class E_0741 : MapSimpleDataElement
	{
		public E_0741()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 18;
		}
	}
	public class E_0742 : MapSimpleDataElement
	{
		public E_0742()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 35;
		}
	}
	public class E_0743 : MapSimpleDataElement
	{
		public E_0743()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "C","F","S","Z" });
		}
	}
	public class E_0744 : MapSimpleDataElement
	{
		public E_0744()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CN","DI","EN","MV","PN","RN","SN","TN","UF","VN","WN","XY" });
		}
	}
	public class E_0745 : MapSimpleDataElement
	{
		public E_0745()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "Y" });
		}
	}
	public class E_0746 : MapSimpleDataElement
	{
		public E_0746()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 9;
		}
	}
	public class E_0747 : MapSimpleDataElement
	{
		public E_0747()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "RB","RC","RD" });
		}
	}
	public class E_0748 : MapSimpleDataElement
	{
		public E_0748()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","B","C","D","DS","E","G","HM","I","L","M","N","NC","NU","O","OA","OS","P","R","RB","S","T","W","X" });
		}
	}
	public class E_0749 : MapSimpleDataElement
	{
		public E_0749()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "BLC","CIR","COA","COM","CON","CTP","CUS","DOM","EXP","FUM","INS","IPI","LOC","MSD","OBV","ONR","ORI","PAK","QAL","SAN","SED","SPI","SWB" });
		}
	}
	public class E_0750 : MapSimpleDataElement
	{
		public E_0750()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "01","02","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","25","28","29","30","32","33","34","35","36","37","38","39","40","41","42","43","54","55","56","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","99","9A","9B","9C","9D","AF","AG","AGE","AT","B8","BC","BCC","BES","BEV","BLM","BND","BPI","BRG","BW","C2","C3","C4","C5","C6","CCN","CD","CFC","CH","CHF","CL","CLT","CM","CMS","CO","CP","CS","CU","CW","DAC","DAF","DE","DF","DIR","DM","EC","EN","FA","FC","FCD","FDD","FL","FLV","FMR","FQ","GD","GEN","GM","GS","HB","HY","HZ","HZR","ING","INJ","KI","LC","LO","MA","MAC","MB","MBU","MS","MSG","NH","OC","OD","ODR","OR","OT","P6","PD","PF","PFA","PFC","PFG","PFI","PFK","PFL","PFM","PFN","PFP","PFS","PFT","PG","PP","PR","PRI","PRO","PSC","PUB","PUR","QAS","R3","RA","RCC","RM","RR","RSD","RSE","RX","SC","SE","SEC","SF","SIZ","SLM","SOL","ST","STL","SYN","TC","TE","TF","THR","TIF","TIR","TP","TR","TRN","TWF","TZ","VA","VC","VI","WD","WF","WLC","WT","WTT","ZZ" });
		}
	}
	public class E_0751 : MapSimpleDataElement
	{
		public E_0751()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0752 : MapSimpleDataElement
	{
		public E_0752()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1S","2S","A1","AL","AO","AS","B1","BC","BI","BK","BL","BR","BS","BT","CH","CT","DO","DT","DU","EX","FR","FS","GF","IN","IT","KB","LC","LO","LT","M1","MC","MD","NS","NT","OA","OS","OT","R0","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RD","RE","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RQ","RR","RS","RT","RU","RV","RW","RX","RY","RZ","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SN","SP","SS","ST","SU","TB","TP","TS","UC","UN","UP","UT","WF" });
		}
	}
	public class E_0753 : MapSimpleDataElement
	{
		public E_0753()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 5;
			AllowedValues.AddRange(new[] { "01","10","11","12","13","34","35","36","37","38","39","40","42","43","44","45","60","61","62","63","65","66","67","68","CB","CC","CD","CS","CT","CUD","HM","IC","IP","LP","OPI","PK","PM","PML","PN","SMK","UC","UCL","UP","WM" });
		}
	}
	public class E_0754 : MapSimpleDataElement
	{
		public E_0754()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0755 : MapSimpleDataElement
	{
		public E_0755()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","A1","A2","A3","A4","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B1","B2","B3","B4","BA","BB","BC","BE","BF","BL","BM","BN","BO","BR","BS","BT","BW","BY","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CW","CX","CY","CZ","D2","DA","DB","DC","DD","DE","DF","DG","DH","DI","DJ","DK","DL","DM","DN","DQ","DR","DS","DT","DU","DV","DW","E1","EA","EB","EC","ED","EL","EP","ER","EX","EY","F1","F2","F3","F4","F5","F6","F7","F8","F9","FB","FC","FD","FE","FH","FI","FM","FS","GP","GT","HC","HR","HW","I2","I3","I4","I5","I6","IA","IC","IM","IN","IP","IR","IS","IT","IU","IV","JA","JB","JC","JD","JE","JF","JG","JH","JI","JK","JL","JM","JN","JO","JP","JQ","JR","JS","JT","JV","JW","JX","JY","JZ","KA","KC","KD","KE","KF","KG","KH","KI","KJ","KY","KZ","LA","LB","LC","LD","LE","LG","LI","LO","LP","LR","LS","LT","LW","M1","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","ML","MM","MN","MO","MP","MQ","MR","MS","MT","MV","MZ","NA","NC","ND","NI","NL","NM","NN","NO","NQ","NR","NT","OB","OC","OD","OE","OL","OP","OR","OS","OT","OX","OZ","P1","P2","P3","P4","P5","P6","P7","P8","PA","PB","PC","PD","PE","PF","PG","PH","PI","PJ","PK","PL","PM","PN","PO","PP","PQ","PR","PS","PT","PV","PW","PX","PY","PZ","QC","QD","QE","QM","QR","QS","QT","R1","R2","R3","R4","R5","R6","RA","RB","RC","RD","RE","RF","RG","RM","RN","RO","RR","RT","RV","RX","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SG","SH","SI","SL","SM","SN","SO","SP","SQ","SR","SS","ST","SU","SV","SW","SX","SY","T1","T2","T3","T4","T5","T6","TA","TB","TC","TD","TE","TF","TG","TH","TI","TJ","TK","TL","TM","TN","TO","TP","TQ","TR","TS","TT","TX","U1","UA","UB","UD","UE","UF","UG","UH","UI","UJ","UK","UL","UM","UN","UO","UP","UQ","UR","US","UT","UU","UV","UX","UY","UZ","V1","V2","V3","V4","V5","V6","V7","VA","VC","VD","VM","W1","W2","WA","WB","WC","WD","WE","WF","WG","WH","WI","WP","WT","X1","X2","X3","X4","X5","XE","XP","Y1","Y2","Y3","ZA","ZB","ZZ" });
		}
	}
	public class E_0756 : MapSimpleDataElement
	{
		public E_0756()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","AA","AC","AE","AM","AS","AT","AU","BE","BM","BW","CD","CF","CP","CT","DA","EL","EM","FT","FX","GS","HL","IA","IE","IM","MB","MD","MN","MP","MT","NS","OL","PO","SE","SM","SN","SW","TA","TE","TM","TX","VO","WS" });
		}
	}
	public class E_0757 : MapSimpleDataElement
	{
		public E_0757()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0758 : MapSimpleDataElement
	{
		public E_0758()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0759 : MapSimpleDataElement
	{
		public E_0759()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "RQ" });
		}
	}
	public class E_0760 : MapSimpleDataElement
	{
		public E_0760()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "Y" });
		}
	}
	public class E_0761 : MapSimpleDataElement
	{
		public E_0761()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0762 : MapSimpleDataElement
	{
		public E_0762()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","D","E","H","M","N","O","R","S","T","U","W" });
		}
	}
	public class E_0765 : MapSimpleDataElement
	{
		public E_0765()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0766 : MapSimpleDataElement
	{
		public E_0766()
		{
			DataType = DataType.AN;
			MinLength = 12;
			MaxLength = 12;
		}
	}
	public class E_0767 : MapSimpleDataElement
	{
		public E_0767()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0768 : MapSimpleDataElement
	{
		public E_0768()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0769 : MapSimpleDataElement
	{
		public E_0769()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 16;
		}
	}
	public class E_0770 : MapSimpleDataElement
	{
		public E_0770()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_0771 : MapSimpleDataElement
	{
		public E_0771()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "001","002","003","004","005","006","007","008","009","010","011","012" });
		}
	}
	public class E_0772 : MapSimpleDataElement
	{
		public E_0772()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "E","H","N" });
		}
	}
	public class E_0773 : MapSimpleDataElement
	{
		public E_0773()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0781 : MapSimpleDataElement
	{
		public E_0781()
		{
			DataType = DataType.AN;
			MinLength = 6;
			MaxLength = 6;
		}
	}
	public class E_0782 : MapSimpleDataElement
	{
		public E_0782()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 18;
		}
	}
	public class E_0783 : MapSimpleDataElement
	{
		public E_0783()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","MM","MN","MP","OS","OT","PM","PS","SO","ST","TO","TS","TT","XA","XF" });
		}
	}
	public class E_0784 : MapSimpleDataElement
	{
		public E_0784()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0785 : MapSimpleDataElement
	{
		public E_0785()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 760;
		}
	}
	public class E_0786 : MapSimpleDataElement
	{
		public E_0786()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "00","01","02","03","04","05","06","09","11","20","21","90","92","93","94","99","ZZ" });
		}
	}
	public class E_0787 : MapSimpleDataElement
	{
		public E_0787()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0788 : MapSimpleDataElement
	{
		public E_0788()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0789 : MapSimpleDataElement
	{
		public E_0789()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0790 : MapSimpleDataElement
	{
		public E_0790()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 132;
		}
	}
	public class E_0791 : MapSimpleDataElement
	{
		public E_0791()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 80;
		}
	}
	public class E_0792 : MapSimpleDataElement
	{
		public E_0792()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","J","K","L","M","N","P","Z" });
		}
	}
	public class E_0795 : MapSimpleDataElement
	{
		public E_0795()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","Z" });
		}
	}
	public class E_0796 : MapSimpleDataElement
	{
		public E_0796()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0797 : MapSimpleDataElement
	{
		public E_0797()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "9A","9E","9N","OC","ZZ" });
		}
	}
	public class E_0799 : MapSimpleDataElement
	{
		public E_0799()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0800 : MapSimpleDataElement
	{
		public E_0800()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0801 : MapSimpleDataElement
	{
		public E_0801()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0802 : MapSimpleDataElement
	{
		public E_0802()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0803 : MapSimpleDataElement
	{
		public E_0803()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 64;
		}
	}
	public class E_0804 : MapSimpleDataElement
	{
		public E_0804()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0805 : MapSimpleDataElement
	{
		public E_0805()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 25;
		}
	}
	public class E_0806 : MapSimpleDataElement
	{
		public E_0806()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 6;
		}
	}
	public class E_0807 : MapSimpleDataElement
	{
		public E_0807()
		{
			DataType = DataType.AN;
			MinLength = 12;
			MaxLength = 16;
		}
	}
	public class E_0808 : MapSimpleDataElement
	{
		public E_0808()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "ADI","CAO","D13","DRC","DWW","EMS","HOT","HZC","INH","LQY","MFA","MOS","MPI","PIH","POI","RAM","TEC","TNM","WST" });
		}
	}
	public class E_0809 : MapSimpleDataElement
	{
		public E_0809()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 25;
		}
	}
	public class E_0810 : MapSimpleDataElement
	{
		public E_0810()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0811 : MapSimpleDataElement
	{
		public E_0811()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AI","AL","AY","BL","CC","ED","FC","FD","FR","HR","ML","OO","PI","RC","RX","SL","UT","ZZ" });
		}
	}
	public class E_0812 : MapSimpleDataElement
	{
		public E_0812()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 10;
			AllowedValues.AddRange(new[] { "BPT","CBC","CCD","CCP","CTP","CTX","PBC","PPD","PPP","PRD" });
		}
	}
	public class E_0813 : MapSimpleDataElement
	{
		public E_0813()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","H","I","J","L","M","N","O","R","S","T","W" });
		}
	}
	public class E_0814 : MapSimpleDataElement
	{
		public E_0814()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","T" });
		}
	}
	public class E_0815 : MapSimpleDataElement
	{
		public E_0815()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "DE","DR","EX","GR","HT","IN","LO","NB","PL","SH","SP","WI","ZZ" });
		}
	}
	public class E_0816 : MapSimpleDataElement
	{
		public E_0816()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "DI","JU","NB","NM","OM","RE","TE","TN","VI","ZZ" });
		}
	}
	public class E_0817 : MapSimpleDataElement
	{
		public E_0817()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_0818 : MapSimpleDataElement
	{
		public E_0818()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0819 : MapSimpleDataElement
	{
		public E_0819()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0820 : MapSimpleDataElement
	{
		public E_0820()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AM","AP","CA","CI","CM","CO","DI","DM","DS","EI","EN","EO","EP","FA","FE","HH","HI","IA","KY","MI","MS","PD","PM","PR","RE","RG","SH","SL","ST","TS","TX" });
		}
	}
	public class E_0821 : MapSimpleDataElement
	{
		public E_0821()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "ACT","AM2","AP2","CAR","CI2","CO2","CON","CTD","DCL","DEC","DEH","DI2","DIS","DM2","EDD","EFA","EFB","EFX","EIM","EN2","ENA","ENB","ENG","ENO","ENS","EO2","EP2","EPA","ESD","EVP","EXC","EXG","EXI","EXL","EYA","EYC","EYF","EYZ","FA2","FAA","FAL","FAS","FAT","FAZ","FE2","FEH","FEZ","FLC","FLP","GCA","GMA","GPI","HAI","HCA","HCP","HH2","HHA","HI2","HZC","HZR","IA2","IGA","IGC","IGZ","IHA","IHC","IHZ","INC","INS","INX","IRR","KY2","LAB","LKI","MAT","MCE","MUT","NOT","NTE","NTR","NTS","NTZ","OPH","OPR","ORC","PD2","PM2","POL","PPA","PPB","PPC","PPD","PPE","PPF","PPG","PPR","PPS","PPZ","PR2","PRE","PRF","PRG","PRH","PRI","PRJ","PRK","PRL","PRM","PRO","PRQ","PRS","PRT","PRU","PRZ","RE2","REA","REC","REP","RG2","RLI","RTK","SAP","SBY","SCE","SGW","SH2","SHI","SKA","SKC","SKS","SKT","SKZ","SL2","SNS","SPF","SPI","SPJ","SPL","SPP","ST2","STA","SUB","SYP","SYS","TER","TOC","TOG","TRH","TS2","TX2","VRZ","WAR","WDI" });
		}
	}
	public class E_0822 : MapSimpleDataElement
	{
		public E_0822()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_0824 : MapSimpleDataElement
	{
		public E_0824()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 64;
		}
	}
	public class E_0825 : MapSimpleDataElement
	{
		public E_0825()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 64;
		}
	}
	public class E_0826 : MapSimpleDataElement
	{
		public E_0826()
		{
			DataType = DataType.R8;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0828 : MapSimpleDataElement
	{
		public E_0828()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0829 : MapSimpleDataElement
	{
		public E_0829()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","K","L","N","O","P","S","Z" });
		}
	}
	public class E_0831 : MapSimpleDataElement
	{
		public E_0831()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","90","96","97","98","99" });
		}
	}
	public class E_0832 : MapSimpleDataElement
	{
		public E_0832()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0833 : MapSimpleDataElement
	{
		public E_0833()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0834 : MapSimpleDataElement
	{
		public E_0834()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0835 : MapSimpleDataElement
	{
		public E_0835()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "Y" });
		}
	}
	public class E_0836 : MapSimpleDataElement
	{
		public E_0836()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","A3","A4","A5","A6","A7","B1","B2","B3","B4","B5","B6","B7","C1","C2","C3","C4","C5","C6","C7" });
		}
	}
	public class E_0837 : MapSimpleDataElement
	{
		public E_0837()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","C","I","M","T","V","X" });
		}
	}
	public class E_0838 : MapSimpleDataElement
	{
		public E_0838()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 9;
		}
	}
	public class E_0839 : MapSimpleDataElement
	{
		public E_0839()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0844 : MapSimpleDataElement
	{
		public E_0844()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03" });
		}
	}
	public class E_0845 : MapSimpleDataElement
	{
		public E_0845()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "8P","DF","FB","GN","SF","SL","TX" });
		}
	}
	public class E_0846 : MapSimpleDataElement
	{
		public E_0846()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AC","AN","AW","CA","CB","CC","CL","CM","CR","CX","DA","DE","DL","EX","FL","GS","HO","IA","IE","IN","MA","NB","NT","OC","PA","PB","PC","PD","PP","PR","RA","RB","RC","RO","SC","SU","TA","TR","VA" });
		}
	}
	public class E_0847 : MapSimpleDataElement
	{
		public E_0847()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AO","CA","CI","CO","PA","PI","PO","PP" });
		}
	}
	public class E_0848 : MapSimpleDataElement
	{
		public E_0848()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "PD","SD","SP" });
		}
	}
	public class E_0849 : MapSimpleDataElement
	{
		public E_0849()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "SB","SL","SS" });
		}
	}
	public class E_0850 : MapSimpleDataElement
	{
		public E_0850()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_0851 : MapSimpleDataElement
	{
		public E_0851()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0852 : MapSimpleDataElement
	{
		public E_0852()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","M","T" });
		}
	}
	public class E_0853 : MapSimpleDataElement
	{
		public E_0853()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BD","CC","CD","DL","DP","FL","HD","ID","IL","IU","LD","LS","NO","NR","PP","PS","SF","TE","UE","VI","WC" });
		}
	}
	public class E_0854 : MapSimpleDataElement
	{
		public E_0854()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BC","BD","BI","BK","BL","BO","CB","CT","DG","DP","FH","GC","GT","MT","PC","PS","RR","SP","TG","VH" });
		}
	}
	public class E_0855 : MapSimpleDataElement
	{
		public E_0855()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","T" });
		}
	}
	public class E_0856 : MapSimpleDataElement
	{
		public E_0856()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","E","I","Z" });
		}
	}
	public class E_0857 : MapSimpleDataElement
	{
		public E_0857()
		{
			DataType = DataType.N6;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0858 : MapSimpleDataElement
	{
		public E_0858()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0859 : MapSimpleDataElement
	{
		public E_0859()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BS","BT","DG","HL","LS","MS","OF","OH","OP","OQ","PA","PO","Q1","Q2","Q3","QA","QB","QC","QD","QE","QF","QH","QI","QK","QL","QM","QN","QO","QP","QR","QS","QT","QU","QW","QX","QZ","RE","TS","WQ" });
		}
	}
	public class E_0860 : MapSimpleDataElement
	{
		public E_0860()
		{
			DataType = DataType.AN;
			MinLength = 9;
			MaxLength = 9;
		}
	}
	public class E_0861 : MapSimpleDataElement
	{
		public E_0861()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 22;
		}
	}
	public class E_0862 : MapSimpleDataElement
	{
		public E_0862()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0863 : MapSimpleDataElement
	{
		public E_0863()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0864 : MapSimpleDataElement
	{
		public E_0864()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0865 : MapSimpleDataElement
	{
		public E_0865()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0866 : MapSimpleDataElement
	{
		public E_0866()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0867 : MapSimpleDataElement
	{
		public E_0867()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0868 : MapSimpleDataElement
	{
		public E_0868()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "R","S" });
		}
	}
	public class E_0869 : MapSimpleDataElement
	{
		public E_0869()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0870 : MapSimpleDataElement
	{
		public E_0870()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 22;
		}
	}
	public class E_0871 : MapSimpleDataElement
	{
		public E_0871()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0872 : MapSimpleDataElement
	{
		public E_0872()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0873 : MapSimpleDataElement
	{
		public E_0873()
		{
			DataType = DataType.DT;
			MinLength = 8;
			MaxLength = 8;
		}
	}
	public class E_0874 : MapSimpleDataElement
	{
		public E_0874()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_0875 : MapSimpleDataElement
	{
		public E_0875()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "001","002","003","004","005","006","007","008","009","010","012","013","014","015","016","017","018","019","020","021","022","023","024","025","026","028","029","030","031","032","033","050","051","052","053","054","055","056","057","058","059","060","061","062","063","064","065","066","067","068","069","070","071","072","073","074","075","076","077","078","079","080","081","082","083","100","101","102","104","105","106","107","108","109","110","111","112","113","114","115","116","117","118","119","123","124","125","126","127","128","129","130","131","132","133","134","135","136","137","138","CEP","PRI","ZZZ" });
		}
	}
	public class E_0876 : MapSimpleDataElement
	{
		public E_0876()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0877 : MapSimpleDataElement
	{
		public E_0877()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 12;
		}
	}
	public class E_0878 : MapSimpleDataElement
	{
		public E_0878()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_0879 : MapSimpleDataElement
	{
		public E_0879()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_0880 : MapSimpleDataElement
	{
		public E_0880()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0881 : MapSimpleDataElement
	{
		public E_0881()
		{
			DataType = DataType.R8;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0883 : MapSimpleDataElement
	{
		public E_0883()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7" });
		}
	}
	public class E_0884 : MapSimpleDataElement
	{
		public E_0884()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0885 : MapSimpleDataElement
	{
		public E_0885()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0886 : MapSimpleDataElement
	{
		public E_0886()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CL","FI","OC","OD","OI","OS","OT","RE","RV" });
		}
	}
	public class E_0887 : MapSimpleDataElement
	{
		public E_0887()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CA","FR","HE","IN","P","RE","RJ","RP","RQ","RS","RT","RW","SC","UA","UC" });
		}
	}
	public class E_0888 : MapSimpleDataElement
	{
		public E_0888()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","N","Y" });
		}
	}
	public class E_0889 : MapSimpleDataElement
	{
		public E_0889()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","D","E","N","P","R","S","W","X","Y" });
		}
	}
	public class E_0890 : MapSimpleDataElement
	{
		public E_0890()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","ZZ" });
		}
	}
	public class E_0891 : MapSimpleDataElement
	{
		public E_0891()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","ZZ" });
		}
	}
	public class E_0892 : MapSimpleDataElement
	{
		public E_0892()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","20","21","22","23","24","25","26","ZZ" });
		}
	}
	public class E_0893 : MapSimpleDataElement
	{
		public E_0893()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2" });
		}
	}
	public class E_0894 : MapSimpleDataElement
	{
		public E_0894()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","09","10","11","12","13" });
		}
	}
	public class E_0895 : MapSimpleDataElement
	{
		public E_0895()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0897 : MapSimpleDataElement
	{
		public E_0897()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","C","L","Z" });
		}
	}
	public class E_0899 : MapSimpleDataElement
	{
		public E_0899()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 4;
		}
	}
	public class E_0901 : MapSimpleDataElement
	{
		public E_0901()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","95","96","97","98","AB","AD","AR","BA","BC","BD","BG","BL","BP","BR","BS","BV","BW","CA","CB","CL","CM","CP","CS","CT","CU","DD","DG","DM","DP","DR","DV","E1","E2","E3","E4","E5","E6","E7","E8","EA","ER","ET","FR","GS","HB","HH","HX","ID","II","IN","KR","LK","LS","LW","MO","OG","OI","OR","OV","PF","PM","PN","RB","RD","RF","RH","RK","RL","RN","RP","RS","RT","SC","ST","SU","SW","T1","T2","T3","T4","T5","T6","TC","TD","TH","TL","TR","UC","UF","UG","WA","WK","ZZ" });
		}
	}
	public class E_0902 : MapSimpleDataElement
	{
		public E_0902()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "D","H","N","S" });
		}
	}
	public class E_0903 : MapSimpleDataElement
	{
		public E_0903()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "H","N","T" });
		}
	}
	public class E_0904 : MapSimpleDataElement
	{
		public E_0904()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","F","M","N","O","R" });
		}
	}
	public class E_0905 : MapSimpleDataElement
	{
		public E_0905()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0906 : MapSimpleDataElement
	{
		public E_0906()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3" });
		}
	}
	public class E_0909 : MapSimpleDataElement
	{
		public E_0909()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 4;
		}
	}
	public class E_0910 : MapSimpleDataElement
	{
		public E_0910()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0911 : MapSimpleDataElement
	{
		public E_0911()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0912 : MapSimpleDataElement
	{
		public E_0912()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","E","L","P","R" });
		}
	}
	public class E_0913 : MapSimpleDataElement
	{
		public E_0913()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AN","B","DT","ID","N0","N1","N2","N3","N4","N5","N6","N7","N8","N9","R","TM" });
		}
	}
	public class E_0914 : MapSimpleDataElement
	{
		public E_0914()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_0915 : MapSimpleDataElement
	{
		public E_0915()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_0916 : MapSimpleDataElement
	{
		public E_0916()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0918 : MapSimpleDataElement
	{
		public E_0918()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0921 : MapSimpleDataElement
	{
		public E_0921()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AI","MS","OT","PT","SN","ST" });
		}
	}
	public class E_0922 : MapSimpleDataElement
	{
		public E_0922()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "I","T","X" });
		}
	}
	public class E_0923 : MapSimpleDataElement
	{
		public E_0923()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8" });
		}
	}
	public class E_0924 : MapSimpleDataElement
	{
		public E_0924()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "F","P" });
		}
	}
	public class E_0926 : MapSimpleDataElement
	{
		public E_0926()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0927 : MapSimpleDataElement
	{
		public E_0927()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B" });
		}
	}
	public class E_0930 : MapSimpleDataElement
	{
		public E_0930()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 5;
		}
	}
	public class E_0931 : MapSimpleDataElement
	{
		public E_0931()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0932 : MapSimpleDataElement
	{
		public E_0932()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0933 : MapSimpleDataElement
	{
		public E_0933()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 264;
		}
	}
	public class E_0934 : MapSimpleDataElement
	{
		public E_0934()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AT","DS","LC","NP","NS","SS" });
		}
	}
	public class E_0935 : MapSimpleDataElement
	{
		public E_0935()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","34","35","36","37","38","39","40","41","42","43","44","45","46","47","49","50","51","52","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","ZZ" });
		}
	}
	public class E_0936 : MapSimpleDataElement
	{
		public E_0936()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","40","41","42","44","45","46","48","49","50","51","52","Q1","Q2","TA","TB","ZZ" });
		}
	}
	public class E_0937 : MapSimpleDataElement
	{
		public E_0937()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","11","12","AG","CT","FL","MA","ME","PC","PO","SB","SP" });
		}
	}
	public class E_0938 : MapSimpleDataElement
	{
		public E_0938()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08" });
		}
	}
	public class E_0939 : MapSimpleDataElement
	{
		public E_0939()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02" });
		}
	}
	public class E_0940 : MapSimpleDataElement
	{
		public E_0940()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05" });
		}
	}
	public class E_0942 : MapSimpleDataElement
	{
		public E_0942()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0943 : MapSimpleDataElement
	{
		public E_0943()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26" });
		}
	}
	public class E_0944 : MapSimpleDataElement
	{
		public E_0944()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16" });
		}
	}
	public class E_0945 : MapSimpleDataElement
	{
		public E_0945()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","30","31","32","33","34" });
		}
	}
	public class E_0949 : MapSimpleDataElement
	{
		public E_0949()
		{
			DataType = DataType.R4;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0950 : MapSimpleDataElement
	{
		public E_0950()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","40","41","42","43","44","53","AD","CF","CS","HG","KS","SK","SW","ZZ" });
		}
	}
	public class E_0951 : MapSimpleDataElement
	{
		public E_0951()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","AM","C","CD","M","N","P","Q","Y" });
		}
	}
	public class E_0952 : MapSimpleDataElement
	{
		public E_0952()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "F","L","S" });
		}
	}
	public class E_0953 : MapSimpleDataElement
	{
		public E_0953()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0954 : MapSimpleDataElement
	{
		public E_0954()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0955 : MapSimpleDataElement
	{
		public E_0955()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CD","VD","VE" });
		}
	}
	public class E_0956 : MapSimpleDataElement
	{
		public E_0956()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0959 : MapSimpleDataElement
	{
		public E_0959()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "CAN","IND" });
		}
	}
	public class E_0960 : MapSimpleDataElement
	{
		public E_0960()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","BF","CB" });
		}
	}
	public class E_0961 : MapSimpleDataElement
	{
		public E_0961()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 99;
		}
	}
	public class E_0962 : MapSimpleDataElement
	{
		public E_0962()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","R" });
		}
	}
	public class E_0963 : MapSimpleDataElement
	{
		public E_0963()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AT","BP","CA","CB","CG","CI","CP","CR","CS","CT","CV","DL","EQ","ET","EV","F1","F2","F3","FD","FF","FI","FL","FR","FS","FT","GR","GS","HS","HT","HZ","LB","LO","LS","LT","LU","LV","MA","MN","MP","MS","MT","OH","OT","PG","PS","SA","SB","SC","SE","SF","SL","SP","SR","SS","ST","SU","SX","T1","T2","TD","TT","TX","UL","UT","VA","WS","ZA","ZB","ZC","ZD","ZE","ZZ" });
		}
	}
	public class E_0964 : MapSimpleDataElement
	{
		public E_0964()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "FNC","HAN","LAB","MTL","OCT","OTH","OVR","PKG","RMP","RMU","SET","TDI","TGA","TLN","TML","TMP","TOL","TPU","TTL" });
		}
	}
	public class E_0965 : MapSimpleDataElement
	{
		public E_0965()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0967 : MapSimpleDataElement
	{
		public E_0967()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_0969 : MapSimpleDataElement
	{
		public E_0969()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","H","M","T","X","Y" });
		}
	}
	public class E_0970 : MapSimpleDataElement
	{
		public E_0970()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0971 : MapSimpleDataElement
	{
		public E_0971()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0972 : MapSimpleDataElement
	{
		public E_0972()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_0973 : MapSimpleDataElement
	{
		public E_0973()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0974 : MapSimpleDataElement
	{
		public E_0974()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "R" });
		}
	}
	public class E_0975 : MapSimpleDataElement
	{
		public E_0975()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_0976 : MapSimpleDataElement
	{
		public E_0976()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","B","C","D","E" });
		}
	}
	public class E_0977 : MapSimpleDataElement
	{
		public E_0977()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_0978 : MapSimpleDataElement
	{
		public E_0978()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0980 : MapSimpleDataElement
	{
		public E_0980()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AC","AT","BF","BS","CA","SR","ZA","ZB" });
		}
	}
	public class E_0981 : MapSimpleDataElement
	{
		public E_0981()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AC","AM","CH","HA","HR","HU","II","MA","MH","MI","MN","NO","PA","RB","SE","SH","ST","TN","VE" });
		}
	}
	public class E_0982 : MapSimpleDataElement
	{
		public E_0982()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","03","05","07","09" });
		}
	}
	public class E_0983 : MapSimpleDataElement
	{
		public E_0983()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "P","S" });
		}
	}
	public class E_0984 : MapSimpleDataElement
	{
		public E_0984()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","D","I" });
		}
	}
	public class E_0985 : MapSimpleDataElement
	{
		public E_0985()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "NOS" });
		}
	}
	public class E_0986 : MapSimpleDataElement
	{
		public E_0986()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "S" });
		}
	}
	public class E_0987 : MapSimpleDataElement
	{
		public E_0987()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 4;
			AllowedValues.AddRange(new[] { "DSM","ERS","ESM","KSM","PKS","RFS","RSI","RSM","RTR" });
		}
	}
	public class E_0988 : MapSimpleDataElement
	{
		public E_0988()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 4;
			AllowedValues.AddRange(new[] { "CTA","CTB","CTP","CTR","EDC","ERF","IDA","IDC","IDD","IDU","KD","KDU","KK","KKU","MAC","NOS","PKK","PKKU","SUBF","SVR","TID" });
		}
	}
	public class E_0989 : MapSimpleDataElement
	{
		public E_0989()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 32;
		}
	}
	public class E_0995 : MapSimpleDataElement
	{
		public E_0995()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 18;
		}
	}
	public class E_0998 : MapSimpleDataElement
	{
		public E_0998()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_0999 : MapSimpleDataElement
	{
		public E_0999()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AC","AL","AU","ES","FG","FN","TA","UC","UH","UT","WR","WW" });
		}
	}
	public class E_0I01 : MapSimpleDataElement
	{
		public E_0I01()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "00","01","02","03","04","05","06" });
		}
	}
	public class E_0I02 : MapSimpleDataElement
	{
		public E_0I02()
		{
			DataType = DataType.AN;
			MinLength = 10;
			MaxLength = 10;
		}
	}
	public class E_0I03 : MapSimpleDataElement
	{
		public E_0I03()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "00","01" });
		}
	}
	public class E_0I04 : MapSimpleDataElement
	{
		public E_0I04()
		{
			DataType = DataType.AN;
			MinLength = 10;
			MaxLength = 10;
		}
	}
	public class E_0I05 : MapSimpleDataElement
	{
		public E_0I05()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","AM","NR","SN","ZZ" });
		}
	}
	public class E_0I06 : MapSimpleDataElement
	{
		public E_0I06()
		{
			DataType = DataType.AN;
			MinLength = 15;
			MaxLength = 15;
		}
	}
	public class E_0I07 : MapSimpleDataElement
	{
		public E_0I07()
		{
			DataType = DataType.AN;
			MinLength = 15;
			MaxLength = 15;
		}
	}
	public class E_0I08 : MapSimpleDataElement
	{
		public E_0I08()
		{
			DataType = DataType.DT;
			MinLength = 6;
			MaxLength = 6;
		}
	}
	public class E_0I09 : MapSimpleDataElement
	{
		public E_0I09()
		{
			DataType = DataType.TM;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_0I10 : MapSimpleDataElement
	{
		public E_0I10()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "U" });
		}
	}
	public class E_0I11 : MapSimpleDataElement
	{
		public E_0I11()
		{
			DataType = DataType.ID;
			MinLength = 5;
			MaxLength = 5;
			AllowedValues.AddRange(new[] { "00200","00201","00204","00300","00301","00302","00303","00304","00305","00306","00307","00400","00401","00402" });
		}
	}
	public class E_0I12 : MapSimpleDataElement
	{
		public E_0I12()
		{
			DataType = DataType.N0;
			MinLength = 9;
			MaxLength = 9;
		}
	}
	public class E_0I13 : MapSimpleDataElement
	{
		public E_0I13()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1" });
		}
	}
	public class E_0I14 : MapSimpleDataElement
	{
		public E_0I14()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "I","P","T" });
		}
	}
	public class E_0I15 : MapSimpleDataElement
	{
		public E_0I15()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_0I16 : MapSimpleDataElement
	{
		public E_0I16()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_0I40 : MapSimpleDataElement
	{
		public E_0I40()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AK","BH","DL","PU","RD","RF","RJ","RT","TR" });
		}
	}
	public class E_0I41 : MapSimpleDataElement
	{
		public E_0I41()
		{
			DataType = DataType.DT;
			MinLength = 6;
			MaxLength = 6;
		}
	}
	public class E_0I42 : MapSimpleDataElement
	{
		public E_0I42()
		{
			DataType = DataType.TM;
			MinLength = 4;
			MaxLength = 6;
		}
	}
	public class E_0I43 : MapSimpleDataElement
	{
		public E_0I43()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "000","001","002","003","004","005","006","007","008","009","010","011","012","013","014","015","016","017","018","019","020","021","022","023","024","025","026","027","028","029","030","031","032","033" });
		}
	}
	public class E_0I44 : MapSimpleDataElement
	{
		public E_0I44()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_0I45 : MapSimpleDataElement
	{
		public E_0I45()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 14;
		}
	}
	public class E_0I46 : MapSimpleDataElement
	{
		public E_0I46()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0I47 : MapSimpleDataElement
	{
		public E_0I47()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_0I48 : MapSimpleDataElement
	{
		public E_0I48()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0I49 : MapSimpleDataElement
	{
		public E_0I49()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 35;
		}
	}
	public class E_0I50 : MapSimpleDataElement
	{
		public E_0I50()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0I51 : MapSimpleDataElement
	{
		public E_0I51()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 35;
		}
	}
	public class E_0I52 : MapSimpleDataElement
	{
		public E_0I52()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0I53 : MapSimpleDataElement
	{
		public E_0I53()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 14;
		}
	}
	public class E_0I54 : MapSimpleDataElement
	{
		public E_0I54()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_0I55 : MapSimpleDataElement
	{
		public E_0I55()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 14;
		}
	}
	public class E_0I58 : MapSimpleDataElement
	{
		public E_0I58()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","Z" });
		}
	}
	public class E_0I59 : MapSimpleDataElement
	{
		public E_0I59()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 35;
		}
	}
	public class E_0I60 : MapSimpleDataElement
	{
		public E_0I60()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2" });
		}
	}
	public class E_0I61 : MapSimpleDataElement
	{
		public E_0I61()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_0I62 : MapSimpleDataElement
	{
		public E_0I62()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","Z" });
		}
	}
	public class E_0I63 : MapSimpleDataElement
	{
		public E_0I63()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6" });
		}
	}
	public class E_0I64 : MapSimpleDataElement
	{
		public E_0I64()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 6;
		}
	}
	public class E_1000 : MapSimpleDataElement
	{
		public E_1000()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_1002 : MapSimpleDataElement
	{
		public E_1002()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","9" });
		}
	}
	public class E_1003 : MapSimpleDataElement
	{
		public E_1003()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_1004 : MapSimpleDataElement
	{
		public E_1004()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","05","06","07","08","09","1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","3","30","31","32","33","34","35","36","37","38","4","40","41","42","43","44","45","46","47","48","49","5","50","51","52","53","59","6","60","61","62","63","64","65","66","67","68","69","7","70","71","72","76","77","78","79","8","80","81","82","83","84","85","86","87","88","89","9","90","91","92","93","94","95","96","97","98","99","A","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AP","AR","AT","B","BA","BB","BC","BD","BE","BF","BG","BH","BP","BS","BU","C","CA","CB","CH","CJ","CN","CO","CP","CR","CS","CU","D","DF","DY","E","EA","EF","EP","F","FT","FV","GA","IA","IN","KA","KB","LM","M","MA","MN","MS","MX","N","NA","NH","O","OC","OF","OH","OP","P","PA","PC","PD","PF","PH","PM","PN","PP","PR","PT","PV","R","RA","RB","RC","RD","RF","RG","RI","RL","RO","RP","RQ","RR","RS","S","SA","SC","SD","SE","SF","SG","T","TP","W","WI","WK","X","X1","XT" });
		}
	}
	public class E_1005 : MapSimpleDataElement
	{
		public E_1005()
		{
			DataType = DataType.ID;
			MinLength = 4;
			MaxLength = 4;
			AllowedValues.AddRange(new[] { "0001","0002","0003","0004","0010","0011","0012","0013","0014","0015","0016","0017","0018","0019","0020","0021","0022","0023","0035","0036","0055","0056","0057","0058","0059","0060","0061","0062","0063","0064","0065","0066","0067","0068","0069","0070","0071","0072","0073","0074","0075","0076","0077","0078","0079","0080","0081","0082","0083","0200","0201","0202","0203","0204","0205","0206","0207","0208","0209","0210","ZZZZ" });
		}
	}
	public class E_1006 : MapSimpleDataElement
	{
		public E_1006()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","6","7","8","9","AA" });
		}
	}
	public class E_1007 : MapSimpleDataElement
	{
		public E_1007()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","T","U" });
		}
	}
	public class E_1008 : MapSimpleDataElement
	{
		public E_1008()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "11","12","13","30","6","7","9","AA","AG","AP","AR","CR","CV","DO","FB","JV","LC","MS","NT","OT","PC","SR","SV","TR","XX","ZZ" });
		}
	}
	public class E_1009 : MapSimpleDataElement
	{
		public E_1009()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","AB","AD","AG","AJ","AL","AM","AS","B","C","CA","CB","CH","CI","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CV","CY","D","DA","DI","DJ","DM","DO","DS","F","FC","GS","HO","HP","HU","I","IC","J","JC","JP","JU","LA","LE","M","M1","M2","M3","MA","MC","MP","MU","MY","OR","OT","P","PC","PK","PL","PO","PP","PR","PS","S","SA","SB","SC","SD","SH","SJ","SO","SP","SR","SS","ST","SU","T","TA","TB","TJ","TO","TR","U","V","WA","X","ZZ" });
		}
	}
	public class E_1010 : MapSimpleDataElement
	{
		public E_1010()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1011 : MapSimpleDataElement
	{
		public E_1011()
		{
			DataType = DataType.AN;
			MinLength = 7;
			MaxLength = 7;
		}
	}
	public class E_1012 : MapSimpleDataElement
	{
		public E_1012()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "A","AC","AS","C","CL","D","DO","H","I","M","N","O","OP","OR","OT","P","PA","PD","PE","PY","S","SJ","SU","TR","W","ZZZ" });
		}
	}
	public class E_1013 : MapSimpleDataElement
	{
		public E_1013()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "1","101","11B","11I","12B","12I","12N","12Y","13B","13I","13N","13P","13Y","18J","18O","2","23A","23B","24B","25","26","27","28","3","305","306","308","309","310","311","315","4","417","5","603","610","611","612","616","619","621","623","625","628","629","630","631","638","642","70","700","701","7BA","7IA","9A","9B","9C","9D","9E","9F","9G","9H","9I","AB","CJ","CP","DEF","DIS","DJ","DOT","FAM","FCL","FFS","FJ","ITB","JC","JN","NOA","OCP","ODC","OFR","POC","SCH","SJ","YJ","ZZZ" });
		}
	}
	public class E_1014 : MapSimpleDataElement
	{
		public E_1014()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1015 : MapSimpleDataElement
	{
		public E_1015()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","7","9" });
		}
	}
	public class E_1016 : MapSimpleDataElement
	{
		public E_1016()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5" });
		}
	}
	public class E_1017 : MapSimpleDataElement
	{
		public E_1017()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","AL","AR","BG","BM","BO","BP","BR","BS","BT","BW","C","CH","CM","DA","DB","EB","EU","GC","HL","I","JL","MG","ML","NF","OL","OP","P","PA","PB","PC","PD","PE","PF","PK","PO","PP","PT","PW","PZ","R","SM","SO","SR","SS","T","TC","TL","TR","TX","U","VT","WP" });
		}
	}
	public class E_1018 : MapSimpleDataElement
	{
		public E_1018()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_1019 : MapSimpleDataElement
	{
		public E_1019()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "IBM","IEL","INR" });
		}
	}
	public class E_1020 : MapSimpleDataElement
	{
		public E_1020()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "GC","SU","UP" });
		}
	}
	public class E_1021 : MapSimpleDataElement
	{
		public E_1021()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1023 : MapSimpleDataElement
	{
		public E_1023()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D" });
		}
	}
	public class E_1024 : MapSimpleDataElement
	{
		public E_1024()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1025 : MapSimpleDataElement
	{
		public E_1025()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","C","R" });
		}
	}
	public class E_1026 : MapSimpleDataElement
	{
		public E_1026()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "999","ALU","CST","FBG","NIK","SST","TTN" });
		}
	}
	public class E_1028 : MapSimpleDataElement
	{
		public E_1028()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 38;
		}
	}
	public class E_1029 : MapSimpleDataElement
	{
		public E_1029()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","4","5","6","7","8","9","AD","AP","CC","CL","CP","I","RA","RB","RC","RD","RO" });
		}
	}
	public class E_1030 : MapSimpleDataElement
	{
		public E_1030()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "999","ASB","BUN","BUT","EPD","FDA","HYP","KAL","LEA","NAT","NEO","SAN","TEF","VIT" });
		}
	}
	public class E_1031 : MapSimpleDataElement
	{
		public E_1031()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "999","BUT","CER","CHL","DER","HAL","HER","KYN","NAT","NIC","POL","TEF","VIT" });
		}
	}
	public class E_1032 : MapSimpleDataElement
	{
		public E_1032()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","AM","BL","CH","CI","CN","DS","FI","HM","LI","LM","MA","MB","MC","MH","OF","SA","TV","VA","WB","WC","WD","WE","ZZ" });
		}
	}
	public class E_1033 : MapSimpleDataElement
	{
		public E_1033()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CO","CR","DE","MA","NC","OA","PI","PR" });
		}
	}
	public class E_1034 : MapSimpleDataElement
	{
		public E_1034()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_1035 : MapSimpleDataElement
	{
		public E_1035()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 35;
		}
	}
	public class E_1036 : MapSimpleDataElement
	{
		public E_1036()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 25;
		}
	}
	public class E_1037 : MapSimpleDataElement
	{
		public E_1037()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 25;
		}
	}
	public class E_1038 : MapSimpleDataElement
	{
		public E_1038()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_1039 : MapSimpleDataElement
	{
		public E_1039()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_1041 : MapSimpleDataElement
	{
		public E_1041()
		{
			DataType = DataType.R9;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_1042 : MapSimpleDataElement
	{
		public E_1042()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AC","BL","BS","PS","PU" });
		}
	}
	public class E_1043 : MapSimpleDataElement
	{
		public E_1043()
		{
			DataType = DataType.R2;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1044 : MapSimpleDataElement
	{
		public E_1044()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AAM","ACD","CEM","CRO","FDA","GAL","HOT","LIQ","NIR","NIT","PUR","SST","TEF","VIT" });
		}
	}
	public class E_1045 : MapSimpleDataElement
	{
		public E_1045()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AL","BR","IR","NS","SS" });
		}
	}
	public class E_1046 : MapSimpleDataElement
	{
		public E_1046()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AC","DF","DM","QF","QM","TH","TM" });
		}
	}
	public class E_1047 : MapSimpleDataElement
	{
		public E_1047()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AD","AF","AI","CY","DB","DR","ME","ND","NO","PR","SC","SE","VI" });
		}
	}
	public class E_1048 : MapSimpleDataElement
	{
		public E_1048()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "COL","CON","DBT","PCS","PEN","PRL","TAX","VEN" });
		}
	}
	public class E_1049 : MapSimpleDataElement
	{
		public E_1049()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_1050 : MapSimpleDataElement
	{
		public E_1050()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_1051 : MapSimpleDataElement
	{
		public E_1051()
		{
			DataType = DataType.N2;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_1053 : MapSimpleDataElement
	{
		public E_1053()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "LX1","LX2" });
		}
	}
	public class E_1054 : MapSimpleDataElement
	{
		public E_1054()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AG","AU","PT" });
		}
	}
	public class E_1056 : MapSimpleDataElement
	{
		public E_1056()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1062 : MapSimpleDataElement
	{
		public E_1062()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 4;
			AllowedValues.AddRange(new[] { "AF","BK","CB","CC","CL","CS","DP","LD","LS","MM","PH","PL","RL","RP","RS","SH","SW","UL","WH","WW" });
		}
	}
	public class E_1065 : MapSimpleDataElement
	{
		public E_1065()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","C","D","E","G","L" });
		}
	}
	public class E_1066 : MapSimpleDataElement
	{
		public E_1066()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","C","D","E","F" });
		}
	}
	public class E_1067 : MapSimpleDataElement
	{
		public E_1067()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","I","K","M","R","S","U","W","X" });
		}
	}
	public class E_1068 : MapSimpleDataElement
	{
		public E_1068()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","F","M","N","U","X" });
		}
	}
	public class E_1069 : MapSimpleDataElement
	{
		public E_1069()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","36","37","38","39","40","41","43","45","46","47","48","49","50","51","52","53","55","56","57","58","59","60","61","62","63","64","65","66","67","68","70","71","72","73","74","75","76","78","79","80","81","82","83","84","86","87","88","90","91","92","93","94","95","96","97","98","99","A1","A2","A3","A4","A5","A6","A7","A8","A9","B1","B2","B3","B4","B5","B6","B7","B8","B9","C1","C2","C3","C4","C5","C8","C9","D1","D2","D3","D4","D5","D6","D7","D8","D9","E1","E2","E3","E4","E5","E6","E7","E8","E9","F1","F2","F3","F6","F7","F8","F9","G2","G3","G4","G5","G6","G7","G8","G9","H1","H4","N1","OT","ZZ" });
		}
	}
	public class E_1070 : MapSimpleDataElement
	{
		public E_1070()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","9","A","B","C","D","F","H","I","L","N" });
		}
	}
	public class E_1071 : MapSimpleDataElement
	{
		public E_1071()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","91","92","93","94","95","96","97","98" });
		}
	}
	public class E_1072 : MapSimpleDataElement
	{
		public E_1072()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "5","D","T","U" });
		}
	}
	public class E_1073 : MapSimpleDataElement
	{
		public E_1073()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","U","W","Y" });
		}
	}
	public class E_1074 : MapSimpleDataElement
	{
		public E_1074()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","UN","ZZ" });
		}
	}
	public class E_1075 : MapSimpleDataElement
	{
		public E_1075()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","J","P","R","S","T" });
		}
	}
	public class E_1076 : MapSimpleDataElement
	{
		public E_1076()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","D","L","M" });
		}
	}
	public class E_1077 : MapSimpleDataElement
	{
		public E_1077()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","R" });
		}
	}
	public class E_1078 : MapSimpleDataElement
	{
		public E_1078()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","F","G","H","L","O","R","S","T","U","X" });
		}
	}
	public class E_1079 : MapSimpleDataElement
	{
		public E_1079()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "E","F","M","T" });
		}
	}
	public class E_1080 : MapSimpleDataElement
	{
		public E_1080()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "2","3","4","5" });
		}
	}
	public class E_1081 : MapSimpleDataElement
	{
		public E_1081()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","30","31","AL","AR","AU","BO","CC","CO","CT","FM","MH","PE","RE","RV","SL","SM","SO" });
		}
	}
	public class E_1082 : MapSimpleDataElement
	{
		public E_1082()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","04","05","06","07","08","09","11","12","13","14","16","17","18","20","21","22","23","24","25","ZZ" });
		}
	}
	public class E_1083 : MapSimpleDataElement
	{
		public E_1083()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","09","10","11","12","13","14","27","28","29","30","31","32","33","34","35","36","37","38","41","42","43","44","ZZ" });
		}
	}
	public class E_1084 : MapSimpleDataElement
	{
		public E_1084()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "P","T" });
		}
	}
	public class E_1085 : MapSimpleDataElement
	{
		public E_1085()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31" });
		}
	}
	public class E_1086 : MapSimpleDataElement
	{
		public E_1086()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7" });
		}
	}
	public class E_1087 : MapSimpleDataElement
	{
		public E_1087()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","P","S" });
		}
	}
	public class E_1088 : MapSimpleDataElement
	{
		public E_1088()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1089 : MapSimpleDataElement
	{
		public E_1089()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","ZZ" });
		}
	}
	public class E_1090 : MapSimpleDataElement
	{
		public E_1090()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","I","P" });
		}
	}
	public class E_1091 : MapSimpleDataElement
	{
		public E_1091()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A" });
		}
	}
	public class E_1092 : MapSimpleDataElement
	{
		public E_1092()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1093 : MapSimpleDataElement
	{
		public E_1093()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","C","D","F","G","I","J","Z" });
		}
	}
	public class E_1094 : MapSimpleDataElement
	{
		public E_1094()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1095 : MapSimpleDataElement
	{
		public E_1095()
		{
			DataType = DataType.N0;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_1096 : MapSimpleDataElement
	{
		public E_1096()
		{
			DataType = DataType.AN;
			MinLength = 5;
			MaxLength = 5;
		}
	}
	public class E_1097 : MapSimpleDataElement
	{
		public E_1097()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4" });
		}
	}
	public class E_1098 : MapSimpleDataElement
	{
		public E_1098()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","D","F" });
		}
	}
	public class E_1099 : MapSimpleDataElement
	{
		public E_1099()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","N","O","P" });
		}
	}
	public class E_1100 : MapSimpleDataElement
	{
		public E_1100()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","Z" });
		}
	}
	public class E_1101 : MapSimpleDataElement
	{
		public E_1101()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","W","Z" });
		}
	}
	public class E_1102 : MapSimpleDataElement
	{
		public E_1102()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","D","N" });
		}
	}
	public class E_1103 : MapSimpleDataElement
	{
		public E_1103()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","F","R" });
		}
	}
	public class E_1104 : MapSimpleDataElement
	{
		public E_1104()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22" });
		}
	}
	public class E_1105 : MapSimpleDataElement
	{
		public E_1105()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7" });
		}
	}
	public class E_1106 : MapSimpleDataElement
	{
		public E_1106()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","51","52","53","54","56","57","58","59","60","61","62","63","64","65","66","67","68","69","71","74","79","80","90","91","92","93","94","96","97" });
		}
	}
	public class E_1107 : MapSimpleDataElement
	{
		public E_1107()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","11","12","13","17","18","19","20","21" });
		}
	}
	public class E_1108 : MapSimpleDataElement
	{
		public E_1108()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12" });
		}
	}
	public class E_1109 : MapSimpleDataElement
	{
		public E_1109()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "7","8","A","B","C","D","E","F","G","H","I","J","N","O","P","Z" });
		}
	}
	public class E_1110 : MapSimpleDataElement
	{
		public E_1110()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_1113 : MapSimpleDataElement
	{
		public E_1113()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BB","DH","DM","EC","FS","HO","HS","IL","IP","MO","MR","NC","OP","RI","SP","TM" });
		}
	}
	public class E_1122 : MapSimpleDataElement
	{
		public E_1122()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","Z" });
		}
	}
	public class E_1123 : MapSimpleDataElement
	{
		public E_1123()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "01","AA","AB","AC","AD","AE","AF","AG","EX","FE","MA","NS","NT","PF","SD","SM","TO","TR","ZZ" });
		}
	}
	public class E_1126 : MapSimpleDataElement
	{
		public E_1126()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_1127 : MapSimpleDataElement
	{
		public E_1127()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CA","CC","CD","CH","CO","CP","CT","DA","DG","DO","DR","DT","GD","LT","NP","NR","OP","OR","PS","PT","RT","SA","SC","SF","SN","SS","ST","T1","TD","TR","UT" });
		}
	}
	public class E_1129 : MapSimpleDataElement
	{
		public E_1129()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","22","23","24","25","26","27","28","29","3","30","31","32","34","35","36","37","38","39","4","40","41","42","43","44","45","46","5","57","58","6","60","61","62","63","64","65","66","67","69","7","71","72","73","74","75","76","77","78","79","8","80","81","82","83","84","85","86","87","88","89","9","90","91","92","93","94","95","96","97","98","99","A1","A2","A3","A4","A5","A6","A7","A8","A9","B1","B2","B3","B4","B5","B6","B7","B8","B9","C1","C2","C3","C4","C5","C6","C7","C8","C9","D1","D2","D3","D4","D5","D6","D7","D8","D9","E1","E2","E3","E4","E5","E6","E7","F1","F2","F3","F4","F5","F6","F7","F8","F9","G2","G3","G4","G5","G6","G7","G8","G9","H2","H3" });
		}
	}
	public class E_1130 : MapSimpleDataElement
	{
		public E_1130()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","P" });
		}
	}
	public class E_1131 : MapSimpleDataElement
	{
		public E_1131()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","0K","10","11","12","20","21","22","23","24","25","26","27","28","29","30","31","32","33","AD","AS","BD","C2","DD","EL","EM","HG","HS","IF","IN","MD","MS","NO","P0","P1","P2","P3","P4","P5","PC","PD","PF","PK","PS","SS","UN","VR","VS" });
		}
	}
	public class E_1132 : MapSimpleDataElement
	{
		public E_1132()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","4","5","6","7","8","9" });
		}
	}
	public class E_1133 : MapSimpleDataElement
	{
		public E_1133()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","31","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","50","51","52","53","54","55","56","57","58","59","6","60","61","62","63","64","65","66","67","68","69","7","70","71","72","73","74","75","76","77","8","9" });
		}
	}
	public class E_1134 : MapSimpleDataElement
	{
		public E_1134()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5" });
		}
	}
	public class E_1135 : MapSimpleDataElement
	{
		public E_1135()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7" });
		}
	}
	public class E_1136 : MapSimpleDataElement
	{
		public E_1136()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","98","99","A1","A2","A3","A4","A5","A7","A8","A9","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ","DA","DB","DC","DD","DE","DF","DG","DH","DI","DP","DR","DV","E1","E2","E3","E4","E5","EB","EC","ED","EE","EF","EG","EH","EI","EJ","FA","FC","FH","FI","FP","FR","FT","GD","GS","GU","HA","HB","HC","HD","HE","HF","HG","HH","HI","HJ","HK","HL","HM","HN","HO","HP","HQ","HR","HS","HT","HY","HZ","IC","ID","IH","IM","IN","LA","LE","LL","LR","LS","LT","LZ","MA","MI","MN","MO","MP","MS","MT","NC","NS","NW","OA","OC","OF","ON","OP","OT","OU","PA","PB","PC","PD","PE","PF","PG","PI","PN","PO","PR","PS","PT","R1","R2","R3","R4","R5","RC","RE","RI","RL","RM","RN","RR","RS","RT","RU","RV","SA","SD","SE","SI","SJ","SL","SN","SP","SR","SS","ST","SU","SW","SZ","TB","TE","TF","TH","TI","TM","TN","TP","TR","TW","UP","VA","VC","VD","VO","WA","WM","ZZ" });
		}
	}
	public class E_1137 : MapSimpleDataElement
	{
		public E_1137()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_1138 : MapSimpleDataElement
	{
		public E_1138()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","O","P","S","T","U" });
		}
	}
	public class E_1139 : MapSimpleDataElement
	{
		public E_1139()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1140 : MapSimpleDataElement
	{
		public E_1140()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "C","D","F","S","W" });
		}
	}
	public class E_1141 : MapSimpleDataElement
	{
		public E_1141()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","G","N","Q","S","U","V","X" });
		}
	}
	public class E_1142 : MapSimpleDataElement
	{
		public E_1142()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","3","4","5","6","7","8","9","A","AR","B","D","DL","E","F","G","H","I","L","M","P","R","T","U","V" });
		}
	}
	public class E_1143 : MapSimpleDataElement
	{
		public E_1143()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1144 : MapSimpleDataElement
	{
		public E_1144()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_1145 : MapSimpleDataElement
	{
		public E_1145()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_1146 : MapSimpleDataElement
	{
		public E_1146()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","Z" });
		}
	}
	public class E_1147 : MapSimpleDataElement
	{
		public E_1147()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","M","N","P","R","T","V","W","X","Z" });
		}
	}
	public class E_1148 : MapSimpleDataElement
	{
		public E_1148()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1149 : MapSimpleDataElement
	{
		public E_1149()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 6;
		}
	}
	public class E_1150 : MapSimpleDataElement
	{
		public E_1150()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","R","X" });
		}
	}
	public class E_1152 : MapSimpleDataElement
	{
		public E_1152()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "IA","MC","TC" });
		}
	}
	public class E_1153 : MapSimpleDataElement
	{
		public E_1153()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","E","G","L","M","N","S","T","V","W","X","Z" });
		}
	}
	public class E_1154 : MapSimpleDataElement
	{
		public E_1154()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "H","L","M","R" });
		}
	}
	public class E_1155 : MapSimpleDataElement
	{
		public E_1155()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1156 : MapSimpleDataElement
	{
		public E_1156()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","Z" });
		}
	}
	public class E_1157 : MapSimpleDataElement
	{
		public E_1157()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4" });
		}
	}
	public class E_1158 : MapSimpleDataElement
	{
		public E_1158()
		{
			DataType = DataType.AN;
			MinLength = 5;
			MaxLength = 5;
		}
	}
	public class E_1159 : MapSimpleDataElement
	{
		public E_1159()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","H","I","J","K","L","M","N","O","P","Q","R","S","T" });
		}
	}
	public class E_1160 : MapSimpleDataElement
	{
		public E_1160()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","Z" });
		}
	}
	public class E_1161 : MapSimpleDataElement
	{
		public E_1161()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","2","28","29","3","30","31","4","5","6","7","8","9","A","B","BA","C","D","GA","N","NC","O","PD","S" });
		}
	}
	public class E_1162 : MapSimpleDataElement
	{
		public E_1162()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "EV","FS","LA","LN","LS","MA","NR","SP" });
		}
	}
	public class E_1163 : MapSimpleDataElement
	{
		public E_1163()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AD","CH","EX","GR","NR","RR","SP","ST" });
		}
	}
	public class E_1164 : MapSimpleDataElement
	{
		public E_1164()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","ZZ" });
		}
	}
	public class E_1165 : MapSimpleDataElement
	{
		public E_1165()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "O","R","U" });
		}
	}
	public class E_1166 : MapSimpleDataElement
	{
		public E_1166()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","09","AB","AC","AD","AE","AF","AG","AH","AI","AJ","CA","CB","CH","CP","CS","CW","CX","CY","DI","EA","ER","FA","FB","FC","FD","FE","FF","FG","FH","FI","FJ","FK","FL","FM","FR","FX","LA","LE","LH","OC","PR","SP","TM","ZZ" });
		}
	}
	public class E_1167 : MapSimpleDataElement
	{
		public E_1167()
		{
			DataType = DataType.R6;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_1168 : MapSimpleDataElement
	{
		public E_1168()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","A3","A4","A5","A6","A7","AO","B1","B2","B3","B4","B5","B6","B7","BO" });
		}
	}
	public class E_1171 : MapSimpleDataElement
	{
		public E_1171()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_1172 : MapSimpleDataElement
	{
		public E_1172()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "CDR","CMP","DC","ELH","ELR","EPC","EW","FRS","FWC","IIS","IRS","IWS","MAP","NCR","NEW","NOP","NRI","NSB","NWR","PNP","PWA","RDP","SUB","UPR","UR","URF","WBS" });
		}
	}
	public class E_1173 : MapSimpleDataElement
	{
		public E_1173()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","20","21","22","PI","PM","SM","ZZ" });
		}
	}
	public class E_1174 : MapSimpleDataElement
	{
		public E_1174()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_1175 : MapSimpleDataElement
	{
		public E_1175()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_1176 : MapSimpleDataElement
	{
		public E_1176()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","53","54","55","56","57","58","ZZ" });
		}
	}
	public class E_1178 : MapSimpleDataElement
	{
		public E_1178()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1179 : MapSimpleDataElement
	{
		public E_1179()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","W" });
		}
	}
	public class E_1180 : MapSimpleDataElement
	{
		public E_1180()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_1181 : MapSimpleDataElement
	{
		public E_1181()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","EA","EF","EP","EU","FR","LA","LD","LE","LO","LP","LS","MA","MC","MN","OT","SC" });
		}
	}
	public class E_1185 : MapSimpleDataElement
	{
		public E_1185()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","ZZ" });
		}
	}
	public class E_1186 : MapSimpleDataElement
	{
		public E_1186()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","38","39","40","41","42","43","44","45","46","47","48","49","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","91","92","93","94","AI","BG","EI","HR","K1","PD","PS","SA","SB","SC","SP","VP","ZZ" });
		}
	}
	public class E_1187 : MapSimpleDataElement
	{
		public E_1187()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33" });
		}
	}
	public class E_1188 : MapSimpleDataElement
	{
		public E_1188()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","98","99","AA","AB","ZZ" });
		}
	}
	public class E_1189 : MapSimpleDataElement
	{
		public E_1189()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","I","M","O","R" });
		}
	}
	public class E_1193 : MapSimpleDataElement
	{
		public E_1193()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","11","13","14","15","20","21","22","23","24","25","AQ","AR","AZ","BD","CL","CS","GA","GD","GP","GT","MH","PL","PN","SF","SN","SP" });
		}
	}
	public class E_1195 : MapSimpleDataElement
	{
		public E_1195()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 80;
		}
	}
	public class E_1196 : MapSimpleDataElement
	{
		public E_1196()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","70","71","72","73","74","75","77","78","79","80","81","82","83","84","85","86","87","88","A1","A2","A3","A4","A5","A6","A7","A8","A9","AT","B1","B2","B3","B4","B5","BL","BY","C1","C2","C3","C4","CM","CY","D1","D2","D3","D4","D5","D6","D7","E1","E2","E3","E4","EH","ES","EX","F1","F2","F3","F4","FE","FP","FR","G1","G2","G3","G4","G5","H1","H2","H3","H4","H5","I1","IN","J1","J2","K6","L1","LM","M1","MD","MR","N1","NP","P1","P2","P3","P4","P5","P6","RL","SC","TA","TC","TD","TR","TU","UB","ZZ" });
		}
	}
	public class E_1197 : MapSimpleDataElement
	{
		public E_1197()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AD","AV","BA","BM","BP","BV","C","D","M","NA","O","P","R","RD","RE","RI","RN","S","TR" });
		}
	}
	public class E_1198 : MapSimpleDataElement
	{
		public E_1198()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03" });
		}
	}
	public class E_1199 : MapSimpleDataElement
	{
		public E_1199()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","ZZ" });
		}
	}
	public class E_1201 : MapSimpleDataElement
	{
		public E_1201()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","L","O","P","S","T" });
		}
	}
	public class E_1202 : MapSimpleDataElement
	{
		public E_1202()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "D","E","H","L","Z" });
		}
	}
	public class E_1203 : MapSimpleDataElement
	{
		public E_1203()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","4A","4B","4C","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","XB","XI","XL","XM","XN","XT","ZZ" });
		}
	}
	public class E_1204 : MapSimpleDataElement
	{
		public E_1204()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 50;
		}
	}
	public class E_1205 : MapSimpleDataElement
	{
		public E_1205()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "403","AC","ADD","AF","AG","AH","AI","AJ","AK","AP","AR","BC","BE","BH","BK","CHU","CLF","CV","DCP","DEN","EMP","EPO","FAC","FSA","GDC","HE","HLT","HMO","IRA","IRC","LL","LTC","LTD","MM","MOD","NGD","NQ","PDG","POS","PPO","PRA","PSP","QDA","QDC","STD","UL","UR","VIS","ZZZ" });
		}
	}
	public class E_1207 : MapSimpleDataElement
	{
		public E_1207()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "CHD","DEP","E1D","E2D","E3D","E5D","E6D","E7D","E8D","E9D","ECH","EMP","ESP","FAM","IND","SPC","SPO","TWO" });
		}
	}
	public class E_1209 : MapSimpleDataElement
	{
		public E_1209()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","I","N","S" });
		}
	}
	public class E_1211 : MapSimpleDataElement
	{
		public E_1211()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AM","BAX","FLR","HCS","NP","PCS","THR","ZZ" });
		}
	}
	public class E_1212 : MapSimpleDataElement
	{
		public E_1212()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","S","T","U","X" });
		}
	}
	public class E_1213 : MapSimpleDataElement
	{
		public E_1213()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","E","F","G","P" });
		}
	}
	public class E_1214 : MapSimpleDataElement
	{
		public E_1214()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_1215 : MapSimpleDataElement
	{
		public E_1215()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "D","H","P" });
		}
	}
	public class E_1216 : MapSimpleDataElement
	{
		public E_1216()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","I","S","T","V" });
		}
	}
	public class E_1218 : MapSimpleDataElement
	{
		public E_1218()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E" });
		}
	}
	public class E_1219 : MapSimpleDataElement
	{
		public E_1219()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","ZZ" });
		}
	}
	public class E_1220 : MapSimpleDataElement
	{
		public E_1220()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "F","N","P" });
		}
	}
	public class E_1221 : MapSimpleDataElement
	{
		public E_1221()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AD","AS","AT","BI","BS","CO","CV","H","HH","LA","ON","OP","OR","OT","P1","P2","PC","PE","PT","PU","R","RF","RP","SB","SK","SU" });
		}
	}
	public class E_1222 : MapSimpleDataElement
	{
		public E_1222()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1223 : MapSimpleDataElement
	{
		public E_1223()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "001","002","003","004","005","006","007","008" });
		}
	}
	public class E_1224 : MapSimpleDataElement
	{
		public E_1224()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AC","EA","EB","EC","ED","EI","EM","EP","ER","ES","ET","EU","IC","MB","MS","MT","MU","NC","NQ","PB","PS","PT","QC","QE","QM","QP","RA","RK","RO","RP","RS","RT","SD","SP","ZZ" });
		}
	}
	public class E_1225 : MapSimpleDataElement
	{
		public E_1225()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_1226 : MapSimpleDataElement
	{
		public E_1226()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_1227 : MapSimpleDataElement
	{
		public E_1227()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1228 : MapSimpleDataElement
	{
		public E_1228()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1229 : MapSimpleDataElement
	{
		public E_1229()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 6;
		}
	}
	public class E_1230 : MapSimpleDataElement
	{
		public E_1230()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 4;
			AllowedValues.AddRange(new[] { "AF","CA","CB","CC","CG","CP","CR","CS","CW","DD","DW","EC","ED","EE","EF","EM","EW","FC","FW","GC","GM","GR","IO","LF","LL","LO","LP","LW","MB","MC","MG","MI","MR","MS","NE","OW","PD","PG","PL","PO","PW","QP","RC","RD","RN","RP","RR","RS","RT","SB","SC","SD","SP","SS","ST","SW","TC","TP","UE","WC" });
		}
	}
	public class E_1231 : MapSimpleDataElement
	{
		public E_1231()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 3;
		}
	}
	public class E_1232 : MapSimpleDataElement
	{
		public E_1232()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AE","CN","DR","ER","HW","IR","MD","OV","RD","RE","SB","SP","SU","SV","TE","UT" });
		}
	}
	public class E_1233 : MapSimpleDataElement
	{
		public E_1233()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_1234 : MapSimpleDataElement
	{
		public E_1234()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1236 : MapSimpleDataElement
	{
		public E_1236()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "6A","9A","9B","9C" });
		}
	}
	public class E_1237 : MapSimpleDataElement
	{
		public E_1237()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "F","J","P","R","T" });
		}
	}
	public class E_1238 : MapSimpleDataElement
	{
		public E_1238()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1239 : MapSimpleDataElement
	{
		public E_1239()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","AA" });
		}
	}
	public class E_1240 : MapSimpleDataElement
	{
		public E_1240()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1G","2G","A","AX","BC","BW","C","CL","CX","D","DA","FX","G","GA","GX","J","K","L","LK","M","N","NF","NH","OF","RH","RR","TP","TR","U","Y" });
		}
	}
	public class E_1241 : MapSimpleDataElement
	{
		public E_1241()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","F","H","L","P","S","X" });
		}
	}
	public class E_1242 : MapSimpleDataElement
	{
		public E_1242()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_1243 : MapSimpleDataElement
	{
		public E_1243()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 3;
		}
	}
	public class E_1244 : MapSimpleDataElement
	{
		public E_1244()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 27;
		}
	}
	public class E_1245 : MapSimpleDataElement
	{
		public E_1245()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1246 : MapSimpleDataElement
	{
		public E_1246()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BH","RT","TA" });
		}
	}
	public class E_1250 : MapSimpleDataElement
	{
		public E_1250()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "CC","CD","CM","CQ","CY","D6","D8","DA","DB","DD","DT","DTS","EH","KA","MD","MM","RD","RD2","RD4","RD5","RD6","RD8","RDM","RDT","RMD","RMY","RTM","RTS","TC","TM","TQ","TR","TS","TT","TU","UN","YM","YMM","YY" });
		}
	}
	public class E_1251 : MapSimpleDataElement
	{
		public E_1251()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 35;
		}
	}
	public class E_1252 : MapSimpleDataElement
	{
		public E_1252()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 6;
		}
	}
	public class E_1253 : MapSimpleDataElement
	{
		public E_1253()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 6;
		}
	}
	public class E_1254 : MapSimpleDataElement
	{
		public E_1254()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1255 : MapSimpleDataElement
	{
		public E_1255()
		{
			DataType = DataType.AN;
			MinLength = 3;
			MaxLength = 6;
		}
	}
	public class E_1256 : MapSimpleDataElement
	{
		public E_1256()
		{
			DataType = DataType.AN;
			MinLength = 5;
			MaxLength = 5;
		}
	}
	public class E_1257 : MapSimpleDataElement
	{
		public E_1257()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","27","28","3","4","5","6","7","8","9","99" });
		}
	}
	public class E_1258 : MapSimpleDataElement
	{
		public E_1258()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1260 : MapSimpleDataElement
	{
		public E_1260()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_1261 : MapSimpleDataElement
	{
		public E_1261()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_1262 : MapSimpleDataElement
	{
		public E_1262()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","29","3","30","31","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","50","51","52","53","54","55","56","57","58","59","6","60","61","62","63","64","65","66","67","7","8","9","90","91","92","93" });
		}
	}
	public class E_1264 : MapSimpleDataElement
	{
		public E_1264()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","11","12","13","14","15","16","17","2","20","21","22","23","24","25","26","27","28","29","3","30","31","32","33","34","35","36","37","4","5","6","9" });
		}
	}
	public class E_1265 : MapSimpleDataElement
	{
		public E_1265()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7" });
		}
	}
	public class E_1266 : MapSimpleDataElement
	{
		public E_1266()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1267 : MapSimpleDataElement
	{
		public E_1267()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6" });
		}
	}
	public class E_1268 : MapSimpleDataElement
	{
		public E_1268()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1270 : MapSimpleDataElement
	{
		public E_1270()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "0","1","10","100","101","102","103","104","105","106","107","108","109","11","12","13","14","16","17","19","2","20","21","22","23","24","25","26","27","28","29","3","30","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","52","53","54","55","56","57","58","59","6","60","61","62","63","66","67","69","7","71","74","75","78","79","8","80","81","82","83","84","85","87","88","89","9","90","91","92","93","94","95","96","97","98","99","A","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AAA","AB","ABR","ABS","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","ALP","AM","AN","AO","AP","APE","AQ","AR","AS","AT","AU","AW","AX","B","BA","BB","BC","BCC","BCR","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BPL","BQ","BR","BRL","BS","BSL","BU","BV","BY","BZ","C","C1","C2","C3","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CLP","CM","CML","CN","CO","COG","CPS","CRC","CS","CSF","CT","CU","CV","CW","CZ","D","D1","D2","D3","D4","D5","DA","DB","DBS","DC","DD","DE","DF","DG","DGO","DH","DI","DJ","DK","DL","DLO","DLP","DM","DN","DO","DPE","DPL","DQ","DR","DS","DT","DU","DW","DX","DY","DZ","E","EA","EB","EC","ED","EE","EF","EG","EH","EI","EJ","EK","EL","EM","EN","EO","EQ","ER","ES","ESL","ET","ETL","EU","EV","EW","EWC","EWR","EX","EY","EZ","F","FA","FB","FC","FD","FE","FF","FG","FH","FI","FJ","FK","FL","FM","FN","FO","FP","FQ","FR","FS","FT","FU","FV","FW","FX","FZ","G","G1","GA","GB","GC","GD","GE","GF","GG","GI","GJ","GK","GQ","GR","GS","GT","GU","GV","GW","H","HA","HB","HD","HE","HI","HRC","HS","HZR","I","IC","ID","IF","IMC","IMP","IPA","IQ","IT","J","J0","J1","J2","J3","J4","J5","J6","J7","J8","J9","JA","JB","JC","JCL","JD","JE","JF","JG","JH","JI","JK","JL","JM","JN","JO","JOL","JP","K","KA","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KO","KP","KQ","KS","KT","KU","KW","KYL","KZ","L","LA","LB","LC","LD","LE","LF","LG","LH","LIN","LJ","LK","LM","LN","LO","LOI","LP","LQ","LR","LS","LSC","LT","LZ","M","MB","MC","MCC","MCD","ME","MI","MJ","MK","ML","MN","MOC","N","NA","NAC","NAF","NAS","NB","NC","ND","NDC","NE","NF","NH","NI","NJ","NK","NL","NP","NR","NS","NT","O","O1","O2","O3","O4","OC","P","PB","PC","PD","PGS","PI","PIT","PL","PLC","PLS","PPD","PPP","PPS","PPV","PRA","PRC","PRR","PRT","PS","PWA","PWI","PWR","PWS","PWT","Q","QA","QB","QC","QE","QF","QG","QH","QI","QJ","QK","QS","R","RA","RC","RCA","RD","RE","REN","RF","RI","RQ","RR","RT","RTC","RUM","RX","S","SA","SB","SBA","SC","SD","SE","SEC","SF","SG","SH","SHL","SI","SJ","SL","SM","SMI","SO","SP","SPE","SR","SRL","SS","ST","STC","T","T00","T01","T02","T03","T04","T05","T06","T07","T08","T09","T10","T11","T12","T13","T14","T15","T16","T17","T18","T19","T20","T21","TB","TC","TCL","TD","TE","TF","TG","TOL","TR","TTL","TX","TY","U","UP","UR","US","UU","V","W","WDL","X","Y","Z","ZZ" });
		}
	}
	public class E_1271 : MapSimpleDataElement
	{
		public E_1271()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_1272 : MapSimpleDataElement
	{
		public E_1272()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 16;
		}
	}
	public class E_1273 : MapSimpleDataElement
	{
		public E_1273()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","F","U" });
		}
	}
	public class E_1274 : MapSimpleDataElement
	{
		public E_1274()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_1275 : MapSimpleDataElement
	{
		public E_1275()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","C","F","N" });
		}
	}
	public class E_1276 : MapSimpleDataElement
	{
		public E_1276()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_1277 : MapSimpleDataElement
	{
		public E_1277()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","4","5" });
		}
	}
	public class E_1278 : MapSimpleDataElement
	{
		public E_1278()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","S" });
		}
	}
	public class E_1280 : MapSimpleDataElement
	{
		public E_1280()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","S","W" });
		}
	}
	public class E_1292 : MapSimpleDataElement
	{
		public E_1292()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CR","DI","KA","KR","MW","PA","RA","RD","RF","RN","RP","RT","SC","SD" });
		}
	}
	public class E_1293 : MapSimpleDataElement
	{
		public E_1293()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BC","CO","CV","DA","DI","DM","DP","DR","DT","EI","EO","EW","LP","MD","NA","OP","PE","PF","PR","PS","PW","RE","SD","SM","SP","SR","ST","TE","WG" });
		}
	}
	public class E_1294 : MapSimpleDataElement
	{
		public E_1294()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "EW","FR","IN","IO","MI","NR","OS","PC","PR","QD","RR","RT","SR","UI" });
		}
	}
	public class E_1295 : MapSimpleDataElement
	{
		public E_1295()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","AN","AV","C","CD","D","DB","DN","DP","DR","DV","EL","GA","KP","N","PD","PF","R","RT","S","S1","S2","TD","TN","TR","TS","TV","US" });
		}
	}
	public class E_1296 : MapSimpleDataElement
	{
		public E_1296()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_1297 : MapSimpleDataElement
	{
		public E_1297()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CL","CO","NS","RE","ST","VO" });
		}
	}
	public class E_1300 : MapSimpleDataElement
	{
		public E_1300()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_1301 : MapSimpleDataElement
	{
		public E_1301()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_1302 : MapSimpleDataElement
	{
		public E_1302()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1303 : MapSimpleDataElement
	{
		public E_1303()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8" });
		}
	}
	public class E_1304 : MapSimpleDataElement
	{
		public E_1304()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1306 : MapSimpleDataElement
	{
		public E_1306()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1307 : MapSimpleDataElement
	{
		public E_1307()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","1A","1B","1C","1D","1E","1F","1G","1H","1J","1K","1L","1M","1N","1P","1Q","1R","1S","1T","1U","1V","1W","1X","1Y","1Z","2","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2D","2E","2F","2G","2H","2I","2J","2K","2L","2M","2N","2P","2Q","2R","2S","2U","2V","2W","2X","2Y","2Z","3","30","31","32","33","34","35","36","37","38","39","3A","4","40","41","42","43","44","45","46","47","48","49","5","50","51","52","53","54","55","56","57","58","59","6","60","61","62","63","64","65","66","67","68","69","7","70","71","72","73","74","75","76","77","78","79","8","80","81","82","83","84","85","86","87","88","89","9","90","91","92","93","94","95","96","97","98","99","AA","ZA","ZZ" });
		}
	}
	public class E_1308 : MapSimpleDataElement
	{
		public E_1308()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CO","KA","KB","KC","KD","KE","KF","KG","PE","RP","ZZ" });
		}
	}
	public class E_1309 : MapSimpleDataElement
	{
		public E_1309()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","24","25","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56","57","58","59","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","K1","K2","K3","K4","K5","K6","KH","KI","KJ","KK","KL","KM","KN","KO","KP","KQ","KR","KS","KT","KU","KV","KW","KX","KY","KZ","L2" });
		}
	}
	public class E_1310 : MapSimpleDataElement
	{
		public E_1310()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","G","P" });
		}
	}
	public class E_1311 : MapSimpleDataElement
	{
		public E_1311()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","D","E","F","M","N","Q","R","S" });
		}
	}
	public class E_1312 : MapSimpleDataElement
	{
		public E_1312()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "TF","TI","TO" });
		}
	}
	public class E_1313 : MapSimpleDataElement
	{
		public E_1313()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 6;
		}
	}
	public class E_1314 : MapSimpleDataElement
	{
		public E_1314()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1315 : MapSimpleDataElement
	{
		public E_1315()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1316 : MapSimpleDataElement
	{
		public E_1316()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "I","R","T","X" });
		}
	}
	public class E_1317 : MapSimpleDataElement
	{
		public E_1317()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E" });
		}
	}
	public class E_1318 : MapSimpleDataElement
	{
		public E_1318()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1319 : MapSimpleDataElement
	{
		public E_1319()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1320 : MapSimpleDataElement
	{
		public E_1320()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3" });
		}
	}
	public class E_1321 : MapSimpleDataElement
	{
		public E_1321()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","1A","1B","1C","1D","1E","1F","1G","1H","1I","1J","1K","1L","1M","1N","1O","1P","1Q","1R","1S","1T","1U","1V","1W","1X","1Y","1Z","20","21","22","23","24","25","26","27","28","29","2A","2B","2C","2D","2E","2F","2G","2H","2I","2J","2K","2L","2M","2N","2O","2P","2Q","2R","2S","2T","2U","2V","2W","2X","2Y","2Z","30","31","32","33","34","35","36","37","38","39","3A","3B","3C","3D","3E","3F","3G","3H","3I","3J","3K","3L","3M","3N","3O","3P","3Q","3R","3S","3T","3U","3V","3W","3X","3Y","3Z","40","41","42","43","44","45","46","47","48","49","4A","4B","4C","4D","4E","4F","4G","4H","4I","4J","4K","4L","4M","4N","4O","4P","4Q","4R","4S","4T","4U","4V","4W","4X","4Y","4Z","50","51","52","53","54","55","56","57","58","59","5A","5B","5C","5D","5E","5F","5G","5H","5I","5J","5K","5L","5M","5N","5O","5P","5Q","5R","5S","5T","5U","5V","5W","5X","5Y","5Z","60","61","62","63","64","65","66","67","68","69","6A","6B","6C","6D","6E","6F","6G","6H","6I","6J","6K","6L","6M","6N","6O","6P","6Q","6R","6S","6T","6U","6V","6W","6X","6Y","6Z","70","71","72","73","74","75","76","77","78","79","7A","7B","7C","7D","7E","7F","7G","7H","7I","7J","7K","7L","7M","7N","7O","7P","7Q","7R","7S","7T","7U","7V","7W","7X","7Y","7Z","80","81","82","83","84","85","86","87","88","89","8A","8B","8C","8D","8E","8F","8G","8H","8I","8J","8K","8L","8M","8N","8O","8P","8Q","8R","8S","8T","8U","8V","8W","8X","8Y","8Z","90","91","92","93","94","95","96","97","98","99","9A","9B","9C","9D","9E","9F","9G","9H","9I","9J","9K","9L","9M","9N","9O","9P","9Q","9R","9S","9T","9U","9V","9W","9X","9Y","9Z","A1","A2","A3","A4","A5","A7","A8","A9","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B1","B2","B3","B4","B5","B6","B7","B8","B9","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","BU","BV","BW","BX","BY","BZ","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","CG","CH","CI","CJ","CK","CL","CM","CN","CO","CP","CQ","CR","CS","CT","CU","CV","CW","CX","CY","CZ","D1","D2","D3","D4","D5","D6","D7","D8","D9","DA","DB","DC","DD","DE","DF","DG","DH","DI","DJ","DK","DL","DM","DN","DO","DP","DQ","DR","DS","DT","DU","DV","DW","DX","DY","DZ","E0","E1","E2","E3","E4","E5","E6","E7","E8","E9","EA","EB","EC","ED","EE","EF","EG","EH","EI","EJ","EK","EL","EM","EN","EO","EP","EQ","ER","ES","ET","EU","EV","EW","EX","EY","EZ","F0","F1","F2","F3","F4","F5","F6","F7","F8","F9","FA","FB","FC","FD","FE","FF","FG","FH","FI","FJ","FK","FL","FM","FN","FO","FP","FQ","FR","FS","FT","FU","FV","FW","FX","FY","FZ","G0","G1","G2","G3","G4","G5","G6","G7","G8","G9","GA","GB","GC","GD","GE","GF","GG","GH","GI","GJ","GK","GL","GM","GN","GO","GP","GQ","GR","GS","GT","GU","GV","GW","GX","GY","GZ","H0","H1","H2","H3","H4","H5","H6","H7","H8","H9","HA","HB","HC","HD","HE","HF","HG","HH","HI","HJ","HK","HL","HM","HN","HO","HP","HQ","HR","HS","HT","HU","HV","HW","HX","HY","HZ","I1","I2","I3","I4","I5","I6","I7","I8","IA","IB","IC","ID","IE","IF","IG","IH","II","IJ","IK","IM","IN","IO","IP","IQ","IR","IS","IT","IU","IV","IW","IX","IY","IZ","J1","J2","J3","J4","J5","J6","J7","J8","J9","JA","JB","JC","JD","JE","JF","JH","JI","JJ","JK","JL","JM","JN","JO","JP","JQ","JR","JS","JT","JU","JV","JW","JX","JY","K0","K1","K2","K3","K4","K5","K6","K7","K8","K9","KA","KB","KC","KD","KE","KF","KG","KH","KI","KJ","KK","KL","KM","KN","KO","KP","KQ","KR","KS","KT","KU","KV","KW","KX","KY","KZ","L1","L2","L3","L4","L5","L6","L7","LA","LB","LC","LD","LE","LF","LG","LH","LI","LJ","LK","LL","LM","LO","LP","LR","LS","LT","LU","LV","LW","M1","M2","MA","MB","MC","MD","MF","MG","MH","MI","MJ","MK","ML","MM","MN","MO","MP","MQ","MR","MS","MT","MU","MV","MW","MX","MY","MZ","NA","NB","NC","ND","NE","NF","NG","NH","NI","NJ","NK","NL","NN","NP","NR","NU","OL","OO","OP","OR","OT","OV","P1","P2","P3","P4","P5","P6","P9","PA","PB","PC","PD","PE","PF","PG","PH","PI","PK","PM","PO","PP","PR","PS","PT","PV","PW","PY","PZ","Q1","Q2","Q3","Q4","Q5","Q6","Q7","Q8","Q9","QA","QB","QC","QD","QE","QF","QG","QH","QI","QJ","QK","QL","QM","QN","QO","QP","QQ","QR","QS","QT","QU","R1","R2","R3","R4","R5","R6","R7","R8","R9","RA","RB","RC","RD","RE","RF","RG","RH","RI","RJ","RK","RL","RM","RN","RO","RP","RQ","RR","RS","RT","RU","RV","RW","RX","RY","RZ","S1","S2","S3","S5","SA","SB","SC","SD","SE","SF","SG","SH","SL","SM","SN","SO","SP","SQ","SR","ST","SU","SV","SW","SX","SY","SZ","T1","T2","T3","T4","T5","T6","TA","TB","TC","TD","TE","TF","TM","TP","TR","TV","U1","U2","U3","U4","U5","U6","U7","U8","U9","UA","UB","UC","UD","UE","UF","UG","UH","UI","UJ","UK","UL","UM","UN","UO","UP","UQ","UR","US","UT","UU","UV","UW","UX","UY","UZ","V1","V2","V3","V4","V5","V6","V7","VA","VB","VC","VD","VE","VF","VG","VH","VI","VJ","VK","VL","VM","VN","VO","VT","VU","W1","W2","W3","W4","W5","W6","W7","W8","W9","WA","WB","WC","WD","WE","WF","WG","WH","WI","WK","WL","WM","WN","WO","WP","WR","WS","WT","WU","WV","WW","WX","WY","WZ","XA","XB","XC","XD","XE","XF","XG","XH","XI","XJ","XK","XL","XM","XN","XO","XP","XQ","XR","XS","XT","XU","XV","XW","XX","XY","XZ","YA","YB","YC","YD","YE","YF","YG","YH","YJ","ZA","ZB","ZC","ZD","ZE","ZF","ZG","ZH","ZI","ZK","ZL","ZM","ZN","ZO","ZP","ZQ","ZR","ZS","ZT","ZU","ZW","ZY","ZZ" });
		}
	}
	public class E_1322 : MapSimpleDataElement
	{
		public E_1322()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","A","B","C","D","E","I","R","S" });
		}
	}
	public class E_1325 : MapSimpleDataElement
	{
		public E_1325()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1327 : MapSimpleDataElement
	{
		public E_1327()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3" });
		}
	}
	public class E_1328 : MapSimpleDataElement
	{
		public E_1328()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1329 : MapSimpleDataElement
	{
		public E_1329()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1330 : MapSimpleDataElement
	{
		public E_1330()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","10","11","12","13","14","15","16","20","21","22","23","24","25","30","31","32","33","34","40","41","42","43","50","51","52","53","60","61","62","63","64","65","66","67","68","69","70","71","72","73","74","75","76","77","78","79","80","81","82","83","84","85","86","87","88","89","90","91","92","93","94","95","96","97","98","99" });
		}
	}
	public class E_1331 : MapSimpleDataElement
	{
		public E_1331()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1332 : MapSimpleDataElement
	{
		public E_1332()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","B" });
		}
	}
	public class E_1333 : MapSimpleDataElement
	{
		public E_1333()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "C","D","E","F","P","S" });
		}
	}
	public class E_1334 : MapSimpleDataElement
	{
		public E_1334()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1335 : MapSimpleDataElement
	{
		public E_1335()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","N" });
		}
	}
	public class E_1336 : MapSimpleDataElement
	{
		public E_1336()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "12","13","14","15","16","41","42","43","47","AP","C1","CO","CP","D","DB","EP","FF","GP","HM","HN","HS","IN","IP","LC","LD","LI","LT","MA","MB","MC","MH","MI","MP","OT","PE","PL","PP","PR","PS","QM","RP","SP","TF","WC","WU" });
		}
	}
	public class E_1337 : MapSimpleDataElement
	{
		public E_1337()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8" });
		}
	}
	public class E_1338 : MapSimpleDataElement
	{
		public E_1338()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "00","01","02","03","04","05","06","09","10","11","F1","F2","I","L","NBC","R","U" });
		}
	}
	public class E_1339 : MapSimpleDataElement
	{
		public E_1339()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_1340 : MapSimpleDataElement
	{
		public E_1340()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "N","P","S" });
		}
	}
	public class E_1341 : MapSimpleDataElement
	{
		public E_1341()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1342 : MapSimpleDataElement
	{
		public E_1342()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","D","E","F","G","M" });
		}
	}
	public class E_1343 : MapSimpleDataElement
	{
		public E_1343()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","AA","AM","AN","CF","CH","CS","DA","DD","DM","DN","ER","HH","HS","IF","IL","L","LT","MD","MF","MH","MI","MO","MS","NM","NP","NS","O","OC","OP","OT","OX","P","PA","PD","PE","PF","PS","PT","RX","S","SC","SN","ST","T","TX","V" });
		}
	}
	public class E_1344 : MapSimpleDataElement
	{
		public E_1344()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "L","N","O" });
		}
	}
	public class E_1345 : MapSimpleDataElement
	{
		public E_1345()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1346 : MapSimpleDataElement
	{
		public E_1346()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "G","P","S" });
		}
	}
	public class E_1347 : MapSimpleDataElement
	{
		public E_1347()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "G","J","N","O" });
		}
	}
	public class E_1348 : MapSimpleDataElement
	{
		public E_1348()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","O" });
		}
	}
	public class E_1349 : MapSimpleDataElement
	{
		public E_1349()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "E","N","O","R","S","W","X" });
		}
	}
	public class E_1350 : MapSimpleDataElement
	{
		public E_1350()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1351 : MapSimpleDataElement
	{
		public E_1351()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","C","M","P","S" });
		}
	}
	public class E_1352 : MapSimpleDataElement
	{
		public E_1352()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1354 : MapSimpleDataElement
	{
		public E_1354()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_1355 : MapSimpleDataElement
	{
		public E_1355()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "00","01","02","03","04","05","06","07" });
		}
	}
	public class E_1356 : MapSimpleDataElement
	{
		public E_1356()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3" });
		}
	}
	public class E_1357 : MapSimpleDataElement
	{
		public E_1357()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5","6","7" });
		}
	}
	public class E_1358 : MapSimpleDataElement
	{
		public E_1358()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "I","R" });
		}
	}
	public class E_1359 : MapSimpleDataElement
	{
		public E_1359()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","P" });
		}
	}
	public class E_1360 : MapSimpleDataElement
	{
		public E_1360()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "D","E","H","I","N","P","Y" });
		}
	}
	public class E_1361 : MapSimpleDataElement
	{
		public E_1361()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "00","01","02","03","04","05","06","07","08","09","10","20","30","40","L","R" });
		}
	}
	public class E_1362 : MapSimpleDataElement
	{
		public E_1362()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AA","AB","AP","EM","OA","ZZ" });
		}
	}
	public class E_1363 : MapSimpleDataElement
	{
		public E_1363()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","I","M","N","O","Y" });
		}
	}
	public class E_1364 : MapSimpleDataElement
	{
		public E_1364()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","L","N" });
		}
	}
	public class E_1365 : MapSimpleDataElement
	{
		public E_1365()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","16","17","18","19","2","20","21","22","23","24","25","26","27","28","3","30","31","32","33","34","35","36","37","38","39","4","40","41","42","43","44","45","46","47","48","49","5","50","51","52","53","54","55","56","57","58","59","6","60","61","62","63","64","65","66","67","68","69","7","70","71","72","73","74","75","76","77","78","79","8","80","81","82","83","84","85","86","87","88","89","9","90","91","92","93","94","95","96","97","98","99","A0","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AQ","AR","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BP","BQ","BR","BS" });
		}
	}
	public class E_1366 : MapSimpleDataElement
	{
		public E_1366()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10" });
		}
	}
	public class E_1367 : MapSimpleDataElement
	{
		public E_1367()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "C1","C2","C3","C4","C5","C6","C7","CO","IL","L1","L2","L3","L4","L5","OC","SA","T1","T10","T11","T12","T2","T3","T4","T5","T6","T7","T8","T9" });
		}
	}
	public class E_1368 : MapSimpleDataElement
	{
		public E_1368()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "E","I","M","X" });
		}
	}
	public class E_1369 : MapSimpleDataElement
	{
		public E_1369()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "B","D","F","I","L","M","O" });
		}
	}
	public class E_1370 : MapSimpleDataElement
	{
		public E_1370()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5","6","7","8","Z" });
		}
	}
	public class E_1371 : MapSimpleDataElement
	{
		public E_1371()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 10;
		}
	}
	public class E_1373 : MapSimpleDataElement
	{
		public E_1373()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 4;
			AllowedValues.AddRange(new[] { "BM","BO","DM","FT","MA","MM","OM","PT","TM","VA","VB","VC" });
		}
	}
	public class E_1374 : MapSimpleDataElement
	{
		public E_1374()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1375 : MapSimpleDataElement
	{
		public E_1375()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 5;
		}
	}
	public class E_1376 : MapSimpleDataElement
	{
		public E_1376()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","1A","1B","1C","1D","1E","1F","1G","1H","1J","1K","IL" });
		}
	}
	public class E_1378 : MapSimpleDataElement
	{
		public E_1378()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "W1","W2","W3","W4","W5","W6","W7","W8","W9" });
		}
	}
	public class E_1379 : MapSimpleDataElement
	{
		public E_1379()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "0","1","10","11","12","13","14","15","16","17","18","19","2","20","21","3","4","5","6","7","8","9" });
		}
	}
	public class E_1382 : MapSimpleDataElement
	{
		public E_1382()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E" });
		}
	}
	public class E_1383 : MapSimpleDataElement
	{
		public E_1383()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "00","01","02","03","05","07","08","09","15","16","17","18","20","22","27","28","29","PB" });
		}
	}
	public class E_1384 : MapSimpleDataElement
	{
		public E_1384()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","L","M","O","P","R","S","T" });
		}
	}
	public class E_1387 : MapSimpleDataElement
	{
		public E_1387()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","14","15","2","2A","3","4","5","6","7","8","9","BA","CF","CM","CR","CX","DA","DI","DR","DS","IR","NB","NC","PB","PF","RR","SR","ST","UF" });
		}
	}
	public class E_1390 : MapSimpleDataElement
	{
		public E_1390()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","A","B","C","CB","D","E","F","G","H","I","J","K","L","M","MC","N","O","P","Q","R","S","T","U","V","W","X","Y" });
		}
	}
	public class E_1392 : MapSimpleDataElement
	{
		public E_1392()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 8;
		}
	}
	public class E_1393 : MapSimpleDataElement
	{
		public E_1393()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "MI","NE","RD","TV" });
		}
	}
	public class E_1395 : MapSimpleDataElement
	{
		public E_1395()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","B","C","S" });
		}
	}
	public class E_1396 : MapSimpleDataElement
	{
		public E_1396()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","G","R" });
		}
	}
	public class E_1397 : MapSimpleDataElement
	{
		public E_1397()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1398 : MapSimpleDataElement
	{
		public E_1398()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X" });
		}
	}
	public class E_1400 : MapSimpleDataElement
	{
		public E_1400()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_1401 : MapSimpleDataElement
	{
		public E_1401()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP" });
		}
	}
	public class E_1402 : MapSimpleDataElement
	{
		public E_1402()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "ATM","C02","CLE","DHT","DWI","FAP","GEN","LIN","MCP","MOI","N2","NDO","NOI","ODF","PCO","PRE","PSE","RAD","RUS","SLI","SMO","STE","SUB","SUR","TBT","TEC","VOD","VOS","YEA" });
		}
	}
	public class E_1403 : MapSimpleDataElement
	{
		public E_1403()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1404 : MapSimpleDataElement
	{
		public E_1404()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2" });
		}
	}
	public class E_1407 : MapSimpleDataElement
	{
		public E_1407()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2" });
		}
	}
	public class E_1408 : MapSimpleDataElement
	{
		public E_1408()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03" });
		}
	}
	public class E_1413 : MapSimpleDataElement
	{
		public E_1413()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","P","R" });
		}
	}
	public class E_1415 : MapSimpleDataElement
	{
		public E_1415()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_1420 : MapSimpleDataElement
	{
		public E_1420()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AP","CL","CP","ES","MP","PP","SE","SP","SV","TC","TD","TI","TP","ZZ" });
		}
	}
	public class E_1422 : MapSimpleDataElement
	{
		public E_1422()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "NW","PE","RP","UK","ZZ" });
		}
	}
	public class E_1423 : MapSimpleDataElement
	{
		public E_1423()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AM","AP","AQ","AR","AT","BU","CC","CI","CO","CU","DA","DB","DD","DL","DP","DU","DV","DX","EX","FD","FG","FM","IP","IT","JJ","LE","LF","LS","MC","MD","MF","ML","MP","MV","NG","OB","OL","PC","PE","PH","PX","RE","RI","RP","RV","S1","SC","SN","ST","SV","TK","TL","TM","TP","TR","TX","US","UV","VF","VN" });
		}
	}
	public class E_1425 : MapSimpleDataElement
	{
		public E_1425()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1426 : MapSimpleDataElement
	{
		public E_1426()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "0","2","3","4","5","6","7","8","9","A","B","C","D","E","F","Z" });
		}
	}
	public class E_1428 : MapSimpleDataElement
	{
		public E_1428()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","P" });
		}
	}
	public class E_1429 : MapSimpleDataElement
	{
		public E_1429()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "0","1","2","3","4","5","6","7","8","9","A","A0","A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" });
		}
	}
	public class E_1430 : MapSimpleDataElement
	{
		public E_1430()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 7;
		}
	}
	public class E_1431 : MapSimpleDataElement
	{
		public E_1431()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","D","N","O" });
		}
	}
	public class E_1460 : MapSimpleDataElement
	{
		public E_1460()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_1465 : MapSimpleDataElement
	{
		public E_1465()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AB","BL","BO","EB","EO","FO","IN","LO","NB","NE","NL","NO","NW","RO","SB","SE","SO","SW","WB","WO","ZZ" });
		}
	}
	public class E_1466 : MapSimpleDataElement
	{
		public E_1466()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AE","AF","AL","AT","FC","LL","PL","RC","RL","TT","VL","WB","WE","WK","WL","WS","WX","ZZ" });
		}
	}
	public class E_1468 : MapSimpleDataElement
	{
		public E_1468()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "10","11","12","13","14","15","16","17","18","19","D1","D2","F1","F2","L1","L2","L3","L4","M1","M2","M3","M4","M5","O1","O2","O3","O4","O5","O6","O7","Q1","R1","V1","V2","V3","V4","V5" });
		}
	}
	public class E_1469 : MapSimpleDataElement
	{
		public E_1469()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6" });
		}
	}
	public class E_1470 : MapSimpleDataElement
	{
		public E_1470()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_1472 : MapSimpleDataElement
	{
		public E_1472()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_1473 : MapSimpleDataElement
	{
		public E_1473()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "00","01","02","03","04","05","06","07","08","09","10","11","12","13","14" });
		}
	}
	public class E_1476 : MapSimpleDataElement
	{
		public E_1476()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","A","B","C","D","E" });
		}
	}
	public class E_1482 : MapSimpleDataElement
	{
		public E_1482()
		{
			DataType = DataType.AN;
			MinLength = 4;
			MaxLength = 4;
		}
	}
	public class E_1484 : MapSimpleDataElement
	{
		public E_1484()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "ES","MC","ME","MP","PE","RP","SH","SP","TC","TD" });
		}
	}
	public class E_1485 : MapSimpleDataElement
	{
		public E_1485()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","R" });
		}
	}
	public class E_1487 : MapSimpleDataElement
	{
		public E_1487()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "BO","CI","CU","DE","ET","HL","HR","HW","ID","MS","MV","OK","OP","RR","SI","SK","SL","SO","TA","TC","TD","TM","TR","WA","WC","WD","WE","WI","WT" });
		}
	}
	public class E_1488 : MapSimpleDataElement
	{
		public E_1488()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q" });
		}
	}
	public class E_1489 : MapSimpleDataElement
	{
		public E_1489()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CC","CW","DE","EM","HI","LI","MI","MS","NB","OC","OI","WG" });
		}
	}
	public class E_1490 : MapSimpleDataElement
	{
		public E_1490()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1491 : MapSimpleDataElement
	{
		public E_1491()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1492 : MapSimpleDataElement
	{
		public E_1492()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","3","4","6","8","A","B","C","P","R" });
		}
	}
	public class E_1493 : MapSimpleDataElement
	{
		public E_1493()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","E","F","G","H","L","P" });
		}
	}
	public class E_1494 : MapSimpleDataElement
	{
		public E_1494()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 1;
		}
	}
	public class E_1496 : MapSimpleDataElement
	{
		public E_1496()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","22","23","26","27","28","29","30","31","32","33","34","35","36","37","38","39","40","41","42","43","44","45","46","47","48","49","50","51","52","53","54","55","56" });
		}
	}
	public class E_1497 : MapSimpleDataElement
	{
		public E_1497()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1499 : MapSimpleDataElement
	{
		public E_1499()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "DE","OR" });
		}
	}
	public class E_1511 : MapSimpleDataElement
	{
		public E_1511()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CS","II","IO","IT","RI","RO","RT" });
		}
	}
	public class E_1514 : MapSimpleDataElement
	{
		public E_1514()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","15","16","17","2","3","4","5","6","7","8","9" });
		}
	}
	public class E_1520 : MapSimpleDataElement
	{
		public E_1520()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY" });
		}
	}
	public class E_1521 : MapSimpleDataElement
	{
		public E_1521()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN" });
		}
	}
	public class E_1522 : MapSimpleDataElement
	{
		public E_1522()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AE","AF","BA","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS" });
		}
	}
	public class E_1523 : MapSimpleDataElement
	{
		public E_1523()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","AD","AE","AF","AG","AH" });
		}
	}
	public class E_1525 : MapSimpleDataElement
	{
		public E_1525()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AR","BA","HS","IN","PR","RE","SC" });
		}
	}
	public class E_1526 : MapSimpleDataElement
	{
		public E_1526()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5" });
		}
	}
	public class E_1527 : MapSimpleDataElement
	{
		public E_1527()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6" });
		}
	}
	public class E_1528 : MapSimpleDataElement
	{
		public E_1528()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1540 : MapSimpleDataElement
	{
		public E_1540()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4" });
		}
	}
	public class E_1543 : MapSimpleDataElement
	{
		public E_1543()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B" });
		}
	}
	public class E_1546 : MapSimpleDataElement
	{
		public E_1546()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A","B","C","D","E" });
		}
	}
	public class E_1549 : MapSimpleDataElement
	{
		public E_1549()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","ZZ" });
		}
	}
	public class E_1550 : MapSimpleDataElement
	{
		public E_1550()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4" });
		}
	}
	public class E_1551 : MapSimpleDataElement
	{
		public E_1551()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 760;
		}
	}
	public class E_1552 : MapSimpleDataElement
	{
		public E_1552()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","10","11","12","13","2","3","4","5","6","7","8","9","ZZ" });
		}
	}
	public class E_1553 : MapSimpleDataElement
	{
		public E_1553()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","C1","C2","C3","F1","MV","P1","R1","S1","U1","U2","U3","U4" });
		}
	}
	public class E_1554 : MapSimpleDataElement
	{
		public E_1554()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","R","S","U","W" });
		}
	}
	public class E_1555 : MapSimpleDataElement
	{
		public E_1555()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","D","G","M" });
		}
	}
	public class E_1556 : MapSimpleDataElement
	{
		public E_1556()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "N","O","T" });
		}
	}
	public class E_1557 : MapSimpleDataElement
	{
		public E_1557()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E" });
		}
	}
	public class E_1558 : MapSimpleDataElement
	{
		public E_1558()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D" });
		}
	}
	public class E_1559 : MapSimpleDataElement
	{
		public E_1559()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","O","Q","R","S","T","U","V","X","Y","Z" });
		}
	}
	public class E_1560 : MapSimpleDataElement
	{
		public E_1560()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "C","E","I","N","O","P","R","S","T","V","W" });
		}
	}
	public class E_1561 : MapSimpleDataElement
	{
		public E_1561()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "L","S" });
		}
	}
	public class E_1565 : MapSimpleDataElement
	{
		public E_1565()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 760;
		}
	}
	public class E_1570 : MapSimpleDataElement
	{
		public E_1570()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "ASB","ASC","HDC","R64","UUE","ZZZ" });
		}
	}
	public class E_1572 : MapSimpleDataElement
	{
		public E_1572()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "ASV","CRT","PUB" });
		}
	}
	public class E_1573 : MapSimpleDataElement
	{
		public E_1573()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 760;
		}
	}
	public class E_1576 : MapSimpleDataElement
	{
		public E_1576()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "IB","II","IW" });
		}
	}
	public class E_1577 : MapSimpleDataElement
	{
		public E_1577()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1578 : MapSimpleDataElement
	{
		public E_1578()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CN","DP","GS","HH","HR","MS","PP","UP","UR" });
		}
	}
	public class E_1579 : MapSimpleDataElement
	{
		public E_1579()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "S","W","X" });
		}
	}
	public class E_1585 : MapSimpleDataElement
	{
		public E_1585()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CN","CY","OV","RL","SQ","TR" });
		}
	}
	public class E_1588 : MapSimpleDataElement
	{
		public E_1588()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AM","CM","CN","DM","FR","GN","GR","IN","LL","LR","LT","NP","OT","PF","RL","RP","SC","SL","TX","ZZ" });
		}
	}
	public class E_1589 : MapSimpleDataElement
	{
		public E_1589()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 2;
		}
	}
	public class E_1590 : MapSimpleDataElement
	{
		public E_1590()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","A3","A4","A5","A6","A7","A8","B1","B2","B3","B4","B5","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","CE","CF","D1","D2","D3","D4","D5","D6","E1","E2","E3","E4","E5","E6","F1","G1","G2","G3","G4","G5","G6","H1","H2","H3","I1","I2","I3","I4","I5","I6","I7","J1","L1","L2","L3","L4","M1","M2","M3","M4","M5","M6","N1","N2","N3","N4","N5","O1","O2","O3","P1","P2","P3","P4","P5","P6","P7","P8","P9","PA","R1","R2","R3","R4","R5","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SG","T1","T2","T3","T4","T5","T6","T7","T8","T9","TA","TB","TC","U1","U2","U3","W1","ZZ" });
		}
	}
	public class E_1591 : MapSimpleDataElement
	{
		public E_1591()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "24","A1","A2","A3","A4","A5","A7","A8","A9","AA","AB","AC","AD","AE","AF","AH","AI","B1","B2","B3","B4","B5","B6","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","CD","D1","D2","DR","E1","E2","F1","F2","F3","F4","F5","G1","G2","G3","H1","H2","H3","H4","I1","I2","I3","I4","I5","I6","J1","J2","K1","K2","M1","M2","M3","M4","M5","M6","M7","M8","M9","MA","MB","MC","MD","ME","MF","MG","MH","MI","MJ","MK","ML","N1","O1","O2","O3","O4","O5","O6","P1","P2","P3","P4","P5","P6","P7","P8","P9","PA","PB","PC","R1","R2","R3","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SG","T1","T2","U1","U2","U3","U4","W1","W2","W3","W4" });
		}
	}
	public class E_1592 : MapSimpleDataElement
	{
		public E_1592()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","A3","A4","A5","B1","D1","D2","D3","D4","D5","F1","F2","F3","G1","I1","I2","I3","I4","I5","L1","M1","M2","N1","N2","P1","R1","S1","S2","S3","S4","U1","V1" });
		}
	}
	public class E_1594 : MapSimpleDataElement
	{
		public E_1594()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","B1","B2","B3","C1","C2","C3","C4","C5","C6","C7","C8","D1","H1","H2","H3","H4","H5","L1","M1","M2","M3","N1","N2","N3","O1","O2","P1","P2","P3","P4","P5","S1","S2","S3","S4","S5","S6","T1","T2","W1" });
		}
	}
	public class E_1595 : MapSimpleDataElement
	{
		public E_1595()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O" });
		}
	}
	public class E_1596 : MapSimpleDataElement
	{
		public E_1596()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","A3","B1","B2","C1","C2","C3","C4","C5","C6","C7","C8","C9","E1","F1","F2","F3","F4","G1","G4","L1","L2","L3","L4","L5","L6","M1","M2","M3","M4","M5","M6","P1","P2","P3","P4","P5","R1","R2","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","T1","V1","W1" });
		}
	}
	public class E_1599 : MapSimpleDataElement
	{
		public E_1599()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","A3","A4","A5","A6","A7","A8","A9","AA","AB","B1","B2","B3","B4","B5","B6","C1","C2","C3","C4","C5","C6","C7","C8","C9","D1","D2","D3","D4","D5","D6","D7","D8","E1","E2","F1","F2","F3","F4","F5","F6","F7","F8","F9","FA","FB","G1","G2","G3","G4","G5","H1","H2","H3","H4","H5","H6","I1","I2","I3","J1","J2","J3","J4","K1","L1","L2","L3","L4","M1","M2","M3","M4","M5","M6","M7","M8","M9","MA","MB","MC","MD","O1","O2","O3","O4","P1","P2","P3","P4","P5","P6","R1","R2","R3","S1","S2","S3","S4","S5","S6","S7","S8","S9","SA","SB","SC","SD","SE","SF","SG","T1","T2","T3","T4","U1","U2","U3","U4","V1","V2","V3","W1" });
		}
	}
	public class E_1600 : MapSimpleDataElement
	{
		public E_1600()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CW","FR","PE","PF","PG","PM","PR","PT","SY" });
		}
	}
	public class E_1601 : MapSimpleDataElement
	{
		public E_1601()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AS","BW","CF","DW","FR","GA","HR","HW","MI","SY","TR","UN" });
		}
	}
	public class E_1602 : MapSimpleDataElement
	{
		public E_1602()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "ADF","ADV","BLK","COD","COL","DEL","DEP","DET","DIB","DSC","EIC","EXC","FLT","FSC","IDL","IPU","LDA","LDL","MIL","MIN","MRK","MSG","ONC","PLA","PWH","REP","RES","SOC","SPU","SRG","SUF","ZZZ" });
		}
	}
	public class E_1603 : MapSimpleDataElement
	{
		public E_1603()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 20;
		}
	}
	public class E_1606 : MapSimpleDataElement
	{
		public E_1606()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","ZY","ZZ" });
		}
	}
	public class E_1607 : MapSimpleDataElement
	{
		public E_1607()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","ZZ" });
		}
	}
	public class E_1608 : MapSimpleDataElement
	{
		public E_1608()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 30;
		}
	}
	public class E_1609 : MapSimpleDataElement
	{
		public E_1609()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "AI","AN","DFI","DT","EI","ES","IN","LI","MA","MV","PO","PR","PS","QY","RP","RS","RT","TT","TX","UP" });
		}
	}
	public class E_1610 : MapSimpleDataElement
	{
		public E_1610()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "DO","LT","ND","ZZ" });
		}
	}
	public class E_1611 : MapSimpleDataElement
	{
		public E_1611()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","ZZ" });
		}
	}
	public class E_1612 : MapSimpleDataElement
	{
		public E_1612()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","I","M","N","U" });
		}
	}
	public class E_1614 : MapSimpleDataElement
	{
		public E_1614()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 24;
		}
	}
	public class E_1615 : MapSimpleDataElement
	{
		public E_1615()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 16;
		}
	}
	public class E_1616 : MapSimpleDataElement
	{
		public E_1616()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 17;
		}
	}
	public class E_1617 : MapSimpleDataElement
	{
		public E_1617()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "B","M","S","U" });
		}
	}
	public class E_1618 : MapSimpleDataElement
	{
		public E_1618()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_1619 : MapSimpleDataElement
	{
		public E_1619()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","D","I" });
		}
	}
	public class E_1620 : MapSimpleDataElement
	{
		public E_1620()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16","17","18","19","20","21","ZZ" });
		}
	}
	public class E_1622 : MapSimpleDataElement
	{
		public E_1622()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","ZY","ZZ" });
		}
	}
	public class E_1626 : MapSimpleDataElement
	{
		public E_1626()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3" });
		}
	}
	public class E_1627 : MapSimpleDataElement
	{
		public E_1627()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","T" });
		}
	}
	public class E_1629 : MapSimpleDataElement
	{
		public E_1629()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","G","H","I","J","K","L","Z" });
		}
	}
	public class E_1630 : MapSimpleDataElement
	{
		public E_1630()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","A","B","C","D","E","F","G","H","I","J","M","S","V","W","Z" });
		}
	}
	public class E_1631 : MapSimpleDataElement
	{
		public E_1631()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","H","L","R","S","Z" });
		}
	}
	public class E_1632 : MapSimpleDataElement
	{
		public E_1632()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" });
		}
	}
	public class E_1633 : MapSimpleDataElement
	{
		public E_1633()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","E","G","H","Z" });
		}
	}
	public class E_1634 : MapSimpleDataElement
	{
		public E_1634()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "1","1A","1B","1C","1D","1E","1F","1G","1H","1J","1K","1L","1M","1N","1O","1P","1Q","1R","1S","1T","1U","1V","1W","1X","1Y","1Z","2","2A","2B","2C","2D","2E","2F","2G","2H","2I","2J","2K","2L","2M","2N","2O","2P","2Q","2R","2S","2T","2U","2V","2W","2X","3","4","5","6","7","8","9","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" });
		}
	}
	public class E_1635 : MapSimpleDataElement
	{
		public E_1635()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D","E","F","J","L","M","S","U","Z" });
		}
	}
	public class E_1636 : MapSimpleDataElement
	{
		public E_1636()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","A","B","C","D","E","F","G","H","I","J","L","M","N","O","P","Q","R","S","T","U","Z" });
		}
	}
	public class E_1637 : MapSimpleDataElement
	{
		public E_1637()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "G","N" });
		}
	}
	public class E_1638 : MapSimpleDataElement
	{
		public E_1638()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "1","2","3","4","5","6","7","8","9","A","B","C","Z" });
		}
	}
	public class E_1642 : MapSimpleDataElement
	{
		public E_1642()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "CCP","CER","CEX","CRQ","CRT","CRV","CSR","PUB" });
		}
	}
	public class E_1644 : MapSimpleDataElement
	{
		public E_1644()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "CO","CS","CT","FA","FP","RE","ST" });
		}
	}
	public class E_1650 : MapSimpleDataElement
	{
		public E_1650()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A3","A7","A9","AF","AG","AH","AI","AJ","AM","AN","AP","AR","AV","B6","BA","BC","C1","CA","CD","CL","CP","D1","I1","J1","K1","L1","OA","OO","P1","PR","R1","RL","S1","SD","X1","X2","X3","X4","X5","X6","X8","XB" });
		}
	}
	public class E_1651 : MapSimpleDataElement
	{
		public E_1651()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "A1","A2","A3","A5","A6","AA","AD","AE","AF","AG","AH","AI","AJ","AK","AL","AM","AN","AO","AP","AQ","AR","AS","AT","AU","AV","AW","AX","AY","AZ","B1","B2","B4","B5","B8","B9","BB","BC","BD","BE","BF","BG","BH","BI","BJ","BK","BL","BM","BN","BO","BP","BQ","BR","BS","BT","C1","C2","C3","C4","C5","C6","C7","C8","C9","CA","CB","CC","D1","D2","F1","F2","HB","NA","NS","P1","P2","P3","P4","RC","S1","T1","T2","T3","T4","T5","T6","T7" });
		}
	}
	public class E_1652 : MapSimpleDataElement
	{
		public E_1652()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","ED","EP","LD","LP","X9","XA" });
		}
	}
	public class E_1654 : MapSimpleDataElement
	{
		public E_1654()
		{
			DataType = DataType.AN;
			MinLength = 7;
			MaxLength = 7;
		}
	}
	public class E_1655 : MapSimpleDataElement
	{
		public E_1655()
		{
			DataType = DataType.AN;
			MinLength = 7;
			MaxLength = 7;
		}
	}
	public class E_1656 : MapSimpleDataElement
	{
		public E_1656()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C","D" });
		}
	}
	public class E_1657 : MapSimpleDataElement
	{
		public E_1657()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","C" });
		}
	}
	public class E_1658 : MapSimpleDataElement
	{
		public E_1658()
		{
			DataType = DataType.ID;
			MinLength = 3;
			MaxLength = 3;
			AllowedValues.AddRange(new[] { "CPT","CPU","EQT","EQU","LNH","PRM","WGT" });
		}
	}
	public class E_1661 : MapSimpleDataElement
	{
		public E_1661()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 2;
		}
	}
	public class E_1662 : MapSimpleDataElement
	{
		public E_1662()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 9;
		}
	}
	public class E_1663 : MapSimpleDataElement
	{
		public E_1663()
		{
			DataType = DataType.N0;
			MinLength = 1;
			MaxLength = 3;
		}
	}
	public class E_1664 : MapSimpleDataElement
	{
		public E_1664()
		{
			DataType = DataType.R4;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_1675 : MapSimpleDataElement
	{
		public E_1675()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC","ZZ" });
		}
	}
	public class E_1678 : MapSimpleDataElement
	{
		public E_1678()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","C","F","N","P","S","Z" });
		}
	}
	public class E_1679 : MapSimpleDataElement
	{
		public E_1679()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","L" });
		}
	}
	public class E_1680 : MapSimpleDataElement
	{
		public E_1680()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "AA","AB","AC" });
		}
	}
	public class E_1681 : MapSimpleDataElement
	{
		public E_1681()
		{
			DataType = DataType.ID;
			MinLength = 2;
			MaxLength = 2;
			AllowedValues.AddRange(new[] { "01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16" });
		}
	}
	public class E_1684 : MapSimpleDataElement
	{
		public E_1684()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_1685 : MapSimpleDataElement
	{
		public E_1685()
		{
			DataType = DataType.ID;
			MinLength = 1;
			MaxLength = 1;
			AllowedValues.AddRange(new[] { "A","B","N" });
		}
	}
	public class E_1687 : MapSimpleDataElement
	{
		public E_1687()
		{
			DataType = DataType.R;
			MinLength = 1;
			MaxLength = 15;
		}
	}
	public class E_1688 : MapSimpleDataElement
	{
		public E_1688()
		{
			DataType = DataType.AN;
			MinLength = 1;
			MaxLength = 4;
		}
	}
	public class E_9830 : MapSimpleDataElement
	{
		public E_9830()
		{
			DataType = DataType.TM;
			MinLength = 4;
			MaxLength = 8;
		}
	}
	public class E_G124 : MapSimpleDataElement
	{
		public E_G124()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 15;
		}
	}
	public class E_G142 : MapSimpleDataElement
	{
		public E_G142()
		{
			DataType = DataType.AN;
			MinLength = 2;
			MaxLength = 15;
		}
	}
}

