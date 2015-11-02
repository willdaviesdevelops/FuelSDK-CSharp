namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class TriggeredSend : APIObject
    {
        
        private TriggeredSendDefinition triggeredSendDefinitionField;
        
        private Subscriber[] subscribersField;
        
        private Attribute[] attributesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TriggeredSendDefinition TriggeredSendDefinition
        {
            get
            {
                return this.triggeredSendDefinitionField;
            }
            set
            {
                this.triggeredSendDefinitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subscribers", Order=1)]
        public Subscriber[] Subscribers
        {
            get
            {
                return this.subscribersField;
            }
            set
            {
                this.subscribersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attributes", Order=2)]
        public Attribute[] Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }
    }
}