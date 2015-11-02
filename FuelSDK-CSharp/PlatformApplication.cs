namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class PlatformApplication : APIObject
    {
        
        private PlatformApplicationPackage packageField;
        
        private PlatformApplicationPackage[] packagesField;
        
        private ResourceSpecification resourceSpecificationField;
        
        private string developerVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public PlatformApplicationPackage Package
        {
            get
            {
                return this.packageField;
            }
            set
            {
                this.packageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Packages", Order=1)]
        public PlatformApplicationPackage[] Packages
        {
            get
            {
                return this.packagesField;
            }
            set
            {
                this.packagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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