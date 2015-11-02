namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AsyncRequestResult : APIObject
    {
        
        private string statusField;
        
        private System.DateTime completeDateField;
        
        private bool completeDateFieldSpecified;
        
        private string callStatusField;
        
        private string callMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime CompleteDate
        {
            get
            {
                return this.completeDateField;
            }
            set
            {
                this.completeDateField = value;
                this.completeDateFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CompleteDateSpecified
        {
            get
            {
                return this.completeDateFieldSpecified;
            }
            set
            {
                this.completeDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CallStatus
        {
            get
            {
                return this.callStatusField;
            }
            set
            {
                this.callStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string CallMessage
        {
            get
            {
                return this.callMessageField;
            }
            set
            {
                this.callMessageField = value;
            }
        }
    }
}