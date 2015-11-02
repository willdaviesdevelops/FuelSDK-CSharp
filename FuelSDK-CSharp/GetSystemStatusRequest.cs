namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="SystemStatusRequestMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class GetSystemStatusRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public FuelSDK.SystemStatusOptions Options;
        
        public GetSystemStatusRequest()
        {
        }
        
        public GetSystemStatusRequest(FuelSDK.SystemStatusOptions Options)
        {
            this.Options = Options;
        }
    }
}