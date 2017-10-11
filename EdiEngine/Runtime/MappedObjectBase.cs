using EdiEngine.Common.Definitions;
using Newtonsoft.Json;

namespace EdiEngine.Runtime
{
    public abstract class MappedObjectBase
    {
        protected MappedObjectBase()
        {

        }

        protected MappedObjectBase(MapBaseEntity definition)
        {
            Name = definition.Name;
            Definition = definition;
        }

        [JsonIgnore]
        public MapBaseEntity Definition { get; set; }

        [JsonProperty(Order = 0)]
        public string Name { get; set; }
    }
}
