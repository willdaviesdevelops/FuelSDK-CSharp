namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ExtractDescription : ExtractTemplate
    {
        
        private ExtractParameterDescription[] parametersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Parameter", IsNullable=false)]
        public ExtractParameterDescription[] Parameters
        {
            get
            {
                return this.parametersField;
            }
            set
            {
                this.parametersField = value;
            }
        }
    }
}