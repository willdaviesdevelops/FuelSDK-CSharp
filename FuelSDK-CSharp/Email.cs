namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Email : APIObject
    {
        
        private string nameField;
        
        private string folderField;
        
        private int categoryIDField;
        
        private bool categoryIDFieldSpecified;
        
        private string hTMLBodyField;
        
        private string textBodyField;
        
        private ContentArea[] contentAreasField;
        
        private string subjectField;
        
        private bool isActiveField;
        
        private bool isActiveFieldSpecified;
        
        private bool isHTMLPasteField;
        
        private bool isHTMLPasteFieldSpecified;
        
        private int clonedFromIDField;
        
        private bool clonedFromIDFieldSpecified;
        
        private string statusField;
        
        private string emailTypeField;
        
        private string characterSetField;
        
        private bool hasDynamicSubjectLineField;
        
        private bool hasDynamicSubjectLineFieldSpecified;
        
        private string contentCheckStatusField;
        
        private bool syncTextWithHTMLField;
        
        private bool syncTextWithHTMLFieldSpecified;
        
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
        public string Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int CategoryID
        {
            get
            {
                return this.categoryIDField;
            }
            set
            {
                this.categoryIDField = value;
                this.categoryIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategoryIDSpecified
        {
            get
            {
                return this.categoryIDFieldSpecified;
            }
            set
            {
                this.categoryIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string HTMLBody
        {
            get
            {
                return this.hTMLBodyField;
            }
            set
            {
                this.hTMLBodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string TextBody
        {
            get
            {
                return this.textBodyField;
            }
            set
            {
                this.textBodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ContentAreas", Order=5)]
        public ContentArea[] ContentAreas
        {
            get
            {
                return this.contentAreasField;
            }
            set
            {
                this.contentAreasField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
                this.isActiveFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsActiveSpecified
        {
            get
            {
                return this.isActiveFieldSpecified;
            }
            set
            {
                this.isActiveFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool IsHTMLPaste
        {
            get
            {
                return this.isHTMLPasteField;
            }
            set
            {
                this.isHTMLPasteField = value;
                this.isHTMLPasteFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsHTMLPasteSpecified
        {
            get
            {
                return this.isHTMLPasteFieldSpecified;
            }
            set
            {
                this.isHTMLPasteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int ClonedFromID
        {
            get
            {
                return this.clonedFromIDField;
            }
            set
            {
                this.clonedFromIDField = value;
                this.clonedFromIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClonedFromIDSpecified
        {
            get
            {
                return this.clonedFromIDFieldSpecified;
            }
            set
            {
                this.clonedFromIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string EmailType
        {
            get
            {
                return this.emailTypeField;
            }
            set
            {
                this.emailTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string CharacterSet
        {
            get
            {
                return this.characterSetField;
            }
            set
            {
                this.characterSetField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public bool HasDynamicSubjectLine
        {
            get
            {
                return this.hasDynamicSubjectLineField;
            }
            set
            {
                this.hasDynamicSubjectLineField = value;
                this.hasDynamicSubjectLineFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasDynamicSubjectLineSpecified
        {
            get
            {
                return this.hasDynamicSubjectLineFieldSpecified;
            }
            set
            {
                this.hasDynamicSubjectLineFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string ContentCheckStatus
        {
            get
            {
                return this.contentCheckStatusField;
            }
            set
            {
                this.contentCheckStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public bool SyncTextWithHTML
        {
            get
            {
                return this.syncTextWithHTMLField;
            }
            set
            {
                this.syncTextWithHTMLField = value;
                this.syncTextWithHTMLFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SyncTextWithHTMLSpecified
        {
            get
            {
                return this.syncTextWithHTMLFieldSpecified;
            }
            set
            {
                this.syncTextWithHTMLFieldSpecified = value;
            }
        }
    }
}