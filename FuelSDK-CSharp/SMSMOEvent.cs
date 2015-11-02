namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SMSMOEvent : APIObject
    {
        
        private BaseMOKeyword keywordField;
        
        private string mobileTelephoneNumberField;
        
        private string mOCodeField;
        
        private System.DateTime eventDateField;
        
        private bool eventDateFieldSpecified;
        
        private string mOMessageField;
        
        private string mTMessageField;
        
        private string carrierField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public BaseMOKeyword Keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string MobileTelephoneNumber
        {
            get
            {
                return this.mobileTelephoneNumberField;
            }
            set
            {
                this.mobileTelephoneNumberField = value;
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
        public string MOMessage
        {
            get
            {
                return this.mOMessageField;
            }
            set
            {
                this.mOMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string MTMessage
        {
            get
            {
                return this.mTMessageField;
            }
            set
            {
                this.mTMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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