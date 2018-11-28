using Newtonsoft.Json;

namespace SharpTinder
{
    public class School
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }
    }
}

