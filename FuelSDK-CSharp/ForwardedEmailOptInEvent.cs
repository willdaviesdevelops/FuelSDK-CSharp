namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ForwardedEmailOptInEvent : TrackingEvent
    {
        
        private string optInSubscriberKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string OptInSubscriberKey
        {
            get
            {
                return this.optInSubscriberKeyField;
            }
            set
            {
                this.optInSubscriberKeyField = value;
            }
        }
    }
}