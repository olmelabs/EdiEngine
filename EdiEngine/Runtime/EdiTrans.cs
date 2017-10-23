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

        public ST ST { get; set; }

        public SE SE { get; set; }

        [JsonProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
