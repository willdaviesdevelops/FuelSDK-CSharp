namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SpamAssassinValidation))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ValidationAction
    {
        
        private string validationTypeField;
        
        private APIProperty[] validationOptionsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ValidationType
        {
            get
            {
                return this.validationTypeField;
            }
            set
            {
                this.validationTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ValidationOption", IsNullable=false)]
        public APIProperty[] ValidationOptions
        {
            get
            {
                return this.validationOptionsField;
            }
            set
            {
                this.validationOptionsField = value;
            }
        }
    }
}