using Newtonsoft.Json;

namespace SharpTinder
{
    public class Boost
    {

        [JsonProperty("regular")]
        public Regular Regular { get; set; }
    }

}
