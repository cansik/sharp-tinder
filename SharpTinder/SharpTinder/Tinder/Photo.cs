using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class Photo
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("fbId")]
        public string FbId { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("processedFiles")]
        public IList<ProcessedFile> ProcessedFiles { get; set; }
    }

}
