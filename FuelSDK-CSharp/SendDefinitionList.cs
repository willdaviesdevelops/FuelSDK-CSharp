namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SendDefinitionList : AudienceItem
    {
        
        private FilterDefinition filterDefinitionField;
        
        private bool isTestObjectField;
        
        private bool isTestObjectFieldSpecified;
        
        private string salesForceObjectIDField;
        
        private string nameField;
        
        private APIProperty[] parametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public FilterDefinition FilterDefinition
        {
            get
            {
                return this.filterDefinitionField;
            }
            set
            {
                this.filterDefinitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool IsTestObject
        {
            get
            {
                return this.isTestObjectField;
            }
            set
            {
                this.isTestObjectField = value;
                this.isTestObjectFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsTestObjectSpecified
        {
            get
            {
                return this.isTestObjectFieldSpecified;
            }
            set
            {
                this.isTestObjectFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SalesForceObjectID
        {
            get
            {
                return this.salesForceObjectIDField;
            }
            set
            {
                this.salesForceObjectIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlArrayAttribute(Order=4)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Parameter", IsNullable=false)]
        public APIProperty[] Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
    }
}