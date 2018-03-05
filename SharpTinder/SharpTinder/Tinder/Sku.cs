using Newtonsoft.Json;

namespace SharpTinder
{
    public class Sku
    {

        [JsonProperty("product_type")]
        public string ProductType { get; set; }

        [JsonProperty("purchase_type")]
        public string PurchaseType { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("is_base_group")]
        public bool IsBaseGroup { get; set; }

        [JsonProperty("is_primary")]
        public bool? IsPrimary { get; set; }
    }

}
