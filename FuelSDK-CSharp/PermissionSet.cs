namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class PermissionSet : APIObject
    {
        
        private string nameField;
        
        private string descriptionField;
        
        private bool isAllowedField;
        
        private bool isAllowedFieldSpecified;
        
        private bool isDeniedField;
        
        private bool isDeniedFieldSpecified;
        
        private PermissionSet[] permissionSetsField;
        
        private Permission[] permissionsField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public PermissionSet[] PermissionSets
        {
            get
            {
                return this.permissionSetsField;
            }
            set
            {
                this.permissionSetsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Permission[] Permissions
        {
            get
            {
                return this.permissionsField;
            }
            set
            {
                this.permissionsField = value;
            }
        }
    }
}