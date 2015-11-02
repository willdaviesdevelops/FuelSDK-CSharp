namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class PrivateLabel
    {
        
        private System.Nullable<int> idField;
        
        private string nameField;
        
        private string colorPaletteXMLField;
        
        private string logoFileField;
        
        private int deleteField;
        
        private bool setActiveField;
        
        private bool setActiveFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ColorPaletteXML
        {
            get
            {
                return this.colorPaletteXMLField;
            }
            set
            {
                this.colorPaletteXMLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string LogoFile
        {
            get
            {
                return this.logoFileField;
            }
            set
            {
                this.logoFileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int Delete
        {
            get
            {
                return this.deleteField;
            }
            set
            {
                this.deleteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool SetActive
        {
            get
            {
                return this.setActiveField;
            }
            set
            {
                this.setActiveField = value;
                this.setActiveFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SetActiveSpecified
        {
            get
            {
                return this.setActiveFieldSpecified;
            }
            set
            {
                this.setActiveFieldSpecified = value;
            }
        }
    }
}