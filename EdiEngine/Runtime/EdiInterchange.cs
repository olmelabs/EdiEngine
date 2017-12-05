using Newtonsoft.Json;
using System.Collections.Generic;
using EdiEngine.Validation;
using EdiEngine.Xml;

namespace EdiEngine.Runtime
{
    public class EdiInterchange : IValidatedEntity
    {
        public const string DefaultCompositeSeparator = ">";

        public EdiInterchange()
        {
            Groups = new List<EdiGroup>();
            ValidationErrors = new List<ValidationError>();
        }

        [XmlProperty(Order = 1)]
        public string SegmentSeparator { get; set; }

        [XmlProperty(Order = 2)]
        public string ElementSeparator { get; set; }

        [XmlProperty(Order = 3)]
        public EdiSegment ISA{ get; set; }

        [XmlProperty(Order = 4)]
        public EdiSegment IEA { get; set; }

        [XmlProperty(Order = 5)]
        public List<EdiGroup> Groups { get; set; }

        [JsonProperty(Order = 100)]
        [XmlProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
