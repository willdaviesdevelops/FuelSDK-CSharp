namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SendDefinitionList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriggeredSendExclusionList))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AudienceItem : APIObject
    {
        
        private List listField;
        
        private SendDefinitionListTypeEnum sendDefinitionListTypeField;
        
        private bool sendDefinitionListTypeFieldSpecified;
        
        private string customObjectIDField;
        
        private DataSourceTypeEnum dataSourceTypeIDField;
        
        private bool dataSourceTypeIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public List List
        {
            get
            {
                return this.listField;
            }
            set
            {
                this.listField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SendDefinitionListTypeEnum SendDefinitionListType
        {
            get
            {
                return this.sendDefinitionListTypeField;
            }
            set
            {
                this.sendDefinitionListTypeField = value;
                this.sendDefinitionListTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendDefinitionListTypeSpecified
        {
            get
            {
                return this.sendDefinitionListTypeFieldSpecified;
            }
            set
            {
                this.sendDefinitionListTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string CustomObjectID
        {
            get
            {
                return this.customObjectIDField;
            }
            set
            {
                this.customObjectIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public DataSourceTypeEnum DataSourceTypeID
        {
            get
            {
                return this.dataSourceTypeIDField;
            }
            set
            {
                this.dataSourceTypeIDField = value;
                this.dataSourceTypeIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataSourceTypeIDSpecified
        {
            get
            {
                return this.dataSourceTypeIDFieldSpecified;
            }
            set
            {
                this.dataSourceTypeIDFieldSpecified = value;
            }
        }
    }
}