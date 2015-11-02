namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class Portfolio : APIObject
    {
        
        private ResourceSpecification sourceField;
        
        private int categoryIDField;
        
        private bool categoryIDFieldSpecified;
        
        private string fileNameField;
        
        private string displayNameField;
        
        private string descriptionField;
        
        private string typeDescriptionField;
        
        private bool isUploadedField;
        
        private bool isUploadedFieldSpecified;
        
        private bool isActiveField;
        
        private bool isActiveFieldSpecified;
        
        private int fileSizeKBField;
        
        private bool fileSizeKBFieldSpecified;
        
        private int thumbSizeKBField;
        
        private bool thumbSizeKBFieldSpecified;
        
        private int fileWidthPXField;
        
        private bool fileWidthPXFieldSpecified;
        
        private int fileHeightPXField;
        
        private bool fileHeightPXFieldSpecified;
        
        private string fileURLField;
        
        private string thumbURLField;
        
        private System.DateTime cacheClearTimeField;
        
        private bool cacheClearTimeFieldSpecified;
        
        private string categoryTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ResourceSpecification Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string FileName
        {
            get
            {
                return this.fileNameField;
            }
            set
            {
                this.fileNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string TypeDescription
        {
            get
            {
                return this.typeDescriptionField;
            }
            set
            {
                this.typeDescriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool IsUploaded
        {
            get
            {
                return this.isUploadedField;
            }
            set
            {
                this.isUploadedField = value;
                this.isUploadedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsUploadedSpecified
        {
            get
            {
                return this.isUploadedFieldSpecified;
            }
            set
            {
                this.isUploadedFieldSpecified = value;
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
        public int FileSizeKB
        {
            get
            {
                return this.fileSizeKBField;
            }
            set
            {
                this.fileSizeKBField = value;
                this.fileSizeKBFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FileSizeKBSpecified
        {
            get
            {
                return this.fileSizeKBFieldSpecified;
            }
            set
            {
                this.fileSizeKBFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int ThumbSizeKB
        {
            get
            {
                return this.thumbSizeKBField;
            }
            set
            {
                this.thumbSizeKBField = value;
                this.thumbSizeKBFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThumbSizeKBSpecified
        {
            get
            {
                return this.thumbSizeKBFieldSpecified;
            }
            set
            {
                this.thumbSizeKBFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int FileWidthPX
        {
            get
            {
                return this.fileWidthPXField;
            }
            set
            {
                this.fileWidthPXField = value;
                this.fileWidthPXFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FileWidthPXSpecified
        {
            get
            {
                return this.fileWidthPXFieldSpecified;
            }
            set
            {
                this.fileWidthPXFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int FileHeightPX
        {
            get
            {
                return this.fileHeightPXField;
            }
            set
            {
                this.fileHeightPXField = value;
                this.fileHeightPXFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FileHeightPXSpecified
        {
            get
            {
                return this.fileHeightPXFieldSpecified;
            }
            set
            {
                this.fileHeightPXFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string FileURL
        {
            get
            {
                return this.fileURLField;
            }
            set
            {
                this.fileURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string ThumbURL
        {
            get
            {
                return this.thumbURLField;
            }
            set
            {
                this.thumbURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public System.DateTime CacheClearTime
        {
            get
            {
                return this.cacheClearTimeField;
            }
            set
            {
                this.cacheClearTimeField = value;
                this.cacheClearTimeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CacheClearTimeSpecified
        {
            get
            {
                return this.cacheClearTimeFieldSpecified;
            }
            set
            {
                this.cacheClearTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string CategoryType
        {
            get
            {
                return this.categoryTypeField;
            }
            set
            {
                this.categoryTypeField = value;
            }
        }
    }
}