namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SMSTriggeredSend : APIObject
    {
        
        private SMSTriggeredSendDefinition sMSTriggeredSendDefinitionField;
        
        private Subscriber subscriberField;
        
        private string messageField;
        
        private string numberField;
        
        private string fromAddressField;
        
        private string smsSendIdField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SMSTriggeredSendDefinition SMSTriggeredSendDefinition
        {
            get
            {
                return this.sMSTriggeredSendDefinitionField;
            }
            set
            {
                this.sMSTriggeredSendDefinitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Subscriber Subscriber
        {
            get
            {
                return this.subscriberField;
            }
            set
            {
                this.subscriberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string FromAddress
        {
            get
            {
                return this.fromAddressField;
            }
            set
            {
                this.fromAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string SmsSendId
        {
            get
            {
                return this.smsSendIdField;
            }
            set
            {
                this.smsSendIdField = value;
            }
        }
    }
}