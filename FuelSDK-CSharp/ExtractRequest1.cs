namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExtractRequestMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class ExtractRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Requests")]
        public ExtractRequest[] Requests;
        
        public ExtractRequest1()
        {
        }
        
        public ExtractRequest1(ExtractRequest[] Requests)
        {
            this.Requests = Requests;
        }
    }
}