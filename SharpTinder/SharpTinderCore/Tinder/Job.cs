using Newtonsoft.Json;

namespace SharpTinder
{
    public class Job
    {

        [JsonProperty("company")]
        public Company Company { get; set; }

        [JsonProperty("title")]
        public Title Title { get; set; }
    }
}

