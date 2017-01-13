using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
	public class UserResultPhoto
	{

		[JsonProperty("fileName")]
		public string FileName { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("extension")]
		public string Extension { get; set; }

		[JsonProperty("processedFiles")]
		public IList<ProcessedFile> ProcessedFiles { get; set; }

		[JsonProperty("url")]
		public string Url { get; set; }

		[JsonProperty("main")]
		public string Main { get; set; }

		[JsonProperty("shape")]
		public string Shape { get; set; }
	}

	public class Results
	{

		[JsonProperty("connection_count")]
		public int ConnectionCount { get; set; }

		[JsonProperty("common_likes")]
		public IList<object> CommonLikes { get; set; }

		[JsonProperty("common_interests")]
		public IList<CommonInterest> CommonInterests { get; set; }

		[JsonProperty("common_friends")]
		public IList<object> CommonFriends { get; set; }

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
		public IList<UserResultPhoto> Photos { get; set; }

		[JsonProperty("instagram")]
		public Instagram Instagram { get; set; }

		[JsonProperty("jobs")]
		public IList<Job> Jobs { get; set; }

		[JsonProperty("schools")]
		public IList<School> Schools { get; set; }

		[JsonProperty("birth_date_info")]
		public string BirthDateInfo { get; set; }

		[JsonProperty("distance_mi")]
		public int DistanceMi { get; set; }

		[JsonProperty("common_connections")]
		public IList<CommonConnection> CommonConnections { get; set; }
	}

	public class TinderUserResult
	{

		[JsonProperty("status")]
		public int Status { get; set; }

		[JsonProperty("results")]
		public Results Results { get; set; }
	}

}

