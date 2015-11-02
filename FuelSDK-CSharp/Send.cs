namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Send : APIObject
    {
        
        private Email emailField;
        
        private List[] listField;
        
        private System.DateTime sendDateField;
        
        private bool sendDateFieldSpecified;
        
        private string fromAddressField;
        
        private string fromNameField;
        
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
        
        private string subjectField;
        
        private string previewURLField;
        
        private Link[] linksField;
        
        private TrackingEvent[] eventsField;
        
        private System.Nullable<System.DateTime> sentDateField;
        
        private bool sentDateFieldSpecified;
        
        private string emailNameField;
        
        private string statusField;
        
        private bool isMultipartField;
        
        private bool isMultipartFieldSpecified;
        
        private int sendLimitField;
        
        private bool sendLimitFieldSpecified;
        
        private System.DateTime sendWindowOpenField;
        
        private bool sendWindowOpenFieldSpecified;
        
        private System.DateTime sendWindowCloseField;
        
        private bool sendWindowCloseFieldSpecified;
        
        private bool isAlwaysOnField;
        
        private bool isAlwaysOnFieldSpecified;
        
        private APIObject[] sourcesField;
        
        private int numberTargetedField;
        
        private bool numberTargetedFieldSpecified;
        
        private int numberErroredField;
        
        private bool numberErroredFieldSpecified;
        
        private int numberExcludedField;
        
        private bool numberExcludedFieldSpecified;
        
        private string additionalField;
        
        private string bccEmailField;
        
        private EmailSendDefinition emailSendDefinitionField;
        
        private AudienceItem[] suppressionListsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute("List", Order=1)]
        public List[] List
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
        public System.DateTime SendDate
        {
            get
            {
                return this.sendDateField;
            }
            set
            {
                this.sendDateField = value;
                this.sendDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendDateSpecified
        {
            get
            {
                return this.sendDateFieldSpecified;
            }
            set
            {
                this.sendDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
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
        [System.Xml.Serialization.XmlElementAttribute("Links", Order=21)]
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
        [System.Xml.Serialization.XmlElementAttribute("Events", Order=22)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=23)]
        public System.Nullable<System.DateTime> SentDate
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
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public string EmailName
        {
            get
            {
                return this.emailNameField;
            }
            set
            {
                this.emailNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public bool IsMultipart
        {
            get
            {
                return this.isMultipartField;
            }
            set
            {
                this.isMultipartField = value;
                this.isMultipartFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsMultipartSpecified
        {
            get
            {
                return this.isMultipartFieldSpecified;
            }
            set
            {
                this.isMultipartFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public int SendLimit
        {
            get
            {
                return this.sendLimitField;
            }
            set
            {
                this.sendLimitField = value;
                this.sendLimitFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendLimitSpecified
        {
            get
            {
                return this.sendLimitFieldSpecified;
            }
            set
            {
                this.sendLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=28)]
        public System.DateTime SendWindowOpen
        {
            get
            {
                return this.sendWindowOpenField;
            }
            set
            {
                this.sendWindowOpenField = value;
                this.sendWindowOpenFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendWindowOpenSpecified
        {
            get
            {
                return this.sendWindowOpenFieldSpecified;
            }
            set
            {
                this.sendWindowOpenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=29)]
        public System.DateTime SendWindowClose
        {
            get
            {
                return this.sendWindowCloseField;
            }
            set
            {
                this.sendWindowCloseField = value;
                this.sendWindowCloseFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendWindowCloseSpecified
        {
            get
            {
                return this.sendWindowCloseFieldSpecified;
            }
            set
            {
                this.sendWindowCloseFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
        public bool IsAlwaysOn
        {
            get
            {
                return this.isAlwaysOnField;
            }
            set
            {
                this.isAlwaysOnField = value;
                this.isAlwaysOnFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAlwaysOnSpecified
        {
            get
            {
                return this.isAlwaysOnFieldSpecified;
            }
            set
            {
                this.isAlwaysOnFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=31)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Source", IsNullable=false)]
        public APIObject[] Sources
        {
            get
            {
                return this.sourcesField;
            }
            set
            {
                this.sourcesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=32)]
        public int NumberTargeted
        {
            get
            {
                return this.numberTargetedField;
            }
            set
            {
                this.numberTargetedField = value;
                this.numberTargetedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberTargetedSpecified
        {
            get
            {
                return this.numberTargetedFieldSpecified;
            }
            set
            {
                this.numberTargetedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=33)]
        public int NumberErrored
        {
            get
            {
                return this.numberErroredField;
            }
            set
            {
                this.numberErroredField = value;
                this.numberErroredFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberErroredSpecified
        {
            get
            {
                return this.numberErroredFieldSpecified;
            }
            set
            {
                this.numberErroredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=34)]
        public int NumberExcluded
        {
            get
            {
                return this.numberExcludedField;
            }
            set
            {
                this.numberExcludedField = value;
                this.numberExcludedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberExcludedSpecified
        {
            get
            {
                return this.numberExcludedFieldSpecified;
            }
            set
            {
                this.numberExcludedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=35)]
        public string Additional
        {
            get
            {
                return this.additionalField;
            }
            set
            {
                this.additionalField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=36)]
        public string BccEmail
        {
            get
            {
                return this.bccEmailField;
            }
            set
            {
                this.bccEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=37)]
        public EmailSendDefinition EmailSendDefinition
        {
            get
            {
                return this.emailSendDefinitionField;
            }
            set
            {
                this.emailSendDefinitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=38)]
        [System.Xml.Serialization.XmlArrayItemAttribute("SuppressionList", IsNullable=false)]
        public AudienceItem[] SuppressionLists
        {
            get
            {
                return this.suppressionListsField;
            }
            set
            {
                this.suppressionListsField = value;
            }
        }
    }
}