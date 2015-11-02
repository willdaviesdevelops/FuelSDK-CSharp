namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class DataExtensionUpdateResult : UpdateResult
    {
        
        private string errorMessageField;
        
        private DataExtensionError[] keyErrorsField;
        
        private DataExtensionError[] valueErrorsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ErrorMessage
        {
            get
            {
                return this.errorMessageField;
            }
            set
            {
                this.errorMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyError", IsNullable=false)]
        public DataExtensionError[] KeyErrors
        {
            get
            {
                return this.keyErrorsField;
            }
            set
            {
                this.keyErrorsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ValueError", IsNullable=false)]
        public DataExtensionError[] ValueErrors
        {
            get
            {
                return this.valueErrorsField;
            }
            set
            {
                this.valueErrorsField = value;
            }
        }
    }
}