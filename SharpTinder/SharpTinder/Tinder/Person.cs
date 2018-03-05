using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
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

}

