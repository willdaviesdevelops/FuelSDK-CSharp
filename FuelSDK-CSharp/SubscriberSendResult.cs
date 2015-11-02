namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SubscriberSendResult : APIObject
    {
        
        private Send sendField;
        
        private Email emailField;
        
        private Subscriber subscriberField;
        
        private System.DateTime clickDateField;
        
        private bool clickDateFieldSpecified;
        
        private System.DateTime bounceDateField;
        
        private bool bounceDateFieldSpecified;
        
        private System.DateTime openDateField;
        
        private bool openDateFieldSpecified;
        
        private System.DateTime sentDateField;
        
        private bool sentDateFieldSpecified;
        
        private string lastActionField;
        
        private System.DateTime unsubscribeDateField;
        
        private bool unsubscribeDateFieldSpecified;
        
        private string fromAddressField;
        
        private string fromNameField;
        
        private int totalClicksField;
        
        private bool totalClicksFieldSpecified;
        
        private int uniqueClicksField;
        
        private bool uniqueClicksFieldSpecified;
        
        private string subjectField;
        
        private string viewSentEmailURLField;
        
        private int hardBouncesField;
        
        private bool hardBouncesFieldSpecified;
        
        private int softBouncesField;
        
        private bool softBouncesFieldSpecified;
        
        private int otherBouncesField;
        
        private bool otherBouncesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Send Send
        {
            get
            {
                return this.sendField;
            }
            set
            {
                this.sendField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Email Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime ClickDate
        {
            get
            {
                return this.clickDateField;
            }
            set
            {
                this.clickDateField = value;
                this.clickDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClickDateSpecified
        {
            get
            {
                return this.clickDateFieldSpecified;
            }
            set
            {
                this.clickDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime BounceDate
        {
            get
            {
                return this.bounceDateField;
            }
            set
            {
                this.bounceDateField = value;
                this.bounceDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BounceDateSpecified
        {
            get
            {
                return this.bounceDateFieldSpecified;
            }
            set
            {
                this.bounceDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public System.DateTime OpenDate
        {
            get
            {
                return this.openDateField;
            }
            set
            {
                this.openDateField = value;
                this.openDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OpenDateSpecified
        {
            get
            {
                return this.openDateFieldSpecified;
            }
            set
            {
                this.openDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime SentDate
        {
            get
            {
                return this.sentDateField;
            }
            set
            {
                this.sentDateField = value;
                this.sentDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SentDateSpecified
        {
            get
            {
                return this.sentDateFieldSpecified;
            }
            set
            {
                this.sentDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string LastAction
        {
            get
            {
                return this.lastActionField;
            }
            set
            {
                this.lastActionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public System.DateTime UnsubscribeDate
        {
            get
            {
                return this.unsubscribeDateField;
            }
            set
            {
                this.unsubscribeDateField = value;
                this.unsubscribeDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnsubscribeDateSpecified
        {
            get
            {
                return this.unsubscribeDateFieldSpecified;
            }
            set
            {
                this.unsubscribeDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string FromName
        {
            get
            {
                return this.fromNameField;
            }
            set
            {
                this.fromNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int TotalClicks
        {
            get
            {
                return this.totalClicksField;
            }
            set
            {
                this.totalClicksField = value;
                this.totalClicksFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalClicksSpecified
        {
            get
            {
                return this.totalClicksFieldSpecified;
            }
            set
            {
                this.totalClicksFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int UniqueClicks
        {
            get
            {
                return this.uniqueClicksField;
            }
            set
            {
                this.uniqueClicksField = value;
                this.uniqueClicksFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UniqueClicksSpecified
        {
            get
            {
                return this.uniqueClicksFieldSpecified;
            }
            set
            {
                this.uniqueClicksFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string ViewSentEmailURL
        {
            get
            {
                return this.viewSentEmailURLField;
            }
            set
            {
                this.viewSentEmailURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public int HardBounces
        {
            get
            {
                return this.hardBouncesField;
            }
            set
            {
                this.hardBouncesField = value;
                this.hardBouncesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HardBouncesSpecified
        {
            get
            {
                return this.hardBouncesFieldSpecified;
            }
            set
            {
                this.hardBouncesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public int SoftBounces
        {
            get
            {
                return this.softBouncesField;
            }
            set
            {
                this.softBouncesField = value;
                this.softBouncesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoftBouncesSpecified
        {
            get
            {
                return this.softBouncesFieldSpecified;
            }
            set
            {
                this.softBouncesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public int OtherBounces
        {
            get
            {
                return this.otherBouncesField;
            }
            set
            {
                this.otherBouncesField = value;
                this.otherBouncesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OtherBouncesSpecified
        {
            get
            {
                return this.otherBouncesFieldSpecified;
            }
            set
            {
                this.otherBouncesFieldSpecified = value;
            }
        }
    }
}