using Newtonsoft.Json;

namespace SharpTinder
{
    public class ProfileJob
    {

        [JsonProperty("company")]
        public ProfileCompany Company { get; set; }
    }
}

