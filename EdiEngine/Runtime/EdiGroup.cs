using Newtonsoft.Json;
using System.Collections.Generic;

namespace EdiEngine.Runtime
{
    public class EdiGroup : IValidatedEntity
    {
        public EdiGroup(string functionalCode)
        {
            FunctionalCode = functionalCode;
            Transactions = new List<EdiTrans>();
            ValidationErrors = new List<ValidationError>();
        }

        public GS GS { get; set; }

        public GE GE { get; set; }

        /// <summary>
        /// GS01
        /// </summary>
        public string FunctionalCode { get; }

        public List<EdiTrans> Transactions { get; set; }

        [JsonProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
