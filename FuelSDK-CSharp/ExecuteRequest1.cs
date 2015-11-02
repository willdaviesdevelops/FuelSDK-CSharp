namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ExecuteRequestMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class ExecuteRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("Requests")]
        public ExecuteRequest[] Requests;
        
        public ExecuteRequest1()
        {
        }
        
        public ExecuteRequest1(ExecuteRequest[] Requests)
        {
            this.Requests = Requests;
        }
    }
}