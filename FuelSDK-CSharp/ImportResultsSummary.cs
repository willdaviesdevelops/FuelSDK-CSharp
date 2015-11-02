namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ImportResultsSummary : APIObject
    {
        
        private string importDefinitionCustomerKeyField;
        
        private string startDateField;
        
        private string endDateField;
        
        private string destinationIDField;
        
        private int numberSuccessfulField;
        
        private bool numberSuccessfulFieldSpecified;
        
        private int numberDuplicatedField;
        
        private bool numberDuplicatedFieldSpecified;
        
        private int numberErrorsField;
        
        private bool numberErrorsFieldSpecified;
        
        private int totalRowsField;
        
        private bool totalRowsFieldSpecified;
        
        private string importTypeField;
        
        private string importStatusField;
        
        private int taskResultIDField;
        
        private bool taskResultIDFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ImportDefinitionCustomerKey
        {
            get
            {
                return this.importDefinitionCustomerKeyField;
            }
            set
            {
                this.importDefinitionCustomerKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string StartDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string DestinationID
        {
            get
            {
                return this.destinationIDField;
            }
            set
            {
                this.destinationIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int NumberSuccessful
        {
            get
            {
                return this.numberSuccessfulField;
            }
            set
            {
                this.numberSuccessfulField = value;
                this.numberSuccessfulFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberSuccessfulSpecified
        {
            get
            {
                return this.numberSuccessfulFieldSpecified;
            }
            set
            {
                this.numberSuccessfulFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int NumberDuplicated
        {
            get
            {
                return this.numberDuplicatedField;
            }
            set
            {
                this.numberDuplicatedField = value;
                this.numberDuplicatedFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberDuplicatedSpecified
        {
            get
            {
                return this.numberDuplicatedFieldSpecified;
            }
            set
            {
                this.numberDuplicatedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int NumberErrors
        {
            get
            {
                return this.numberErrorsField;
            }
            set
            {
                this.numberErrorsField = value;
                this.numberErrorsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberErrorsSpecified
        {
            get
            {
                return this.numberErrorsFieldSpecified;
            }
            set
            {
                this.numberErrorsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int TotalRows
        {
            get
            {
                return this.totalRowsField;
            }
            set
            {
                this.totalRowsField = value;
                this.totalRowsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalRowsSpecified
        {
            get
            {
                return this.totalRowsFieldSpecified;
            }
            set
            {
                this.totalRowsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string ImportType
        {
            get
            {
                return this.importTypeField;
            }
            set
            {
                this.importTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string ImportStatus
        {
            get
            {
                return this.importStatusField;
            }
            set
            {
                this.importStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int TaskResultID
        {
            get
            {
                return this.taskResultIDField;
            }
            set
            {
                this.taskResultIDField = value;
                this.taskResultIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TaskResultIDSpecified
        {
            get
            {
                return this.taskResultIDFieldSpecified;
            }
            set
            {
                this.taskResultIDFieldSpecified = value;
            }
        }
    }
}