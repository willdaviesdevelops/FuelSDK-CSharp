namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class DataExtension : APIObject
    {
        
        private string nameField;
        
        private string descriptionField;
        
        private bool isSendableField;
        
        private bool isSendableFieldSpecified;
        
        private bool isTestableField;
        
        private bool isTestableFieldSpecified;
        
        private DataExtensionField sendableDataExtensionFieldField;
        
        private Attribute sendableSubscriberFieldField;
        
        private DataExtensionTemplate templateField;
        
        private int dataRetentionPeriodLengthField;
        
        private bool dataRetentionPeriodLengthFieldSpecified;
        
        private int dataRetentionPeriodUnitOfMeasureField;
        
        private bool dataRetentionPeriodUnitOfMeasureFieldSpecified;
        
        private bool rowBasedRetentionField;
        
        private bool rowBasedRetentionFieldSpecified;
        
        private bool resetRetentionPeriodOnImportField;
        
        private bool resetRetentionPeriodOnImportFieldSpecified;
        
        private bool deleteAtEndOfRetentionPeriodField;
        
        private bool deleteAtEndOfRetentionPeriodFieldSpecified;
        
        private string retainUntilField;
        
        private DataExtensionField[] fieldsField;
        
        private DateTimeUnitOfMeasure dataRetentionPeriodField;
        
        private bool dataRetentionPeriodFieldSpecified;
        
        private long categoryIDField;
        
        private bool categoryIDFieldSpecified;
        
        private string statusField;
        
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IsSendable
        {
            get
            {
                return this.isSendableField;
            }
            set
            {
                this.isSendableField = value;
                this.isSendableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSendableSpecified
        {
            get
            {
                return this.isSendableFieldSpecified;
            }
            set
            {
                this.isSendableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool IsTestable
        {
            get
            {
                return this.isTestableField;
            }
            set
            {
                this.isTestableField = value;
                this.isTestableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsTestableSpecified
        {
            get
            {
                return this.isTestableFieldSpecified;
            }
            set
            {
                this.isTestableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public DataExtensionField SendableDataExtensionField
        {
            get
            {
                return this.sendableDataExtensionFieldField;
            }
            set
            {
                this.sendableDataExtensionFieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public Attribute SendableSubscriberField
        {
            get
            {
                return this.sendableSubscriberFieldField;
            }
            set
            {
                this.sendableSubscriberFieldField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public DataExtensionTemplate Template
        {
            get
            {
                return this.templateField;
            }
            set
            {
                this.templateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int DataRetentionPeriodLength
        {
            get
            {
                return this.dataRetentionPeriodLengthField;
            }
            set
            {
                this.dataRetentionPeriodLengthField = value;
                this.dataRetentionPeriodLengthFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataRetentionPeriodLengthSpecified
        {
            get
            {
                return this.dataRetentionPeriodLengthFieldSpecified;
            }
            set
            {
                this.dataRetentionPeriodLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public int DataRetentionPeriodUnitOfMeasure
        {
            get
            {
                return this.dataRetentionPeriodUnitOfMeasureField;
            }
            set
            {
                this.dataRetentionPeriodUnitOfMeasureField = value;
                this.dataRetentionPeriodUnitOfMeasureFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataRetentionPeriodUnitOfMeasureSpecified
        {
            get
            {
                return this.dataRetentionPeriodUnitOfMeasureFieldSpecified;
            }
            set
            {
                this.dataRetentionPeriodUnitOfMeasureFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool RowBasedRetention
        {
            get
            {
                return this.rowBasedRetentionField;
            }
            set
            {
                this.rowBasedRetentionField = value;
                this.rowBasedRetentionFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RowBasedRetentionSpecified
        {
            get
            {
                return this.rowBasedRetentionFieldSpecified;
            }
            set
            {
                this.rowBasedRetentionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool ResetRetentionPeriodOnImport
        {
            get
            {
                return this.resetRetentionPeriodOnImportField;
            }
            set
            {
                this.resetRetentionPeriodOnImportField = value;
                this.resetRetentionPeriodOnImportFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResetRetentionPeriodOnImportSpecified
        {
            get
            {
                return this.resetRetentionPeriodOnImportFieldSpecified;
            }
            set
            {
                this.resetRetentionPeriodOnImportFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool DeleteAtEndOfRetentionPeriod
        {
            get
            {
                return this.deleteAtEndOfRetentionPeriodField;
            }
            set
            {
                this.deleteAtEndOfRetentionPeriodField = value;
                this.deleteAtEndOfRetentionPeriodFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeleteAtEndOfRetentionPeriodSpecified
        {
            get
            {
                return this.deleteAtEndOfRetentionPeriodFieldSpecified;
            }
            set
            {
                this.deleteAtEndOfRetentionPeriodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public string RetainUntil
        {
            get
            {
                return this.retainUntilField;
            }
            set
            {
                this.retainUntilField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=13)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Field", IsNullable=false)]
        public DataExtensionField[] Fields
        {
            get
            {
                return this.fieldsField;
            }
            set
            {
                this.fieldsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public DateTimeUnitOfMeasure DataRetentionPeriod
        {
            get
            {
                return this.dataRetentionPeriodField;
            }
            set
            {
                this.dataRetentionPeriodField = value;
                this.dataRetentionPeriodFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DataRetentionPeriodSpecified
        {
            get
            {
                return this.dataRetentionPeriodFieldSpecified;
            }
            set
            {
                this.dataRetentionPeriodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public long CategoryID
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
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
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
    }
}