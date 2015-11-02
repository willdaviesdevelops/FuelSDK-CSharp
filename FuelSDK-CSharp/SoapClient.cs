namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class SoapClient : System.ServiceModel.ClientBase<FuelSDK.Soap>, FuelSDK.Soap
    {
        
        public SoapClient()
        {
        }
        
        public SoapClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
        {
        }
        
        public SoapClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
        {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.CreateResponse FuelSDK.Soap.Create(FuelSDK.CreateRequest request)
        {
            return base.Channel.Create(request);
        }
        
        public CreateResult[] Create(FuelSDK.CreateOptions Options, APIObject[] Objects, out string RequestID, out string OverallStatus)
        {
            FuelSDK.CreateRequest inValue = new FuelSDK.CreateRequest();
            inValue.Options = Options;
            inValue.Objects = Objects;
            FuelSDK.CreateResponse retVal = ((FuelSDK.Soap)(this)).Create(inValue);
            RequestID = retVal.RequestID;
            OverallStatus = retVal.OverallStatus;
            return retVal.Results;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.RetrieveResponse FuelSDK.Soap.Retrieve(FuelSDK.RetrieveRequest1 request)
        {
            return base.Channel.Retrieve(request);
        }
        
        public string Retrieve(FuelSDK.RetrieveRequest RetrieveRequest, out string RequestID, out APIObject[] Results)
        {
            FuelSDK.RetrieveRequest1 inValue = new FuelSDK.RetrieveRequest1();
            inValue.RetrieveRequest = RetrieveRequest;
            FuelSDK.RetrieveResponse retVal = ((FuelSDK.Soap)(this)).Retrieve(inValue);
            RequestID = retVal.RequestID;
            Results = retVal.Results;
            return retVal.OverallStatus;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.UpdateResponse FuelSDK.Soap.Update(FuelSDK.UpdateRequest request)
        {
            return base.Channel.Update(request);
        }
        
        public UpdateResult[] Update(FuelSDK.UpdateOptions Options, APIObject[] Objects, out string RequestID, out string OverallStatus)
        {
            FuelSDK.UpdateRequest inValue = new FuelSDK.UpdateRequest();
            inValue.Options = Options;
            inValue.Objects = Objects;
            FuelSDK.UpdateResponse retVal = ((FuelSDK.Soap)(this)).Update(inValue);
            RequestID = retVal.RequestID;
            OverallStatus = retVal.OverallStatus;
            return retVal.Results;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.DeleteResponse FuelSDK.Soap.Delete(FuelSDK.DeleteRequest request)
        {
            return base.Channel.Delete(request);
        }
        
        public DeleteResult[] Delete(FuelSDK.DeleteOptions Options, APIObject[] Objects, out string RequestID, out string OverallStatus)
        {
            FuelSDK.DeleteRequest inValue = new FuelSDK.DeleteRequest();
            inValue.Options = Options;
            inValue.Objects = Objects;
            FuelSDK.DeleteResponse retVal = ((FuelSDK.Soap)(this)).Delete(inValue);
            RequestID = retVal.RequestID;
            OverallStatus = retVal.OverallStatus;
            return retVal.Results;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.QueryResponse FuelSDK.Soap.Query(FuelSDK.QueryRequest1 request)
        {
            return base.Channel.Query(request);
        }
        
        public string Query(FuelSDK.QueryRequest QueryRequest, out string RequestID, out APIObject[] Results)
        {
            FuelSDK.QueryRequest1 inValue = new FuelSDK.QueryRequest1();
            inValue.QueryRequest = QueryRequest;
            FuelSDK.QueryResponse retVal = ((FuelSDK.Soap)(this)).Query(inValue);
            RequestID = retVal.RequestID;
            Results = retVal.Results;
            return retVal.OverallStatus;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.DescribeResponse FuelSDK.Soap.Describe(FuelSDK.DescribeRequest request)
        {
            return base.Channel.Describe(request);
        }
        
        public ObjectDefinition[] Describe(ObjectDefinitionRequest[] DescribeRequests, out string RequestID)
        {
            FuelSDK.DescribeRequest inValue = new FuelSDK.DescribeRequest();
            inValue.DescribeRequests = DescribeRequests;
            FuelSDK.DescribeResponse retVal = ((FuelSDK.Soap)(this)).Describe(inValue);
            RequestID = retVal.RequestID;
            return retVal.ObjectDefinition;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.ExecuteResponse1 FuelSDK.Soap.Execute(FuelSDK.ExecuteRequest1 request)
        {
            return base.Channel.Execute(request);
        }
        
        public string Execute(ExecuteRequest[] Requests, out string RequestID, out ExecuteResponse[] Results)
        {
            FuelSDK.ExecuteRequest1 inValue = new FuelSDK.ExecuteRequest1();
            inValue.Requests = Requests;
            FuelSDK.ExecuteResponse1 retVal = ((FuelSDK.Soap)(this)).Execute(inValue);
            RequestID = retVal.RequestID;
            Results = retVal.Results;
            return retVal.OverallStatus;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.PerformResponse FuelSDK.Soap.Perform(FuelSDK.PerformRequest request)
        {
            return base.Channel.Perform(request);
        }
        
        public PerformResult[] Perform(FuelSDK.PerformOptions Options, string Action, APIObject[] Definitions, out string OverallStatus, out string OverallStatusMessage, out string RequestID)
        {
            FuelSDK.PerformRequest inValue = new FuelSDK.PerformRequest();
            inValue.Options = Options;
            inValue.Action = Action;
            inValue.Definitions = Definitions;
            FuelSDK.PerformResponse retVal = ((FuelSDK.Soap)(this)).Perform(inValue);
            OverallStatus = retVal.OverallStatus;
            OverallStatusMessage = retVal.OverallStatusMessage;
            RequestID = retVal.RequestID;
            return retVal.Results;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.ConfigureResponse FuelSDK.Soap.Configure(FuelSDK.ConfigureRequest request)
        {
            return base.Channel.Configure(request);
        }
        
        public ConfigureResult[] Configure(FuelSDK.ConfigureOptions Options, string Action, APIObject[] Configurations, out string OverallStatus, out string OverallStatusMessage, out string RequestID)
        {
            FuelSDK.ConfigureRequest inValue = new FuelSDK.ConfigureRequest();
            inValue.Options = Options;
            inValue.Action = Action;
            inValue.Configurations = Configurations;
            FuelSDK.ConfigureResponse retVal = ((FuelSDK.Soap)(this)).Configure(inValue);
            OverallStatus = retVal.OverallStatus;
            OverallStatusMessage = retVal.OverallStatusMessage;
            RequestID = retVal.RequestID;
            return retVal.Results;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.ScheduleResponse FuelSDK.Soap.Schedule(FuelSDK.ScheduleRequest request)
        {
            return base.Channel.Schedule(request);
        }
        
        public ScheduleResult[] Schedule(FuelSDK.ScheduleOptions Options, string Action, FuelSDK.ScheduleDefinition Schedule1, APIObject[] Interactions, out string OverallStatus, out string OverallStatusMessage, out string RequestID)
        {
            FuelSDK.ScheduleRequest inValue = new FuelSDK.ScheduleRequest();
            inValue.Options = Options;
            inValue.Action = Action;
            inValue.Schedule = Schedule1;
            inValue.Interactions = Interactions;
            FuelSDK.ScheduleResponse retVal = ((FuelSDK.Soap)(this)).Schedule(inValue);
            OverallStatus = retVal.OverallStatus;
            OverallStatusMessage = retVal.OverallStatusMessage;
            RequestID = retVal.RequestID;
            return retVal.Results;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.VersionInfoResponse1 FuelSDK.Soap.VersionInfo(FuelSDK.VersionInfoRequest request)
        {
            return base.Channel.VersionInfo(request);
        }
        
        public FuelSDK.VersionInfoResponse VersionInfo(bool IncludeVersionHistory, out string RequestID)
        {
            FuelSDK.VersionInfoRequest inValue = new FuelSDK.VersionInfoRequest();
            inValue.IncludeVersionHistory = IncludeVersionHistory;
            FuelSDK.VersionInfoResponse1 retVal = ((FuelSDK.Soap)(this)).VersionInfo(inValue);
            RequestID = retVal.RequestID;
            return retVal.VersionInfo;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.ExtractResponse FuelSDK.Soap.Extract(FuelSDK.ExtractRequest1 request)
        {
            return base.Channel.Extract(request);
        }
        
        public string Extract(ExtractRequest[] Requests, out string RequestID, out ExtractResult[] Results)
        {
            FuelSDK.ExtractRequest1 inValue = new FuelSDK.ExtractRequest1();
            inValue.Requests = Requests;
            FuelSDK.ExtractResponse retVal = ((FuelSDK.Soap)(this)).Extract(inValue);
            RequestID = retVal.RequestID;
            Results = retVal.Results;
            return retVal.OverallStatus;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        FuelSDK.GetSystemStatusResponse FuelSDK.Soap.GetSystemStatus(FuelSDK.GetSystemStatusRequest request)
        {
            return base.Channel.GetSystemStatus(request);
        }
        
        public SystemStatusResult[] GetSystemStatus(FuelSDK.SystemStatusOptions Options, out string OverallStatus, out string OverallStatusMessage, out string RequestID)
        {
            FuelSDK.GetSystemStatusRequest inValue = new FuelSDK.GetSystemStatusRequest();
            inValue.Options = Options;
            FuelSDK.GetSystemStatusResponse retVal = ((FuelSDK.Soap)(this)).GetSystemStatus(inValue);
            OverallStatus = retVal.OverallStatus;
            OverallStatusMessage = retVal.OverallStatusMessage;
            RequestID = retVal.RequestID;
            return retVal.Results;
        }
    }
}