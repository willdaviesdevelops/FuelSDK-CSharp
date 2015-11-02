namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Owner
    {
        
        private ClientID clientField;
        
        private string fromNameField;
        
        private string fromAddressField;
        
        private AccountUser userField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ClientID Client
        {
            get
            {
                return this.clientField;
            }
            set
            {
                this.clientField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string FromName
        {
            get
            {
                return this.fromNameField;
            }
            set
            {
                this.fromNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string FromAddress
        {
            get
            {
                return this.fromAddressField;
            }
            set
            {
                this.fromAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public AccountUser User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
    }
}