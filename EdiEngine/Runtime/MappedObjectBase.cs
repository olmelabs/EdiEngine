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
            if (definition != null)
            {
                Name = definition.Name;
                Definition = definition;
            }
        }

        [JsonIgnore]
        public MapBaseEntity Definition { get; set; }

        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 0)]
        public abstract string Type { get; }
    
    }
}
