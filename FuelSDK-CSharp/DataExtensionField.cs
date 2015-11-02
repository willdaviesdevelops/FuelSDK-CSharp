namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class DataExtensionField : PropertyDefinition
    {
        
        private int ordinalField;
        
        private bool ordinalFieldSpecified;
        
        private bool isPrimaryKeyField;
        
        private bool isPrimaryKeyFieldSpecified;
        
        private DataExtensionFieldType fieldTypeField;
        
        private bool fieldTypeFieldSpecified;
        
        private DataExtension dataExtensionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int Ordinal
        {
            get
            {
                return this.ordinalField;
            }
            set
            {
                this.ordinalField = value;
                this.ordinalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrdinalSpecified
        {
            get
            {
                return this.ordinalFieldSpecified;
            }
            set
            {
                this.ordinalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool IsPrimaryKey
        {
            get
            {
                return this.isPrimaryKeyField;
            }
            set
            {
                this.isPrimaryKeyField = value;
                this.isPrimaryKeyFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPrimaryKeySpecified
        {
            get
            {
                return this.isPrimaryKeyFieldSpecified;
            }
            set
            {
                this.isPrimaryKeyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public DataExtensionFieldType FieldType
        {
            get
            {
                return this.fieldTypeField;
            }
            set
            {
                this.fieldTypeField = value;
                this.fieldTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FieldTypeSpecified
        {
            get
            {
                return this.fieldTypeFieldSpecified;
            }
            set
            {
                this.fieldTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
    }
}