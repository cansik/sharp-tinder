using Newtonsoft.Json;

namespace SharpTinder
{

    public class TinderUserResult
    {

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("results")]
        public Results Results { get; set; }
    }

}

