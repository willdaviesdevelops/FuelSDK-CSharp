namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Link : APIObject
    {
        
        private System.DateTime lastClickedField;
        
        private bool lastClickedFieldSpecified;
        
        private string aliasField;
        
        private int totalClicksField;
        
        private bool totalClicksFieldSpecified;
        
        private int uniqueClicksField;
        
        private bool uniqueClicksFieldSpecified;
        
        private string uRLField;
        
        private TrackingEvent[] subscribersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public System.DateTime LastClicked
        {
            get
            {
                return this.lastClickedField;
            }
            set
            {
                this.lastClickedField = value;
                this.lastClickedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastClickedSpecified
        {
            get
            {
                return this.lastClickedFieldSpecified;
            }
            set
            {
                this.lastClickedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Alias
        {
            get
            {
                return this.aliasField;
            }
            set
            {
                this.aliasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int TotalClicks
        {
            get
            {
                return this.totalClicksField;
            }
            set
            {
                this.totalClicksField = value;
                this.totalClicksFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalClicksSpecified
        {
            get
            {
                return this.totalClicksFieldSpecified;
            }
            set
            {
                this.totalClicksFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int UniqueClicks
        {
            get
            {
                return this.uniqueClicksField;
            }
            set
            {
                this.uniqueClicksField = value;
                this.uniqueClicksFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UniqueClicksSpecified
        {
            get
            {
                return this.uniqueClicksFieldSpecified;
            }
            set
            {
                this.uniqueClicksFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subscribers", Order=5)]
        public TrackingEvent[] Subscribers
        {
            get
            {
                return this.subscribersField;
            }
            set
            {
                this.subscribersField = value;
            }
        }
    }
}