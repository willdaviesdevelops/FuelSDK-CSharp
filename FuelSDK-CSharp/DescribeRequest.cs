namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DefinitionRequestMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class DescribeRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public ObjectDefinitionRequest[] DescribeRequests;
        
        public DescribeRequest()
        {
        }
        
        public DescribeRequest(ObjectDefinitionRequest[] DescribeRequests)
        {
            this.DescribeRequests = DescribeRequests;
        }
    }
}