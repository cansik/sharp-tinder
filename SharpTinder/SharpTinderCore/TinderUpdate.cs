using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{

    public class TinderUpdate
    {

        [JsonProperty("matches")]
        public IList<Match> Matches { get; set; }

        [JsonProperty("blocks")]
        public IList<string> Blocks { get; set; }

        [JsonProperty("lists")]
        public IList<object> Lists { get; set; }

        [JsonProperty("deleted_lists")]
        public IList<object> DeletedLists { get; set; }

        [JsonProperty("liked_messages")]
        public IList<LikedMessage> LikedMessages { get; set; }

        [JsonProperty("squads")]
        public IList<object> Squads { get; set; }

        [JsonProperty("last_activity_date")]
        public DateTime LastActivityDate { get; set; }
    }

}

