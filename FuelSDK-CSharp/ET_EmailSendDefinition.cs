using System;

namespace FuelSDK
{
    public class ET_EmailSendDefinition : EmailSendDefinition
    {
        public int? FolderID { get; set; }
        internal string FolderMediaType = "userinitiatedsends";
        internal string LastTaskID = string.Empty;
        public FuelSDK.PostReturn Post()
        {
            return new FuelSDK.PostReturn(this);
        }
        public FuelSDK.PatchReturn Patch()
        {
            return new FuelSDK.PatchReturn(this);
        }
        public FuelSDK.DeleteReturn Delete()
        {
            return new FuelSDK.DeleteReturn(this);
        }
        public FuelSDK.GetReturn Get()
        {
            FuelSDK.GetReturn response = new GetReturn(this);
            this.LastRequestID = response.RequestID;
            return response;
        }
        public FuelSDK.GetReturn GetMoreResults()
        {
            FuelSDK.GetReturn response = new GetReturn(this, true, null);
            this.LastRequestID = response.RequestID;
            return response;
        }
        public FuelSDK.InfoReturn Info()
        {
            return new FuelSDK.InfoReturn(this);
        }

        public FuelSDK.PerformReturn Send()
        {
            PerformReturn thisPerformResult = new FuelSDK.PerformReturn(this, "start");
            if (thisPerformResult.Results.Length == 1)
            {
                this.LastTaskID = ((ResultDetail)thisPerformResult.Results[0]).Task.ID;
            }
            return thisPerformResult;
        }

        public FuelSDK.GetReturn Status()
        {
            if (LastTaskID == string.Empty)
            {
                throw new Exception("No ID available in order to return status for ET_EmailSendDefinition");
            }
            else
            {
                ET_Send thisSend = new ET_Send();
                thisSend.AuthStub = this.AuthStub;
                thisSend.SearchFilter = new SimpleFilterPart() { Value = new string[] { LastTaskID.ToString() }, Property = "ID", SimpleOperator = SimpleOperators.equals };
                FuelSDK.GetReturn response = new GetReturn(thisSend);
                this.LastRequestID = response.RequestID;
                return response;
            }
        }        
    }
}