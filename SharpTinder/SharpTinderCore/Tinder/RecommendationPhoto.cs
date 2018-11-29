using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class RecommendationPhoto
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("processedFiles")]
        public IList<ProcessedFile> ProcessedFiles { get; set; }
    }
}

