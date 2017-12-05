using EdiEngine.Common.Definitions;
using EdiEngine.Xml;
using Newtonsoft.Json;

namespace EdiEngine.Runtime
{
    public abstract class EdiBaseEntity
    {
        protected EdiBaseEntity()
        {

        }

        protected EdiBaseEntity(MapBaseEntity definition)
        {
            if (definition != null)
            {
                Name = definition.Name;
                Definition = definition;
            }
        }

        [JsonIgnore]
        [XmlIgnore]
        public MapBaseEntity Definition { get; set; }

        [JsonProperty(Order = 1)]
        [XmlProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 0)]
        [XmlProperty(Order = 0)]
        public abstract string Type { get; }
        }
}
