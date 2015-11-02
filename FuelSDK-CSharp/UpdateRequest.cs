namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="UpdateRequest", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class UpdateRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public FuelSDK.UpdateOptions Options;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("Objects")]
        public APIObject[] Objects;
        
        public UpdateRequest()
        {
        }
        
        public UpdateRequest(FuelSDK.UpdateOptions Options, APIObject[] Objects)
        {
            this.Options = Options;
            this.Objects = Objects;
        }
    }
}