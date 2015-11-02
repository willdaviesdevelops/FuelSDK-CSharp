namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataExtensionCreateResult))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriggeredSendCreateResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class CreateResult : Result
    {
        
        private int newIDField;
        
        private string newObjectIDField;
        
        private string partnerKeyField;
        
        private APIObject objectField;
        
        private CreateResult[] createResultsField;
        
        private string parentPropertyNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int NewID
        {
            get
            {
                return this.newIDField;
            }
            set
            {
                this.newIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string NewObjectID
        {
            get
            {
                return this.newObjectIDField;
            }
            set
            {
                this.newObjectIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string PartnerKey
        {
            get
            {
                return this.partnerKeyField;
            }
            set
            {
                this.partnerKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public APIObject Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CreateResults", Order=4)]
        public CreateResult[] CreateResults
        {
            get
            {
                return this.createResultsField;
            }
            set
            {
                this.createResultsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string ParentPropertyName
        {
            get
            {
                return this.parentPropertyNameField;
            }
            set
            {
                this.parentPropertyNameField = value;
            }
        }
    }
}