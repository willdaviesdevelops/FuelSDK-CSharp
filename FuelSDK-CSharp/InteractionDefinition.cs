namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Automation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AutomationInstance))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(QueryDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FileTransferActivity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GroupDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImportDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ReportActivity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobilePushSendMessageActivity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileConnectSendSmsActivity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MobileConnectRefreshListActivity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SmsSendActivity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(MessageSendActivity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataExtractActivity))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SendDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EmailSendDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SMSTriggeredSendDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VoiceTriggeredSendDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TriggeredSendDefinition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Campaign))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class InteractionDefinition : InteractionBaseObject
    {
        
        private string interactionObjectIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string InteractionObjectID
        {
            get
            {
                return this.interactionObjectIDField;
            }
            set
            {
                this.interactionObjectIDField = value;
            }
        }
    }
}