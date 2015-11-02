namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SendSMSMOKeyword : BaseMOKeyword
    {
        
        private BaseMOKeyword nextMOKeywordField;
        
        private string messageField;
        
        private string scriptErrorMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public BaseMOKeyword NextMOKeyword
        {
            get
            {
                return this.nextMOKeywordField;
            }
            set
            {
                this.nextMOKeywordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ScriptErrorMessage
        {
            get
            {
                return this.scriptErrorMessageField;
            }
            set
            {
                this.scriptErrorMessageField = value;
            }
        }
    }
}