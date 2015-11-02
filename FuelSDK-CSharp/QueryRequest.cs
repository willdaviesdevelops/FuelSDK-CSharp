namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class QueryRequest
    {
        
        private ClientID[] clientIDsField;
        
        private Query queryField;
        
        private AsyncResponse[] respondToField;
        
        private APIProperty[] partnerPropertiesField;
        
        private string continueRequestField;
        
        private bool queryAllAccountsField;
        
        private bool queryAllAccountsFieldSpecified;
        
        private bool retrieveAllSinceLastBatchField;
        
        private bool retrieveAllSinceLastBatchFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClientIDs", Order=0)]
        public ClientID[] ClientIDs
        {
            get
            {
                return this.clientIDsField;
            }
            set
            {
                this.clientIDsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Query Query
        {
            get
            {
                return this.queryField;
            }
            set
            {
                this.queryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RespondTo", Order=2)]
        public AsyncResponse[] RespondTo
        {
            get
            {
                return this.respondToField;
            }
            set
            {
                this.respondToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PartnerProperties", Order=3)]
        public APIProperty[] PartnerProperties
        {
            get
            {
                return this.partnerPropertiesField;
            }
            set
            {
                this.partnerPropertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string ContinueRequest
        {
            get
            {
                return this.continueRequestField;
            }
            set
            {
                this.continueRequestField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool QueryAllAccounts
        {
            get
            {
                return this.queryAllAccountsField;
            }
            set
            {
                this.queryAllAccountsField = value;
                this.queryAllAccountsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QueryAllAccountsSpecified
        {
            get
            {
                return this.queryAllAccountsFieldSpecified;
            }
            set
            {
                this.queryAllAccountsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool RetrieveAllSinceLastBatch
        {
            get
            {
                return this.retrieveAllSinceLastBatchField;
            }
            set
            {
                this.retrieveAllSinceLastBatchField = value;
                this.retrieveAllSinceLastBatchFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RetrieveAllSinceLastBatchSpecified
        {
            get
            {
                return this.retrieveAllSinceLastBatchFieldSpecified;
            }
            set
            {
                this.retrieveAllSinceLastBatchFieldSpecified = value;
            }
        }
    }
}