namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AccountDataItem
    {
        
        private int childAccountIDField;
        
        private bool childAccountIDFieldSpecified;
        
        private System.Nullable<int> brandIDField;
        
        private bool brandIDFieldSpecified;
        
        private System.Nullable<int> privateLabelIDField;
        
        private bool privateLabelIDFieldSpecified;
        
        private System.Nullable<int> accountTypeField;
        
        private bool accountTypeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int ChildAccountID
        {
            get
            {
                return this.childAccountIDField;
            }
            set
            {
                this.childAccountIDField = value;
                this.childAccountIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ChildAccountIDSpecified
        {
            get
            {
                return this.childAccountIDFieldSpecified;
            }
            set
            {
                this.childAccountIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<int> BrandID
        {
            get
            {
                return this.brandIDField;
            }
            set
            {
                this.brandIDField = value;
                this.brandIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrandIDSpecified
        {
            get
            {
                return this.brandIDFieldSpecified;
            }
            set
            {
                this.brandIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<int> PrivateLabelID
        {
            get
            {
                return this.privateLabelIDField;
            }
            set
            {
                this.privateLabelIDField = value;
                this.privateLabelIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrivateLabelIDSpecified
        {
            get
            {
                return this.privateLabelIDFieldSpecified;
            }
            set
            {
                this.privateLabelIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<int> AccountType
        {
            get
            {
                return this.accountTypeField;
            }
            set
            {
                this.accountTypeField = value;
                this.accountTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountTypeSpecified
        {
            get
            {
                return this.accountTypeFieldSpecified;
            }
            set
            {
                this.accountTypeFieldSpecified = value;
            }
        }
    }
}