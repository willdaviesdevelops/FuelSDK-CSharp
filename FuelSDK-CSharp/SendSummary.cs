namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SendSummary : APIObject
    {
        
        private int accountIDField;
        
        private bool accountIDFieldSpecified;
        
        private string accountNameField;
        
        private string accountEmailField;
        
        private bool isTestAccountField;
        
        private bool isTestAccountFieldSpecified;
        
        private int sendIDField;
        
        private bool sendIDFieldSpecified;
        
        private string deliveredTimeField;
        
        private int totalSentField;
        
        private bool totalSentFieldSpecified;
        
        private int transactionalField;
        
        private bool transactionalFieldSpecified;
        
        private int nonTransactionalField;
        
        private bool nonTransactionalFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int AccountID
        {
            get
            {
                return this.accountIDField;
            }
            set
            {
                this.accountIDField = value;
                this.accountIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountIDSpecified
        {
            get
            {
                return this.accountIDFieldSpecified;
            }
            set
            {
                this.accountIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AccountName
        {
            get
            {
                return this.accountNameField;
            }
            set
            {
                this.accountNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string AccountEmail
        {
            get
            {
                return this.accountEmailField;
            }
            set
            {
                this.accountEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool IsTestAccount
        {
            get
            {
                return this.isTestAccountField;
            }
            set
            {
                this.isTestAccountField = value;
                this.isTestAccountFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsTestAccountSpecified
        {
            get
            {
                return this.isTestAccountFieldSpecified;
            }
            set
            {
                this.isTestAccountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int SendID
        {
            get
            {
                return this.sendIDField;
            }
            set
            {
                this.sendIDField = value;
                this.sendIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendIDSpecified
        {
            get
            {
                return this.sendIDFieldSpecified;
            }
            set
            {
                this.sendIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string DeliveredTime
        {
            get
            {
                return this.deliveredTimeField;
            }
            set
            {
                this.deliveredTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int TotalSent
        {
            get
            {
                return this.totalSentField;
            }
            set
            {
                this.totalSentField = value;
                this.totalSentFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalSentSpecified
        {
            get
            {
                return this.totalSentFieldSpecified;
            }
            set
            {
                this.totalSentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int Transactional
        {
            get
            {
                return this.transactionalField;
            }
            set
            {
                this.transactionalField = value;
                this.transactionalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionalSpecified
        {
            get
            {
                return this.transactionalFieldSpecified;
            }
            set
            {
                this.transactionalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int NonTransactional
        {
            get
            {
                return this.nonTransactionalField;
            }
            set
            {
                this.nonTransactionalField = value;
                this.nonTransactionalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NonTransactionalSpecified
        {
            get
            {
                return this.nonTransactionalFieldSpecified;
            }
            set
            {
                this.nonTransactionalFieldSpecified = value;
            }
        }
    }
}