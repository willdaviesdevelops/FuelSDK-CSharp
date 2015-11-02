namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class VoiceTriggeredSend : APIObject
    {
        
        private VoiceTriggeredSendDefinition voiceTriggeredSendDefinitionField;
        
        private Subscriber subscriberField;
        
        private string messageField;
        
        private string numberField;
        
        private string transferMessageField;
        
        private string transferNumberField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public VoiceTriggeredSendDefinition VoiceTriggeredSendDefinition
        {
            get
            {
                return this.voiceTriggeredSendDefinitionField;
            }
            set
            {
                this.voiceTriggeredSendDefinitionField = value;
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
        public string TransferMessage
        {
            get
            {
                return this.transferMessageField;
            }
            set
            {
                this.transferMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string TransferNumber
        {
            get
            {
                return this.transferNumberField;
            }
            set
            {
                this.transferNumberField = value;
            }
        }
    }
}