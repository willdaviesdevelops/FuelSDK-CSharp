using System;
using Newtonsoft.Json.Linq;

namespace FuelSDK
{
    public class ET_CampaignAsset : FuelObject
    {
        public string Type { get; set; }
        public string CampaignID { get; set; }
        public string[] IDs { get; set; }
        public string ItemID { get; set; }

        public ET_CampaignAsset()
        {
            Endpoint = "https://www.exacttargetapis.com/hub/v1/campaigns/{CampaignID}/assets/{ID}";
            URLProperties = new string[] { "CampaignID", "ID" };
            RequiredURLProperties = new string[] { "CampaignID" };
        }

        public ET_CampaignAsset(JObject jObject)
        {
            if (jObject["id"] != null)
                this.ID = int.Parse(cleanRestValue(jObject["id"]));
            if (jObject["createdDate"] != null)
                this.CreatedDate = DateTime.Parse(cleanRestValue(jObject["createdDate"]));
            if (jObject["type"] != null)
                this.Type = cleanRestValue(jObject["type"]);
            if (jObject["campaignId"] != null)
                this.CampaignID = cleanRestValue(jObject["campaignId"]);
            if (jObject["itemID"] != null)
                this.ItemID = cleanRestValue(jObject["itemID"]);
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