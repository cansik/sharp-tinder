using Newtonsoft.Json;

namespace SharpTinder
{
    public class SuperLikes
    {

        [JsonProperty("remaining")]
        public int Remaining { get; set; }

        [JsonProperty("alc_remaining")]
        public int AlcRemaining { get; set; }

        [JsonProperty("new_alc_remaining")]
        public int NewAlcRemaining { get; set; }

        [JsonProperty("allotment")]
        public int Allotment { get; set; }

        [JsonProperty("superlike_refresh_amount")]
        public int SuperlikeRefreshAmount { get; set; }

        [JsonProperty("superlike_refresh_interval")]
        public int SuperlikeRefreshInterval { get; set; }

        [JsonProperty("superlike_refresh_interval_unit")]
        public string SuperlikeRefreshIntervalUnit { get; set; }

        [JsonProperty("resets_at")]
        public object ResetsAt { get; set; }
    }

}
