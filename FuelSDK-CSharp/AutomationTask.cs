namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AutomationTaskInstance))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AutomationTask : APIObject
    {
        
        private string automationTaskTypeField;
        
        private string nameField;
        
        private string descriptionField;
        
        private Automation automationField;
        
        private int sequenceField;
        
        private bool sequenceFieldSpecified;
        
        private AutomationActivity[] activitiesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string AutomationTaskType
        {
            get
            {
                return this.automationTaskTypeField;
            }
            set
            {
                this.automationTaskTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public Automation Automation
        {
            get
            {
                return this.automationField;
            }
            set
            {
                this.automationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int Sequence
        {
            get
            {
                return this.sequenceField;
            }
            set
            {
                this.sequenceField = value;
                this.sequenceFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SequenceSpecified
        {
            get
            {
                return this.sequenceFieldSpecified;
            }
            set
            {
                this.sequenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Activity", IsNullable=false)]
        public AutomationActivity[] Activities
        {
            get
            {
                return this.activitiesField;
            }
            set
            {
                this.activitiesField = value;
            }
        }
    }
}