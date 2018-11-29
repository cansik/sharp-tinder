using Newtonsoft.Json;

namespace SharpTinder
{
    public class Teaser
    {

        [JsonProperty("string")]
        public string String { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

