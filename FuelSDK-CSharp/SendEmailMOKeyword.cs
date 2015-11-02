namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SendEmailMOKeyword : BaseMOKeyword
    {
        
        private string successMessageField;
        
        private string missingEmailMessageField;
        
        private string failureMessageField;
        
        private TriggeredSendDefinition triggeredSendField;
        
        private BaseMOKeyword nextMOKeywordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SuccessMessage
        {
            get
            {
                return this.successMessageField;
            }
            set
            {
                this.successMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string MissingEmailMessage
        {
            get
            {
                return this.missingEmailMessageField;
            }
            set
            {
                this.missingEmailMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string FailureMessage
        {
            get
            {
                return this.failureMessageField;
            }
            set
            {
                this.failureMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public TriggeredSendDefinition TriggeredSend
        {
            get
            {
                return this.triggeredSendField;
            }
            set
            {
                this.triggeredSendField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public BaseMOKeyword NextMOKeyword
        {
            get
            {
                return this.nextMOKeywordField;
            }
            set
            {
                this.nextMOKeywordField = value;
            }
        }
    }
}