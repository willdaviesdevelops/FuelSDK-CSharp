namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class BusinessUnit : Account
    {
        
        private string descriptionField;
        
        private SendClassification defaultSendClassificationField;
        
        private LandingPage defaultHomePageField;
        
        private FilterPart subscriberFilterField;
        
        private UnsubscribeBehaviorEnum masterUnsubscribeBehaviorField;
        
        private bool masterUnsubscribeBehaviorFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SendClassification DefaultSendClassification
        {
            get
            {
                return this.defaultSendClassificationField;
            }
            set
            {
                this.defaultSendClassificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public LandingPage DefaultHomePage
        {
            get
            {
                return this.defaultHomePageField;
            }
            set
            {
                this.defaultHomePageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public FilterPart SubscriberFilter
        {
            get
            {
                return this.subscriberFilterField;
            }
            set
            {
                this.subscriberFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public UnsubscribeBehaviorEnum MasterUnsubscribeBehavior
        {
            get
            {
                return this.masterUnsubscribeBehaviorField;
            }
            set
            {
                this.masterUnsubscribeBehaviorField = value;
                this.masterUnsubscribeBehaviorFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MasterUnsubscribeBehaviorSpecified
        {
            get
            {
                return this.masterUnsubscribeBehaviorFieldSpecified;
            }
            set
            {
                this.masterUnsubscribeBehaviorFieldSpecified = value;
            }
        }
    }
}