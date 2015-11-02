namespace FuelSDK
{
    public class ET_Send : Send
    {               
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
    }
}