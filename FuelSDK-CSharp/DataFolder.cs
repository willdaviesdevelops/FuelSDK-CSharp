namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class DataFolder : APIObject
    {
        
        private DataFolder parentFolderField;
        
        private string nameField;
        
        private string descriptionField;
        
        private string contentTypeField;
        
        private bool isActiveField;
        
        private bool isActiveFieldSpecified;
        
        private bool isEditableField;
        
        private bool isEditableFieldSpecified;
        
        private bool allowChildrenField;
        
        private bool allowChildrenFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DataFolder ParentFolder
        {
            get
            {
                return this.parentFolderField;
            }
            set
            {
                this.parentFolderField = value;
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
        public string ContentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool IsEditable
        {
            get
            {
                return this.isEditableField;
            }
            set
            {
                this.isEditableField = value;
                this.isEditableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEditableSpecified
        {
            get
            {
                return this.isEditableFieldSpecified;
            }
            set
            {
                this.isEditableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool AllowChildren
        {
            get
            {
                return this.allowChildrenField;
            }
            set
            {
                this.allowChildrenField = value;
                this.allowChildrenFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowChildrenSpecified
        {
            get
            {
                return this.allowChildrenFieldSpecified;
            }
            set
            {
                this.allowChildrenFieldSpecified = value;
            }
        }
    }
}