namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class DeliveryProfile : APIObject
    {
        
        private string nameField;
        
        private string descriptionField;
        
        private DeliveryProfileSourceAddressTypeEnum sourceAddressTypeField;
        
        private bool sourceAddressTypeFieldSpecified;
        
        private PrivateIP privateIPField;
        
        private DeliveryProfileDomainTypeEnum domainTypeField;
        
        private bool domainTypeFieldSpecified;
        
        private PrivateDomain privateDomainField;
        
        private SalutationSourceEnum headerSalutationSourceField;
        
        private bool headerSalutationSourceFieldSpecified;
        
        private ContentArea headerContentAreaField;
        
        private SalutationSourceEnum footerSalutationSourceField;
        
        private bool footerSalutationSourceFieldSpecified;
        
        private ContentArea footerContentAreaField;
        
        private bool subscriberLevelPrivateDomainField;
        
        private bool subscriberLevelPrivateDomainFieldSpecified;
        
        private Certificate sMIMESignatureCertificateField;
        
        private PrivateDomainSet privateDomainSetField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public DeliveryProfileSourceAddressTypeEnum SourceAddressType
        {
            get
            {
                return this.sourceAddressTypeField;
            }
            set
            {
                this.sourceAddressTypeField = value;
                this.sourceAddressTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SourceAddressTypeSpecified
        {
            get
            {
                return this.sourceAddressTypeFieldSpecified;
            }
            set
            {
                this.sourceAddressTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public PrivateIP PrivateIP
        {
            get
            {
                return this.privateIPField;
            }
            set
            {
                this.privateIPField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public DeliveryProfileDomainTypeEnum DomainType
        {
            get
            {
                return this.domainTypeField;
            }
            set
            {
                this.domainTypeField = value;
                this.domainTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DomainTypeSpecified
        {
            get
            {
                return this.domainTypeFieldSpecified;
            }
            set
            {
                this.domainTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public PrivateDomain PrivateDomain
        {
            get
            {
                return this.privateDomainField;
            }
            set
            {
                this.privateDomainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public SalutationSourceEnum HeaderSalutationSource
        {
            get
            {
                return this.headerSalutationSourceField;
            }
            set
            {
                this.headerSalutationSourceField = value;
                this.headerSalutationSourceFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeaderSalutationSourceSpecified
        {
            get
            {
                return this.headerSalutationSourceFieldSpecified;
            }
            set
            {
                this.headerSalutationSourceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public ContentArea HeaderContentArea
        {
            get
            {
                return this.headerContentAreaField;
            }
            set
            {
                this.headerContentAreaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public SalutationSourceEnum FooterSalutationSource
        {
            get
            {
                return this.footerSalutationSourceField;
            }
            set
            {
                this.footerSalutationSourceField = value;
                this.footerSalutationSourceFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FooterSalutationSourceSpecified
        {
            get
            {
                return this.footerSalutationSourceFieldSpecified;
            }
            set
            {
                this.footerSalutationSourceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public ContentArea FooterContentArea
        {
            get
            {
                return this.footerContentAreaField;
            }
            set
            {
                this.footerContentAreaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool SubscriberLevelPrivateDomain
        {
            get
            {
                return this.subscriberLevelPrivateDomainField;
            }
            set
            {
                this.subscriberLevelPrivateDomainField = value;
                this.subscriberLevelPrivateDomainFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubscriberLevelPrivateDomainSpecified
        {
            get
            {
                return this.subscriberLevelPrivateDomainFieldSpecified;
            }
            set
            {
                this.subscriberLevelPrivateDomainFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public Certificate SMIMESignatureCertificate
        {
            get
            {
                return this.sMIMESignatureCertificateField;
            }
            set
            {
                this.sMIMESignatureCertificateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public PrivateDomainSet PrivateDomainSet
        {
            get
            {
                return this.privateDomainSetField;
            }
            set
            {
                this.privateDomainSetField = value;
            }
        }
    }
}