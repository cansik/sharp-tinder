using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
	public class FacebookPhoto
	{

		[JsonProperty("small")]
		public string Small { get; set; }

		[JsonProperty("medium")]
		public string Medium { get; set; }

		[JsonProperty("large")]
		public string Large { get; set; }
	}

	public class CommonConnection
	{

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("photo")]
		public FacebookPhoto Photo { get; set; }

		[JsonProperty("degree")]
		public int Degree { get; set; }
	}

	public class CommonInterest
	{

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class RecommendationPhoto
	{

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("processedFiles")]
		public IList<ProcessedFile> ProcessedFiles { get; set; }
	}

	public class Company
	{

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class Title
	{

		[JsonProperty("name")]
		public string Name { get; set; }
	}

	public class Job
	{

		[JsonProperty("company")]
		public Company Company { get; set; }

		[JsonProperty("title")]
		public Title Title { get; set; }
	}

	public class School
	{

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }
	}

	public class Teaser
	{

		[JsonProperty("string")]
		public string String { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }
	}

	public class InstagramPhoto
	{

		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("thumbnail")]
		public string Thumbnail { get; set; }

		[JsonProperty("ts")]
		public string Ts { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }
	}

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

	public class TinderRecommendation
	{

		[JsonProperty("status")]
		public int Status { get; set; }

		[JsonProperty("results")]
		public IList<Result> Results { get; set; }
	}
}

