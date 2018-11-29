using System;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class Message
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("match_id")]
        public string MatchId { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("message")]
        public string Text { get; set; }

        [JsonProperty("sent_date")]
        public DateTime SentDate { get; set; }

        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("timestamp")]
        public object Timestamp { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("fixed_height")]
        public string FixedHeight { get; set; }
    }

}

