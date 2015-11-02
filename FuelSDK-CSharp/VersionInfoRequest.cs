namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="VersionInfoRequestMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class VersionInfoRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public bool IncludeVersionHistory;
        
        public VersionInfoRequest()
        {
        }
        
        public VersionInfoRequest(bool IncludeVersionHistory)
        {
            this.IncludeVersionHistory = IncludeVersionHistory;
        }
    }
}