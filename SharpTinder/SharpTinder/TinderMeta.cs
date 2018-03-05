using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using SharpTinder;

namespace SharpTinder
{

    public class TinderMeta
    {

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("account")]
        public Account Account { get; set; }

        [JsonProperty("client_resources")]
        public ClientResources ClientResources { get; set; }

        [JsonProperty("notifications")]
        public IList<object> Notifications { get; set; }

        [JsonProperty("groups")]
        public IList<object> Groups { get; set; }

        [JsonProperty("rating")]
        public Rating Rating { get; set; }

        [JsonProperty("travel")]
        public Travel Travel { get; set; }

        [JsonProperty("purchases")]
        public IList<Purchase> Purchases { get; set; }

        [JsonProperty("versions")]
        public Versions Versions { get; set; }

        [JsonProperty("globals")]
        public Globals Globals { get; set; }

        [JsonProperty("tutorials")]
        public IList<string> Tutorials { get; set; }

        [JsonProperty("products")]
        public Products Products { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }
    }

}
