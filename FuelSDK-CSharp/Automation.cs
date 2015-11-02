namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AutomationInstance))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Automation : InteractionDefinition
    {
        
        private ScheduleDefinition scheduleField;
        
        private AutomationTask[] automationTasksField;
        
        private bool isActiveField;
        
        private bool isActiveFieldSpecified;
        
        private AutomationSource automationSourceField;
        
        private int statusField;
        
        private bool statusFieldSpecified;
        
        private AutomationNotification[] notificationsField;
        
        private System.DateTime scheduledTimeField;
        
        private bool scheduledTimeFieldSpecified;
        
        private string automationTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ScheduleDefinition Schedule
        {
            get
            {
                return this.scheduleField;
            }
            set
            {
                this.scheduleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public AutomationTask[] AutomationTasks
        {
            get
            {
                return this.automationTasksField;
            }
            set
            {
                this.automationTasksField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
                this.isActiveFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsActiveSpecified
        {
            get
            {
                return this.isActiveFieldSpecified;
            }
            set
            {
                this.isActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public AutomationSource AutomationSource
        {
            get
            {
                return this.automationSourceField;
            }
            set
            {
                this.automationSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Notification", IsNullable=false)]
        public AutomationNotification[] Notifications
        {
            get
            {
                return this.notificationsField;
            }
            set
            {
                this.notificationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string AutomationType
        {
            get
            {
                return this.automationTypeField;
            }
            set
            {
                this.automationTypeField = value;
            }
        }
    }
}