namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class TriggeredSendSummary : APIObject
    {
        
        private TriggeredSendDefinition triggeredSendDefinitionField;
        
        private long sentField;
        
        private bool sentFieldSpecified;
        
        private long notSentDueToOptOutField;
        
        private bool notSentDueToOptOutFieldSpecified;
        
        private long notSentDueToUndeliverableField;
        
        private bool notSentDueToUndeliverableFieldSpecified;
        
        private long bouncesField;
        
        private bool bouncesFieldSpecified;
        
        private long opensField;
        
        private bool opensFieldSpecified;
        
        private long clicksField;
        
        private bool clicksFieldSpecified;
        
        private long uniqueOpensField;
        
        private bool uniqueOpensFieldSpecified;
        
        private long uniqueClicksField;
        
        private bool uniqueClicksFieldSpecified;
        
        private long optOutsField;
        
        private bool optOutsFieldSpecified;
        
        private long surveyResponsesField;
        
        private bool surveyResponsesFieldSpecified;
        
        private long fTAFRequestsField;
        
        private bool fTAFRequestsFieldSpecified;
        
        private long fTAFEmailsSentField;
        
        private bool fTAFEmailsSentFieldSpecified;
        
        private long fTAFOptInsField;
        
        private bool fTAFOptInsFieldSpecified;
        
        private long conversionsField;
        
        private bool conversionsFieldSpecified;
        
        private long uniqueConversionsField;
        
        private bool uniqueConversionsFieldSpecified;
        
        private long inProcessField;
        
        private bool inProcessFieldSpecified;
        
        private long notSentDueToErrorField;
        
        private bool notSentDueToErrorFieldSpecified;
        
        private long queuedField;
        
        private bool queuedFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public TriggeredSendDefinition TriggeredSendDefinition
        {
            get
            {
                return this.triggeredSendDefinitionField;
            }
            set
            {
                this.triggeredSendDefinitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public long Sent
        {
            get
            {
                return this.sentField;
            }
            set
            {
                this.sentField = value;
                this.sentFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SentSpecified
        {
            get
            {
                return this.sentFieldSpecified;
            }
            set
            {
                this.sentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public long NotSentDueToOptOut
        {
            get
            {
                return this.notSentDueToOptOutField;
            }
            set
            {
                this.notSentDueToOptOutField = value;
                this.notSentDueToOptOutFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotSentDueToOptOutSpecified
        {
            get
            {
                return this.notSentDueToOptOutFieldSpecified;
            }
            set
            {
                this.notSentDueToOptOutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public long NotSentDueToUndeliverable
        {
            get
            {
                return this.notSentDueToUndeliverableField;
            }
            set
            {
                this.notSentDueToUndeliverableField = value;
                this.notSentDueToUndeliverableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotSentDueToUndeliverableSpecified
        {
            get
            {
                return this.notSentDueToUndeliverableFieldSpecified;
            }
            set
            {
                this.notSentDueToUndeliverableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public long Bounces
        {
            get
            {
                return this.bouncesField;
            }
            set
            {
                this.bouncesField = value;
                this.bouncesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BouncesSpecified
        {
            get
            {
                return this.bouncesFieldSpecified;
            }
            set
            {
                this.bouncesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public long Opens
        {
            get
            {
                return this.opensField;
            }
            set
            {
                this.opensField = value;
                this.opensFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OpensSpecified
        {
            get
            {
                return this.opensFieldSpecified;
            }
            set
            {
                this.opensFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public long Clicks
        {
            get
            {
                return this.clicksField;
            }
            set
            {
                this.clicksField = value;
                this.clicksFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClicksSpecified
        {
            get
            {
                return this.clicksFieldSpecified;
            }
            set
            {
                this.clicksFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public long UniqueOpens
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public long UniqueClicks
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
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public long OptOuts
        {
            get
            {
                return this.optOutsField;
            }
            set
            {
                this.optOutsField = value;
                this.optOutsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OptOutsSpecified
        {
            get
            {
                return this.optOutsFieldSpecified;
            }
            set
            {
                this.optOutsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public long SurveyResponses
        {
            get
            {
                return this.surveyResponsesField;
            }
            set
            {
                this.surveyResponsesField = value;
                this.surveyResponsesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SurveyResponsesSpecified
        {
            get
            {
                return this.surveyResponsesFieldSpecified;
            }
            set
            {
                this.surveyResponsesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public long FTAFRequests
        {
            get
            {
                return this.fTAFRequestsField;
            }
            set
            {
                this.fTAFRequestsField = value;
                this.fTAFRequestsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FTAFRequestsSpecified
        {
            get
            {
                return this.fTAFRequestsFieldSpecified;
            }
            set
            {
                this.fTAFRequestsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public long FTAFEmailsSent
        {
            get
            {
                return this.fTAFEmailsSentField;
            }
            set
            {
                this.fTAFEmailsSentField = value;
                this.fTAFEmailsSentFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FTAFEmailsSentSpecified
        {
            get
            {
                return this.fTAFEmailsSentFieldSpecified;
            }
            set
            {
                this.fTAFEmailsSentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public long FTAFOptIns
        {
            get
            {
                return this.fTAFOptInsField;
            }
            set
            {
                this.fTAFOptInsField = value;
                this.fTAFOptInsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FTAFOptInsSpecified
        {
            get
            {
                return this.fTAFOptInsFieldSpecified;
            }
            set
            {
                this.fTAFOptInsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public long Conversions
        {
            get
            {
                return this.conversionsField;
            }
            set
            {
                this.conversionsField = value;
                this.conversionsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConversionsSpecified
        {
            get
            {
                return this.conversionsFieldSpecified;
            }
            set
            {
                this.conversionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public long UniqueConversions
        {
            get
            {
                return this.uniqueConversionsField;
            }
            set
            {
                this.uniqueConversionsField = value;
                this.uniqueConversionsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UniqueConversionsSpecified
        {
            get
            {
                return this.uniqueConversionsFieldSpecified;
            }
            set
            {
                this.uniqueConversionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public long InProcess
        {
            get
            {
                return this.inProcessField;
            }
            set
            {
                this.inProcessField = value;
                this.inProcessFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InProcessSpecified
        {
            get
            {
                return this.inProcessFieldSpecified;
            }
            set
            {
                this.inProcessFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public long NotSentDueToError
        {
            get
            {
                return this.notSentDueToErrorField;
            }
            set
            {
                this.notSentDueToErrorField = value;
                this.notSentDueToErrorFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotSentDueToErrorSpecified
        {
            get
            {
                return this.notSentDueToErrorFieldSpecified;
            }
            set
            {
                this.notSentDueToErrorFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public long Queued
        {
            get
            {
                return this.queuedField;
            }
            set
            {
                this.queuedField = value;
                this.queuedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QueuedSpecified
        {
            get
            {
                return this.queuedFieldSpecified;
            }
            set
            {
                this.queuedFieldSpecified = value;
            }
        }
    }
}