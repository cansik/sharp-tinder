using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class RateCard
    {

        [JsonProperty("carousel")]
        public IList<Carousel> Carousel { get; set; }
    }

}
