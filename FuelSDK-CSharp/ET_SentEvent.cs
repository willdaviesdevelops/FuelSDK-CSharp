using System;

namespace FuelSDK
{
    public class ET_SentEvent : SentEvent
    {
        public Boolean GetSinceLastBatch { get; set; }
        public ET_SentEvent()
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