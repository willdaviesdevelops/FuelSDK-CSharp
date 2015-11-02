using Newtonsoft.Json.Linq;

namespace FuelSDK
{
    public class ET_Endpoint : FuelObject
    {
        public string Type { get; set; }
        public string URL { get; set; }

        public ET_Endpoint()
        {
            Endpoint = "https://www.exacttargetapis.com/platform/v1/endpoints/{Type}";
            URLProperties = new string[] { "Type" };
            RequiredURLProperties = new string[] { };
        }

        public ET_Endpoint(JObject jObject)
        {
            if (jObject["type"] != null)
                this.Type = cleanRestValue(jObject["type"]).ToString().Trim();
            if (jObject["url"] != null)
                this.URL = cleanRestValue(jObject["url"]);
        }

        public FuelSDK.GetReturn Get()
        {
            FuelSDK.GetReturn gr = new FuelSDK.GetReturn(this);
            this.Page = gr.LastPageNumber;
            return gr;
        }

        public FuelSDK.GetReturn GetMoreResults()
        {
            this.Page = this.Page + 1;
            FuelSDK.GetReturn gr = new FuelSDK.GetReturn(this);
            this.Page = gr.LastPageNumber;
            return gr;
        }
    }
}