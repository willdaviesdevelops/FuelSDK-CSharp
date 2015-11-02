namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DefinitionResponseMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class DescribeResponse
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("ObjectDefinition")]
        public ObjectDefinition[] ObjectDefinition;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=1)]
        public string RequestID;
        
        public DescribeResponse()
        {
        }
        
        public DescribeResponse(ObjectDefinition[] ObjectDefinition, string RequestID)
        {
            this.ObjectDefinition = ObjectDefinition;
            this.RequestID = RequestID;
        }
    }
}