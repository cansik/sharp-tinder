using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class Instagram
    {

        [JsonProperty("last_fetch_time")]
        public DateTime LastFetchTime { get; set; }

        [JsonProperty("completed_initial_fetch")]
        public bool CompletedInitialFetch { get; set; }

        [JsonProperty("photos")]
        public IList<InstagramPhoto> Photos { get; set; }

        [JsonProperty("media_count")]
        public int MediaCount { get; set; }

        [JsonProperty("profile_picture")]
        public string ProfilePicture { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }
}

