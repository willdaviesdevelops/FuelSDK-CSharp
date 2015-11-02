namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class HelpMOKeyword : BaseMOKeyword
    {
        
        private string friendlyNameField;
        
        private string defaultHelpMessageField;
        
        private string menuTextField;
        
        private string moreChoicesPromptField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string FriendlyName
        {
            get
            {
                return this.friendlyNameField;
            }
            set
            {
                this.friendlyNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string DefaultHelpMessage
        {
            get
            {
                return this.defaultHelpMessageField;
            }
            set
            {
                this.defaultHelpMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string MenuText
        {
            get
            {
                return this.menuTextField;
            }
            set
            {
                this.menuTextField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string MoreChoicesPrompt
        {
            get
            {
                return this.moreChoicesPromptField;
            }
            set
            {
                this.moreChoicesPromptField = value;
            }
        }
    }
}