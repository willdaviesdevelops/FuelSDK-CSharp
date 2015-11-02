namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="RetrieveRequestMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class RetrieveRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public FuelSDK.RetrieveRequest RetrieveRequest;
        
        public RetrieveRequest1()
        {
        }
        
        public RetrieveRequest1(FuelSDK.RetrieveRequest RetrieveRequest)
        {
            this.RetrieveRequest = RetrieveRequest;
        }
    }
}