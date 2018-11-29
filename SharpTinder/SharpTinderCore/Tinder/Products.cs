using Newtonsoft.Json;

namespace SharpTinder
{
    public class Products
    {

        [JsonProperty("superlike")]
        public Superlike Superlike { get; set; }

        [JsonProperty("boost")]
        public Boost Boost { get; set; }
    }

}
