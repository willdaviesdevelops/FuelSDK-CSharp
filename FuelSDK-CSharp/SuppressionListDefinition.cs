namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SuppressionListDefinition : APIObject
    {
        
        private string nameField;
        
        private long categoryField;
        
        private bool categoryFieldSpecified;
        
        private string descriptionField;
        
        private SuppressionListContext[] contextsField;
        
        private DataExtensionField[] fieldsField;
        
        private long subscriberCountField;
        
        private bool subscriberCountFieldSpecified;
        
        private string notifyEmailField;
        
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
        public long Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
                this.categoryFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategorySpecified
        {
            get
            {
                return this.categoryFieldSpecified;
            }
            set
            {
                this.categoryFieldSpecified = value;
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
        [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Context", IsNullable=false)]
        public SuppressionListContext[] Contexts
        {
            get
            {
                return this.contextsField;
            }
            set
            {
                this.contextsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Field", IsNullable=false)]
        public DataExtensionField[] Fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public long SubscriberCount
        {
            get
            {
                return this.subscriberCountField;
            }
            set
            {
                this.subscriberCountField = value;
                this.subscriberCountFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubscriberCountSpecified
        {
            get
            {
                return this.subscriberCountFieldSpecified;
            }
            set
            {
                this.subscriberCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string NotifyEmail
        {
            get
            {
                return this.notifyEmailField;
            }
            set
            {
                this.notifyEmailField = value;
            }
        }
    }
}