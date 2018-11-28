using Newtonsoft.Json;

namespace SharpTinder
{
    public class Travel
    {

        [JsonProperty("is_traveling")]
        public bool IsTraveling { get; set; }
    }

}
