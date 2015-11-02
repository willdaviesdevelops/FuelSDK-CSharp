namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ListSubscriber : APIObject
    {
        
        private SubscriberStatus statusField;
        
        private bool statusFieldSpecified;
        
        private int listIDField;
        
        private bool listIDFieldSpecified;
        
        private string subscriberKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SubscriberStatus Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
                this.statusFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int ListID
        {
            get
            {
                return this.listIDField;
            }
            set
            {
                this.listIDField = value;
                this.listIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListIDSpecified
        {
            get
            {
                return this.listIDFieldSpecified;
            }
            set
            {
                this.listIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string SubscriberKey
        {
            get
            {
                return this.subscriberKeyField;
            }
            set
            {
                this.subscriberKeyField = value;
            }
        }
    }
}