namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AutomationInstance : Automation
    {
        
        private string automationIDField;
        
        private string statusMessageField;
        
        private System.DateTime statusLastUpdateField;
        
        private bool statusLastUpdateFieldSpecified;
        
        private AutomationTaskInstance[] taskInstancesField;
        
        private System.DateTime startTimeField;
        
        private bool startTimeFieldSpecified;
        
        private System.DateTime completedTimeField;
        
        private bool completedTimeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public AutomationTaskInstance[] TaskInstances
        {
            get
            {
                return this.taskInstancesField;
            }
            set
            {
                this.taskInstancesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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