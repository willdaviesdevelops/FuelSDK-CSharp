namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Subscription
    {
        
        private System.Nullable<int> subscriptionIDField;
        
        private bool subscriptionIDFieldSpecified;
        
        private int emailsPurchasedField;
        
        private int accountsPurchasedField;
        
        private int advAccountsPurchasedField;
        
        private int lPAccountsPurchasedField;
        
        private int dOTOAccountsPurchasedField;
        
        private int bUAccountsPurchasedField;
        
        private System.DateTime beginDateField;
        
        private System.DateTime endDateField;
        
        private string notesField;
        
        private string periodField;
        
        private string notificationTitleField;
        
        private string notificationMessageField;
        
        private string notificationFlagField;
        
        private System.Nullable<System.DateTime> notificationExpDateField;
        
        private bool notificationExpDateFieldSpecified;
        
        private string forAccountingField;
        
        private bool hasPurchasedEmailsField;
        
        private string contractNumberField;
        
        private string contractModifierField;
        
        private bool isRenewalField;
        
        private bool isRenewalFieldSpecified;
        
        private long numberofEmailsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> SubscriptionID
        {
            get
            {
                return this.subscriptionIDField;
            }
            set
            {
                this.subscriptionIDField = value;
                this.subscriptionIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubscriptionIDSpecified
        {
            get
            {
                return this.subscriptionIDFieldSpecified;
            }
            set
            {
                this.subscriptionIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int EmailsPurchased
        {
            get
            {
                return this.emailsPurchasedField;
            }
            set
            {
                this.emailsPurchasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int AccountsPurchased
        {
            get
            {
                return this.accountsPurchasedField;
            }
            set
            {
                this.accountsPurchasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int AdvAccountsPurchased
        {
            get
            {
                return this.advAccountsPurchasedField;
            }
            set
            {
                this.advAccountsPurchasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int LPAccountsPurchased
        {
            get
            {
                return this.lPAccountsPurchasedField;
            }
            set
            {
                this.lPAccountsPurchasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int DOTOAccountsPurchased
        {
            get
            {
                return this.dOTOAccountsPurchasedField;
            }
            set
            {
                this.dOTOAccountsPurchasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int BUAccountsPurchased
        {
            get
            {
                return this.bUAccountsPurchasedField;
            }
            set
            {
                this.bUAccountsPurchasedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public System.DateTime BeginDate
        {
            get
            {
                return this.beginDateField;
            }
            set
            {
                this.beginDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public string Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public string NotificationTitle
        {
            get
            {
                return this.notificationTitleField;
            }
            set
            {
                this.notificationTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public string NotificationMessage
        {
            get
            {
                return this.notificationMessageField;
            }
            set
            {
                this.notificationMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public string NotificationFlag
        {
            get
            {
                return this.notificationFlagField;
            }
            set
            {
                this.notificationFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<System.DateTime> NotificationExpDate
        {
            get
            {
                return this.notificationExpDateField;
            }
            set
            {
                this.notificationExpDateField = value;
                this.notificationExpDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NotificationExpDateSpecified
        {
            get
            {
                return this.notificationExpDateFieldSpecified;
            }
            set
            {
                this.notificationExpDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public string ForAccounting
        {
            get
            {
                return this.forAccountingField;
            }
            set
            {
                this.forAccountingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public bool HasPurchasedEmails
        {
            get
            {
                return this.hasPurchasedEmailsField;
            }
            set
            {
                this.hasPurchasedEmailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public string ContractNumber
        {
            get
            {
                return this.contractNumberField;
            }
            set
            {
                this.contractNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string ContractModifier
        {
            get
            {
                return this.contractModifierField;
            }
            set
            {
                this.contractModifierField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public bool IsRenewal
        {
            get
            {
                return this.isRenewalField;
            }
            set
            {
                this.isRenewalField = value;
                this.isRenewalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsRenewalSpecified
        {
            get
            {
                return this.isRenewalFieldSpecified;
            }
            set
            {
                this.isRenewalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public long NumberofEmails
        {
            get
            {
                return this.numberofEmailsField;
            }
            set
            {
                this.numberofEmailsField = value;
            }
        }
    }
}