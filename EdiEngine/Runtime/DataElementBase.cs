using EdiEngine.Common.Definitions;
using EdiEngine.Xml;
using Newtonsoft.Json;

namespace EdiEngine.Runtime
{
    public abstract class DataElementBase
    {
        protected DataElementBase(MapBaseDataElement definition)
        {
            Definition = definition;
        }

        [JsonIgnore]
        [XmlIgnore]
        public MapBaseDataElement Definition { get; }

        public abstract string Val { get;}

        public override string ToString()
        {
            return Val ?? string.Empty;
        }
    }
}
