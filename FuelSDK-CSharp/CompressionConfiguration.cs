namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class CompressionConfiguration
    {
        
        private CompressionType typeField;
        
        private bool typeFieldSpecified;
        
        private CompressionEncoding encodingField;
        
        private bool encodingFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public CompressionType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.typeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public CompressionEncoding Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
                this.encodingFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EncodingSpecified
        {
            get
            {
                return this.encodingFieldSpecified;
            }
            set
            {
                this.encodingFieldSpecified = value;
            }
        }
    }
}