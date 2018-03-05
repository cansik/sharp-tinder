using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class User
    {

        [JsonProperty("connection_count")]
        public int ConnectionCount { get; set; }

        [JsonProperty("age_filter_min")]
        public int AgeFilterMin { get; set; }

        [JsonProperty("can_create_squad")]
        public bool CanCreateSquad { get; set; }

        [JsonProperty("api_token")]
        public string ApiToken { get; set; }

        [JsonProperty("ping_time")]
        public DateTime PingTime { get; set; }

        [JsonProperty("birth_date")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("photos_processing")]
        public bool PhotosProcessing { get; set; }

        [JsonProperty("schools")]
        public IList<ProfileSchool> Schools { get; set; }

        [JsonProperty("discoverable")]
        public bool Discoverable { get; set; }

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("create_date")]
        public DateTime CreateDate { get; set; }

        [JsonConverter(typeof(MicrosecondEpochConverter))]
        [JsonProperty("active_time")]
        public DateTime ActiveTime { get; set; }

        [JsonProperty("purchases")]
        public IList<object> Purchases { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("is_new_user")]
        public bool IsNewUser { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("squads_only")]
        public bool SquadsOnly { get; set; }

        [JsonProperty("age_filter_max")]
        public int AgeFilterMax { get; set; }

        [JsonProperty("gender")]
        public int Gender { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("groups")]
        public IList<string> Groups { get; set; }

        [JsonProperty("distance_filter")]
        public int DistanceFilter { get; set; }

        [JsonProperty("squads_discoverable")]
        public bool SquadsDiscoverable { get; set; }

        [JsonProperty("photos")]
        public IList<InformationPhoto> Photos { get; set; }

        [JsonProperty("gender_filter")]
        public int GenderFilter { get; set; }

        [JsonProperty("interests")]
        public IList<Interest> Interests { get; set; }

        [JsonProperty("jobs")]
        public IList<ProfileJob> Jobs { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}

