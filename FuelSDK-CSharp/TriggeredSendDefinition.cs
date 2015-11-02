namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class TriggeredSendDefinition : SendDefinition
    {
        
        private TriggeredSendTypeEnum triggeredSendTypeField;
        
        private bool triggeredSendTypeFieldSpecified;
        
        private TriggeredSendStatusEnum triggeredSendStatusField;
        
        private bool triggeredSendStatusFieldSpecified;
        
        private Email emailField;
        
        private List listField;
        
        private bool autoAddSubscribersField;
        
        private bool autoAddSubscribersFieldSpecified;
        
        private bool autoUpdateSubscribersField;
        
        private bool autoUpdateSubscribersFieldSpecified;
        
        private int batchIntervalField;
        
        private bool batchIntervalFieldSpecified;
        
        private string bccEmailField;
        
        private string emailSubjectField;
        
        private string dynamicEmailSubjectField;
        
        private bool isMultipartField;
        
        private bool isMultipartFieldSpecified;
        
        private bool isWrappedField;
        
        private bool isWrappedFieldSpecified;
        
        private short allowedSlotsField;
        
        private bool allowedSlotsFieldSpecified;
        
        private int newSlotTriggerField;
        
        private bool newSlotTriggerFieldSpecified;
        
        private int sendLimitField;
        
        private bool sendLimitFieldSpecified;
        
        private System.DateTime sendWindowOpenField;
        
        private bool sendWindowOpenFieldSpecified;
        
        private System.DateTime sendWindowCloseField;
        
        private bool sendWindowCloseFieldSpecified;
        
        private bool sendWindowDeleteField;
        
        private bool sendWindowDeleteFieldSpecified;
        
        private bool refreshContentField;
        
        private bool refreshContentFieldSpecified;
        
        private string exclusionFilterField;
        
        private string priorityField;
        
        private string sendSourceCustomerKeyField;
        
        private TriggeredSendExclusionList[] exclusionListCollectionField;
        
        private string cCEmailField;
        
        private DataExtension sendSourceDataExtensionField;
        
        private bool isAlwaysOnField;
        
        private bool isAlwaysOnFieldSpecified;
        
        private bool disableOnEmailBuildErrorField;
        
        private bool disableOnEmailBuildErrorFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TriggeredSendTypeEnum TriggeredSendType
        {
            get
            {
                return this.triggeredSendTypeField;
            }
            set
            {
                this.triggeredSendTypeField = value;
                this.triggeredSendTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TriggeredSendTypeSpecified
        {
            get
            {
                return this.triggeredSendTypeFieldSpecified;
            }
            set
            {
                this.triggeredSendTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public TriggeredSendStatusEnum TriggeredSendStatus
        {
            get
            {
                return this.triggeredSendStatusField;
            }
            set
            {
                this.triggeredSendStatusField = value;
                this.triggeredSendStatusFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TriggeredSendStatusSpecified
        {
            get
            {
                return this.triggeredSendStatusFieldSpecified;
            }
            set
            {
                this.triggeredSendStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool AutoAddSubscribers
        {
            get
            {
                return this.autoAddSubscribersField;
            }
            set
            {
                this.autoAddSubscribersField = value;
                this.autoAddSubscribersFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutoAddSubscribersSpecified
        {
            get
            {
                return this.autoAddSubscribersFieldSpecified;
            }
            set
            {
                this.autoAddSubscribersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool AutoUpdateSubscribers
        {
            get
            {
                return this.autoUpdateSubscribersField;
            }
            set
            {
                this.autoUpdateSubscribersField = value;
                this.autoUpdateSubscribersFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutoUpdateSubscribersSpecified
        {
            get
            {
                return this.autoUpdateSubscribersFieldSpecified;
            }
            set
            {
                this.autoUpdateSubscribersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int BatchInterval
        {
            get
            {
                return this.batchIntervalField;
            }
            set
            {
                this.batchIntervalField = value;
                this.batchIntervalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatchIntervalSpecified
        {
            get
            {
                return this.batchIntervalFieldSpecified;
            }
            set
            {
                this.batchIntervalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public short AllowedSlots
        {
            get
            {
                return this.allowedSlotsField;
            }
            set
            {
                this.allowedSlotsField = value;
                this.allowedSlotsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowedSlotsSpecified
        {
            get
            {
                return this.allowedSlotsFieldSpecified;
            }
            set
            {
                this.allowedSlotsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int NewSlotTrigger
        {
            get
            {
                return this.newSlotTriggerField;
            }
            set
            {
                this.newSlotTriggerField = value;
                this.newSlotTriggerFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NewSlotTriggerSpecified
        {
            get
            {
                return this.newSlotTriggerFieldSpecified;
            }
            set
            {
                this.newSlotTriggerFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=15)]
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
        [System.Xml.Serialization.XmlElementAttribute(DataType="time", Order=16)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public bool RefreshContent
        {
            get
            {
                return this.refreshContentField;
            }
            set
            {
                this.refreshContentField = value;
                this.refreshContentFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RefreshContentSpecified
        {
            get
            {
                return this.refreshContentFieldSpecified;
            }
            set
            {
                this.refreshContentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string SendSourceCustomerKey
        {
            get
            {
                return this.sendSourceCustomerKeyField;
            }
            set
            {
                this.sendSourceCustomerKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExclusionListCollection", Order=22)]
        public TriggeredSendExclusionList[] ExclusionListCollection
        {
            get
            {
                return this.exclusionListCollectionField;
            }
            set
            {
                this.exclusionListCollectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public DataExtension SendSourceDataExtension
        {
            get
            {
                return this.sendSourceDataExtensionField;
            }
            set
            {
                this.sendSourceDataExtensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public bool DisableOnEmailBuildError
        {
            get
            {
                return this.disableOnEmailBuildErrorField;
            }
            set
            {
                this.disableOnEmailBuildErrorField = value;
                this.disableOnEmailBuildErrorFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisableOnEmailBuildErrorSpecified
        {
            get
            {
                return this.disableOnEmailBuildErrorFieldSpecified;
            }
            set
            {
                this.disableOnEmailBuildErrorFieldSpecified = value;
            }
        }
    }
}