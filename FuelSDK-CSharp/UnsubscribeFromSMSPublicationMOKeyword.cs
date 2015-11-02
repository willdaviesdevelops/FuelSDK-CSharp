namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class UnsubscribeFromSMSPublicationMOKeyword : BaseMOKeyword
    {
        
        private BaseMOKeyword nextMOKeywordField;
        
        private string allUnsubSuccessMessageField;
        
        private string invalidPublicationMessageField;
        
        private string singleUnsubSuccessMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AllUnsubSuccessMessage
        {
            get
            {
                return this.allUnsubSuccessMessageField;
            }
            set
            {
                this.allUnsubSuccessMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string InvalidPublicationMessage
        {
            get
            {
                return this.invalidPublicationMessageField;
            }
            set
            {
                this.invalidPublicationMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string SingleUnsubSuccessMessage
        {
            get
            {
                return this.singleUnsubSuccessMessageField;
            }
            set
            {
                this.singleUnsubSuccessMessageField = value;
            }
        }
    }
}