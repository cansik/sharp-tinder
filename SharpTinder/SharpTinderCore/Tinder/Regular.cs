using System.Collections.Generic;
using Newtonsoft.Json;

namespace SharpTinder
{
    public class Regular
    {

        [JsonProperty("skus")]
        public IList<Sku> Skus { get; set; }
    }

}
