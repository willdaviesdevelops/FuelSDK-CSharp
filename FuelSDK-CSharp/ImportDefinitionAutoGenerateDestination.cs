namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ImportDefinitionAutoGenerateDestination
    {
        
        private DataExtension dataExtensionTargetField;
        
        private bool errorIfExistsField;
        
        private bool errorIfExistsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DataExtension DataExtensionTarget
        {
            get
            {
                return this.dataExtensionTargetField;
            }
            set
            {
                this.dataExtensionTargetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool ErrorIfExists
        {
            get
            {
                return this.errorIfExistsField;
            }
            set
            {
                this.errorIfExistsField = value;
                this.errorIfExistsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorIfExistsSpecified
        {
            get
            {
                return this.errorIfExistsFieldSpecified;
            }
            set
            {
                this.errorIfExistsFieldSpecified = value;
            }
        }
    }
}