namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class DoubleOptInMOKeyword : BaseMOKeyword
    {
        
        private List defaultPublicationField;
        
        private string invalidPublicationMessageField;
        
        private string invalidResponseMessageField;
        
        private string missingPublicationMessageField;
        
        private string needPublicationMessageField;
        
        private string promptMessageField;
        
        private string successMessageField;
        
        private string unexpectedErrorMessageField;
        
        private List[] validPublicationsField;
        
        private string[] validResponsesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public List DefaultPublication
        {
            get
            {
                return this.defaultPublicationField;
            }
            set
            {
                this.defaultPublicationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string InvalidResponseMessage
        {
            get
            {
                return this.invalidResponseMessageField;
            }
            set
            {
                this.invalidResponseMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string MissingPublicationMessage
        {
            get
            {
                return this.missingPublicationMessageField;
            }
            set
            {
                this.missingPublicationMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string NeedPublicationMessage
        {
            get
            {
                return this.needPublicationMessageField;
            }
            set
            {
                this.needPublicationMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string PromptMessage
        {
            get
            {
                return this.promptMessageField;
            }
            set
            {
                this.promptMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string UnexpectedErrorMessage
        {
            get
            {
                return this.unexpectedErrorMessageField;
            }
            set
            {
                this.unexpectedErrorMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=8)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ValidPublication", IsNullable=false)]
        public List[] ValidPublications
        {
            get
            {
                return this.validPublicationsField;
            }
            set
            {
                this.validPublicationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=9)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ValidResponse", IsNullable=false)]
        public string[] ValidResponses
        {
            get
            {
                return this.validResponsesField;
            }
            set
            {
                this.validResponsesField = value;
            }
        }
    }
}