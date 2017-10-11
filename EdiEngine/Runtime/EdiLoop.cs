using EdiEngine.Common.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;
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

        [JsonIgnore]
        public EdiLoop Parent { get; }

        [JsonProperty(Order = 10)]
        public List<MappedObjectBase> Content { get; }
    }
}
