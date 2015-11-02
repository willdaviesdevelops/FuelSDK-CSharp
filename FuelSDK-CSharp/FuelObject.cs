using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FuelSDK
{
    public class FuelObject : APIObject
    {
        [JsonIgnore]
        public string Endpoint { get; set; }
        public string[] URLProperties { get; set; }
        public string[] RequiredURLProperties { get; set; }
        public int Page { get; set; }

        protected string cleanRestValue(JToken jobj)
        {
            return jobj.ToString().Replace("\"", "").Trim();
        }
    }
}