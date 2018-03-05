using Newtonsoft.Json;

namespace SharpTinder
{
    public class Globals
    {

        [JsonProperty("boost_down")]
        public int BoostDown { get; set; }

        [JsonProperty("fetch_connections")]
        public bool FetchConnections { get; set; }

        [JsonProperty("tinder_sparks")]
        public bool TinderSparks { get; set; }

        [JsonProperty("matchmaker_default_message")]
        public string MatchmakerDefaultMessage { get; set; }

        [JsonProperty("share_default_text")]
        public string ShareDefaultText { get; set; }

        [JsonProperty("recs_interval")]
        public int RecsInterval { get; set; }

        [JsonProperty("sparks_enabled")]
        public bool SparksEnabled { get; set; }

        [JsonProperty("moments_interval")]
        public int MomentsInterval { get; set; }

        [JsonProperty("sparks")]
        public bool Sparks { get; set; }

        [JsonProperty("updates_interval")]
        public int UpdatesInterval { get; set; }

        [JsonProperty("invite_type")]
        public string InviteType { get; set; }

        [JsonProperty("kontagent_enabled")]
        public bool KontagentEnabled { get; set; }

        [JsonProperty("boost_up")]
        public int BoostUp { get; set; }

        [JsonProperty("friends")]
        public bool Friends { get; set; }

        [JsonProperty("boost_decay")]
        public int BoostDecay { get; set; }

        [JsonProperty("kontagent")]
        public bool Kontagent { get; set; }

        [JsonProperty("recs_size")]
        public int RecsSize { get; set; }

        [JsonProperty("mqtt")]
        public bool Mqtt { get; set; }

        [JsonProperty("plus")]
        public bool Plus { get; set; }
    }
}

