namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Permission : APIObject
    {
        
        private string nameField;
        
        private string descriptionField;
        
        private string objectTypeField;
        
        private string operationField;
        
        private bool isShareableField;
        
        private bool isShareableFieldSpecified;
        
        private bool isAllowedField;
        
        private bool isAllowedFieldSpecified;
        
        private bool isDeniedField;
        
        private bool isDeniedFieldSpecified;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ObjectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool IsShareable
        {
            get
            {
                return this.isShareableField;
            }
            set
            {
                this.isShareableField = value;
                this.isShareableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsShareableSpecified
        {
            get
            {
                return this.isShareableFieldSpecified;
            }
            set
            {
                this.isShareableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool IsAllowed
        {
            get
            {
                return this.isAllowedField;
            }
            set
            {
                this.isAllowedField = value;
                this.isAllowedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAllowedSpecified
        {
            get
            {
                return this.isAllowedFieldSpecified;
            }
            set
            {
                this.isAllowedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool IsDenied
        {
            get
            {
                return this.isDeniedField;
            }
            set
            {
                this.isDeniedField = value;
                this.isDeniedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDeniedSpecified
        {
            get
            {
                return this.isDeniedFieldSpecified;
            }
            set
            {
                this.isDeniedFieldSpecified = value;
            }
        }
    }
}