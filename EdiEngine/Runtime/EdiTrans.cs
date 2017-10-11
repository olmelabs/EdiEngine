using Newtonsoft.Json;
using System.Collections.Generic;

namespace EdiEngine.Runtime
{
    public class EdiTrans : EdiLoop, IValidatedEntity
    {
        public EdiTrans()
        {
            ST = new List<string>();
            SE = new List<string>();
            ValidationErrors = new List<ValidationError>();
        }

        public List<string> ST { get; set; }

        public List<string> SE { get; set; }

        [JsonProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
