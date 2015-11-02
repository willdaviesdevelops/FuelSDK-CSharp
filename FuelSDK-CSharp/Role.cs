namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Role : APIObject
    {
        
        private string nameField;
        
        private string descriptionField;
        
        private bool isPrivateField;
        
        private bool isPrivateFieldSpecified;
        
        private bool isSystemDefinedField;
        
        private bool isSystemDefinedFieldSpecified;
        
        private bool forceInheritanceField;
        
        private bool forceInheritanceFieldSpecified;
        
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
        public bool IsPrivate
        {
            get
            {
                return this.isPrivateField;
            }
            set
            {
                this.isPrivateField = value;
                this.isPrivateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPrivateSpecified
        {
            get
            {
                return this.isPrivateFieldSpecified;
            }
            set
            {
                this.isPrivateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool IsSystemDefined
        {
            get
            {
                return this.isSystemDefinedField;
            }
            set
            {
                this.isSystemDefinedField = value;
                this.isSystemDefinedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSystemDefinedSpecified
        {
            get
            {
                return this.isSystemDefinedFieldSpecified;
            }
            set
            {
                this.isSystemDefinedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool ForceInheritance
        {
            get
            {
                return this.forceInheritanceField;
            }
            set
            {
                this.forceInheritanceField = value;
                this.forceInheritanceFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ForceInheritanceSpecified
        {
            get
            {
                return this.forceInheritanceFieldSpecified;
            }
            set
            {
                this.forceInheritanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order=6)]
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