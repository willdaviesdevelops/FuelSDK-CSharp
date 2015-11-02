using System;

namespace FuelSDK
{
    public class ET_OpenEvent : OpenEvent
    {
        public Boolean GetSinceLastBatch { get; set; }
        public ET_OpenEvent()
        {
            this.GetSinceLastBatch = true;
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