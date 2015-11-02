namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class FieldMap
    {
        
        private object itemField;
        
        private string destinationNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SourceName", typeof(string), Order=0)]
        [System.Xml.Serialization.XmlElementAttribute("SourceOrdinal", typeof(int), Order=0)]
        public object Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DestinationName
        {
            get
            {
                return this.destinationNameField;
            }
            set
            {
                this.destinationNameField = value;
            }
        }
    }
}