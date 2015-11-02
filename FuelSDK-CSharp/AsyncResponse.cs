namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AsyncResponse
    {
        
        private AsyncResponseType responseTypeField;
        
        private string responseAddressField;
        
        private RespondWhen respondWhenField;
        
        private bool respondWhenFieldSpecified;
        
        private bool includeResultsField;
        
        private bool includeResultsFieldSpecified;
        
        private bool includeObjectsField;
        
        private bool includeObjectsFieldSpecified;
        
        private bool onlyIncludeBaseField;
        
        private bool onlyIncludeBaseFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AsyncResponseType ResponseType
        {
            get
            {
                return this.responseTypeField;
            }
            set
            {
                this.responseTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ResponseAddress
        {
            get
            {
                return this.responseAddressField;
            }
            set
            {
                this.responseAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public RespondWhen RespondWhen
        {
            get
            {
                return this.respondWhenField;
            }
            set
            {
                this.respondWhenField = value;
                this.respondWhenFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RespondWhenSpecified
        {
            get
            {
                return this.respondWhenFieldSpecified;
            }
            set
            {
                this.respondWhenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool IncludeResults
        {
            get
            {
                return this.includeResultsField;
            }
            set
            {
                this.includeResultsField = value;
                this.includeResultsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeResultsSpecified
        {
            get
            {
                return this.includeResultsFieldSpecified;
            }
            set
            {
                this.includeResultsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool IncludeObjects
        {
            get
            {
                return this.includeObjectsField;
            }
            set
            {
                this.includeObjectsField = value;
                this.includeObjectsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeObjectsSpecified
        {
            get
            {
                return this.includeObjectsFieldSpecified;
            }
            set
            {
                this.includeObjectsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool OnlyIncludeBase
        {
            get
            {
                return this.onlyIncludeBaseField;
            }
            set
            {
                this.onlyIncludeBaseField = value;
                this.onlyIncludeBaseFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OnlyIncludeBaseSpecified
        {
            get
            {
                return this.onlyIncludeBaseFieldSpecified;
            }
            set
            {
                this.onlyIncludeBaseFieldSpecified = value;
            }
        }
    }
}