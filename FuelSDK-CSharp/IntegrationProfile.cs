namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class IntegrationProfile : APIObject
    {
        
        private string profileIDField;
        
        private string subscriberKeyField;
        
        private string externalIDField;
        
        private string externalTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ProfileID
        {
            get
            {
                return this.profileIDField;
            }
            set
            {
                this.profileIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ExternalID
        {
            get
            {
                return this.externalIDField;
            }
            set
            {
                this.externalIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ExternalType
        {
            get
            {
                return this.externalTypeField;
            }
            set
            {
                this.externalTypeField = value;
            }
        }
    }
}