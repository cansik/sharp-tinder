using System;
using Newtonsoft.Json;

namespace SharpTinder
{
	public class TinderMatchResult
	{
		[JsonProperty("match")]
		public bool Match { get; set; }

		[JsonProperty("likes_remaining")]
		public int LikesRemaining { get; set; }
	}
}

