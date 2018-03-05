using Newtonsoft.Json;

namespace SharpTinder
{
    public class Company
    {

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

