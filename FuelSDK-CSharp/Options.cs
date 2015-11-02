namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemStatusOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtractOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConfigureOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerformOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CampaignPerformOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RetrieveOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RetrieveSingleOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdateOptions))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateOptions))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public abstract partial class Options
    {
        
        private ClientID clientField;
        
        private AsyncResponse[] sendResponseToField;
        
        private SaveOption[] saveOptionsField;
        
        private sbyte priorityField;
        
        private bool priorityFieldSpecified;
        
        private string conversationIDField;
        
        private int sequenceCodeField;
        
        private bool sequenceCodeFieldSpecified;
        
        private int callsInConversationField;
        
        private bool callsInConversationFieldSpecified;
        
        private System.DateTime scheduledTimeField;
        
        private bool scheduledTimeFieldSpecified;
        
        private RequestType requestTypeField;
        
        private bool requestTypeFieldSpecified;
        
        private Priority queuePriorityField;
        
        private bool queuePriorityFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ClientID Client
        {
            get
            {
                return this.clientField;
            }
            set
            {
                this.clientField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SendResponseTo", Order=1)]
        public AsyncResponse[] SendResponseTo
        {
            get
            {
                return this.sendResponseToField;
            }
            set
            {
                this.sendResponseToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public SaveOption[] SaveOptions
        {
            get
            {
                return this.saveOptionsField;
            }
            set
            {
                this.saveOptionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public sbyte Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
                this.priorityFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrioritySpecified
        {
            get
            {
                return this.priorityFieldSpecified;
            }
            set
            {
                this.priorityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ConversationID
        {
            get
            {
                return this.conversationIDField;
            }
            set
            {
                this.conversationIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int SequenceCode
        {
            get
            {
                return this.sequenceCodeField;
            }
            set
            {
                this.sequenceCodeField = value;
                this.sequenceCodeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SequenceCodeSpecified
        {
            get
            {
                return this.sequenceCodeFieldSpecified;
            }
            set
            {
                this.sequenceCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int CallsInConversation
        {
            get
            {
                return this.callsInConversationField;
            }
            set
            {
                this.callsInConversationField = value;
                this.callsInConversationFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CallsInConversationSpecified
        {
            get
            {
                return this.callsInConversationFieldSpecified;
            }
            set
            {
                this.callsInConversationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public System.DateTime ScheduledTime
        {
            get
            {
                return this.scheduledTimeField;
            }
            set
            {
                this.scheduledTimeField = value;
                this.scheduledTimeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduledTimeSpecified
        {
            get
            {
                return this.scheduledTimeFieldSpecified;
            }
            set
            {
                this.scheduledTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public RequestType RequestType
        {
            get
            {
                return this.requestTypeField;
            }
            set
            {
                this.requestTypeField = value;
                this.requestTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequestTypeSpecified
        {
            get
            {
                return this.requestTypeFieldSpecified;
            }
            set
            {
                this.requestTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public Priority QueuePriority
        {
            get
            {
                return this.queuePriorityField;
            }
            set
            {
                this.queuePriorityField = value;
                this.queuePriorityFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QueuePrioritySpecified
        {
            get
            {
                return this.queuePriorityFieldSpecified;
            }
            set
            {
                this.queuePriorityFieldSpecified = value;
            }
        }
    }
}