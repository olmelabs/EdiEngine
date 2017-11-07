using EdiEngine.Common.Enums;
using EdiEngine.Common.Definitions;
using EdiEngine.Standards.X12_004010.DataElements;

namespace EdiEngine.Standards.X12_004010.Segments
{
    public class AMT : MapSegment
    {
        public AMT()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0522 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0782 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0478 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class BNX : MapSegment
    {
        public BNX()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0460 { ReqDes = RequirementDesignator.Optional  },
                new E_0129 { ReqDes = RequirementDesignator.Optional  },
                new E_0011 { ReqDes = RequirementDesignator.Optional  },
                new E_0223 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class FA1 : MapSegment
    {
        public FA1()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0559 { ReqDes = RequirementDesignator.Mandatory  },
                new E_1300 { ReqDes = RequirementDesignator.Optional  },
                new E_0248 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class FA2 : MapSegment
    {
        public FA2()
        {
            Content.AddRange(new MapDataElement[] {
                new E_1196 { ReqDes = RequirementDesignator.Mandatory  },
                new E_1195 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class G61 : MapSegment
    {
        public G61()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0366 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0093 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0365 { ReqDes = RequirementDesignator.Optional  },
                new E_0364 { ReqDes = RequirementDesignator.Optional  },
                new E_0443 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class G62 : MapSegment
    {
        public G62()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0432 { ReqDes = RequirementDesignator.Optional  },
                new E_0373 { ReqDes = RequirementDesignator.Optional  },
                new E_0176 { ReqDes = RequirementDesignator.Optional  },
                new E_0337 { ReqDes = RequirementDesignator.Optional  },
                new E_0623 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class G66 : MapSegment
    {
        public G66()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0146 { ReqDes = RequirementDesignator.Optional  },
                new E_0091 { ReqDes = RequirementDesignator.Optional  },
                new E_0399 { ReqDes = RequirementDesignator.Optional  },
                new E_0400 { ReqDes = RequirementDesignator.Optional  },
                new E_0387 { ReqDes = RequirementDesignator.Optional  },
                new E_0433 { ReqDes = RequirementDesignator.Optional  },
                new E_0434 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class G69 : MapSegment
    {
        public G69()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0369 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class GE : MapSegment
    {
        public GE()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0097 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0028 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class GS : MapSegment
    {
        public GS()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0479 { ReqDes = RequirementDesignator.Mandatory  },
                new E_G142 { ReqDes = RequirementDesignator.Mandatory  },
                new E_G124 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0373 { ReqDes = RequirementDesignator.Mandatory  },
                new E_9830 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0028 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0455 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0480 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class IEA : MapSegment
    {
        public IEA()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0I16 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I12 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class ISA : MapSegment
    {
        public ISA()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0I01 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I02 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I03 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I04 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I05 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I06 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I05 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I07 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I08 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I09 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I10 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I11 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I12 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I13 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I14 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0I15 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class LE : MapSegment
    {
        public LE()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0447 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class LEP : MapSegment
    {
        public LEP()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0806 { ReqDes = RequirementDesignator.Optional  },
                new E_0807 { ReqDes = RequirementDesignator.Optional  },
                new E_0156 { ReqDes = RequirementDesignator.Optional  },
                new E_0127 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LFH : MapSegment
    {
        public LFH()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0808 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0809 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0809 { ReqDes = RequirementDesignator.Optional  },
                new E_1023 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LH1 : MapSegment
    {
        public LH1()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0355 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0080 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0277 { ReqDes = RequirementDesignator.Optional  },
                new E_0200 { ReqDes = RequirementDesignator.Optional  },
                new E_0022 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0595 { ReqDes = RequirementDesignator.Optional  },
                new E_0665 { ReqDes = RequirementDesignator.Optional  },
                new E_0254 { ReqDes = RequirementDesignator.Optional  },
                new E_1375 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LH2 : MapSegment
    {
        public LH2()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0215 { ReqDes = RequirementDesignator.Optional  },
                new E_0983 { ReqDes = RequirementDesignator.Optional  },
                new E_0218 { ReqDes = RequirementDesignator.Optional  },
                new E_0222 { ReqDes = RequirementDesignator.Optional  },
                new E_0759 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0408 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0408 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0408 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LH3 : MapSegment
    {
        public LH3()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0224 { ReqDes = RequirementDesignator.Optional  },
                new E_0984 { ReqDes = RequirementDesignator.Optional  },
                new E_0985 { ReqDes = RequirementDesignator.Optional  },
                new E_1073 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LH4 : MapSegment
    {
        public LH4()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0238 { ReqDes = RequirementDesignator.Optional  },
                new E_0364 { ReqDes = RequirementDesignator.Optional  },
                new E_0254 { ReqDes = RequirementDesignator.Optional  },
                new E_0230 { ReqDes = RequirementDesignator.Optional  },
                new E_0230 { ReqDes = RequirementDesignator.Optional  },
                new E_0230 { ReqDes = RequirementDesignator.Optional  },
                new E_0271 { ReqDes = RequirementDesignator.Optional  },
                new E_0267 { ReqDes = RequirementDesignator.Optional  },
                new E_0805 { ReqDes = RequirementDesignator.Optional  },
                new E_0986 { ReqDes = RequirementDesignator.Optional  },
                new E_0364 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LH6 : MapSegment
    {
        public LH6()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0093 { ReqDes = RequirementDesignator.Optional  },
                new E_0272 { ReqDes = RequirementDesignator.Optional  },
                new E_0273 { ReqDes = RequirementDesignator.Optional  },
                new E_0273 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LHR : MapSegment
    {
        public LHR()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0128 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0127 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0373 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LHT : MapSegment
    {
        public LHT()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0215 { ReqDes = RequirementDesignator.Optional  },
                new E_0218 { ReqDes = RequirementDesignator.Optional  },
                new E_0222 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LM : MapSegment
    {
        public LM()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0559 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0822 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LQ : MapSegment
    {
        public LQ()
        {
            Content.AddRange(new MapDataElement[] {
                new E_1270 { ReqDes = RequirementDesignator.Optional  },
                new E_1271 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class LS : MapSegment
    {
        public LS()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0447 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class LX : MapSegment
    {
        public LX()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0554 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class MAN : MapSegment
    {
        public MAN()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0088 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0087 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0087 { ReqDes = RequirementDesignator.Optional  },
                new E_0088 { ReqDes = RequirementDesignator.Optional  },
                new E_0087 { ReqDes = RequirementDesignator.Optional  },
                new E_0087 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class N1 : MapSegment
    {
        public N1()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0098 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0093 { ReqDes = RequirementDesignator.Optional  },
                new E_0066 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0706 { ReqDes = RequirementDesignator.Optional  },
                new E_0098 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class N2 : MapSegment
    {
        public N2()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0093 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0093 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class N3 : MapSegment
    {
        public N3()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0166 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0166 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class N4 : MapSegment
    {
        public N4()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0019 { ReqDes = RequirementDesignator.Optional  },
                new E_0156 { ReqDes = RequirementDesignator.Optional  },
                new E_0116 { ReqDes = RequirementDesignator.Optional  },
                new E_0026 { ReqDes = RequirementDesignator.Optional  },
                new E_0309 { ReqDes = RequirementDesignator.Optional  },
                new E_0310 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class N9 : MapSegment
    {
        public N9()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0128 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0127 { ReqDes = RequirementDesignator.Optional  },
                new E_0369 { ReqDes = RequirementDesignator.Optional  },
                new E_0373 { ReqDes = RequirementDesignator.Optional  },
                new E_0337 { ReqDes = RequirementDesignator.Optional  },
                new E_0623 { ReqDes = RequirementDesignator.Optional  },
                new E_0128 { ReqDes = RequirementDesignator.Optional  },
                new E_0127 { ReqDes = RequirementDesignator.Optional  },
                new E_0128 { ReqDes = RequirementDesignator.Optional  },
                new E_0127 { ReqDes = RequirementDesignator.Optional  },
                new E_0128 { ReqDes = RequirementDesignator.Optional  },
                new E_0127 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class NTE : MapSegment
    {
        public NTE()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0363 { ReqDes = RequirementDesignator.Optional  },
                new E_0352 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class PER : MapSegment
    {
        public PER()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0366 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0093 { ReqDes = RequirementDesignator.Optional  },
                new E_0365 { ReqDes = RequirementDesignator.Optional  },
                new E_0364 { ReqDes = RequirementDesignator.Optional  },
                new E_0365 { ReqDes = RequirementDesignator.Optional  },
                new E_0364 { ReqDes = RequirementDesignator.Optional  },
                new E_0365 { ReqDes = RequirementDesignator.Optional  },
                new E_0364 { ReqDes = RequirementDesignator.Optional  },
                new E_0443 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class QTY : MapSegment
    {
        public QTY()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0673 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_1018 { ReqDes = RequirementDesignator.Optional  },
                new E_0649 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_1018 { ReqDes = RequirementDesignator.Optional  },
                new E_0649 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_1018 { ReqDes = RequirementDesignator.Optional  },
                new E_0649 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_1018 { ReqDes = RequirementDesignator.Optional  },
                new E_0649 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_1018 { ReqDes = RequirementDesignator.Optional  },
                new E_0649 { ReqDes = RequirementDesignator.Optional  },
                new E_0061 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class R2 : MapSegment
    {
        public R2()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0140 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0133 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0019 { ReqDes = RequirementDesignator.Optional  },
                new E_0154 { ReqDes = RequirementDesignator.Optional  },
                new E_0177 { ReqDes = RequirementDesignator.Optional  },
                new E_0091 { ReqDes = RequirementDesignator.Optional  },
                new E_0296 { ReqDes = RequirementDesignator.Optional  },
                new E_0296 { ReqDes = RequirementDesignator.Optional  },
                new E_0076 { ReqDes = RequirementDesignator.Optional  },
                new E_0373 { ReqDes = RequirementDesignator.Optional  },
                new E_0369 { ReqDes = RequirementDesignator.Optional  },
                new E_0056 { ReqDes = RequirementDesignator.Optional  },
                new E_0742 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class SDQ : MapSegment
    {
        public SDQ()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0355 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0066 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0380 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0067 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
                new E_0310 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class SE : MapSegment
    {
        public SE()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0096 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0329 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class ST : MapSegment
    {
        public ST()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0143 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0329 { ReqDes = RequirementDesignator.Mandatory  },
            });
        }
    }
    public class W01 : MapSegment
    {
        public W01()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0330 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0355 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0438 { ReqDes = RequirementDesignator.Optional  },
                new E_0235 { ReqDes = RequirementDesignator.Optional  },
                new E_0234 { ReqDes = RequirementDesignator.Optional  },
                new E_0235 { ReqDes = RequirementDesignator.Optional  },
                new E_0234 { ReqDes = RequirementDesignator.Optional  },
                new E_0059 { ReqDes = RequirementDesignator.Optional  },
                new E_0121 { ReqDes = RequirementDesignator.Optional  },
                new E_0023 { ReqDes = RequirementDesignator.Optional  },
                new E_0022 { ReqDes = RequirementDesignator.Optional  },
                new E_0416 { ReqDes = RequirementDesignator.Optional  },
                new E_0451 { ReqDes = RequirementDesignator.Optional  },
                new E_0286 { ReqDes = RequirementDesignator.Optional  },
                new E_0235 { ReqDes = RequirementDesignator.Optional  },
                new E_0234 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class W05 : MapSegment
    {
        public W05()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0473 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0285 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0324 { ReqDes = RequirementDesignator.Optional  },
                new E_0472 { ReqDes = RequirementDesignator.Optional  },
                new E_0474 { ReqDes = RequirementDesignator.Optional  },
                new E_0640 { ReqDes = RequirementDesignator.Optional  },
                new E_0306 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class W09 : MapSegment
    {
        public W09()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0040 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0408 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0408 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0003 { ReqDes = RequirementDesignator.Optional  },
                new E_1122 { ReqDes = RequirementDesignator.Optional  },
                new E_0488 { ReqDes = RequirementDesignator.Optional  },
                new E_0380 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class W20 : MapSegment
    {
        public W20()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0356 { ReqDes = RequirementDesignator.Optional  },
                new E_0357 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0081 { ReqDes = RequirementDesignator.Optional  },
                new E_0187 { ReqDes = RequirementDesignator.Optional  },
                new E_0188 { ReqDes = RequirementDesignator.Optional  },
                new E_0395 { ReqDes = RequirementDesignator.Optional  },
                new E_0183 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0397 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class W6 : MapSegment
    {
        public W6()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0152 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0152 { ReqDes = RequirementDesignator.Optional  },
                new E_0152 { ReqDes = RequirementDesignator.Optional  },
                new E_0152 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class W66 : MapSegment
    {
        public W66()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0146 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0091 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0399 { ReqDes = RequirementDesignator.Optional  },
                new E_0400 { ReqDes = RequirementDesignator.Optional  },
                new E_0387 { ReqDes = RequirementDesignator.Optional  },
                new E_0433 { ReqDes = RequirementDesignator.Optional  },
                new E_0434 { ReqDes = RequirementDesignator.Optional  },
                new E_0625 { ReqDes = RequirementDesignator.Optional  },
                new E_0610 { ReqDes = RequirementDesignator.Optional  },
                new E_0140 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
    public class W76 : MapSegment
    {
        public W76()
        {
            Content.AddRange(new MapDataElement[] {
                new E_0330 { ReqDes = RequirementDesignator.Mandatory  },
                new E_0081 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0183 { ReqDes = RequirementDesignator.Optional  },
                new E_0355 { ReqDes = RequirementDesignator.Optional  },
                new E_0398 { ReqDes = RequirementDesignator.Optional  },
            });
        }
    }
}

