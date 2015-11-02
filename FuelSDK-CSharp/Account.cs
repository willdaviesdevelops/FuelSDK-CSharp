namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessUnit))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Account : APIObject
    {
        
        private AccountTypeEnum accountTypeField;
        
        private int parentIDField;
        
        private bool parentIDFieldSpecified;
        
        private int brandIDField;
        
        private bool brandIDFieldSpecified;
        
        private int privateLabelIDField;
        
        private bool privateLabelIDFieldSpecified;
        
        private int reportingParentIDField;
        
        private bool reportingParentIDFieldSpecified;
        
        private string nameField;
        
        private string emailField;
        
        private string fromNameField;
        
        private string businessNameField;
        
        private string phoneField;
        
        private string addressField;
        
        private string faxField;
        
        private string cityField;
        
        private string stateField;
        
        private string zipField;
        
        private string countryField;
        
        private int isActiveField;
        
        private bool isActiveFieldSpecified;
        
        private bool isTestAccountField;
        
        private bool isTestAccountFieldSpecified;
        
        private int orgIDField;
        
        private bool orgIDFieldSpecified;
        
        private int dBIDField;
        
        private bool dBIDFieldSpecified;
        
        private string parentNameField;
        
        private long customerIDField;
        
        private bool customerIDFieldSpecified;
        
        private System.DateTime deletedDateField;
        
        private bool deletedDateFieldSpecified;
        
        private int editionIDField;
        
        private bool editionIDFieldSpecified;
        
        private AccountDataItem[] childrenField;
        
        private Subscription subscriptionField;
        
        private PrivateLabel[] privateLabelsField;
        
        private BusinessRule[] businessRulesField;
        
        private AccountUser[] accountUsersField;
        
        private bool inheritAddressField;
        
        private bool inheritAddressFieldSpecified;
        
        private bool isTrialAccountField;
        
        private bool isTrialAccountFieldSpecified;
        
        private Locale localeField;
        
        private Account parentAccountField;
        
        private TimeZone timeZoneField;
        
        private Role[] rolesField;
        
        private Locale languageLocaleField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AccountTypeEnum AccountType
        {
            get
            {
                return this.accountTypeField;
            }
            set
            {
                this.accountTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int ParentID
        {
            get
            {
                return this.parentIDField;
            }
            set
            {
                this.parentIDField = value;
                this.parentIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ParentIDSpecified
        {
            get
            {
                return this.parentIDFieldSpecified;
            }
            set
            {
                this.parentIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int BrandID
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int PrivateLabelID
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int ReportingParentID
        {
            get
            {
                return this.reportingParentIDField;
            }
            set
            {
                this.reportingParentIDField = value;
                this.reportingParentIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReportingParentIDSpecified
        {
            get
            {
                return this.reportingParentIDFieldSpecified;
            }
            set
            {
                this.reportingParentIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string BusinessName
        {
            get
            {
                return this.businessNameField;
            }
            set
            {
                this.businessNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string Zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public int IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
                this.isActiveFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsActiveSpecified
        {
            get
            {
                return this.isActiveFieldSpecified;
            }
            set
            {
                this.isActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public int OrgID
        {
            get
            {
                return this.orgIDField;
            }
            set
            {
                this.orgIDField = value;
                this.orgIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrgIDSpecified
        {
            get
            {
                return this.orgIDFieldSpecified;
            }
            set
            {
                this.orgIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public int DBID
        {
            get
            {
                return this.dBIDField;
            }
            set
            {
                this.dBIDField = value;
                this.dBIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DBIDSpecified
        {
            get
            {
                return this.dBIDFieldSpecified;
            }
            set
            {
                this.dBIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public string ParentName
        {
            get
            {
                return this.parentNameField;
            }
            set
            {
                this.parentNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public long CustomerID
        {
            get
            {
                return this.customerIDField;
            }
            set
            {
                this.customerIDField = value;
                this.customerIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomerIDSpecified
        {
            get
            {
                return this.customerIDFieldSpecified;
            }
            set
            {
                this.customerIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public System.DateTime DeletedDate
        {
            get
            {
                return this.deletedDateField;
            }
            set
            {
                this.deletedDateField = value;
                this.deletedDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeletedDateSpecified
        {
            get
            {
                return this.deletedDateFieldSpecified;
            }
            set
            {
                this.deletedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public int EditionID
        {
            get
            {
                return this.editionIDField;
            }
            set
            {
                this.editionIDField = value;
                this.editionIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EditionIDSpecified
        {
            get
            {
                return this.editionIDFieldSpecified;
            }
            set
            {
                this.editionIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Children", IsNullable=true, Order=24)]
        public AccountDataItem[] Children
        {
            get
            {
                return this.childrenField;
            }
            set
            {
                this.childrenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=25)]
        public Subscription Subscription
        {
            get
            {
                return this.subscriptionField;
            }
            set
            {
                this.subscriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrivateLabels", IsNullable=true, Order=26)]
        public PrivateLabel[] PrivateLabels
        {
            get
            {
                return this.privateLabelsField;
            }
            set
            {
                this.privateLabelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BusinessRules", IsNullable=true, Order=27)]
        public BusinessRule[] BusinessRules
        {
            get
            {
                return this.businessRulesField;
            }
            set
            {
                this.businessRulesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccountUsers", IsNullable=true, Order=28)]
        public AccountUser[] AccountUsers
        {
            get
            {
                return this.accountUsersField;
            }
            set
            {
                this.accountUsersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=29)]
        public bool InheritAddress
        {
            get
            {
                return this.inheritAddressField;
            }
            set
            {
                this.inheritAddressField = value;
                this.inheritAddressFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InheritAddressSpecified
        {
            get
            {
                return this.inheritAddressFieldSpecified;
            }
            set
            {
                this.inheritAddressFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
        public bool IsTrialAccount
        {
            get
            {
                return this.isTrialAccountField;
            }
            set
            {
                this.isTrialAccountField = value;
                this.isTrialAccountFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsTrialAccountSpecified
        {
            get
            {
                return this.isTrialAccountFieldSpecified;
            }
            set
            {
                this.isTrialAccountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=31)]
        public Locale Locale
        {
            get
            {
                return this.localeField;
            }
            set
            {
                this.localeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=32)]
        public Account ParentAccount
        {
            get
            {
                return this.parentAccountField;
            }
            set
            {
                this.parentAccountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=33)]
        public TimeZone TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=34)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Role[] Roles
        {
            get
            {
                return this.rolesField;
            }
            set
            {
                this.rolesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=35)]
        public Locale LanguageLocale
        {
            get
            {
                return this.languageLocaleField;
            }
            set
            {
                this.languageLocaleField = value;
            }
        }
    }
}