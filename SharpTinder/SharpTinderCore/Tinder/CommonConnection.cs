using Newtonsoft.Json;

namespace SharpTinder
{
    public class CommonConnection
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("photo")]
        public FacebookPhoto Photo { get; set; }

        [JsonProperty("degree")]
        public int Degree { get; set; }
    }
}

