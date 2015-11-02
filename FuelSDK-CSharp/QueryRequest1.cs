namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="QueryRequestMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class QueryRequest1
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public FuelSDK.QueryRequest QueryRequest;
        
        public QueryRequest1()
        {
        }
        
        public QueryRequest1(FuelSDK.QueryRequest QueryRequest)
        {
            this.QueryRequest = QueryRequest;
        }
    }
}