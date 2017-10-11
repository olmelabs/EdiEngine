
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

        [JsonProperty(Order = 0, PropertyName = "T")]
        public string Type { get; }

        [JsonProperty(Order = 1, PropertyName = "V")]
        public string Val { get; }
    }
}
