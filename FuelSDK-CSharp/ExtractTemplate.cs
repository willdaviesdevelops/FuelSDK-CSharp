namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtractDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtractDescription))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ExtractTemplate : APIObject
    {
        
        private string nameField;
        
        private string configurationPageField;
        
        private string packageKeyField;
        
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
        public string ConfigurationPage
        {
            get
            {
                return this.configurationPageField;
            }
            set
            {
                this.configurationPageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string PackageKey
        {
            get
            {
                return this.packageKeyField;
            }
            set
            {
                this.packageKeyField = value;
            }
        }
    }
}