using EdiEngine.Common.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;
using EdiEngine.Xml;

namespace EdiEngine.Runtime
{
    public class EdiLoop : EdiBaseEntity
    {
        public EdiLoop()
        {
            Content = new List<EdiBaseEntity>();
        }

        public EdiLoop(MapBaseEntity definition, EdiLoop parent) : base(definition)
        {
            Content = new List<EdiBaseEntity>();
            Parent = parent;
        }

        [JsonProperty(Order = 0)]
        [XmlIgnore]
        public override string Type => "L";

        [JsonIgnore]
        [XmlIgnore]
        public EdiLoop Parent { get; }

        [JsonProperty(Order = 10)]
        [XmlProperty(Order = 10)]
        public List<EdiBaseEntity> Content { get; }
    }
}
