using System.Collections.Generic;
using System.Linq;
using EdiEngine.Common.Definitions;
using EdiEngine.Xml;
using Newtonsoft.Json;

namespace EdiEngine.Runtime
{
    [XmlElement(ElementName = "C")]
    public class EdiCompositeDataElement : DataElementBase
    {
        private readonly string _compositeSeparator;
        public EdiCompositeDataElement(MapBaseDataElement definition, string compositeSeparator = null) : base(definition)
        {
            Name = definition.GetType().Name;
            Content = new List<EdiSimpleDataElement>();
            _compositeSeparator = compositeSeparator;
        }

        [JsonIgnore]
        [XmlIgnore]
        public new MapCompositeDataElement Definition => (MapCompositeDataElement)base.Definition;

        [JsonProperty(Order = 0)]
        [XmlIgnore]
        public string Type => "C";

        [JsonProperty(Order = 1)]
        [XmlProperty(Order = 1)]
        public string Name { get; }

        [JsonProperty(Order = 10)]
        [XmlProperty(Order = 10)]
        public List<EdiSimpleDataElement> Content { get; }

        [JsonIgnore]
        [XmlIgnore]
        public override string Val
        {
            get
            {
                if (Content.Count == 0)
                    return string.Empty;

                var res = Content.Aggregate(string.Empty,
                    (curr, next) => curr + (_compositeSeparator ?? EdiInterchange.DefaultCompositeSeparator) + next.Val);
                return res.Remove(0, 1);
            }
        }
    }
}
