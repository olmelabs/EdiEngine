using Newtonsoft.Json;
using System.Collections.Generic;
using EdiEngine.Xml;

namespace EdiEngine.Runtime
{
    public class EdiInterchange : IValidatedEntity
    {
        public EdiInterchange()
        {
            Groups = new List<EdiGroup>();
            ValidationErrors = new List<ValidationError>();
        }

        public string SegmentSeparator { get; set; }

        public string ElementSeparator { get; set; }

        public EdiSegment ISA{ get; set; }

        public EdiSegment IEA { get; set; }

        public List<EdiGroup> Groups { get; set; }

        [JsonProperty(Order = 100)]
        [XmlProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
