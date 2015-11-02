namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ContentArea : APIObject
    {
        
        private string keyField;
        
        private string contentField;
        
        private bool isBlankField;
        
        private bool isBlankFieldSpecified;
        
        private int categoryIDField;
        
        private bool categoryIDFieldSpecified;
        
        private string nameField;
        
        private LayoutType layoutField;
        
        private bool layoutFieldSpecified;
        
        private bool isDynamicContentField;
        
        private bool isDynamicContentFieldSpecified;
        
        private bool isSurveyField;
        
        private bool isSurveyFieldSpecified;
        
        private string backgroundColorField;
        
        private string borderColorField;
        
        private int borderWidthField;
        
        private bool borderWidthFieldSpecified;
        
        private int cellpaddingField;
        
        private bool cellpaddingFieldSpecified;
        
        private int cellspacingField;
        
        private bool cellspacingFieldSpecified;
        
        private string widthField;
        
        private string fontFamilyField;
        
        private bool hasFontSizeField;
        
        private bool hasFontSizeFieldSpecified;
        
        private bool isLockedField;
        
        private bool isLockedFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IsBlank
        {
            get
            {
                return this.isBlankField;
            }
            set
            {
                this.isBlankField = value;
                this.isBlankFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsBlankSpecified
        {
            get
            {
                return this.isBlankFieldSpecified;
            }
            set
            {
                this.isBlankFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
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
        public LayoutType Layout
        {
            get
            {
                return this.layoutField;
            }
            set
            {
                this.layoutField = value;
                this.layoutFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LayoutSpecified
        {
            get
            {
                return this.layoutFieldSpecified;
            }
            set
            {
                this.layoutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool IsDynamicContent
        {
            get
            {
                return this.isDynamicContentField;
            }
            set
            {
                this.isDynamicContentField = value;
                this.isDynamicContentFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsDynamicContentSpecified
        {
            get
            {
                return this.isDynamicContentFieldSpecified;
            }
            set
            {
                this.isDynamicContentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool IsSurvey
        {
            get
            {
                return this.isSurveyField;
            }
            set
            {
                this.isSurveyField = value;
                this.isSurveyFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSurveySpecified
        {
            get
            {
                return this.isSurveyFieldSpecified;
            }
            set
            {
                this.isSurveyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string BackgroundColor
        {
            get
            {
                return this.backgroundColorField;
            }
            set
            {
                this.backgroundColorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string BorderColor
        {
            get
            {
                return this.borderColorField;
            }
            set
            {
                this.borderColorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int BorderWidth
        {
            get
            {
                return this.borderWidthField;
            }
            set
            {
                this.borderWidthField = value;
                this.borderWidthFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BorderWidthSpecified
        {
            get
            {
                return this.borderWidthFieldSpecified;
            }
            set
            {
                this.borderWidthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int Cellpadding
        {
            get
            {
                return this.cellpaddingField;
            }
            set
            {
                this.cellpaddingField = value;
                this.cellpaddingFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CellpaddingSpecified
        {
            get
            {
                return this.cellpaddingFieldSpecified;
            }
            set
            {
                this.cellpaddingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public int Cellspacing
        {
            get
            {
                return this.cellspacingField;
            }
            set
            {
                this.cellspacingField = value;
                this.cellspacingFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CellspacingSpecified
        {
            get
            {
                return this.cellspacingFieldSpecified;
            }
            set
            {
                this.cellspacingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string Width
        {
            get
            {
                return this.widthField;
            }
            set
            {
                this.widthField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string FontFamily
        {
            get
            {
                return this.fontFamilyField;
            }
            set
            {
                this.fontFamilyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public bool HasFontSize
        {
            get
            {
                return this.hasFontSizeField;
            }
            set
            {
                this.hasFontSizeField = value;
                this.hasFontSizeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasFontSizeSpecified
        {
            get
            {
                return this.hasFontSizeFieldSpecified;
            }
            set
            {
                this.hasFontSizeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public bool IsLocked
        {
            get
            {
                return this.isLockedField;
            }
            set
            {
                this.isLockedField = value;
                this.isLockedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsLockedSpecified
        {
            get
            {
                return this.isLockedFieldSpecified;
            }
            set
            {
                this.isLockedFieldSpecified = value;
            }
        }
    }
}