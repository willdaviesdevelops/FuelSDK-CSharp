namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Folder))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UserMap))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtractParameter))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeMap))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NullAPIProperty))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class APIProperty
    {
        
        private string nameField;
        
        private string valueField;
        
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
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}