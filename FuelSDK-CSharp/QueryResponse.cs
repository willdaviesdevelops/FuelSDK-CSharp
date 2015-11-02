namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="QueryResponseMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class QueryResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public string OverallStatus;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=1)]
        public string RequestID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("Results")]
        public APIObject[] Results;
        
        public QueryResponse()
        {
        }
        
        public QueryResponse(string OverallStatus, string RequestID, APIObject[] Results)
        {
            this.OverallStatus = OverallStatus;
            this.RequestID = RequestID;
            this.Results = Results;
        }
    }
}