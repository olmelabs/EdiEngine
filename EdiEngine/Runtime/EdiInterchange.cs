using Newtonsoft.Json;
using System.Collections.Generic;

namespace EdiEngine.Runtime
{
    public class EdiInterchange : IValidatedEntity
    {
        public EdiInterchange()
        {
            ISA = new List<string>();
            IEA = new List<string>();
            Groups = new List<EdiGroup>();
            ValidationErrors = new List<ValidationError>();
        }

        public string SegmentSeparator { get; set; }
        public string ElementSeparator { get; set; }
        public List<string> ISA { get; set; }
        public List<string> IEA { get; set; }
        public List<EdiGroup> Groups { get; set; }

        [JsonProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
