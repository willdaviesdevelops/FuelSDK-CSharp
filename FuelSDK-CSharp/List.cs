namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class List : APIObject
    {
        
        private string listNameField;
        
        private int categoryField;
        
        private bool categoryFieldSpecified;
        
        private ListTypeEnum typeField;
        
        private bool typeFieldSpecified;
        
        private string descriptionField;
        
        private Subscriber[] subscribersField;
        
        private ListClassificationEnum listClassificationField;
        
        private bool listClassificationFieldSpecified;
        
        private Email automatedEmailField;
        
        private SendClassification sendClassificationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ListName
        {
            get
            {
                return this.listNameField;
            }
            set
            {
                this.listNameField = value;
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
        public ListTypeEnum Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
                this.typeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute("Subscribers", Order=4)]
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public ListClassificationEnum ListClassification
        {
            get
            {
                return this.listClassificationField;
            }
            set
            {
                this.listClassificationField = value;
                this.listClassificationFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListClassificationSpecified
        {
            get
            {
                return this.listClassificationFieldSpecified;
            }
            set
            {
                this.listClassificationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public Email AutomatedEmail
        {
            get
            {
                return this.automatedEmailField;
            }
            set
            {
                this.automatedEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public SendClassification SendClassification
        {
            get
            {
                return this.sendClassificationField;
            }
            set
            {
                this.sendClassificationField = value;
            }
        }
    }
}