namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class TriggeredSendCreateResult : CreateResult
    {
        
        private SubscriberResult[] subscriberFailuresField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubscriberFailures", Order=0)]
        public SubscriberResult[] SubscriberFailures
        {
            get
            {
                return this.subscriberFailuresField;
            }
            set
            {
                this.subscriberFailuresField = value;
            }
        }
    }
}