namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AccountUser : APIObject
    {
        
        private System.Nullable<int> accountUserIDField;
        
        private bool accountUserIDFieldSpecified;
        
        private string userIDField;
        
        private string passwordField;
        
        private string nameField;
        
        private string emailField;
        
        private bool mustChangePasswordField;
        
        private bool mustChangePasswordFieldSpecified;
        
        private bool activeFlagField;
        
        private bool activeFlagFieldSpecified;
        
        private string challengePhraseField;
        
        private string challengeAnswerField;
        
        private UserAccess[] userPermissionsField;
        
        private int deleteField;
        
        private System.DateTime lastSuccessfulLoginField;
        
        private bool lastSuccessfulLoginFieldSpecified;
        
        private bool isAPIUserField;
        
        private bool isAPIUserFieldSpecified;
        
        private string notificationEmailAddressField;
        
        private bool isLockedField;
        
        private bool isLockedFieldSpecified;
        
        private bool unlockField;
        
        private bool unlockFieldSpecified;
        
        private int businessUnitField;
        
        private bool businessUnitFieldSpecified;
        
        private int defaultBusinessUnitField;
        
        private bool defaultBusinessUnitFieldSpecified;
        
        private string defaultApplicationField;
        
        private Locale localeField;
        
        private TimeZone timeZoneField;
        
        private BusinessUnit defaultBusinessUnitObjectField;
        
        private BusinessUnit[] associatedBusinessUnitsField;
        
        private Role[] rolesField;
        
        private Locale languageLocaleField;
        
        private SsoIdentity[] ssoIdentitiesField;
        
        public AccountUser()
        {
            this.deleteField = 0;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> AccountUserID
        {
            get
            {
                return this.accountUserIDField;
            }
            set
            {
                this.accountUserIDField = value;
                this.accountUserIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountUserIDSpecified
        {
            get
            {
                return this.accountUserIDFieldSpecified;
            }
            set
            {
                this.accountUserIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool MustChangePassword
        {
            get
            {
                return this.mustChangePasswordField;
            }
            set
            {
                this.mustChangePasswordField = value;
                this.mustChangePasswordFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MustChangePasswordSpecified
        {
            get
            {
                return this.mustChangePasswordFieldSpecified;
            }
            set
            {
                this.mustChangePasswordFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool ActiveFlag
        {
            get
            {
                return this.activeFlagField;
            }
            set
            {
                this.activeFlagField = value;
                this.activeFlagFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActiveFlagSpecified
        {
            get
            {
                return this.activeFlagFieldSpecified;
            }
            set
            {
                this.activeFlagFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string ChallengePhrase
        {
            get
            {
                return this.challengePhraseField;
            }
            set
            {
                this.challengePhraseField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string ChallengeAnswer
        {
            get
            {
                return this.challengeAnswerField;
            }
            set
            {
                this.challengeAnswerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserPermissions", IsNullable=true, Order=9)]
        public UserAccess[] UserPermissions
        {
            get
            {
                return this.userPermissionsField;
            }
            set
            {
                this.userPermissionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int Delete
        {
            get
            {
                return this.deleteField;
            }
            set
            {
                this.deleteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public System.DateTime LastSuccessfulLogin
        {
            get
            {
                return this.lastSuccessfulLoginField;
            }
            set
            {
                this.lastSuccessfulLoginField = value;
                this.lastSuccessfulLoginFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastSuccessfulLoginSpecified
        {
            get
            {
                return this.lastSuccessfulLoginFieldSpecified;
            }
            set
            {
                this.lastSuccessfulLoginFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public bool IsAPIUser
        {
            get
            {
                return this.isAPIUserField;
            }
            set
            {
                this.isAPIUserField = value;
                this.isAPIUserFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAPIUserSpecified
        {
            get
            {
                return this.isAPIUserFieldSpecified;
            }
            set
            {
                this.isAPIUserFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string NotificationEmailAddress
        {
            get
            {
                return this.notificationEmailAddressField;
            }
            set
            {
                this.notificationEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public bool IsLocked
        {
            get
            {
                return this.isLockedField;
            }
            set
            {
                this.isLockedField = value;
                this.isLockedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsLockedSpecified
        {
            get
            {
                return this.isLockedFieldSpecified;
            }
            set
            {
                this.isLockedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public bool Unlock
        {
            get
            {
                return this.unlockField;
            }
            set
            {
                this.unlockField = value;
                this.unlockFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnlockSpecified
        {
            get
            {
                return this.unlockFieldSpecified;
            }
            set
            {
                this.unlockFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public int BusinessUnit
        {
            get
            {
                return this.businessUnitField;
            }
            set
            {
                this.businessUnitField = value;
                this.businessUnitFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BusinessUnitSpecified
        {
            get
            {
                return this.businessUnitFieldSpecified;
            }
            set
            {
                this.businessUnitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public int DefaultBusinessUnit
        {
            get
            {
                return this.defaultBusinessUnitField;
            }
            set
            {
                this.defaultBusinessUnitField = value;
                this.defaultBusinessUnitFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DefaultBusinessUnitSpecified
        {
            get
            {
                return this.defaultBusinessUnitFieldSpecified;
            }
            set
            {
                this.defaultBusinessUnitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string DefaultApplication
        {
            get
            {
                return this.defaultApplicationField;
            }
            set
            {
                this.defaultApplicationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public BusinessUnit DefaultBusinessUnitObject
        {
            get
            {
                return this.defaultBusinessUnitObjectField;
            }
            set
            {
                this.defaultBusinessUnitObjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=22)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public BusinessUnit[] AssociatedBusinessUnits
        {
            get
            {
                return this.associatedBusinessUnitsField;
            }
            set
            {
                this.associatedBusinessUnitsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=23)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=25)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public SsoIdentity[] SsoIdentities
        {
            get
            {
                return this.ssoIdentitiesField;
            }
            set
            {
                this.ssoIdentitiesField = value;
            }
        }
    }
}