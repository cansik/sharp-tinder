using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class Result
    {

        [JsonProperty("distance_mi")]
        public int DistanceMi { get; set; }

        [JsonProperty("common_connections")]
        public IList<CommonConnection> CommonConnections { get; set; }

        [JsonProperty("connection_count")]
        public int ConnectionCount { get; set; }

        [JsonProperty("common_likes")]
        public IList<object> CommonLikes { get; set; }

        [JsonProperty("common_interests")]
        public IList<CommonInterest> CommonInterests { get; set; }

        [JsonProperty("common_friends")]
        public IList<object> CommonFriends { get; set; }

        [JsonProperty("content_hash")]
        public string ContentHash { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("badges")]
        public IList<object> Badges { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ping_time")]
        public DateTime PingTime { get; set; }

        [JsonProperty("photos")]
        public IList<RecommendationPhoto> Photos { get; set; }

        [JsonProperty("jobs")]
        public IList<Job> Jobs { get; set; }

        [JsonProperty("schools")]
        public IList<School> Schools { get; set; }

        [JsonProperty("teaser")]
        public Teaser Teaser { get; set; }

        [JsonProperty("birth_date_info")]
        public string BirthDateInfo { get; set; }

        [JsonProperty("is_traveling")]
        public bool? IsTraveling { get; set; }

        [JsonProperty("instagram")]
        public Instagram Instagram { get; set; }

        [JsonProperty("uncommon_interests")]
        public IList<object> UncommonInterests { get; set; }
    }
}

