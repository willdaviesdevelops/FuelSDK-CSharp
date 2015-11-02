namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ListSend : APIObject
    {
        
        private int sendIDField;
        
        private bool sendIDFieldSpecified;
        
        private List listField;
        
        private int duplicatesField;
        
        private bool duplicatesFieldSpecified;
        
        private int invalidAddressesField;
        
        private bool invalidAddressesFieldSpecified;
        
        private int existingUndeliverablesField;
        
        private bool existingUndeliverablesFieldSpecified;
        
        private int existingUnsubscribesField;
        
        private bool existingUnsubscribesFieldSpecified;
        
        private int hardBouncesField;
        
        private bool hardBouncesFieldSpecified;
        
        private int softBouncesField;
        
        private bool softBouncesFieldSpecified;
        
        private int otherBouncesField;
        
        private bool otherBouncesFieldSpecified;
        
        private int forwardedEmailsField;
        
        private bool forwardedEmailsFieldSpecified;
        
        private int uniqueClicksField;
        
        private bool uniqueClicksFieldSpecified;
        
        private int uniqueOpensField;
        
        private bool uniqueOpensFieldSpecified;
        
        private System.Nullable<int> numberSentField;
        
        private bool numberSentFieldSpecified;
        
        private System.Nullable<int> numberDeliveredField;
        
        private bool numberDeliveredFieldSpecified;
        
        private int unsubscribesField;
        
        private bool unsubscribesFieldSpecified;
        
        private int missingAddressesField;
        
        private bool missingAddressesFieldSpecified;
        
        private string previewURLField;
        
        private Link[] linksField;
        
        private TrackingEvent[] eventsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int SendID
        {
            get
            {
                return this.sendIDField;
            }
            set
            {
                this.sendIDField = value;
                this.sendIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendIDSpecified
        {
            get
            {
                return this.sendIDFieldSpecified;
            }
            set
            {
                this.sendIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public List List
        {
            get
            {
                return this.listField;
            }
            set
            {
                this.listField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Duplicates
        {
            get
            {
                return this.duplicatesField;
            }
            set
            {
                this.duplicatesField = value;
                this.duplicatesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DuplicatesSpecified
        {
            get
            {
                return this.duplicatesFieldSpecified;
            }
            set
            {
                this.duplicatesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int InvalidAddresses
        {
            get
            {
                return this.invalidAddressesField;
            }
            set
            {
                this.invalidAddressesField = value;
                this.invalidAddressesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvalidAddressesSpecified
        {
            get
            {
                return this.invalidAddressesFieldSpecified;
            }
            set
            {
                this.invalidAddressesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int ExistingUndeliverables
        {
            get
            {
                return this.existingUndeliverablesField;
            }
            set
            {
                this.existingUndeliverablesField = value;
                this.existingUndeliverablesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExistingUndeliverablesSpecified
        {
            get
            {
                return this.existingUndeliverablesFieldSpecified;
            }
            set
            {
                this.existingUndeliverablesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int ExistingUnsubscribes
        {
            get
            {
                return this.existingUnsubscribesField;
            }
            set
            {
                this.existingUnsubscribesField = value;
                this.existingUnsubscribesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExistingUnsubscribesSpecified
        {
            get
            {
                return this.existingUnsubscribesFieldSpecified;
            }
            set
            {
                this.existingUnsubscribesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int ForwardedEmails
        {
            get
            {
                return this.forwardedEmailsField;
            }
            set
            {
                this.forwardedEmailsField = value;
                this.forwardedEmailsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForwardedEmailsSpecified
        {
            get
            {
                return this.forwardedEmailsFieldSpecified;
            }
            set
            {
                this.forwardedEmailsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int UniqueOpens
        {
            get
            {
                return this.uniqueOpensField;
            }
            set
            {
                this.uniqueOpensField = value;
                this.uniqueOpensFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UniqueOpensSpecified
        {
            get
            {
                return this.uniqueOpensFieldSpecified;
            }
            set
            {
                this.uniqueOpensFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<int> NumberSent
        {
            get
            {
                return this.numberSentField;
            }
            set
            {
                this.numberSentField = value;
                this.numberSentFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberSentSpecified
        {
            get
            {
                return this.numberSentFieldSpecified;
            }
            set
            {
                this.numberSentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<int> NumberDelivered
        {
            get
            {
                return this.numberDeliveredField;
            }
            set
            {
                this.numberDeliveredField = value;
                this.numberDeliveredFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberDeliveredSpecified
        {
            get
            {
                return this.numberDeliveredFieldSpecified;
            }
            set
            {
                this.numberDeliveredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public int Unsubscribes
        {
            get
            {
                return this.unsubscribesField;
            }
            set
            {
                this.unsubscribesField = value;
                this.unsubscribesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnsubscribesSpecified
        {
            get
            {
                return this.unsubscribesFieldSpecified;
            }
            set
            {
                this.unsubscribesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public int MissingAddresses
        {
            get
            {
                return this.missingAddressesField;
            }
            set
            {
                this.missingAddressesField = value;
                this.missingAddressesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MissingAddressesSpecified
        {
            get
            {
                return this.missingAddressesFieldSpecified;
            }
            set
            {
                this.missingAddressesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string PreviewURL
        {
            get
            {
                return this.previewURLField;
            }
            set
            {
                this.previewURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Links", Order=17)]
        public Link[] Links
        {
            get
            {
                return this.linksField;
            }
            set
            {
                this.linksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Events", Order=18)]
        public TrackingEvent[] Events
        {
            get
            {
                return this.eventsField;
            }
            set
            {
                this.eventsField = value;
            }
        }
    }
}