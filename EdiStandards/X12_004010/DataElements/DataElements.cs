using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;

namespace EdiEngine.Standards.X12_004010.DataElements
{
    public class E_0003 : MapDataElement
    {
        public E_0003()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 60;
        }
    }
    public class E_0011 : MapDataElement
    {
        public E_0011()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "A", "B", "C", "D", "E", "F", "G", "H", "J", "M", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y" });
        }
    }
    public class E_0019 : MapDataElement
    {
        public E_0019()
        {
            DataType = DataType.AN;
            MinLength = 2;
            MaxLength = 30;
        }
    }
    public class E_0022 : MapDataElement
    {
        public E_0022()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 30;
        }
    }
    public class E_0023 : MapDataElement
    {
        public E_0023()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "2", "3", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "P", "Q", "S", "T", "U", "V", "Z" });
        }
    }
    public class E_0026 : MapDataElement
    {
        public E_0026()
        {
            DataType = DataType.AN;
            MinLength = 2;
            MaxLength = 3;
        }
    }
    public class E_0040 : MapDataElement
    {
        public E_0040()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "20", "2B", "2D", "2E", "2F", "2G", "40", "4B", "AC", "AF", "AL", "AP", "AT", "BC", "BE", "BF", "BG", "BH", "BJ", "BK", "BO", "BR", "BX", "CA", "CB", "CC", "CD", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CZ", "DD", "DF", "DT", "DX", "ET", "FF", "FH", "FN", "FP", "FR", "FS", "FT", "FX", "GS", "HB", "HC", "HO", "HP", "HT", "HV", "HY", "ID", "IX", "LO", "LS", "LU", "NX", "OB", "OT", "OV", "PL", "PP", "PT", "PU", "RA", "RC", "RD", "RE", "RF", "RG", "RI", "RO", "RR", "RS", "RT", "SA", "SC", "SD", "SK", "SL", "SR", "SS", "ST", "SV", "TA", "TB", "TC", "TF", "TG", "TH", "TI", "TJ", "TK", "TL", "TM", "TN", "TO", "TP", "TQ", "TR", "TT", "TU", "TV", "TW", "UA", "UB", "UC", "UD", "UE", "UL", "UP", "VA", "VE", "VL", "VR", "VS", "VT", "WR", "WY" });
        }
    }
    public class E_0056 : MapDataElement
    {
        public E_0056()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "AI", "BB", "CS", "CY", "DD", "DR", "HA", "HH", "HL", "HP", "MC", "MD", "NC", "PH", "PP", "RD", "RE", "RR" });
        }
    }
    public class E_0059 : MapDataElement
    {
        public E_0059()
        {
            DataType = DataType.AN;
            MinLength = 2;
            MaxLength = 5;
        }
    }
    public class E_0061 : MapDataElement
    {
        public E_0061()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 30;
        }
    }
    public class E_0066 : MapDataElement
    {
        public E_0066()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "1", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "2", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "3", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "4", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "5", "50", "53", "54", "55", "56", "57", "58", "59", "6", "61", "62", "63", "64", "7", "71", "72", "73", "74", "75", "76", "77", "78", "8", "81", "82", "9", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "A", "A1", "A2", "A3", "A4", "A5", "A6", "AA", "AB", "AC", "AD", "AE", "AL", "AP", "BC", "BD", "BE", "BG", "BP", "BS", "C", "C1", "C2", "C5", "CA", "CB", "CC", "CD", "CE", "CF", "CI", "CL", "CM", "CP", "CR", "CS", "CT", "D", "DG", "DL", "DN", "DP", "DS", "E", "EC", "EH", "EI", "EP", "EQ", "ER", "ES", "F", "FA", "FB", "FC", "FD", "FI", "FJ", "FN", "G", "GA", "GC", "HC", "HN", "I", "J", "K", "L", "LC", "LD", "LE", "LI", "LN", "M3", "M4", "M5", "M6", "MA", "MB", "MC", "MD", "MI", "MK", "ML", "MN", "MP", "MR", "N", "NA", "ND", "NI", "NO", "OC", "OP", "PA", "PB", "PC", "PI", "PP", "PR", "RA", "RB", "RC", "RD", "RE", "RT", "S", "SA", "SB", "SD", "SF", "SI", "SJ", "SL", "SP", "ST", "SV", "SW", "TA", "TC", "TZ", "UC", "UL", "UM", "UP", "UR", "US", "WR", "XV", "XX", "ZC", "ZN", "ZY", "ZZ" });
        }
    }
    public class E_0067 : MapDataElement
    {
        public E_0067()
        {
            DataType = DataType.AN;
            MinLength = 2;
            MaxLength = 80;
        }
    }
    public class E_0076 : MapDataElement
    {
        public E_0076()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 22;
        }
    }
    public class E_0080 : MapDataElement
    {
        public E_0080()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 7;
        }
    }
    public class E_0081 : MapDataElement
    {
        public E_0081()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 10;
        }
    }
    public class E_0087 : MapDataElement
    {
        public E_0087()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 48;
        }
    }
    public class E_0088 : MapDataElement
    {
        public E_0088()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "AA", "AI", "CA", "CP", "DZ", "GM", "L", "MC", "PB", "R", "S", "SI", "SM", "SR", "SS", "UC", "UP", "W", "X", "ZZ" });
        }
    }
    public class E_0091 : MapDataElement
    {
        public E_0091()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "6", "7", "A", "AC", "AE", "AF", "AH", "AR", "B", "BP", "BU", "C", "CE", "D", "DA", "DW", "E", "ED", "F", "FA", "FL", "GG", "GR", "GS", "H", "HH", "I", "J", "K", "L", "LA", "LT", "M", "MB", "MP", "N", "O", "P", "PA", "PG", "PL", "PP", "PR", "PT", "Q", "R", "RC", "RR", "S", "SB", "SC", "SD", "SE", "SR", "SS", "ST", "T", "TA", "TC", "TT", "U", "VA", "VE", "VL", "W", "WP", "X", "Y", "Y1", "Y2", "ZZ" });
        }
    }
    public class E_0093 : MapDataElement
    {
        public E_0093()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 60;
        }
    }
    public class E_0098 : MapDataElement
    {
        public E_0098()
        {
            DataType = DataType.AN;
            MinLength = 2;
            MaxLength = 3;
        }
    }
    public class E_0116 : MapDataElement
    {
        public E_0116()
        {
            DataType = DataType.AN;
            MinLength = 3;
            MaxLength = 15;
        }
    }
    public class E_0121 : MapDataElement
    {
        public E_0121()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 3;
            AllowedValues.AddRange(new[] { "A", "BHR", "C", "CTR", "DMA", "DMB", "DMC", "E", "ECR", "F", "H", "I", "L", "M", "N", "O", "Q", "QUO", "R", "S", "T", "U", "V", "X", "Y" });
        }
    }
    public class E_0127 : MapDataElement
    {
        public E_0127()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 30;
        }
    }
    public class E_0128 : MapDataElement
    {
        public E_0128()
        {
            DataType = DataType.AN;
            MinLength = 2;
            MaxLength = 3;
        }
    }
    public class E_0129 : MapDataElement
    {
        public E_0129()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 13;
        }
    }
    public class E_0133 : MapDataElement
    {
        public E_0133()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "D", "H", "I", "JD", "JO", "M", "O", "R", "S", "V", "X", "Z" });
        }
    }
    public class E_0140 : MapDataElement
    {
        public E_0140()
        {
            DataType = DataType.AN;
            MinLength = 2;
            MaxLength = 4;
        }
    }
    public class E_0146 : MapDataElement
    {
        public E_0146()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "11", "BP", "CA", "CC", "CD", "CF", "DE", "DF", "FO", "HP", "MX", "NC", "NR", "PA", "PB", "PC", "PD", "PE", "PL", "PO", "PP", "PS", "PU", "RC", "RF", "RS", "TP", "WC" });
        }
    }
    public class E_0152 : MapDataElement
    {
        public E_0152()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 3;
            AllowedValues.AddRange(new[] { "045", "15", "170", "25", "35", "45", "510", "520", "550", "555", "565", "570", "585", "665", "670", "675", "761", "A1M", "A3M", "A5M", "AAS", "AB", "ADL", "AFN", "AGG", "AGS", "AIB", "AK", "ALP", "ALT", "AMM", "ANC", "APD", "APL", "ARC", "ARG", "ARR", "ART", "ASY", "AT", "AUX", "AV", "AW", "BA", "BCP", "BKA", "BL", "BLK", "BLS", "BN", "BNS", "BOX", "BU2", "BU4", "BUA", "BW", "CA2", "CA4", "CAR", "CC", "CCB", "CCH", "CCS", "CD", "CDD", "CE", "CF", "CFC", "CFL", "CGC", "CGR", "CGT", "CH", "CHN", "CI", "CIP", "CIS", "CLN", "CLS", "CM", "CMD", "CNL", "CNS", "CO", "CON", "COR", "COU", "COV", "CPC", "CPM", "CR", "CRL", "CSD", "CSP", "CTL", "CTM", "CTR", "CUF", "CW", "CX", "CY", "DA", "DBL", "DBP", "DCS", "DDN", "DDP", "DDS", "DDZ", "DE", "DEL", "DEP", "DET", "DEZ", "DFD", "DFM", "DFS", "DIS", "DLP", "DLR", "DM", "DN", "DNC", "DNF", "DNT", "DOC", "DOV", "DPB", "DPD", "DPE", "DPL", "DPT", "DPU", "DR", "DRO", "DRU", "DS", "DSK", "DSM", "DSR", "DSV", "DT", "DTB", "DTP", "DTV", "DU", "DV", "DW", "DWP", "EAX", "ECR", "ECS", "ED", "EDD", "EDO", "EE", "EED", "EL", "ELS", "EMR", "EMT", "END", "EP", "ER", "ERS", "ERT", "EV", "EW", "EX", "EXC", "EXD", "EXL", "EXO", "EXP", "EXQ", "EXT", "EXU", "EXZ", "EZE", "FA", "FAK", "FAS", "FB", "FC", "FCS", "FD", "FFC", "FFS", "FG", "FL", "FLS", "FP", "FPT", "FR", "FRZ", "FS", "FST", "FTR", "GI", "GMS", "GOC", "GSP", "GSS", "HAL", "HAN", "HBR", "HDH", "HDW", "HE", "HEA", "HES", "HET", "HH", "HM", "HMA", "HMI", "HO", "HOL", "HOR", "HOS", "HOX", "HP", "HQT", "HR", "HRS", "HT", "HTI", "HV", "HW", "HZC", "HZD", "IB", "IC", "ID", "IDC", "IDL", "IIH", "IM", "IMP", "IMS", "INT", "IP", "IPU", "IR", "IS", "ITS", "JIT", "JLX", "JS", "KEG", "KMD", "LAB", "LAY", "LB", "LBL", "LBR", "LBT", "LC", "LC2", "LC4", "LCL", "LD", "LEC", "LF", "LFD", "LHS", "LIE", "LMD", "LME", "LN", "LP", "LPD", "LR", "LS", "LT", "LTE", "LTT", "LYC", "MAT", "MC", "MEN", "MES", "MET", "MF", "MIN", "MNS", "MOT", "MP", "MR", "MRF", "MSS", "MTE", "MVS", "NC", "ND", "NE", "NH", "NHC", "NHL", "NI", "NP", "NPR", "NS", "NSV", "NT", "NW", "NX", "OAH", "OBL", "OCA", "OCL", "OCN", "OCS", "OCV", "ODI", "OEH", "OFH", "OFU", "OHC", "OIL", "ONC", "ONS", "OOB", "OOD", "OOL", "OPR", "OPT", "OS", "OSB", "OST", "OTC", "OTD", "OTH", "OTO", "OTS", "OUC", "OUW", "OV", "OVR", "OWC", "OWR", "PAJ", "PAV", "PB", "PD", "PDS", "PDY", "PER", "PFH", "PG", "PHR", "PI", "PIR", "PMM", "PMR", "PMS", "PMT", "POC", "PPD", "PRL", "PRT", "PS", "PSG", "PSS", "PTS", "PUC", "PUD", "PUK", "PUP", "PVB", "PVD", "PVI", "PVL", "PVP", "PVS", "PVT", "PW", "PYS", "RA", "RB", "RC", "RCC", "RCL", "RDH", "RDR", "REP", "RES", "RFM", "RIE", "RLS", "RM", "RMC", "RMP", "RMS", "RO", "RPD", "RR", "RRR", "RS", "RSP", "RSS", "RSV", "RT", "RWR", "SAS", "SAT", "SB", "SC", "SCC", "SCL", "SD", "SDL", "SDS", "SE", "SEC", "SED", "SEE", "SER", "SEV", "SFB", "SFD", "SFE", "SFT", "SGL", "SH", "SHH", "SHL", "SHW", "SI", "SK", "SKT", "SLC", "SM", "SMP", "SMS", "SNM", "SNS", "SNT", "SOC", "SOL", "SP", "SPC", "SPR", "SPT", "SPU", "SR", "SRG", "SRS", "SSC", "SSN", "SSU", "ST", "STA", "STD", "STO", "STP", "STR", "SUA", "SUB", "SUP", "SVS", "SW", "TA", "TC", "TDC", "TDP", "TER", "TF", "TLS", "TMS", "TMV", "TN", "TOF", "TPS", "TRA", "TRK", "TRL", "TRM", "TRN", "TRP", "TRS", "TRT", "TS", "TSC", "TSP", "TSS", "TT", "TV", "UB", "UFC", "UI", "UL", "UN", "UP", "UPK", "UR", "URC", "US", "UTL", "VAC", "VAN", "VCL", "VFN", "VIS", "VN", "VSO", "VT", "VTS", "WB", "WBB", "WCT", "WD", "WDS", "WE", "WFG", "WH", "WI", "WM", "WO", "WRB", "WRI", "WTV", "WW", "XP", "XT", "ZZZ" });
        }
    }
    public class E_0154 : MapDataElement
    {
        public E_0154()
        {
            DataType = DataType.AN;
            MinLength = 6;
            MaxLength = 9;
        }
    }
    public class E_0156 : MapDataElement
    {
        public E_0156()
        {
            DataType = DataType.AN;
            MinLength = 2;
            MaxLength = 2;
        }
    }
    public class E_0166 : MapDataElement
    {
        public E_0166()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 55;
        }
    }
    public class E_0176 : MapDataElement
    {
        public E_0176()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "CB", "CE", "D", "E", "ED", "EP", "F", "G", "H", "I", "J", "K", "L", "LD", "LP", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" });
        }
    }
    public class E_0177 : MapDataElement
    {
        public E_0177()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 2;
        }
    }
    public class E_0183 : MapDataElement
    {
        public E_0183()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 8;
        }
    }
    public class E_0187 : MapDataElement
    {
        public E_0187()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "A", "A1", "A2", "A3", "A4", "B", "C", "CD", "CE", "D", "DR", "E", "F", "FR", "G", "H", "I", "J", "K", "L", "LC", "M", "N", "ND", "NI", "NR", "NT", "O", "P", "PA", "Q", "R", "RG", "RN", "RT", "S", "SF", "SI", "SK", "SO", "T", "U", "V", "W", "WA", "WB", "WG", "WJ", "X", "Y", "Z" });
        }
    }
    public class E_0188 : MapDataElement
    {
        public E_0188()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "E", "G", "K", "L", "M", "O", "S", "T" });
        }
    }
    public class E_0200 : MapDataElement
    {
        public E_0200()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 6;
        }
    }
    public class E_0215 : MapDataElement
    {
        public E_0215()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 30;
        }
    }
    public class E_0218 : MapDataElement
    {
        public E_0218()
        {
            DataType = DataType.AN;
            MinLength = 14;
            MaxLength = 40;
        }
    }
    public class E_0222 : MapDataElement
    {
        public E_0222()
        {
            DataType = DataType.AN;
            MinLength = 4;
            MaxLength = 25;
        }
    }
    public class E_0223 : MapDataElement
    {
        public E_0223()
        {
            DataType = DataType.AN;
            MinLength = 5;
            MaxLength = 5;
        }
    }
    public class E_0224 : MapDataElement
    {
        public E_0224()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 25;
        }
    }
    public class E_0230 : MapDataElement
    {
        public E_0230()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 3;
        }
    }
    public class E_0234 : MapDataElement
    {
        public E_0234()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 48;
        }
    }
    public class E_0235 : MapDataElement
    {
        public E_0235()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "D1", "D2", "D3", "D4", "D5", "DD", "DE", "DF", "DG", "DI", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV", "DW", "DX", "DY", "DZ", "E1", "E2", "E3", "E4", "E5", "E6", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EP", "EQ", "ER", "ES", "EU", "EX", "EZ", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FI", "FL", "FM", "FN", "FP", "FS", "FT", "FW", "GA", "GC", "GD", "GE", "GI", "GK", "GN", "GQ", "GR", "GS", "GU", "HC", "HD", "HI", "HN", "IA", "IB", "IC", "ID", "IE", "IF", "IG", "IM", "IN", "IP", "IQ", "IR", "IS", "IT", "IV", "IW", "IZ", "JA", "JB", "JC", "JD", "JN", "JP", "JS", "KA", "KB", "KD", "KE", "KF", "KG", "KI", "KJ", "KK", "KL", "KM", "KN", "KP", "L1", "L2", "L3", "L4", "L5", "LA", "LB", "LC", "LD", "LG", "LP", "LR", "LS", "LT", "LU", "MA", "MB", "MC", "MD", "ME", "MF", "MG", "MH", "MI", "MJ", "MK", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "N1", "N2", "N3", "N4", "N5", "N6", "NC", "ND", "NE", "NH", "NM", "NR", "NU", "NW", "NZ", "OA", "OB", "OC", "OD", "OE", "OF", "OG", "OH", "OI", "OL", "ON", "OO", "OP", "OR", "OT", "P1", "P2", "P3", "P4", "P5", "P7", "P8", "P9", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "R1", "R2", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RR", "RS", "RT", "RU", "RV", "RW", "RY", "RZ", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "SW", "SX", "SY", "SZ", "T2", "T3", "TA", "TB", "TC", "TD", "TE", "TF", "TG", "TH", "TI", "TJ", "TM", "TN", "TP", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "TZ", "U2", "U3", "U5", "U6", "UA", "UB", "UC", "UD", "UE", "UF", "UG", "UH", "UI", "UJ", "UK", "UL", "UM", "UN", "UO", "UP", "UQ", "UR", "US", "UT", "UV", "UX", "VA", "VB", "VC", "VE", "VI", "VM", "VN", "VO", "VP", "VS", "VT", "VU", "VV", "VX", "W1", "W2", "W5", "W6", "W7", "WA", "WC", "WL", "WR", "WS", "XA", "XC", "XP", "XQ", "XZ", "YP", "ZB", "ZR", "ZZ" });
        }
    }
    public class E_0238 : MapDataElement
    {
        public E_0238()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 12;
        }
    }
    public class E_0248 : MapDataElement
    {
        public E_0248()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "A", "C", "N", "P", "Q", "R", "S" });
        }
    }
    public class E_0254 : MapDataElement
    {
        public E_0254()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 3;
        }
    }
    public class E_0267 : MapDataElement
    {
        public E_0267()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 6;
        }
    }
    public class E_0271 : MapDataElement
    {
        public E_0271()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "I" });
        }
    }
    public class E_0272 : MapDataElement
    {
        public E_0272()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "1", "2" });
        }
    }
    public class E_0273 : MapDataElement
    {
        public E_0273()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 25;
        }
    }
    public class E_0277 : MapDataElement
    {
        public E_0277()
        {
            DataType = DataType.AN;
            MinLength = 6;
            MaxLength = 6;
        }
    }
    public class E_0285 : MapDataElement
    {
        public E_0285()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 22;
        }
    }
    public class E_0286 : MapDataElement
    {
        public E_0286()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "ZZ" });
        }
    }
    public class E_0296 : MapDataElement
    {
        public E_0296()
        {
            DataType = DataType.AN;
            MinLength = 2;
            MaxLength = 4;
        }
    }
    public class E_0306 : MapDataElement
    {
        public E_0306()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "1", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "2", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "3", "30", "31", "32", "34", "35", "36", "37", "38", "39", "4", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "5", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "6", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "7", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "8", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "9", "90", "A", "A1", "A2", "A3", "A4", "A5", "A6", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AL", "AP", "AQ", "AR", "AS", "AT", "AV", "AW", "AX", "B", "BD", "BI", "BO", "C", "C1", "C2", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CL", "CM", "CN", "CO", "CP", "CS", "CT", "CU", "CV", "CX", "D", "D1", "D2", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DP", "DR", "DS", "DT", "DX", "E", "EA", "EB", "EC", "ED", "EE", "EN", "EP", "ER", "EV", "EX", "F", "F1", "FA", "FC", "FI", "FO", "FR", "G", "GR", "H", "HR", "I", "I1", "IA", "IM", "IN", "IS", "IT", "J", "JA", "JO", "JU", "K", "KA", "L", "LC", "LQ", "M", "ME", "MO", "N", "NA", "ND", "NP", "NS", "O", "OD", "OP", "OR", "OT", "P", "P1", "PA", "PB", "PC", "PD", "PF", "PI", "PJ", "PO", "PP", "PR", "PS", "PT", "PU", "PV", "Q", "R", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RQ", "RR", "RS", "RT", "RU", "RV", "RW", "RX", "S", "S1", "S2", "SA", "SB", "SC", "SD", "SE", "SL", "SR", "SS", "SU", "SV", "SZ", "T", "TD", "TE", "TG", "TN", "TP", "TR", "TS", "TU", "U", "V", "VA", "W", "W1", "WD", "WI", "WQ", "WV", "X", "Y", "Z" });
        }
    }
    public class E_0309 : MapDataElement
    {
        public E_0309()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "10", "11", "12", "13", "14", "18", "19", "20", "21", "22", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "52", "53", "54", "55", "57", "58", "59", "60", "93", "94", "A", "A1", "AA", "AC", "AP", "AR", "B", "B1", "BE", "BL", "BS", "C", "C2", "CA", "CB", "CC", "CD", "CE", "CI", "CL", "CO", "CR", "CS", "CY", "D", "DC", "DE", "DL", "DO", "DP", "DR", "DT", "E", "EA", "EL", "F", "FA", "FE", "FF", "FI", "FR", "FS", "FT", "FV", "GL", "H", "I", "IA", "IB", "IM", "IP", "IS", "IT", "K", "KE", "KL", "KP", "L", "LO", "M", "MI", "MS", "MZ", "NS", "O", "OA", "OF", "OL", "OP", "OR", "OV", "P", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "RA", "RC", "RE", "RG", "RJ", "RL", "RS", "RT", "SA", "SB", "SC", "SD", "SE", "SG", "SH", "SL", "SN", "SP", "SS", "ST", "SW", "TA", "TC", "TL", "TM", "TN", "TP", "TR", "TX", "UN", "UR", "UT", "VA", "VI", "VS", "W", "WF", "WH", "WI", "ZN", "ZZ" });
        }
    }
    public class E_0310 : MapDataElement
    {
        public E_0310()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 30;
        }
    }
    public class E_0324 : MapDataElement
    {
        public E_0324()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 22;
        }
    }
    public class E_0330 : MapDataElement
    {
        public E_0330()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 15;
        }
    }
    public class E_0337 : MapDataElement
    {
        public E_0337()
        {
            DataType = DataType.AN;
            MinLength = 4;
            MaxLength = 8;
        }
    }
    public class E_0352 : MapDataElement
    {
        public E_0352()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 80;
        }
    }
    public class E_0355 : MapDataElement
    {
        public E_0355()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "1I", "1J", "1K", "1L", "1M", "1N", "1O", "1P", "1Q", "1R", "1X", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2F", "2G", "2H", "2I", "2J", "2K", "2L", "2M", "2N", "2P", "2Q", "2R", "2U", "2V", "2W", "2X", "2Y", "2Z", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3B", "3C", "3E", "3F", "3G", "3H", "3I", "40", "41", "43", "44", "45", "46", "47", "48", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4K", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4T", "4U", "4V", "4W", "4X", "50", "51", "52", "53", "54", "56", "57", "58", "59", "5A", "5B", "5C", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5P", "5Q", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "89", "8C", "8D", "8P", "8R", "8S", "8U", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "A8", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "D2", "D3", "D5", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DW", "DX", "DY", "DZ", "E1", "E3", "E4", "E5", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EJ", "EM", "EP", "EQ", "EV", "EX", "EY", "EZ", "F1", "F2", "F3", "F4", "F5", "F6", "F9", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FJ", "FK", "FL", "FM", "FO", "FP", "FR", "FS", "FT", "FZ", "G2", "G3", "G4", "G5", "G7", "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ", "H1", "H2", "H4", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HY", "HZ", "IA", "IB", "IC", "IE", "IF", "IH", "II", "IK", "IL", "IM", "IN", "IP", "IT", "IU", "IV", "IW", "J2", "JA", "JB", "JE", "JG", "JK", "JM", "JO", "JR", "JU", "K1", "K2", "K3", "K4", "K5", "K6", "K7", "K9", "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KO", "KP", "KQ", "KR", "KS", "KT", "KU", "KV", "KW", "KX", "L2", "LA", "LB", "LC", "LE", "LF", "LG", "LH", "LI", "LJ", "LK", "LL", "LM", "LN", "LO", "LP", "LQ", "LR", "LS", "LT", "LX", "LY", "M0", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "M9", "MA", "MB", "MC", "MD", "ME", "MF", "MG", "MH", "MI", "MJ", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "N1", "N2", "N3", "N4", "N6", "N7", "N9", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NH", "NI", "NJ", "NL", "NM", "NN", "NQ", "NR", "NS", "NT", "NU", "NV", "NW", "NX", "NY", "OA", "OC", "ON", "OP", "OT", "OZ", "P0", "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "QA", "QB", "QC", "QD", "QE", "QH", "QK", "QR", "QS", "QT", "QU", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RG", "RH", "RK", "RL", "RM", "RN", "RO", "RP", "RS", "RT", "RU", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SV", "SW", "SX", "SY", "SZ", "T0", "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "TA", "TB", "TC", "TD", "TE", "TF", "TG", "TH", "TI", "TJ", "TK", "TL", "TM", "TN", "TO", "TP", "TQ", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "TZ", "U1", "U2", "U3", "U5", "UA", "UB", "UC", "UD", "UE", "UF", "UH", "UL", "UM", "UN", "UP", "UQ", "UR", "US", "UT", "UU", "UV", "UW", "UX", "UY", "UZ", "V1", "V2", "VA", "VC", "VI", "VP", "VR", "VS", "W2", "WA", "WB", "WD", "WE", "WG", "WH", "WI", "WK", "WM", "WP", "WR", "WW", "X1", "X2", "X3", "X4", "X5", "X6", "X7", "X8", "X9", "XP", "Y1", "Y2", "Y3", "Y4", "YD", "YL", "YR", "YT", "Z1", "Z2", "Z3", "Z4", "Z5", "Z6", "Z8", "ZA", "ZB", "ZC", "ZP", "ZZ" });
        }
    }
    public class E_0356 : MapDataElement
    {
        public E_0356()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 6;
        }
    }
    public class E_0357 : MapDataElement
    {
        public E_0357()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 8;
        }
    }
    public class E_0363 : MapDataElement
    {
        public E_0363()
        {
            DataType = DataType.ID;
            MinLength = 3;
            MaxLength = 3;
            AllowedValues.AddRange(new[] { "AAA", "AAB", "AAC", "AAD", "AAE", "AAF", "ABN", "ACC", "ACI", "ACN", "ACS", "ACT", "ADD", "AES", "AET", "ALG", "ALL", "ALT", "AMN", "AOO", "APN", "APS", "BBD", "BBF", "BBH", "BBN", "BBO", "BBT", "BFD", "BOL", "BUR", "CAA", "CAB", "CAC", "CAD", "CAE", "CAF", "CAG", "CAH", "CAI", "CAJ", "CAK", "CAL", "CAM", "CAN", "CAO", "CAP", "CAQ", "CAR", "CAS", "CAT", "CAU", "CAV", "CAW", "CAX", "CAZ", "CBA", "CBB", "CBC", "CBH", "CBI", "CCA", "CCB", "CCC", "CCD", "CCE", "CCF", "CCG", "CCN", "CDD", "CER", "CHG", "CIG", "CLN", "CLR", "CMP", "CMT", "COD", "COM", "CON", "CRA", "CRK", "CRN", "CUS", "DCP", "DEE", "DEL", "DEP", "DFR", "DFS", "DGN", "DME", "DOD", "DOI", "ECD", "ECM", "ECN", "ECT", "EED", "EFD", "ELE", "EMC", "EMD", "ENR", "ERN", "EVL", "EXE", "EXR", "EXT", "FEE", "FUT", "GEN", "GPI", "GSI", "HHI", "ICN", "IDT", "IID", "IIE", "IIR", "IMP", "INS", "INT", "INV", "IVC", "JVD", "LAB", "LBD", "LBS", "LEN", "LIN", "LIQ", "LLA", "LLB", "LLC", "LOC", "LOI", "LSD", "MCD", "MDO", "MED", "MFG", "MKN", "MMD", "MSD", "NCD", "NPD", "NTR", "OBI", "OBL", "OCA", "OCC", "OCL", "OCP", "OCR", "ODT", "OLS", "OPO", "ORA", "ORE", "ORI", "OTH", "OTN", "OTS", "PAY", "PCS", "PDS", "PED", "PEN", "PES", "PID", "PKG", "PMT", "POB", "POC", "POL", "PPC", "PRI", "PRN", "PRO", "PRR", "PSY", "PUR", "QUL", "QUT", "RDI", "REC", "REG", "REP", "REV", "RFL", "RHB", "RLA", "RLH", "RNH", "RNI", "ROU", "RPT", "RST", "RVC", "SAN", "SCN", "SDD", "SET", "SFM", "SMD", "SOB", "SOW", "SPH", "SPT", "SPV", "SSA", "SSC", "SSD", "SSE", "SSG", "SSH", "SSI", "SSS", "SST", "TAF", "TCF", "TDA", "TES", "TIL", "TLF", "TLR", "TPO", "TRA", "TRE", "TRF", "TRS", "TSD", "TSF", "TST", "UPI", "VEC", "VNN", "WHI", "WRP", "ZZZ" });
        }
    }
    public class E_0364 : MapDataElement
    {
        public E_0364()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 80;
        }
    }
    public class E_0365 : MapDataElement
    {
        public E_0365()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "AA", "AB", "AC", "AD", "AP", "AS", "AU", "BN", "BT", "CA", "CP", "DN", "ED", "EM", "EX", "FT", "FU", "FX", "HF", "HP", "IT", "MN", "NP", "OF", "OT", "PA", "PC", "PP", "PS", "SP", "TE", "TL", "TM", "TN", "TX", "UR", "VM", "WC", "WF", "WP" });
        }
    }
    public class E_0366 : MapDataElement
    {
        public E_0366()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "3A", "A1", "A2", "A3", "A4", "A5", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AL", "AM", "AN", "AP", "AR", "AS", "AT", "AU", "AV", "BA", "BB", "BC", "BD", "BI", "BJ", "BK", "BL", "BM", "BP", "BS", "BU", "C2", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "DA", "DC", "DD", "DE", "DF", "DI", "DM", "DN", "DV", "E1", "E2", "EA", "EB", "EC", "ED", "EF", "EG", "EM", "EN", "EO", "EP", "ES", "EV", "EX", "FA", "FB", "FC", "FD", "FF", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "GA", "GB", "GC", "GE", "GR", "HM", "HR", "IC", "IO", "IP", "IS", "KA", "KB", "KC", "KP", "KT", "LD", "MA", "MB", "MC", "MD", "ME", "MG", "MK", "ML", "MM", "NA", "NC", "NP", "NT", "OA", "OC", "OD", "OS", "OW", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "QA", "QC", "QI", "QM", "QP", "QR", "QY", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RP", "RQ", "RS", "RZ", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "SW", "SY", "TA", "TB", "TC", "TD", "TE", "TH", "TM", "TN", "TP", "TR", "TY", "UG", "UP", "UQ", "UR", "VM", "VP", "WH", "WI", "WR", "ZZ" });
        }
    }
    public class E_0369 : MapDataElement
    {
        public E_0369()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 45;
        }
    }
    public class E_0373 : MapDataElement
    {
        public E_0373()
        {
            DataType = DataType.AN;
            MinLength = 8;
            MaxLength = 8;
        }
    }
    public class E_0380 : MapDataElement
    {
        public E_0380()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 15;
        }
    }
    public class E_0387 : MapDataElement
    {
        public E_0387()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 35;
        }
    }
    public class E_0395 : MapDataElement
    {
        public E_0395()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 8;
        }
    }
    public class E_0397 : MapDataElement
    {
        public E_0397()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 10;
        }
    }
    public class E_0398 : MapDataElement
    {
        public E_0398()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 10;
        }
    }
    public class E_0399 : MapDataElement
    {
        public E_0399()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "1", "2", "3", "4", "5" });
        }
    }
    public class E_0400 : MapDataElement
    {
        public E_0400()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "ZZ" });
        }
    }
    public class E_0408 : MapDataElement
    {
        public E_0408()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 4;
        }
    }
    public class E_0416 : MapDataElement
    {
        public E_0416()
        {
            DataType = DataType.AN;
            MinLength = 6;
            MaxLength = 6;
        }
    }
    public class E_0432 : MapDataElement
    {
        public E_0432()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "67", "68", "69", "70", "71", "72", "73", "74", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "AA", "AB", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "CA", "CB", "CE", "CL", "EP", "KA", "LA", "LC", "LD", "LP", "PE", "SE", "TA", "TR" });
        }
    }
    public class E_0433 : MapDataElement
    {
        public E_0433()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04" });
        }
    }
    public class E_0434 : MapDataElement
    {
        public E_0434()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 30;
        }
    }
    public class E_0438 : MapDataElement
    {
        public E_0438()
        {
            DataType = DataType.AN;
            MinLength = 12;
            MaxLength = 12;
        }
    }
    public class E_0443 : MapDataElement
    {
        public E_0443()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 20;
        }
    }
    public class E_0447 : MapDataElement
    {
        public E_0447()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 6;
        }
    }
    public class E_0451 : MapDataElement
    {
        public E_0451()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 12;
        }
    }
    public class E_0460 : MapDataElement
    {
        public E_0460()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "A", "C", "D", "E", "F", "G", "H", "M", "N", "O", "R", "S", "T" });
        }
    }
    public class E_0472 : MapDataElement
    {
        public E_0472()
        {
            DataType = DataType.AN;
            MinLength = 6;
            MaxLength = 6;
        }
    }
    public class E_0473 : MapDataElement
    {
        public E_0473()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "B", "C", "D", "E", "F", "G", "L", "N", "R", "S", "T", "X" });
        }
    }
    public class E_0474 : MapDataElement
    {
        public E_0474()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 22;
        }
    }
    public class E_0478 : MapDataElement
    {
        public E_0478()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "C", "D" });
        }
    }
    public class E_0488 : MapDataElement
    {
        public E_0488()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 3;
        }
    }
    public class E_0522 : MapDataElement
    {
        public E_0522()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 3;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "0A", "0B", "0C", "0D", "0E", "0F", "0G", "0H", "0I", "0J", "0K", "0L", "0M", "0N", "0P", "0Q", "0R", "0S", "0T", "0U", "1", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "1J", "1K", "1L", "1M", "1N", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X", "1Y", "1Z", "2", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "2G", "2H", "2I", "2J", "2K", "2L", "2M", "2N", "2P", "2Q", "2R", "2S", "2T", "2U", "2V", "2W", "2X", "2Y", "2Z", "3", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3O", "3P", "3Q", "3R", "3S", "3T", "3U", "3V", "3W", "3X", "3Y", "3Z", "4", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4K", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4T", "4U", "4V", "4W", "4X", "4Y", "4Z", "5", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5L", "5M", "5N", "5O", "5P", "5Q", "5R", "5S", "5T", "5U", "5V", "5W", "5X", "5Y", "5Z", "6", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N", "6O", "6P", "6Q", "6R", "6S", "6T", "6U", "6V", "6W", "6X", "6Y", "6Z", "7", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "7G", "7H", "7I", "7J", "7K", "7L", "7M", "7N", "7O", "7P", "7Q", "7R", "7S", "7T", "7U", "7V", "7W", "7X", "7Y", "7Z", "8", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "8G", "8H", "8I", "8J", "8K", "8L", "8M", "8N", "8O", "8P", "8Q", "8R", "8S", "8T", "8U", "8V", "8W", "8X", "8Y", "8Z", "9", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9B", "9C", "9D", "9E", "9F", "9G", "9H", "9I", "9J", "9K", "9L", "9M", "9N", "9O", "9P", "9Q", "9R", "9S", "9T", "9U", "9V", "9W", "9X", "9Y", "9Z", "A", "A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AAA", "AAB", "AAC", "AAD", "AAE", "AAF", "AAG", "AAH", "AAI", "AAJ", "AAK", "AAL", "AAM", "AAN", "AAO", "AAP", "AAQ", "AAR", "AAS", "AAT", "AAU", "AAV", "AAW", "AAX", "AAY", "AAZ", "AB", "ABA", "ABB", "ABC", "ABD", "ABE", "ABF", "ABG", "ABH", "ABI", "ABJ", "ABK", "ABL", "ABM", "ABN", "ABO", "ABP", "ABQ", "ABR", "ABS", "ABT", "ABU", "ABV", "ABW", "ABX", "ABY", "ABZ", "AC", "ACA", "ACB", "ACC", "ACD", "ACE", "ACF", "ACG", "ACH", "ACI", "ACJ", "ACK", "ACL", "ACM", "ACN", "ACO", "ACP", "ACQ", "ACR", "ACS", "ACT", "ACU", "ACV", "ACW", "ACX", "ACY", "ACZ", "AD", "ADA", "ADB", "ADC", "ADD", "ADE", "ADF", "ADG", "ADH", "ADI", "ADJ", "ADK", "ADL", "ADM", "ADN", "ADO", "ADP", "ADQ", "ADR", "ADS", "ADT", "ADW", "ADX", "ADY", "ADZ", "AE", "AEB", "AEC", "AED", "AEE", "AEF", "AEG", "AEH", "AEI", "AEJ", "AEK", "AEL", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AVE", "AW", "AX", "AY", "AZ", "B", "B0", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "BA", "BAA", "BAB", "BAC", "BAD", "BAE", "BAF", "BAG", "BAH", "BAI", "BAJ", "BAK", "BAL", "BAM", "BAN", "BAO", "BAP", "BAQ", "BAR", "BAS", "BAT", "BAU", "BAV", "BAW", "BAX", "BAY", "BAZ", "BB", "BBA", "BBB", "BBC", "BBD", "BBE", "BBF", "BBG", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", "C", "C0", "C1", "C2", "C3", "C4", "C5", "C6", "C7", "C8", "C9", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "D", "D0", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "D8", "D9", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV", "DW", "DX", "DY", "DZ", "E", "E0", "E1", "E2", "E3", "E4", "E5", "E6", "E7", "E8", "E9", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ", "ER", "ES", "ET", "EU", "EV", "EW", "EX", "EY", "EZ", "F", "F0", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "FA", "FB", "FBA", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "FS", "FT", "FU", "FV", "FW", "FX", "FY", "FZ", "G", "G0", "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ", "H", "H0", "H1", "H2", "H3", "H4", "H5", "H6", "H7", "H8", "H9", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HX", "HY", "HZ", "I", "I0", "I1", "I2", "I3", "I4", "I5", "I6", "I7", "I8", "I9", "IA", "IB", "IC", "ID", "IE", "IF", "IG", "IH", "II", "IJ", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "IU", "IV", "IW", "IX", "IY", "IZ", "J", "J0", "J1", "J2", "J3", "J4", "J5", "J6", "J7", "J8", "J9", "JA", "JB", "JC", "JD", "JE", "JF", "JG", "JH", "JI", "JJ", "JK", "JL", "JM", "JN", "JO", "JP", "JQ", "JR", "JS", "JT", "JU", "JV", "JW", "JX", "JY", "JZ", "K", "K0", "K1", "K2", "K3", "K4", "K5", "K6", "K7", "K8", "K9", "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KN", "KO", "KP", "KQ", "KR", "KS", "KT", "KU", "KV", "KW", "KX", "KY", "KZ", "L", "L0", "L1", "L2", "L3", "L4", "L5", "L6", "L7", "L8", "L9", "LA", "LB", "LC", "LD", "LE", "LF", "LG", "LH", "LI", "LJ", "LK", "LL", "LM", "LN", "LO", "LOW", "LP", "LQ", "LR", "LS", "LT", "LU", "LV", "LW", "LX", "LY", "LZ", "M", "M0", "M1", "M2", "M3", "M4", "M5", "M6", "M7", "M8", "M9", "MA", "MB", "MC", "MD", "ME", "MF", "MG", "MH", "MI", "MJ", "MK", "ML", "MM", "MN", "MO", "MP", "MQ", "MR", "MS", "MT", "MU", "MV", "MW", "MX", "MY", "MZ", "N", "N0", "N1", "N2", "N3", "N4", "N5", "N6", "N7", "N8", "N9", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NH", "NI", "NJ", "NK", "NL", "NM", "NN", "NO", "NP", "NQ", "NR", "NS", "NT", "NU", "NV", "NW", "NX", "NY", "NZ", "O", "O0", "O1", "O2", "O3", "O4", "O5", "O6", "O7", "O8", "O9", "OA", "OB", "OC", "OD", "OE", "OF", "OG", "OH", "OI", "OJ", "OK", "OL", "OM", "ON", "OO", "OP", "OQ", "OR", "OS", "OT", "OU", "OV", "OW", "OX", "OY", "OZ", "P", "P0", "P1", "P2", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "PA", "PB", "PC", "PCC", "PCS", "PCV", "PD", "PE", "PF", "PG", "PH", "PI", "PJ", "PK", "PL", "PM", "PN", "PO", "PP", "PQ", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PY", "PZ", "Q", "Q0", "Q1", "Q2", "Q3", "Q4", "Q5", "Q6", "Q7", "Q8", "Q9", "QA", "QB", "QC", "QD", "QE", "QF", "QG", "QH", "QI", "QJ", "QK", "QL", "QM", "QN", "QO", "QP", "QQ", "QR", "QS", "QT", "QU", "QV", "QW", "QX", "QY", "QZ", "R", "R0", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RI", "RJ", "RK", "RL", "RM", "RN", "RO", "RP", "RQ", "RR", "RS", "RT", "RU", "RV", "RW", "RX", "RY", "RZ", "S", "S0", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SOF", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "SW", "SX", "SY", "SZ", "T", "T0", "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8", "T9", "TA", "TB", "TC", "TD", "TE", "TF", "TG", "TH", "TI", "TJ", "TK", "TL", "TM", "TN", "TO", "TP", "TQ", "TR", "TS", "TT", "TU", "TW", "TX", "TY", "TZ", "U", "U0", "U1", "U2", "U3", "U4", "U5", "U6", "U7", "U8", "U9", "UA", "UB", "UC", "UD", "UE", "UF", "UG", "UH", "UI", "UJ", "UK", "UL", "UM", "UN", "UO", "UP", "UPF", "UQ", "UR", "US", "UT", "UU", "UV", "UW", "UX", "UY", "UZ", "V", "V0", "V1", "V2", "V3", "V4", "V5", "V6", "V7", "V8", "V9", "VA", "VB", "VC", "VD", "VE", "VES", "VF", "VG", "VH", "VI", "VJ", "VK", "VL", "VM", "VN", "VO", "VP", "VQ", "VR", "VS", "VT", "VU", "VV", "VW", "VX", "VY", "VZ", "W", "W0", "W1", "W2", "W3", "W4", "W5", "W6", "W7", "W8", "W9", "WA", "WB", "WC", "WD", "WE", "WF", "WG", "WH", "WI", "WJ", "WK", "WL", "WM", "WN", "WO", "WP", "WQ", "WR", "WS", "WT", "WU", "WV", "WW", "WX", "WY", "WZ", "X", "X0", "X1", "X2", "X3", "X4", "X5", "X6", "X7", "X8", "X9", "XA", "XB", "XC", "XD", "XE", "XF", "XG", "XH", "XI", "XJ", "XK", "XL", "XM", "XN", "XO", "XP", "XQ", "XR", "XS", "XT", "XU", "XV", "XW", "XX", "XY", "XZ", "Y", "Y1", "Y2", "Y3", "Y4", "Y5", "Y6", "Y7", "Y8", "Y9", "YA", "YB", "YC", "YD", "YE", "YF", "YG", "YH", "YI", "YJ", "YK", "YL", "YM", "YN", "YO", "YQ", "YR", "YS", "YT", "YU", "YV", "YW", "YX", "YY", "YZ", "Z", "Z0", "Z1", "Z2", "Z3", "Z4", "Z5", "Z6", "Z7", "Z8", "Z9", "ZA", "ZB", "ZC", "ZD", "ZE", "ZF", "ZG", "ZH", "ZI", "ZJ", "ZK", "ZL", "ZM", "ZN", "ZO", "ZP", "ZQ", "ZR", "ZS", "ZT", "ZU", "ZV", "ZW", "ZX", "ZY", "ZZ" });
        }
    }
    public class E_0554 : MapDataElement
    {
        public E_0554()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 6;
        }
    }
    public class E_0559 : MapDataElement
    {
        public E_0559()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "93", "94", "A1", "A2", "A3", "A4", "AA", "AB", "AC", "AD", "AE", "AG", "AH", "AI", "AJ", "AL", "AM", "AP", "AQ", "AS", "AT", "AW", "AX", "AY", "BE", "BF", "BI", "CA", "CB", "CC", "CE", "CI", "CL", "CM", "CO", "CR", "CS", "CU", "CX", "DA", "DD", "DE", "DF", "DI", "DL", "DN", "DO", "DR", "DS", "DX", "DY", "DZ", "EI", "EP", "ES", "ET", "EU", "EX", "FA", "FC", "FD", "FG", "FH", "FI", "GC", "GS", "GU", "HC", "HI", "HS", "HU", "IA", "IB", "IC", "IM", "IN", "IS", "JA", "LA", "LB", "LI", "MA", "MB", "MC", "ME", "MI", "MP", "MS", "MV", "NA", "NB", "NC", "NE", "NF", "NG", "NI", "NR", "NS", "NT", "NU", "NW", "OI", "OP", "OS", "PA", "PC", "SA", "SE", "SL", "SP", "ST", "TA", "TB", "TC", "TD", "TI", "TM", "TP", "TR", "TX", "UC", "UN", "VI", "WH", "ZZ" });
        }
    }
    public class E_0595 : MapDataElement
    {
        public E_0595()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "1", "2", "3", "4", "5", "6" });
        }
    }
    public class E_0610 : MapDataElement
    {
        public E_0610()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 15;
        }
    }
    public class E_0623 : MapDataElement
    {
        public E_0623()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "AD", "AS", "AT", "CD", "CS", "CT", "ED", "ES", "ET", "GM", "HD", "HS", "HT", "LT", "MD", "MS", "MT", "ND", "NS", "NT", "PD", "PS", "PT", "TD", "TS", "TT", "UT" });
        }
    }
    public class E_0625 : MapDataElement
    {
        public E_0625()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "1", "2", "3", "4" });
        }
    }
    public class E_0640 : MapDataElement
    {
        public E_0640()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "33", "34", "35", "36", "37", "38", "39", "3M", "40", "41", "60", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6C", "6N", "6R", "6S", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "85", "87", "88", "91", "94", "95", "97", "98", "99", "A0", "A1", "A3", "A4", "A5", "A6", "A7", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AI", "AM", "AN", "AP", "AQ", "AR", "AS", "AT", "AV", "AW", "AZ", "BA", "BB", "BD", "BF", "BH", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BR", "BS", "BT", "BU", "BV", "BW", "C0", "C1", "C2", "C3", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", "D1", "D4", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DK", "DL", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "EA", "EB", "EF", "EI", "EM", "EP", "ER", "EX", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FI", "FL", "FM", "FN", "FP", "FR", "FS", "FT", "GA", "GI", "GR", "HP", "I1", "IA", "IB", "IC", "ID", "IE", "IF", "II", "IM", "IN", "IO", "IR", "IU", "IW", "IX", "IZ", "JM", "JO", "JR", "JS", "JU", "JX", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KN", "KS", "KT", "LC", "LD", "LE", "LF", "LN", "LO", "LP", "LR", "LV", "M1", "MA", "MB", "MC", "MD", "ME", "MF", "MI", "ML", "MM", "MP", "MR", "MS", "MU", "N1", "N2", "N3", "N4", "N5", "N6", "N7", "N8", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NH", "NI", "NJ", "NK", "NL", "NM", "NO", "NP", "NQ", "NR", "NT", "NU", "OC", "OF", "OP", "OR", "P1", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PI", "PL", "PM", "PO", "PP", "PR", "PS", "PT", "PU", "PV", "PW", "PX", "PZ", "QA", "QB", "QC", "QD", "QE", "QF", "QG", "QH", "QJ", "QK", "QL", "QP", "QR", "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RK", "RM", "RP", "RQ", "RS", "RT", "RU", "RZ", "S1", "S2", "S3", "S4", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SL", "SM", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "TD", "TG", "TH", "TI", "TJ", "TK", "TP", "TR", "TS", "TT", "TX", "U1", "U2", "U4", "U5", "U9", "UA", "UC", "UD", "UF", "UI", "UM", "UO", "UP", "UR", "UT", "V1", "VH", "VJ", "VL", "VM", "VN", "VO", "VP", "VQ", "VR", "W1", "W4", "W5", "WA", "WC", "WD", "WH", "WO", "WS", "WT", "X1", "XA", "XB", "XC", "XD", "XX", "XY", "XZ", "YI", "YR", "ZA", "ZB", "ZC", "ZD", "ZE", "ZF", "ZG", "ZH", "ZI", "ZJ", "ZK", "ZL", "ZM", "ZN", "ZO", "ZP", "ZQ", "ZR", "ZS", "ZT", "ZU", "ZW", "ZZ" });
        }
    }
    public class E_0649 : MapDataElement
    {
        public E_0649()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 10;
        }
    }
    public class E_0665 : MapDataElement
    {
        public E_0665()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "P", "R" });
        }
    }
    public class E_0673 : MapDataElement
    {
        public E_0673()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "1A", "1B", "1C", "1D", "1E", "1F", "1G", "1H", "1I", "1J", "1K", "1L", "1M", "1N", "1O", "1P", "1Q", "1R", "1S", "1T", "1U", "1V", "1W", "1X", "1Y", "1Z", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "2A", "2B", "2C", "2D", "2E", "2F", "2G", "2H", "2I", "2J", "2K", "2L", "2M", "2N", "2O", "2P", "2Q", "2R", "2S", "2T", "2U", "2V", "2W", "2X", "2Y", "2Z", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "3A", "3B", "3C", "3D", "3E", "3F", "3G", "3H", "3I", "3J", "3K", "3L", "3M", "3N", "3P", "3Q", "3R", "3S", "3T", "3U", "3V", "3W", "3X", "3Y", "40", "41", "42", "43", "45", "46", "47", "48", "49", "4A", "4B", "4C", "4D", "4E", "4F", "4G", "4H", "4I", "4J", "4K", "4L", "4M", "4N", "4O", "4P", "4Q", "4R", "4S", "4T", "4U", "50", "51", "52", "53", "54", "55", "56", "57", "58", "5A", "5B", "5C", "5D", "5E", "5F", "5G", "5H", "5I", "5J", "5K", "5L", "5M", "5N", "5O", "5P", "5Q", "5R", "5S", "5T", "5U", "5V", "5W", "5X", "5Y", "5Z", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "6A", "6B", "6C", "6D", "6E", "6F", "6G", "6H", "6I", "6J", "6K", "6L", "6M", "6N", "6O", "6P", "6Q", "6R", "6S", "6T", "6U", "6V", "6W", "6X", "6Z", "70", "72", "73", "74", "75", "76", "77", "78", "79", "7A", "7B", "7C", "7D", "7E", "7F", "7G", "7H", "7I", "7J", "7K", "7L", "7M", "7N", "7O", "7P", "7Q", "7R", "7S", "7T", "7U", "7V", "7W", "7X", "7Y", "7Z", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "8A", "8B", "8C", "8D", "8E", "8F", "8G", "8H", "8I", "8J", "8K", "8L", "8M", "8N", "8O", "8P", "8Q", "8R", "8S", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "9A", "9C", "9D", "9E", "9F", "9H", "9J", "9K", "9L", "9M", "9N", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BQ", "BR", "BW", "C0", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CL", "CN", "CO", "CP", "CR", "CS", "CW", "CY", "CZ", "D1", "D3", "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DI", "DN", "DO", "DP", "DR", "DS", "DT", "DY", "E1", "E2", "E3", "E4", "E5", "EA", "EB", "EC", "ED", "EE", "EM", "EP", "EQ", "ER", "ES", "ET", "EW", "F1", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FR", "FS", "FT", "GA", "GB", "GC", "GE", "GF", "GI", "GL", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GZ", "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HR", "HS", "II", "IN", "IP", "IQ", "IS", "IT", "JA", "JB", "JC", "JD", "JE", "JF", "JG", "JH", "JI", "JJ", "JK", "JL", "JM", "JN", "JO", "JP", "JQ", "JR", "JS", "JT", "K6", "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KN", "KO", "KP", "KQ", "KR", "KS", "KU", "KV", "KW", "KX", "KY", "KZ", "L2", "L3", "L4", "L5", "L6", "L7", "LA", "LB", "LC", "LE", "LG", "LH", "LI", "LK", "LL", "LM", "LN", "LO", "LP", "LQ", "LR", "LS", "LT", "LV", "LW", "LX", "LY", "M1", "M2", "MA", "MD", "ME", "MF", "MI", "MM", "MN", "MO", "MQ", "MX", "N1", "N2", "N3", "N4", "N5", "N6", "NA", "NB", "NC", "ND", "NE", "NF", "NG", "NL", "NN", "NO", "NP", "NQ", "NR", "NS", "NT", "NU", "NV", "NW", "OC", "OD", "OF", "OG", "OH", "OI", "OL", "ON", "OO", "OR", "OT", "OU", "OV", "OW", "P1", "P3", "P4", "P5", "P6", "P7", "P8", "P9", "PA", "PB", "PC", "PD", "PE", "PF", "PG", "PK", "PL", "PO", "PP", "PQ", "PR", "PS", "PT", "PW", "PX", "Q1", "Q2", "Q3", "Q4", "QA", "QB", "QC", "QD", "QE", "QF", "QH", "QI", "QJ", "QL", "QM", "QN", "QO", "QP", "QQ", "QR", "QS", "QU", "QV", "QW", "QX", "R3", "R5", "R6", "R9", "RA", "RB", "RC", "RD", "RE", "RF", "RG", "RH", "RJ", "RL", "RM", "RN", "RQ", "RS", "RT", "RW", "RY", "S1", "S2", "S3", "S4", "S5", "S6", "S7", "S8", "S9", "SA", "SB", "SC", "SD", "SE", "SF", "SG", "SH", "SI", "SJ", "SK", "SL", "SM", "SN", "SO", "SP", "SQ", "SR", "SS", "ST", "SU", "SV", "SW", "SX", "SY", "T1", "T2", "T3", "T4", "T5", "T6", "T7", "TA", "TB", "TC", "TD", "TE", "TG", "TH", "TI", "TJ", "TK", "TM", "TN", "TO", "TP", "TR", "TS", "TT", "TU", "TV", "TW", "TX", "TY", "UA", "UG", "UL", "UO", "US", "UU", "V1", "V2", "V3", "V4", "V5", "VA", "VB", "VC", "VD", "VE", "VF", "VG", "VH", "VI", "VJ", "VK", "VL", "VM", "VN", "VP", "VR", "VS", "VT", "VV", "VY", "WA", "WB", "WC", "WD", "WE", "WG", "WL", "WO", "WP", "WR", "WT", "WV", "WW", "WX", "WY", "X1", "XA", "XB", "XC", "XD", "XE", "XG", "XI", "XJ", "XL", "XN", "XO", "XT", "XU", "XV", "XX", "XY", "XZ", "YA", "YB", "YC", "YD", "YE", "YF", "YG", "YH", "YJ", "YK", "YL", "YM", "YN", "YP", "YQ", "YR", "YS", "YT", "YW", "YX", "YY", "Z1", "Z2", "Z3", "Z4", "Z6", "ZA", "ZB", "ZC", "ZD", "ZE", "ZF", "ZG", "ZH", "ZI", "ZJ", "ZK", "ZL", "ZM", "ZN", "ZO", "ZP", "ZR", "ZS" });
        }
    }
    public class E_0706 : MapDataElement
    {
        public E_0706()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "68", "69", "70", "71", "72", "73", "74", "75", "76", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "89", "90", "91", "92", "93", "94", "95", "96", "97" });
        }
    }
    public class E_0742 : MapDataElement
    {
        public E_0742()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 35;
        }
    }
    public class E_0759 : MapDataElement
    {
        public E_0759()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "RQ" });
        }
    }
    public class E_0782 : MapDataElement
    {
        public E_0782()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 18;
        }
    }
    public class E_0805 : MapDataElement
    {
        public E_0805()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 25;
        }
    }
    public class E_0806 : MapDataElement
    {
        public E_0806()
        {
            DataType = DataType.AN;
            MinLength = 4;
            MaxLength = 6;
        }
    }
    public class E_0807 : MapDataElement
    {
        public E_0807()
        {
            DataType = DataType.AN;
            MinLength = 12;
            MaxLength = 16;
        }
    }
    public class E_0808 : MapDataElement
    {
        public E_0808()
        {
            DataType = DataType.ID;
            MinLength = 3;
            MaxLength = 3;
            AllowedValues.AddRange(new[] { "ADI", "CAO", "D13", "DRC", "DWW", "EMS", "HOT", "HZC", "INH", "LQY", "MFA", "MOS", "MPI", "PIH", "POI", "RAM", "TEC", "TNM", "WST" });
        }
    }
    public class E_0809 : MapDataElement
    {
        public E_0809()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 25;
        }
    }
    public class E_0822 : MapDataElement
    {
        public E_0822()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 15;
        }
    }
    public class E_0983 : MapDataElement
    {
        public E_0983()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "P", "S" });
        }
    }
    public class E_0984 : MapDataElement
    {
        public E_0984()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "C", "D", "I" });
        }
    }
    public class E_0985 : MapDataElement
    {
        public E_0985()
        {
            DataType = DataType.ID;
            MinLength = 3;
            MaxLength = 3;
            AllowedValues.AddRange(new[] { "NOS" });
        }
    }
    public class E_0986 : MapDataElement
    {
        public E_0986()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "S" });
        }
    }
    public class E_1018 : MapDataElement
    {
        public E_1018()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 15;
        }
    }
    public class E_1023 : MapDataElement
    {
        public E_1023()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "A", "B", "C", "D" });
        }
    }
    public class E_1073 : MapDataElement
    {
        public E_1073()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "N", "U", "W", "Y" });
        }
    }
    public class E_1122 : MapDataElement
    {
        public E_1122()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 1;
            AllowedValues.AddRange(new[] { "A", "B", "C", "D", "E", "F", "Z" });
        }
    }
    public class E_1195 : MapDataElement
    {
        public E_1195()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 80;
        }
    }
    public class E_1196 : MapDataElement
    {
        public E_1196()
        {
            DataType = DataType.ID;
            MinLength = 2;
            MaxLength = 2;
            AllowedValues.AddRange(new[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59", "60", "61", "62", "63", "64", "65", "66", "67", "70", "71", "72", "73", "74", "75", "77", "78", "79", "80", "81", "82", "83", "84", "85", "86", "87", "88", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AT", "B1", "B2", "B3", "B4", "B5", "BL", "BY", "C1", "C2", "C3", "C4", "CM", "CY", "D1", "D2", "D3", "D4", "D5", "D6", "D7", "E1", "E2", "E3", "E4", "EH", "ES", "EX", "F1", "F2", "F3", "F4", "FE", "FP", "FR", "G1", "G2", "G3", "G4", "G5", "H1", "H2", "H3", "H4", "H5", "I1", "IN", "J1", "J2", "K6", "L1", "LM", "M1", "MD", "MR", "N1", "NP", "P1", "P2", "P3", "P4", "P5", "P6", "RL", "SC", "TA", "TC", "TD", "TR", "TU", "UB", "ZZ" });
        }
    }
    public class E_1270 : MapDataElement
    {
        public E_1270()
        {
            DataType = DataType.ID;
            MinLength = 1;
            MaxLength = 3;
            AllowedValues.AddRange(new[] { "0", "1", "10", "100", "101", "102", "103", "104", "105", "106", "107", "108", "109", "11", "12", "13", "14", "16", "17", "19", "2", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "3", "30", "32", "33", "34", "35", "36", "37", "38", "39", "4", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "5", "52", "53", "54", "55", "56", "57", "58", "59", "6", "60", "61", "62", "63", "66", "67", "69", "7", "71", "74", "75", "78", "79", "8", "80", "81", "82", "83", "84", "85", "87", "88", "89", "9", "90", "91", "92", "93", "94", "95", "96", "97", "98", "99", "A", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "AA", "AAA", "AB", "ABR", "ABS", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "ALP", "AM", "AN", "AO", "AP", "APE", "AQ", "AR", "AS", "AT", "AU", "AW", "AX", "B", "BA", "BB", "BC", "BCC", "BCR", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BPL", "BQ", "BR", "BRL", "BS", "BSL", "BU", "BV", "BY", "BZ", "C", "C1", "C2", "C3", "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CLP", "CM", "CML", "CN", "CO", "COG", "CPS", "CRC", "CS", "CSF", "CT", "CU", "CV", "CW", "CZ", "D", "D1", "D2", "D3", "D4", "D5", "DA", "DB", "DBS", "DC", "DD", "DE", "DF", "DG", "DGO", "DH", "DI", "DJ", "DK", "DL", "DLO", "DLP", "DM", "DN", "DO", "DPE", "DPL", "DQ", "DR", "DS", "DT", "DU", "DW", "DX", "DY", "DZ", "E", "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EQ", "ER", "ES", "ESL", "ET", "ETL", "EU", "EV", "EW", "EWC", "EWR", "EX", "EY", "EZ", "F", "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "FS", "FT", "FU", "FV", "FW", "FX", "FZ", "G", "G1", "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GI", "GJ", "GK", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "H", "HA", "HB", "HD", "HE", "HI", "HRC", "HS", "HZR", "I", "IC", "ID", "IF", "IMC", "IMP", "IPA", "IQ", "IT", "J", "J0", "J1", "J2", "J3", "J4", "J5", "J6", "J7", "J8", "J9", "JA", "JB", "JC", "JCL", "JD", "JE", "JF", "JG", "JH", "JI", "JK", "JL", "JM", "JN", "JO", "JOL", "JP", "K", "KA", "KB", "KC", "KD", "KE", "KF", "KG", "KH", "KI", "KJ", "KK", "KL", "KM", "KO", "KP", "KQ", "KS", "KT", "KU", "KW", "KYL", "KZ", "L", "LA", "LB", "LC", "LD", "LE", "LF", "LG", "LH", "LIN", "LJ", "LK", "LM", "LN", "LO", "LOI", "LP", "LQ", "LR", "LS", "LSC", "LT", "LZ", "M", "MB", "MC", "MCC", "MCD", "ME", "MI", "MJ", "MK", "ML", "MN", "MOC", "N", "NA", "NAC", "NAF", "NAS", "NB", "NC", "ND", "NDC", "NE", "NF", "NH", "NI", "NJ", "NK", "NL", "NP", "NR", "NS", "NT", "O", "O1", "O2", "O3", "O4", "OC", "P", "PB", "PC", "PD", "PGS", "PI", "PIT", "PL", "PLC", "PLS", "PPD", "PPP", "PPS", "PPV", "PRA", "PRC", "PRR", "PRT", "PS", "PWA", "PWI", "PWR", "PWS", "PWT", "Q", "QA", "QB", "QC", "QE", "QF", "QG", "QH", "QI", "QJ", "QK", "QS", "R", "RA", "RC", "RCA", "RD", "RE", "REN", "RF", "RI", "RQ", "RR", "RT", "RTC", "RUM", "RX", "S", "SA", "SB", "SBA", "SC", "SD", "SE", "SEC", "SF", "SG", "SH", "SHL", "SI", "SJ", "SL", "SM", "SMI", "SO", "SP", "SPE", "SR", "SRL", "SS", "ST", "STC", "T", "T00", "T01", "T02", "T03", "T04", "T05", "T06", "T07", "T08", "T09", "T10", "T11", "T12", "T13", "T14", "T15", "T16", "T17", "T18", "T19", "T20", "T21", "TB", "TC", "TCL", "TD", "TE", "TF", "TG", "TOL", "TR", "TTL", "TX", "TY", "U", "UP", "UR", "US", "UU", "V", "W", "WDL", "X", "Y", "Z", "ZZ" });
        }
    }
    public class E_1271 : MapDataElement
    {
        public E_1271()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 30;
        }
    }
    public class E_1300 : MapDataElement
    {
        public E_1300()
        {
            DataType = DataType.AN;
            MinLength = 4;
            MaxLength = 4;
        }
    }
    public class E_1375 : MapDataElement
    {
        public E_1375()
        {
            DataType = DataType.AN;
            MinLength = 1;
            MaxLength = 5;
        }
    }
}

