namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class BounceEvent : TrackingEvent
    {
        
        private string sMTPCodeField;
        
        private string bounceCategoryField;
        
        private string sMTPReasonField;
        
        private string bounceTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string SMTPCode
        {
            get
            {
                return this.sMTPCodeField;
            }
            set
            {
                this.sMTPCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string BounceCategory
        {
            get
            {
                return this.bounceCategoryField;
            }
            set
            {
                this.bounceCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SMTPReason
        {
            get
            {
                return this.sMTPReasonField;
            }
            set
            {
                this.sMTPReasonField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string BounceType
        {
            get
            {
                return this.bounceTypeField;
            }
            set
            {
                this.bounceTypeField = value;
            }
        }
    }
}