namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SimpleFilterPart : FilterPart
    {
        
        private string propertyField;
        
        private SimpleOperators simpleOperatorField;
        
        private string[] valueField;
        
        private System.DateTime[] dateValueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public SimpleOperators SimpleOperator
        {
            get
            {
                return this.simpleOperatorField;
            }
            set
            {
                this.simpleOperatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value", Order=2)]
        public string[] Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DateValue", Order=3)]
        public System.DateTime[] DateValue
        {
            get
            {
                return this.dateValueField;
            }
            set
            {
                this.dateValueField = value;
            }
        }
    }
}