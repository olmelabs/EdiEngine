using Newtonsoft.Json;

namespace EdiEngine.Validation
{
    public class ValidationError
    {
        [JsonProperty(Order = 1)]
        public int? SegmentPos { get; set; }

        [JsonProperty(Order = 2)]
        public string SegmentName { get; set; }

        [JsonProperty(Order = 3)]
        public int? ElementPos { get; set; }

        [JsonProperty(Order = 4)]
        public string Message { get; set; }
    }
}
