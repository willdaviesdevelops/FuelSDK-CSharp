namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeliveredEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForwardedEmailOptInEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ForwardedEmailEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SurveyEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NotSentEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SentEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClickEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnsubEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BounceEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OpenEvent))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class TrackingEvent : APIObject
    {
        
        private int sendIDField;
        
        private bool sendIDFieldSpecified;
        
        private string subscriberKeyField;
        
        private System.DateTime eventDateField;
        
        private bool eventDateFieldSpecified;
        
        private EventType eventTypeField;
        
        private bool eventTypeFieldSpecified;
        
        private string triggeredSendDefinitionObjectIDField;
        
        private int batchIDField;
        
        private bool batchIDFieldSpecified;
        
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
        public string SubscriberKey
        {
            get
            {
                return this.subscriberKeyField;
            }
            set
            {
                this.subscriberKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public EventType EventType
        {
            get
            {
                return this.eventTypeField;
            }
            set
            {
                this.eventTypeField = value;
                this.eventTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EventTypeSpecified
        {
            get
            {
                return this.eventTypeFieldSpecified;
            }
            set
            {
                this.eventTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string TriggeredSendDefinitionObjectID
        {
            get
            {
                return this.triggeredSendDefinitionObjectIDField;
            }
            set
            {
                this.triggeredSendDefinitionObjectIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int BatchID
        {
            get
            {
                return this.batchIDField;
            }
            set
            {
                this.batchIDField = value;
                this.batchIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatchIDSpecified
        {
            get
            {
                return this.batchIDFieldSpecified;
            }
            set
            {
                this.batchIDFieldSpecified = value;
            }
        }
    }
}