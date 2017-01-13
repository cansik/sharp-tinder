using System;
using Newtonsoft.Json;

namespace SharpTinder
{
	public class TinderApiResult
	{
		[JsonProperty("status")]
		public int Status { get; set; }
	}

}

