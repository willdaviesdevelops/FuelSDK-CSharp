namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AutomationSource
    {
        
        private string automationSourceIDField;
        
        private string automationSourceTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string AutomationSourceID
        {
            get
            {
                return this.automationSourceIDField;
            }
            set
            {
                this.automationSourceIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string AutomationSourceType
        {
            get
            {
                return this.automationSourceTypeField;
            }
            set
            {
                this.automationSourceTypeField = value;
            }
        }
    }
}