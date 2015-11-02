namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class EmailSendDefinition : SendDefinition
    {
        
        private SendDefinitionList[] sendDefinitionListField;
        
        private Email emailField;
        
        private string bccEmailField;
        
        private string autoBccEmailField;
        
        private string testEmailAddrField;
        
        private string emailSubjectField;
        
        private string dynamicEmailSubjectField;
        
        private bool isMultipartField;
        
        private bool isMultipartFieldSpecified;
        
        private bool isWrappedField;
        
        private bool isWrappedFieldSpecified;
        
        private int sendLimitField;
        
        private bool sendLimitFieldSpecified;
        
        private System.DateTime sendWindowOpenField;
        
        private bool sendWindowOpenFieldSpecified;
        
        private System.DateTime sendWindowCloseField;
        
        private bool sendWindowCloseFieldSpecified;
        
        private bool sendWindowDeleteField;
        
        private bool sendWindowDeleteFieldSpecified;
        
        private bool deduplicateByEmailField;
        
        private bool deduplicateByEmailFieldSpecified;
        
        private string exclusionFilterField;
        
        private TrackingUser[] trackingUsersField;
        
        private string additionalField;
        
        private string cCEmailField;
        
        private System.DateTime deliveryScheduledTimeField;
        
        private bool deliveryScheduledTimeFieldSpecified;
        
        private MessageDeliveryTypeEnum messageDeliveryTypeField;
        
        private bool messageDeliveryTypeFieldSpecified;
        
        private bool isSeedListSendField;
        
        private bool isSeedListSendFieldSpecified;
        
        private TimeZone timeZoneField;
        
        private int seedListOccuranceField;
        
        private bool seedListOccuranceFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SendDefinitionList", Order=0)]
        public SendDefinitionList[] SendDefinitionList
        {
            get
            {
                return this.sendDefinitionListField;
            }
            set
            {
                this.sendDefinitionListField = value;
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string AutoBccEmail
        {
            get
            {
                return this.autoBccEmailField;
            }
            set
            {
                this.autoBccEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string TestEmailAddr
        {
            get
            {
                return this.testEmailAddrField;
            }
            set
            {
                this.testEmailAddrField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string EmailSubject
        {
            get
            {
                return this.emailSubjectField;
            }
            set
            {
                this.emailSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string DynamicEmailSubject
        {
            get
            {
                return this.dynamicEmailSubjectField;
            }
            set
            {
                this.dynamicEmailSubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool IsWrapped
        {
            get
            {
                return this.isWrappedField;
            }
            set
            {
                this.isWrappedField = value;
                this.isWrappedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsWrappedSpecified
        {
            get
            {
                return this.isWrappedFieldSpecified;
            }
            set
            {
                this.isWrappedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public bool SendWindowDelete
        {
            get
            {
                return this.sendWindowDeleteField;
            }
            set
            {
                this.sendWindowDeleteField = value;
                this.sendWindowDeleteFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendWindowDeleteSpecified
        {
            get
            {
                return this.sendWindowDeleteFieldSpecified;
            }
            set
            {
                this.sendWindowDeleteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public bool DeduplicateByEmail
        {
            get
            {
                return this.deduplicateByEmailField;
            }
            set
            {
                this.deduplicateByEmailField = value;
                this.deduplicateByEmailFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeduplicateByEmailSpecified
        {
            get
            {
                return this.deduplicateByEmailFieldSpecified;
            }
            set
            {
                this.deduplicateByEmailFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string ExclusionFilter
        {
            get
            {
                return this.exclusionFilterField;
            }
            set
            {
                this.exclusionFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=15)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public TrackingUser[] TrackingUsers
        {
            get
            {
                return this.trackingUsersField;
            }
            set
            {
                this.trackingUsersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string CCEmail
        {
            get
            {
                return this.cCEmailField;
            }
            set
            {
                this.cCEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=18)]
        public System.DateTime DeliveryScheduledTime
        {
            get
            {
                return this.deliveryScheduledTimeField;
            }
            set
            {
                this.deliveryScheduledTimeField = value;
                this.deliveryScheduledTimeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryScheduledTimeSpecified
        {
            get
            {
                return this.deliveryScheduledTimeFieldSpecified;
            }
            set
            {
                this.deliveryScheduledTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public MessageDeliveryTypeEnum MessageDeliveryType
        {
            get
            {
                return this.messageDeliveryTypeField;
            }
            set
            {
                this.messageDeliveryTypeField = value;
                this.messageDeliveryTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageDeliveryTypeSpecified
        {
            get
            {
                return this.messageDeliveryTypeFieldSpecified;
            }
            set
            {
                this.messageDeliveryTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public bool IsSeedListSend
        {
            get
            {
                return this.isSeedListSendField;
            }
            set
            {
                this.isSeedListSendField = value;
                this.isSeedListSendFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSeedListSendSpecified
        {
            get
            {
                return this.isSeedListSendFieldSpecified;
            }
            set
            {
                this.isSeedListSendFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public TimeZone TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public int SeedListOccurance
        {
            get
            {
                return this.seedListOccuranceField;
            }
            set
            {
                this.seedListOccuranceField = value;
                this.seedListOccuranceFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SeedListOccuranceSpecified
        {
            get
            {
                return this.seedListOccuranceFieldSpecified;
            }
            set
            {
                this.seedListOccuranceFieldSpecified = value;
            }
        }
    }
}