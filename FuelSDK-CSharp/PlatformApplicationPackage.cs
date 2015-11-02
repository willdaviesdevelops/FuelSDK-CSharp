namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class PlatformApplicationPackage : APIObject
    {
        
        private ResourceSpecification resourceSpecificationField;
        
        private PublicKeyManagement signingKeyField;
        
        private bool isUpgradeField;
        
        private bool isUpgradeFieldSpecified;
        
        private string developerVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ResourceSpecification ResourceSpecification
        {
            get
            {
                return this.resourceSpecificationField;
            }
            set
            {
                this.resourceSpecificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public PublicKeyManagement SigningKey
        {
            get
            {
                return this.signingKeyField;
            }
            set
            {
                this.signingKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IsUpgrade
        {
            get
            {
                return this.isUpgradeField;
            }
            set
            {
                this.isUpgradeField = value;
                this.isUpgradeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsUpgradeSpecified
        {
            get
            {
                return this.isUpgradeFieldSpecified;
            }
            set
            {
                this.isUpgradeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string DeveloperVersion
        {
            get
            {
                return this.developerVersionField;
            }
            set
            {
                this.developerVersionField = value;
            }
        }
    }
}