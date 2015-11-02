namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SendEmailMOKeyword))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(HelpMOKeyword))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DoubleOptInMOKeyword))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnsubscribeFromSMSPublicationMOKeyword))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SendSMSMOKeyword))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class BaseMOKeyword : APIObject
    {
        
        private bool isDefaultKeywordField;
        
        private bool isDefaultKeywordFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool IsDefaultKeyword
        {
            get
            {
                return this.isDefaultKeywordField;
            }
            set
            {
                this.isDefaultKeywordField = value;
                this.isDefaultKeywordFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDefaultKeywordSpecified
        {
            get
            {
                return this.isDefaultKeywordFieldSpecified;
            }
            set
            {
                this.isDefaultKeywordFieldSpecified = value;
            }
        }
    }
}