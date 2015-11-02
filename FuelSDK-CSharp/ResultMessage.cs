namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ResultMessage : APIObject
    {
        
        private string requestIDField;
        
        private string conversationIDField;
        
        private string overallStatusCodeField;
        
        private string statusCodeField;
        
        private string statusMessageField;
        
        private int errorCodeField;
        
        private bool errorCodeFieldSpecified;
        
        private RequestType requestTypeField;
        
        private bool requestTypeFieldSpecified;
        
        private string resultTypeField;
        
        private string resultDetailXMLField;
        
        private int sequenceCodeField;
        
        private bool sequenceCodeFieldSpecified;
        
        private int callsInConversationField;
        
        private bool callsInConversationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string RequestID
        {
            get
            {
                return this.requestIDField;
            }
            set
            {
                this.requestIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ConversationID
        {
            get
            {
                return this.conversationIDField;
            }
            set
            {
                this.conversationIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string OverallStatusCode
        {
            get
            {
                return this.overallStatusCodeField;
            }
            set
            {
                this.overallStatusCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string StatusMessage
        {
            get
            {
                return this.statusMessageField;
            }
            set
            {
                this.statusMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
                this.errorCodeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorCodeSpecified
        {
            get
            {
                return this.errorCodeFieldSpecified;
            }
            set
            {
                this.errorCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public RequestType RequestType
        {
            get
            {
                return this.requestTypeField;
            }
            set
            {
                this.requestTypeField = value;
                this.requestTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RequestTypeSpecified
        {
            get
            {
                return this.requestTypeFieldSpecified;
            }
            set
            {
                this.requestTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string ResultType
        {
            get
            {
                return this.resultTypeField;
            }
            set
            {
                this.resultTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string ResultDetailXML
        {
            get
            {
                return this.resultDetailXMLField;
            }
            set
            {
                this.resultDetailXMLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int SequenceCode
        {
            get
            {
                return this.sequenceCodeField;
            }
            set
            {
                this.sequenceCodeField = value;
                this.sequenceCodeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SequenceCodeSpecified
        {
            get
            {
                return this.sequenceCodeFieldSpecified;
            }
            set
            {
                this.sequenceCodeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int CallsInConversation
        {
            get
            {
                return this.callsInConversationField;
            }
            set
            {
                this.callsInConversationField = value;
                this.callsInConversationFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CallsInConversationSpecified
        {
            get
            {
                return this.callsInConversationFieldSpecified;
            }
            set
            {
                this.callsInConversationFieldSpecified = value;
            }
        }
    }
}