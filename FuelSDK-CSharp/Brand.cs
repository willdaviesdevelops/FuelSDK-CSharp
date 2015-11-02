namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Brand : APIObject
    {
        
        private int brandIDField;
        
        private bool brandIDFieldSpecified;
        
        private string labelField;
        
        private string commentField;
        
        private BrandTag[] brandTagsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int BrandID
        {
            get
            {
                return this.brandIDField;
            }
            set
            {
                this.brandIDField = value;
                this.brandIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BrandIDSpecified
        {
            get
            {
                return this.brandIDFieldSpecified;
            }
            set
            {
                this.brandIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Comment
        {
            get
            {
                return this.commentField;
            }
            set
            {
                this.commentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BrandTags", IsNullable=true, Order=3)]
        public BrandTag[] BrandTags
        {
            get
            {
                return this.brandTagsField;
            }
            set
            {
                this.brandTagsField = value;
            }
        }
    }
}