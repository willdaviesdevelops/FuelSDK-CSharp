namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class BusinessRule : APIObject
    {
        
        private int memberBusinessRuleIDField;
        
        private int businessRuleIDField;
        
        private int dataField;
        
        private string qualityField;
        
        private string nameField;
        
        private string typeField;
        
        private string descriptionField;
        
        private bool isViewableField;
        
        private bool isViewableFieldSpecified;
        
        private bool isInheritedFromParentField;
        
        private bool isInheritedFromParentFieldSpecified;
        
        private string displayNameField;
        
        private string productCodeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int MemberBusinessRuleID
        {
            get
            {
                return this.memberBusinessRuleIDField;
            }
            set
            {
                this.memberBusinessRuleIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int BusinessRuleID
        {
            get
            {
                return this.businessRuleIDField;
            }
            set
            {
                this.businessRuleIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int Data
        {
            get
            {
                return this.dataField;
            }
            set
            {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Quality
        {
            get
            {
                return this.qualityField;
            }
            set
            {
                this.qualityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool IsViewable
        {
            get
            {
                return this.isViewableField;
            }
            set
            {
                this.isViewableField = value;
                this.isViewableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsViewableSpecified
        {
            get
            {
                return this.isViewableFieldSpecified;
            }
            set
            {
                this.isViewableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool IsInheritedFromParent
        {
            get
            {
                return this.isInheritedFromParentField;
            }
            set
            {
                this.isInheritedFromParentField = value;
                this.isInheritedFromParentFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsInheritedFromParentSpecified
        {
            get
            {
                return this.isInheritedFromParentFieldSpecified;
            }
            set
            {
                this.isInheritedFromParentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string DisplayName
        {
            get
            {
                return this.displayNameField;
            }
            set
            {
                this.displayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string ProductCode
        {
            get
            {
                return this.productCodeField;
            }
            set
            {
                this.productCodeField = value;
            }
        }
    }
}