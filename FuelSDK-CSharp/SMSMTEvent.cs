namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SMSMTEvent : APIObject
    {
        
        private SMSTriggeredSend sMSTriggeredSendField;
        
        private Subscriber subscriberField;
        
        private string mOCodeField;
        
        private System.DateTime eventDateField;
        
        private bool eventDateFieldSpecified;
        
        private string carrierField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SMSTriggeredSend SMSTriggeredSend
        {
            get
            {
                return this.sMSTriggeredSendField;
            }
            set
            {
                this.sMSTriggeredSendField = value;
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
        public string MOCode
        {
            get
            {
                return this.mOCodeField;
            }
            set
            {
                this.mOCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime EventDate
        {
            get
            {
                return this.eventDateField;
            }
            set
            {
                this.eventDateField = value;
                this.eventDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventDateSpecified
        {
            get
            {
                return this.eventDateFieldSpecified;
            }
            set
            {
                this.eventDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Carrier
        {
            get
            {
                return this.carrierField;
            }
            set
            {
                this.carrierField = value;
            }
        }
    }
}