using System;
using Newtonsoft.Json.Linq;

namespace FuelSDK
{
    public class ET_Campaign : FuelObject
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string CampaignCode { get; set; }
        public string Color { get; set; }
        public bool Favorite { get; set; }


        public ET_Campaign()
        {
            Endpoint = "https://www.exacttargetapis.com/hub/v1/campaigns/{ID}";
            URLProperties = new string[] { "ID" };
            RequiredURLProperties = new string[] { };
        }

        public ET_Campaign(JObject jObject)
        {
            if (jObject["id"] != null)
                this.ID = int.Parse(cleanRestValue(jObject["id"]));
            if (jObject["createdDate"] != null)
                this.CreatedDate = DateTime.Parse(cleanRestValue(jObject["createdDate"]));
            if (jObject["modifiedDate"] != null)
                this.ModifiedDate = DateTime.Parse(cleanRestValue(jObject["modifiedDate"]));
            if (jObject["name"] != null)
                this.Name = cleanRestValue(jObject["name"]);
            if (jObject["description"] != null)
                this.Description = cleanRestValue(jObject["description"]);
            if (jObject["campaignCode"] != null)
                this.CampaignCode = cleanRestValue(jObject["campaignCode"]);
            if (jObject["color"] != null)
                this.Color = cleanRestValue(jObject["color"]);
            if (jObject["favorite"] != null)
                this.Favorite = bool.Parse(cleanRestValue(jObject["favorite"]));
        }

        public FuelSDK.PostReturn Post()
        {
            return new FuelSDK.PostReturn(this);
        }

        public FuelSDK.DeleteReturn Delete()
        {
            return new FuelSDK.DeleteReturn(this);
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