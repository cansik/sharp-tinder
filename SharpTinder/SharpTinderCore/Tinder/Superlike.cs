using Newtonsoft.Json;

namespace SharpTinder
{
    public class Superlike
    {

        [JsonProperty("regular")]
        public Regular Regular { get; set; }
    }

}
