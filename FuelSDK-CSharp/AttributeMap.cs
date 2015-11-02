namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AttributeMap : APIProperty
    {
        
        private string entityNameField;
        
        private string columnNameField;
        
        private string columnNameMappedToField;
        
        private string entityNameMappedToField;
        
        private APIProperty[] additionalDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string EntityName
        {
            get
            {
                return this.entityNameField;
            }
            set
            {
                this.entityNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ColumnName
        {
            get
            {
                return this.columnNameField;
            }
            set
            {
                this.columnNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ColumnNameMappedTo
        {
            get
            {
                return this.columnNameMappedToField;
            }
            set
            {
                this.columnNameMappedToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string EntityNameMappedTo
        {
            get
            {
                return this.entityNameMappedToField;
            }
            set
            {
                this.entityNameMappedToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalData", Order=4)]
        public APIProperty[] AdditionalData
        {
            get
            {
                return this.additionalDataField;
            }
            set
            {
                this.additionalDataField = value;
            }
        }
    }
}