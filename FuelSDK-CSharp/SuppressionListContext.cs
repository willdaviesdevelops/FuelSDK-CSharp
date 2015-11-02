namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SuppressionListContext : APIObject
    {
        
        private SuppressionListContextEnum contextField;
        
        private bool contextFieldSpecified;
        
        private SendClassificationTypeEnum sendClassificationTypeField;
        
        private bool sendClassificationTypeFieldSpecified;
        
        private SendClassification sendClassificationField;
        
        private Send sendField;
        
        private SuppressionListDefinition definitionField;
        
        private bool appliesToAllSendsField;
        
        private bool appliesToAllSendsFieldSpecified;
        
        private SenderProfile senderProfileField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SuppressionListContextEnum Context
        {
            get
            {
                return this.contextField;
            }
            set
            {
                this.contextField = value;
                this.contextFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ContextSpecified
        {
            get
            {
                return this.contextFieldSpecified;
            }
            set
            {
                this.contextFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SendClassificationTypeEnum SendClassificationType
        {
            get
            {
                return this.sendClassificationTypeField;
            }
            set
            {
                this.sendClassificationTypeField = value;
                this.sendClassificationTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendClassificationTypeSpecified
        {
            get
            {
                return this.sendClassificationTypeFieldSpecified;
            }
            set
            {
                this.sendClassificationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public SendClassification SendClassification
        {
            get
            {
                return this.sendClassificationField;
            }
            set
            {
                this.sendClassificationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public Send Send
        {
            get
            {
                return this.sendField;
            }
            set
            {
                this.sendField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public SuppressionListDefinition Definition
        {
            get
            {
                return this.definitionField;
            }
            set
            {
                this.definitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool AppliesToAllSends
        {
            get
            {
                return this.appliesToAllSendsField;
            }
            set
            {
                this.appliesToAllSendsField = value;
                this.appliesToAllSendsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AppliesToAllSendsSpecified
        {
            get
            {
                return this.appliesToAllSendsFieldSpecified;
            }
            set
            {
                this.appliesToAllSendsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public SenderProfile SenderProfile
        {
            get
            {
                return this.senderProfileField;
            }
            set
            {
                this.senderProfileField = value;
            }
        }
    }
}