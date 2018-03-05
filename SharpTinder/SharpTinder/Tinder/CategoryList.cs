using Newtonsoft.Json;

namespace SharpTinder
{
    public class CategoryList
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

