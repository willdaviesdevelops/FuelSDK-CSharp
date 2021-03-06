namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ScheduleResponseMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class ScheduleResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Result", IsNullable=false)]
        public ScheduleResult[] Results;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=1)]
        public string OverallStatus;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=2)]
        public string OverallStatusMessage;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=3)]
        public string RequestID;
        
        public ScheduleResponse()
        {
        }
        
        public ScheduleResponse(ScheduleResult[] Results, string OverallStatus, string OverallStatusMessage, string RequestID)
        {
            this.Results = Results;
            this.OverallStatus = OverallStatus;
            this.OverallStatusMessage = OverallStatusMessage;
            this.RequestID = RequestID;
        }
    }
}