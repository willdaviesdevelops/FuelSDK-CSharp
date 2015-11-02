namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class MessagingVendorKind : APIObject
    {
        
        private string vendorField;
        
        private string kindField;
        
        private bool isUsernameRequiredField;
        
        private bool isPasswordRequiredField;
        
        private bool isProfileRequiredField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Kind
        {
            get
            {
                return this.kindField;
            }
            set
            {
                this.kindField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IsUsernameRequired
        {
            get
            {
                return this.isUsernameRequiredField;
            }
            set
            {
                this.isUsernameRequiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool IsPasswordRequired
        {
            get
            {
                return this.isPasswordRequiredField;
            }
            set
            {
                this.isPasswordRequiredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool IsProfileRequired
        {
            get
            {
                return this.isProfileRequiredField;
            }
            set
            {
                this.isProfileRequiredField = value;
            }
        }
    }
}