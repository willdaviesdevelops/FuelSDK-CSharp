namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Subscriber : APIObject
    {
        
        private string emailAddressField;
        
        private Attribute[] attributesField;
        
        private string subscriberKeyField;
        
        private System.DateTime unsubscribedDateField;
        
        private bool unsubscribedDateFieldSpecified;
        
        private SubscriberStatus statusField;
        
        private bool statusFieldSpecified;
        
        private string partnerTypeField;
        
        private EmailType emailTypePreferenceField;
        
        private bool emailTypePreferenceFieldSpecified;
        
        private SubscriberList[] listsField;
        
        private GlobalUnsubscribeCategory globalUnsubscribeCategoryField;
        
        private SubscriberTypeDefinition subscriberTypeDefinitionField;
        
        private SubscriberAddress[] addressesField;
        
        private SMSAddress primarySMSAddressField;
        
        private SubscriberAddressStatus primarySMSPublicationStatusField;
        
        private bool primarySMSPublicationStatusFieldSpecified;
        
        private EmailAddress primaryEmailAddressField;
        
        private Locale localeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string EmailAddress
        {
            get
            {
                return this.emailAddressField;
            }
            set
            {
                this.emailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attributes", Order=1)]
        public Attribute[] Attributes
        {
            get
            {
                return this.attributesField;
            }
            set
            {
                this.attributesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SubscriberKey
        {
            get
            {
                return this.subscriberKeyField;
            }
            set
            {
                this.subscriberKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public System.DateTime UnsubscribedDate
        {
            get
            {
                return this.unsubscribedDateField;
            }
            set
            {
                this.unsubscribedDateField = value;
                this.unsubscribedDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UnsubscribedDateSpecified
        {
            get
            {
                return this.unsubscribedDateFieldSpecified;
            }
            set
            {
                this.unsubscribedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public SubscriberStatus Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.statusFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string PartnerType
        {
            get
            {
                return this.partnerTypeField;
            }
            set
            {
                this.partnerTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public EmailType EmailTypePreference
        {
            get
            {
                return this.emailTypePreferenceField;
            }
            set
            {
                this.emailTypePreferenceField = value;
                this.emailTypePreferenceFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmailTypePreferenceSpecified
        {
            get
            {
                return this.emailTypePreferenceFieldSpecified;
            }
            set
            {
                this.emailTypePreferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Lists", Order=7)]
        public SubscriberList[] Lists
        {
            get
            {
                return this.listsField;
            }
            set
            {
                this.listsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public GlobalUnsubscribeCategory GlobalUnsubscribeCategory
        {
            get
            {
                return this.globalUnsubscribeCategoryField;
            }
            set
            {
                this.globalUnsubscribeCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public SubscriberTypeDefinition SubscriberTypeDefinition
        {
            get
            {
                return this.subscriberTypeDefinitionField;
            }
            set
            {
                this.subscriberTypeDefinitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=10)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Address", IsNullable=false)]
        public SubscriberAddress[] Addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public SMSAddress PrimarySMSAddress
        {
            get
            {
                return this.primarySMSAddressField;
            }
            set
            {
                this.primarySMSAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public SubscriberAddressStatus PrimarySMSPublicationStatus
        {
            get
            {
                return this.primarySMSPublicationStatusField;
            }
            set
            {
                this.primarySMSPublicationStatusField = value;
                this.primarySMSPublicationStatusFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrimarySMSPublicationStatusSpecified
        {
            get
            {
                return this.primarySMSPublicationStatusFieldSpecified;
            }
            set
            {
                this.primarySMSPublicationStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public EmailAddress PrimaryEmailAddress
        {
            get
            {
                return this.primaryEmailAddressField;
            }
            set
            {
                this.primaryEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
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
    }
}