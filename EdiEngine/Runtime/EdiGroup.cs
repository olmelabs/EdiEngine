using Newtonsoft.Json;
using System.Collections.Generic;

namespace EdiEngine.Runtime
{
    public class EdiGroup : IValidatedEntity
    {
        public EdiGroup()
        {
            GS = new List<string>();
            GE = new List<string>();
            Transactions = new List<EdiTrans>();
            ValidationErrors = new List<ValidationError>();
        }

        public List<string> GS { get; set; }
        public List<string> GE { get; set; }
        public List<EdiTrans> Transactions { get; set; }

        [JsonProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
