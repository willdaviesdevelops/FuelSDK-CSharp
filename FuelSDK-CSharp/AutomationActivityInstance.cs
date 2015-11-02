namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AutomationActivityInstance : AutomationActivity
    {
        
        private string activityIDField;
        
        private string automationIDField;
        
        private int sequenceIDField;
        
        private bool sequenceIDFieldSpecified;
        
        private int statusField;
        
        private bool statusFieldSpecified;
        
        private System.DateTime statusLastUpdateField;
        
        private bool statusLastUpdateFieldSpecified;
        
        private string statusMessageField;
        
        private AutomationActivity activityDefinitionField;
        
        private AutomationInstance automationInstanceField;
        
        private AutomationTaskInstance automationTaskInstanceField;
        
        private System.DateTime scheduledTimeField;
        
        private bool scheduledTimeFieldSpecified;
        
        private System.DateTime startTimeField;
        
        private bool startTimeFieldSpecified;
        
        private System.DateTime completedTimeField;
        
        private bool completedTimeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ActivityID
        {
            get
            {
                return this.activityIDField;
            }
            set
            {
                this.activityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AutomationID
        {
            get
            {
                return this.automationIDField;
            }
            set
            {
                this.automationIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int SequenceID
        {
            get
            {
                return this.sequenceIDField;
            }
            set
            {
                this.sequenceIDField = value;
                this.sequenceIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SequenceIDSpecified
        {
            get
            {
                return this.sequenceIDFieldSpecified;
            }
            set
            {
                this.sequenceIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.statusFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime StatusLastUpdate
        {
            get
            {
                return this.statusLastUpdateField;
            }
            set
            {
                this.statusLastUpdateField = value;
                this.statusLastUpdateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusLastUpdateSpecified
        {
            get
            {
                return this.statusLastUpdateFieldSpecified;
            }
            set
            {
                this.statusLastUpdateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string StatusMessage
        {
            get
            {
                return this.statusMessageField;
            }
            set
            {
                this.statusMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public AutomationActivity ActivityDefinition
        {
            get
            {
                return this.activityDefinitionField;
            }
            set
            {
                this.activityDefinitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public AutomationInstance AutomationInstance
        {
            get
            {
                return this.automationInstanceField;
            }
            set
            {
                this.automationInstanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public AutomationTaskInstance AutomationTaskInstance
        {
            get
            {
                return this.automationTaskInstanceField;
            }
            set
            {
                this.automationTaskInstanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public System.DateTime StartTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
                this.startTimeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartTimeSpecified
        {
            get
            {
                return this.startTimeFieldSpecified;
            }
            set
            {
                this.startTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public System.DateTime CompletedTime
        {
            get
            {
                return this.completedTimeField;
            }
            set
            {
                this.completedTimeField = value;
                this.completedTimeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompletedTimeSpecified
        {
            get
            {
                return this.completedTimeFieldSpecified;
            }
            set
            {
                this.completedTimeFieldSpecified = value;
            }
        }
    }
}