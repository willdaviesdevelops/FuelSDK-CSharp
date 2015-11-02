namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DeleteRequest", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class DeleteRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public FuelSDK.DeleteOptions Options;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute("Objects")]
        public APIObject[] Objects;
        
        public DeleteRequest()
        {
        }
        
        public DeleteRequest(FuelSDK.DeleteOptions Options, APIObject[] Objects)
        {
            this.Options = Options;
            this.Objects = Objects;
        }
    }
}