using EdiEngine.Common.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;
using EdiEngine.Xml;

namespace EdiEngine.Runtime
{
    public class EdiTrans : EdiLoop, IValidatedEntity
    {
        public EdiTrans()
        {
            ValidationErrors = new List<ValidationError>();
        }

        public EdiTrans(MapBaseEntity definition) : base(definition, null)
        {
            ValidationErrors = new List<ValidationError>();
        }

        [JsonProperty(Order = 0)]
        [XmlIgnore]
        public override string Type => "M";

        public EdiSegment ST { get; set; }

        public EdiSegment SE { get; set; }

        [JsonProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
