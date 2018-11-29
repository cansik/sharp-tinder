using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class InformationPhoto
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("fbId")]
        public string FbId { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("processedFiles")]
        public IList<ProcessedFile> ProcessedFiles { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("xoffset_percent")]
        public double? XoffsetPercent { get; set; }

        [JsonProperty("ydistance_percent")]
        public double? YdistancePercent { get; set; }

        [JsonProperty("yoffset_percent")]
        public double? YoffsetPercent { get; set; }

        [JsonProperty("main")]
        public bool? Main { get; set; }

        [JsonProperty("xdistance_percent")]
        public double? XdistancePercent { get; set; }
    }
}

