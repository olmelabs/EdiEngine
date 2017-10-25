
using EdiEngine.Common.Definitions;
using Newtonsoft.Json;
namespace EdiEngine.Runtime
{
    public class EdiDataElement 
    {
        public EdiDataElement(MapDataElement definition, string val)
        {
            if (definition != null)
            {
                Type = definition.GetType().Name;
            }
            Val = val;
        }

        [JsonIgnore]
        public string Type { get; }

        [JsonProperty(Order = 1, PropertyName = "E")]
        public string Val { get; }
    }
}
