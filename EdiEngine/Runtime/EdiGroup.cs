using Newtonsoft.Json;
using System.Collections.Generic;
using EdiEngine.Xml;

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

        public EdiSegment GS { get; set; }

        public EdiSegment GE { get; set; }

        /// <summary>
        /// GS01
        /// </summary>
        public string FunctionalCode { get; }

        public List<EdiTrans> Transactions { get; set; }

        [JsonProperty(Order = 100)]
        [XmlProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
