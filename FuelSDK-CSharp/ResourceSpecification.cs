namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ResourceSpecification : APIObject
    {
        
        private string uRNField;
        
        private Authentication authenticationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string URN
        {
            get
            {
                return this.uRNField;
            }
            set
            {
                this.uRNField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Authentication Authentication
        {
            get
            {
                return this.authenticationField;
            }
            set
            {
                this.authenticationField = value;
            }
        }
    }
}