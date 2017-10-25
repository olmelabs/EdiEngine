using EdiEngine.Common.Definitions;
using Newtonsoft.Json;
using System.Collections.Generic;

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

        public EdiSegment ST { get; set; }

        public EdiSegment SE { get; set; }

        [JsonProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
