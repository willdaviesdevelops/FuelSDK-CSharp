namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SMSTriggeredSendDefinition : SendDefinition
    {
        
        private List publicationField;
        
        private DataExtension dataExtensionField;
        
        private ContentArea contentField;
        
        private bool sendToListField;
        
        private bool sendToListFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public List Publication
        {
            get
            {
                return this.publicationField;
            }
            set
            {
                this.publicationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public DataExtension DataExtension
        {
            get
            {
                return this.dataExtensionField;
            }
            set
            {
                this.dataExtensionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public ContentArea Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool SendToList
        {
            get
            {
                return this.sendToListField;
            }
            set
            {
                this.sendToListField = value;
                this.sendToListFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendToListSpecified
        {
            get
            {
                return this.sendToListFieldSpecified;
            }
            set
            {
                this.sendToListFieldSpecified = value;
            }
        }
    }
}