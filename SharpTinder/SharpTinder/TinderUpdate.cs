using System;
using System.Collections.Generic;
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


	public class Person
	{

		[JsonProperty("_id")]
		public string Id { get; set; }

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
		public IList<TinderPhoto> Photos { get; set; }

		[JsonProperty("badges")]
		public IList<object> Badges { get; set; }

		[JsonProperty("hide_age")]
		public bool? HideAge { get; set; }

		[JsonProperty("hide_distance")]
		public bool? HideDistance { get; set; }
	}

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

	public class LikedMessage
	{

		[JsonProperty("message_id")]
		public string MessageId { get; set; }

		[JsonProperty("updated_at")]
		public string UpdatedAt { get; set; }

		[JsonProperty("liker_id")]
		public string LikerId { get; set; }

		[JsonProperty("match_id")]
		public string MatchId { get; set; }

		[JsonProperty("is_liked")]
		public bool IsLiked { get; set; }
	}

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

