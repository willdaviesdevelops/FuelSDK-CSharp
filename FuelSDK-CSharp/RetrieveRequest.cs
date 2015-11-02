namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class RetrieveRequest
    {
        
        private ClientID[] clientIDsField;
        
        private string objectTypeField;
        
        private string[] propertiesField;
        
        private FilterPart filterField;
        
        private AsyncResponse[] respondToField;
        
        private APIProperty[] partnerPropertiesField;
        
        private string continueRequestField;
        
        private bool queryAllAccountsField;
        
        private bool queryAllAccountsFieldSpecified;
        
        private bool retrieveAllSinceLastBatchField;
        
        private bool retrieveAllSinceLastBatchFieldSpecified;
        
        private bool repeatLastResultField;
        
        private bool repeatLastResultFieldSpecified;
        
        private Request[] retrievesField;
        
        private RetrieveOptions optionsField;
        
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
        public string ObjectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Properties", Order=2)]
        public string[] Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public FilterPart Filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RespondTo", Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute("PartnerProperties", Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool RepeatLastResult
        {
            get
            {
                return this.repeatLastResultField;
            }
            set
            {
                this.repeatLastResultField = value;
                this.repeatLastResultFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RepeatLastResultSpecified
        {
            get
            {
                return this.repeatLastResultFieldSpecified;
            }
            set
            {
                this.repeatLastResultFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=10)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public Request[] Retrieves
        {
            get
            {
                return this.retrievesField;
            }
            set
            {
                this.retrievesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public RetrieveOptions Options
        {
            get
            {
                return this.optionsField;
            }
            set
            {
                this.optionsField = value;
            }
        }
    }
}