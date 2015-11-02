namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ComplexFilterPart : FilterPart
    {
        
        private FilterPart leftOperandField;
        
        private LogicalOperators logicalOperatorField;
        
        private FilterPart rightOperandField;
        
        private FilterPart[] additionalOperandsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public FilterPart LeftOperand
        {
            get
            {
                return this.leftOperandField;
            }
            set
            {
                this.leftOperandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public LogicalOperators LogicalOperator
        {
            get
            {
                return this.logicalOperatorField;
            }
            set
            {
                this.logicalOperatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public FilterPart RightOperand
        {
            get
            {
                return this.rightOperandField;
            }
            set
            {
                this.rightOperandField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=3)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Operand", IsNullable=false)]
        public FilterPart[] AdditionalOperands
        {
            get
            {
                return this.additionalOperandsField;
            }
            set
            {
                this.additionalOperandsField = value;
            }
        }
    }
}