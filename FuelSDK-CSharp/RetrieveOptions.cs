namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class RetrieveOptions : Options
    {
        
        private int batchSizeField;
        
        private bool batchSizeFieldSpecified;
        
        private bool includeObjectsField;
        
        private bool includeObjectsFieldSpecified;
        
        private bool onlyIncludeBaseField;
        
        private bool onlyIncludeBaseFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int BatchSize
        {
            get
            {
                return this.batchSizeField;
            }
            set
            {
                this.batchSizeField = value;
                this.batchSizeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BatchSizeSpecified
        {
            get
            {
                return this.batchSizeFieldSpecified;
            }
            set
            {
                this.batchSizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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