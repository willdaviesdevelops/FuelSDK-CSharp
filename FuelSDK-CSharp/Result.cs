namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemStatusResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExtractResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConfigureResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PerformResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ContentValidationResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DeleteResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataExtensionDeleteResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UpdateResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataExtensionUpdateResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataExtensionCreateResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriggeredSendCreateResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Result
    {
        
        private string statusCodeField;
        
        private string statusMessageField;
        
        private int ordinalIDField;
        
        private bool ordinalIDFieldSpecified;
        
        private int errorCodeField;
        
        private bool errorCodeFieldSpecified;
        
        private string requestIDField;
        
        private string conversationIDField;
        
        private string overallStatusCodeField;
        
        private RequestType requestTypeField;
        
        private bool requestTypeFieldSpecified;
        
        private string resultTypeField;
        
        private string resultDetailXMLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
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
    }
}