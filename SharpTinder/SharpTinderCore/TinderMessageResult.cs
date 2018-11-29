using System;
using Newtonsoft.Json;

namespace SharpTinder
{
	public class TinderMessageResult
	{

		[JsonProperty("_id")]
		public string Id { get; set; }

		[JsonProperty("from")]
		public string From { get; set; }

		[JsonProperty("to")]
		public string To { get; set; }

		[JsonProperty("match_id")]
		public string MatchId { get; set; }

		[JsonProperty("sent_date")]
		public DateTime SentDate { get; set; }

		[JsonProperty("message")]
		public string Message { get; set; }

		[JsonProperty("created_date")]
		public DateTime CreatedDate { get; set; }
	}

}

