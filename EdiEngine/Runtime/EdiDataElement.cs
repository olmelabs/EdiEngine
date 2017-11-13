
using EdiEngine.Common.Definitions;
using EdiEngine.Xml;
using Newtonsoft.Json;
namespace EdiEngine.Runtime
{
    [XmlElement(IgnoreElementRoot = true)]
    public class EdiDataElement 
    {
        public EdiDataElement(MapDataElement definition, string val)
        {
            if (definition != null)
            {
                Type = definition.GetType().Name;
            }
            Val = val;
        }

        [JsonIgnore]
        [XmlIgnore]
        public string Type { get; }

        [JsonProperty(Order = 1, PropertyName = "E")]
        [XmlProperty(Order = 1, PropertyName = "E")]
        public string Val { get; }
    }
}
