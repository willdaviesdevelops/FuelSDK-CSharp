namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Group : APIObject
    {
        
        private string nameField;
        
        private int categoryField;
        
        private bool categoryFieldSpecified;
        
        private string descriptionField;
        
        private Subscriber[] subscribersField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
                this.categoryFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategorySpecified
        {
            get
            {
                return this.categoryFieldSpecified;
            }
            set
            {
                this.categoryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Subscribers", Order=3)]
        public Subscriber[] Subscribers
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