namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class UserMap : APIProperty
    {
        
        private AccountUser eTAccountUserField;
        
        private APIProperty[] additionalDataField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AccountUser ETAccountUser
        {
            get
            {
                return this.eTAccountUserField;
            }
            set
            {
                this.eTAccountUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalData", Order=1)]
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