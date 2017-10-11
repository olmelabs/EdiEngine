using EdiEngine.Common.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace EdiEngine.Runtime
{
    public class EdiSegment : MappedObjectBase
    {
        public EdiSegment(MapBaseEntity definition) : base(definition)
        {
            Content = new List<EdiDataElement>();
        }

        [JsonProperty(Order = 10)]
        public List<EdiDataElement> Content { get; }
    }
}
