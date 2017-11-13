using EdiEngine.Common.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;
using EdiEngine.Xml;

namespace EdiEngine.Runtime
{
    public class EdiLoop : MappedObjectBase
    {
        public EdiLoop()
        {
            Content = new List<MappedObjectBase>();
        }

        public EdiLoop(MapBaseEntity definition, EdiLoop parent) : base(definition)
        {
            Content = new List<MappedObjectBase>();
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
        public List<MappedObjectBase> Content { get; }
    }
}
