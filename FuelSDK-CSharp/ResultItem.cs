namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ResultItem : APIObject
    {
        
        private string requestIDField;
        
        private string conversationIDField;
        
        private string statusCodeField;
        
        private string statusMessageField;
        
        private int ordinalIDField;
        
        private bool ordinalIDFieldSpecified;
        
        private int errorCodeField;
        
        private bool errorCodeFieldSpecified;
        
        private RequestType requestTypeField;
        
        private bool requestTypeFieldSpecified;
        
        private string requestObjectTypeField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int OrdinalID
        {
            get
            {
                return this.ordinalIDField;
            }
            set
            {
                this.ordinalIDField = value;
                this.ordinalIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrdinalIDSpecified
        {
            get
            {
                return this.ordinalIDFieldSpecified;
            }
            set
            {
                this.ordinalIDFieldSpecified = value;
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
        public string RequestObjectType
        {
            get
            {
                return this.requestObjectTypeField;
            }
            set
            {
                this.requestObjectTypeField = value;
            }
        }
    }
}