using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{

    public class TinderRecommendation
    {

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("results")]
        public IList<Result> Results { get; set; }
    }
}

