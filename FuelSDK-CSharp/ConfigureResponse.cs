namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConfigureResponseMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class ConfigureResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Result", IsNullable=false)]
        public ConfigureResult[] Results;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=1)]
        public string OverallStatus;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=2)]
        public string OverallStatusMessage;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=3)]
        public string RequestID;
        
        public ConfigureResponse()
        {
        }
        
        public ConfigureResponse(ConfigureResult[] Results, string OverallStatus, string OverallStatusMessage, string RequestID)
        {
            this.Results = Results;
            this.OverallStatus = OverallStatus;
            this.OverallStatusMessage = OverallStatusMessage;
            this.RequestID = RequestID;
        }
    }
}