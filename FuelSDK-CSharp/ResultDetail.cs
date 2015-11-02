namespace FuelSDK
{
    public class ResultDetail
    {
        public string StatusCode { get; set; }
        public string StatusMessage { get; set; }
        public int OrdinalID { get; set; }
        public int ErrorCode { get; set; }
        public int NewID { get; set; }
        public string NewObjectID { get; set; }
        public APIObject Object { get; set; }
        public TaskResult Task {get;set; }        
    }
}