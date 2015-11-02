namespace FuelSDK
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ConfigureRequestMsg", WrapperNamespace="http://exacttarget.com/wsdl/partnerAPI", IsWrapped=true)]
    public partial class ConfigureRequest
    {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=0)]
        public FuelSDK.ConfigureOptions Options;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=1)]
        public string Action;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI", Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Configuration", IsNullable=false)]
        public APIObject[] Configurations;
        
        public ConfigureRequest()
        {
        }
        
        public ConfigureRequest(FuelSDK.ConfigureOptions Options, string Action, APIObject[] Configurations)
        {
            this.Options = Options;
            this.Action = Action;
            this.Configurations = Configurations;
        }
    }
}