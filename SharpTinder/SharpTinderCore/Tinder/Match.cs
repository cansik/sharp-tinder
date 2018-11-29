using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class Match
    {

        [JsonProperty("_id")]
        public string Id { get; set; }

        [JsonProperty("closed")]
        public bool Closed { get; set; }

        [JsonProperty("common_friend_count")]
        public int CommonFriendCount { get; set; }

        [JsonProperty("common_like_count")]
        public int CommonLikeCount { get; set; }

        [JsonProperty("created_date")]
        public DateTime CreatedDate { get; set; }

        [JsonProperty("dead")]
        public bool Dead { get; set; }

        [JsonProperty("last_activity_date")]
        public DateTime LastActivityDate { get; set; }

        [JsonProperty("message_count")]
        public int MessageCount { get; set; }

        [JsonProperty("messages")]
        public List<Message> Messages { get; set; }

        [JsonProperty("muted")]
        public bool Muted { get; set; }

        [JsonProperty("participants")]
        public IList<string> Participants { get; set; }

        [JsonProperty("pending")]
        public bool Pending { get; set; }

        [JsonProperty("is_super_like")]
        public bool IsSuperLike { get; set; }

        [JsonProperty("following")]
        public bool Following { get; set; }

        [JsonProperty("following_moments")]
        public bool FollowingMoments { get; set; }

        [JsonProperty("id")]
        public string MatchId { get; set; }

        [JsonProperty("person")]
        public Person Person { get; set; }

        [JsonProperty("super_liker")]
        public string SuperLiker { get; set; }

        [JsonProperty("is_new_message")]
        public bool? IsNewMessage { get; set; }
    }

}

