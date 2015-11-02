namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SMSSharedKeyword : APIObject
    {
        
        private string shortCodeField;
        
        private string sharedKeywordField;
        
        private System.DateTime requestDateField;
        
        private bool requestDateFieldSpecified;
        
        private System.DateTime effectiveDateField;
        
        private bool effectiveDateFieldSpecified;
        
        private System.DateTime expireDateField;
        
        private bool expireDateFieldSpecified;
        
        private System.DateTime returnToPoolDateField;
        
        private bool returnToPoolDateFieldSpecified;
        
        private string countryCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ShortCode
        {
            get
            {
                return this.shortCodeField;
            }
            set
            {
                this.shortCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string SharedKeyword
        {
            get
            {
                return this.sharedKeywordField;
            }
            set
            {
                this.sharedKeywordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime RequestDate
        {
            get
            {
                return this.requestDateField;
            }
            set
            {
                this.requestDateField = value;
                this.requestDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequestDateSpecified
        {
            get
            {
                return this.requestDateFieldSpecified;
            }
            set
            {
                this.requestDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime EffectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
                this.effectiveDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified
        {
            get
            {
                return this.effectiveDateFieldSpecified;
            }
            set
            {
                this.effectiveDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public System.DateTime ExpireDate
        {
            get
            {
                return this.expireDateField;
            }
            set
            {
                this.expireDateField = value;
                this.expireDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get
            {
                return this.expireDateFieldSpecified;
            }
            set
            {
                this.expireDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public System.DateTime ReturnToPoolDate
        {
            get
            {
                return this.returnToPoolDateField;
            }
            set
            {
                this.returnToPoolDateField = value;
                this.returnToPoolDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnToPoolDateSpecified
        {
            get
            {
                return this.returnToPoolDateFieldSpecified;
            }
            set
            {
                this.returnToPoolDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }
    }
}