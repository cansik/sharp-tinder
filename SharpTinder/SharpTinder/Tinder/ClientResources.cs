using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class ClientResources
    {

        [JsonProperty("rate_card")]
        public RateCard RateCard { get; set; }

        [JsonProperty("plus_screen")]
        public IList<string> PlusScreen { get; set; }
    }

}
