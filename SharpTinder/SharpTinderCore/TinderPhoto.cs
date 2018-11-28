using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class TinderPhoto
    {

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("processedFiles")]
        public IList<ProcessedFile> ProcessedFiles { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

        [JsonProperty("fileName")]
        public string FileName { get; set; }

        [JsonProperty("main")]
        public object Main { get; set; }

        [JsonProperty("ydistance_percent")]
        public double YdistancePercent { get; set; }

        [JsonProperty("yoffset_percent")]
        public double YoffsetPercent { get; set; }

        [JsonProperty("xoffset_percent")]
        public double XoffsetPercent { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("xdistance_percent")]
        public double XdistancePercent { get; set; }

        [JsonProperty("shape")]
        public string Shape { get; set; }
    }

}

