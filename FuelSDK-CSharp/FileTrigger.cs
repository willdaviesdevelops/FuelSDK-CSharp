namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class FileTrigger : APIObject
    {
        
        private string externalReferenceField;
        
        private string typeField;
        
        private string statusField;
        
        private string statusMessageField;
        
        private string requestParameterDetailField;
        
        private string responseControlManifestField;
        
        private string fileNameField;
        
        private string descriptionField;
        
        private string nameField;
        
        private System.DateTime lastPullDateField;
        
        private bool lastPullDateFieldSpecified;
        
        private System.DateTime scheduledDateField;
        
        private bool scheduledDateFieldSpecified;
        
        private bool isActiveField;
        
        private bool isActiveFieldSpecified;
        
        private string fileTriggerProgramIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ExternalReference
        {
            get
            {
                return this.externalReferenceField;
            }
            set
            {
                this.externalReferenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string RequestParameterDetail
        {
            get
            {
                return this.requestParameterDetailField;
            }
            set
            {
                this.requestParameterDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ResponseControlManifest
        {
            get
            {
                return this.responseControlManifestField;
            }
            set
            {
                this.responseControlManifestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public System.DateTime LastPullDate
        {
            get
            {
                return this.lastPullDateField;
            }
            set
            {
                this.lastPullDateField = value;
                this.lastPullDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastPullDateSpecified
        {
            get
            {
                return this.lastPullDateFieldSpecified;
            }
            set
            {
                this.lastPullDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public System.DateTime ScheduledDate
        {
            get
            {
                return this.scheduledDateField;
            }
            set
            {
                this.scheduledDateField = value;
                this.scheduledDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduledDateSpecified
        {
            get
            {
                return this.scheduledDateFieldSpecified;
            }
            set
            {
                this.scheduledDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string FileTriggerProgramID
        {
            get
            {
                return this.fileTriggerProgramIDField;
            }
            set
            {
                this.fileTriggerProgramIDField = value;
            }
        }
    }
}