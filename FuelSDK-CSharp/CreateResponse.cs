namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="CreateResponse", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class CreateResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Results")]
        public CreateResult[] Results;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=1)]
        public string RequestID;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=2)]
        public string OverallStatus;
        
        public CreateResponse()
        {
        }
        
        public CreateResponse(CreateResult[] Results, string RequestID, string OverallStatus)
        {
            this.Results = Results;
            this.RequestID = RequestID;
            this.OverallStatus = OverallStatus;
        }
    }
}