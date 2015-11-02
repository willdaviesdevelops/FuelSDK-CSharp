namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataExtensionUpdateResult))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class UpdateResult : Result
    {
        
        private APIObject objectField;
        
        private UpdateResult[] updateResultsField;
        
        private string parentPropertyNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
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
        [System.Xml.Serialization.XmlElementAttribute("UpdateResults", Order=1)]
        public UpdateResult[] UpdateResults
        {
            get
            {
                return this.updateResultsField;
            }
            set
            {
                this.updateResultsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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