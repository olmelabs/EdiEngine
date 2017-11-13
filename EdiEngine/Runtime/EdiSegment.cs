using EdiEngine.Common.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using EdiEngine.Xml;

namespace EdiEngine.Runtime
{
    public class EdiSegment : MappedObjectBase
    {
        public EdiSegment(MapBaseEntity definition) : base(definition)
        {
            Content = new List<EdiDataElement>();
        }

        [JsonProperty(Order = 0)]
        [XmlIgnore]
        public override string Type => "S";

        [JsonProperty(Order = 10)]
        [XmlProperty(Order = 10)]
        public List<EdiDataElement> Content { get; }

        public override string ToString()
        {
            var res = Content.Aggregate(string.Empty, (curr, next) => curr + "*" + next.Val);
            return $"{Name}*{res.Remove(0, 1)}";
        }
    }
}
