using Newtonsoft.Json;
using System.Collections.Generic;
using EdiEngine.Validation;
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

        /// <summary>
        /// GS01
        /// </summary>
        [XmlProperty(Order = 1)]
        public string FunctionalCode { get; }

        [XmlProperty(Order = 2)]
        public EdiSegment GS { get; set; }

        [XmlProperty(Order = 3)]
        public EdiSegment GE { get; set; }

        [XmlProperty(Order = 4)]
        public List<EdiTrans> Transactions { get; set; }

        [JsonProperty(Order = 100)]
        [XmlProperty(Order = 100)]
        public virtual List<ValidationError> ValidationErrors { get; }
    }
}
