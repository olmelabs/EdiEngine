using EdiEngine.Common.Definitions;
using EdiEngine.Xml;
using Newtonsoft.Json;

namespace EdiEngine.Runtime
{
    [XmlElement(ElementName = "EdiLoop")]
    public class EdiHlLoop : EdiLoop
    {
        public EdiHlLoop(MapBaseEntity definition, 
            EdiLoop parent, 
            int HL01,
            int? HL02
            ) : base(definition, parent)
        {
            HL01_HierarchicalIdNumber = HL01;
            HL02_HierarchicalParentIdNumber = HL02;
        }

        [JsonProperty(Order = 5)]
        [XmlProperty(Order = 5)]
        public int HL01_HierarchicalIdNumber { get; }

        [JsonProperty(Order = 6)]
        [XmlProperty(Order = 6)]
        public int? HL02_HierarchicalParentIdNumber { get; }
    }
}
