namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ScheduleRequestMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class ScheduleRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public FuelSDK.ScheduleOptions Options;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=1)]
        public string Action;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=2)]
        public FuelSDK.ScheduleDefinition Schedule;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Interaction", IsNullable=false)]
        public APIObject[] Interactions;
        
        public ScheduleRequest()
        {
        }
        
        public ScheduleRequest(FuelSDK.ScheduleOptions Options, string Action, FuelSDK.ScheduleDefinition Schedule, APIObject[] Interactions)
        {
            this.Options = Options;
            this.Action = Action;
            this.Schedule = Schedule;
            this.Interactions = Interactions;
        }
    }
}