namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SenderProfile : APIObject
    {
        
        private string nameField;
        
        private string descriptionField;
        
        private string fromNameField;
        
        private string fromAddressField;
        
        private bool useDefaultRMMRulesField;
        
        private bool useDefaultRMMRulesFieldSpecified;
        
        private string autoForwardToEmailAddressField;
        
        private string autoForwardToNameField;
        
        private bool directForwardField;
        
        private bool directForwardFieldSpecified;
        
        private TriggeredSendDefinition autoForwardTriggeredSendField;
        
        private bool autoReplyField;
        
        private bool autoReplyFieldSpecified;
        
        private TriggeredSendDefinition autoReplyTriggeredSendField;
        
        private string senderHeaderEmailAddressField;
        
        private string senderHeaderNameField;
        
        private short dataRetentionPeriodLengthField;
        
        private bool dataRetentionPeriodLengthFieldSpecified;
        
        private RecurrenceTypeEnum dataRetentionPeriodUnitOfMeasureField;
        
        private bool dataRetentionPeriodUnitOfMeasureFieldSpecified;
        
        private APIObject replyManagementRuleSetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        public bool UseDefaultRMMRules
        {
            get
            {
                return this.useDefaultRMMRulesField;
            }
            set
            {
                this.useDefaultRMMRulesField = value;
                this.useDefaultRMMRulesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UseDefaultRMMRulesSpecified
        {
            get
            {
                return this.useDefaultRMMRulesFieldSpecified;
            }
            set
            {
                this.useDefaultRMMRulesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string AutoForwardToEmailAddress
        {
            get
            {
                return this.autoForwardToEmailAddressField;
            }
            set
            {
                this.autoForwardToEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string AutoForwardToName
        {
            get
            {
                return this.autoForwardToNameField;
            }
            set
            {
                this.autoForwardToNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool DirectForward
        {
            get
            {
                return this.directForwardField;
            }
            set
            {
                this.directForwardField = value;
                this.directForwardFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DirectForwardSpecified
        {
            get
            {
                return this.directForwardFieldSpecified;
            }
            set
            {
                this.directForwardFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public TriggeredSendDefinition AutoForwardTriggeredSend
        {
            get
            {
                return this.autoForwardTriggeredSendField;
            }
            set
            {
                this.autoForwardTriggeredSendField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool AutoReply
        {
            get
            {
                return this.autoReplyField;
            }
            set
            {
                this.autoReplyField = value;
                this.autoReplyFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AutoReplySpecified
        {
            get
            {
                return this.autoReplyFieldSpecified;
            }
            set
            {
                this.autoReplyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public TriggeredSendDefinition AutoReplyTriggeredSend
        {
            get
            {
                return this.autoReplyTriggeredSendField;
            }
            set
            {
                this.autoReplyTriggeredSendField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string SenderHeaderEmailAddress
        {
            get
            {
                return this.senderHeaderEmailAddressField;
            }
            set
            {
                this.senderHeaderEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string SenderHeaderName
        {
            get
            {
                return this.senderHeaderNameField;
            }
            set
            {
                this.senderHeaderNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public short DataRetentionPeriodLength
        {
            get
            {
                return this.dataRetentionPeriodLengthField;
            }
            set
            {
                this.dataRetentionPeriodLengthField = value;
                this.dataRetentionPeriodLengthFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataRetentionPeriodLengthSpecified
        {
            get
            {
                return this.dataRetentionPeriodLengthFieldSpecified;
            }
            set
            {
                this.dataRetentionPeriodLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public RecurrenceTypeEnum DataRetentionPeriodUnitOfMeasure
        {
            get
            {
                return this.dataRetentionPeriodUnitOfMeasureField;
            }
            set
            {
                this.dataRetentionPeriodUnitOfMeasureField = value;
                this.dataRetentionPeriodUnitOfMeasureFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataRetentionPeriodUnitOfMeasureSpecified
        {
            get
            {
                return this.dataRetentionPeriodUnitOfMeasureFieldSpecified;
            }
            set
            {
                this.dataRetentionPeriodUnitOfMeasureFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public APIObject ReplyManagementRuleSet
        {
            get
            {
                return this.replyManagementRuleSetField;
            }
            set
            {
                this.replyManagementRuleSetField = value;
            }
        }
    }
}