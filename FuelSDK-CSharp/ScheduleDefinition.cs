namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ScheduleDefinition : APIObject
    {
        
        private string nameField;
        
        private string descriptionField;
        
        private Recurrence recurrenceField;
        
        private RecurrenceTypeEnum recurrenceTypeField;
        
        private bool recurrenceTypeFieldSpecified;
        
        private RecurrenceRangeTypeEnum recurrenceRangeTypeField;
        
        private bool recurrenceRangeTypeFieldSpecified;
        
        private System.DateTime startDateTimeField;
        
        private bool startDateTimeFieldSpecified;
        
        private System.DateTime endDateTimeField;
        
        private bool endDateTimeFieldSpecified;
        
        private int occurrencesField;
        
        private bool occurrencesFieldSpecified;
        
        private string keywordField;
        
        private TimeZone timeZoneField;
        
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
        public Recurrence Recurrence
        {
            get
            {
                return this.recurrenceField;
            }
            set
            {
                this.recurrenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public RecurrenceTypeEnum RecurrenceType
        {
            get
            {
                return this.recurrenceTypeField;
            }
            set
            {
                this.recurrenceTypeField = value;
                this.recurrenceTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecurrenceTypeSpecified
        {
            get
            {
                return this.recurrenceTypeFieldSpecified;
            }
            set
            {
                this.recurrenceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public RecurrenceRangeTypeEnum RecurrenceRangeType
        {
            get
            {
                return this.recurrenceRangeTypeField;
            }
            set
            {
                this.recurrenceRangeTypeField = value;
                this.recurrenceRangeTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecurrenceRangeTypeSpecified
        {
            get
            {
                return this.recurrenceRangeTypeFieldSpecified;
            }
            set
            {
                this.recurrenceRangeTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public System.DateTime StartDateTime
        {
            get
            {
                return this.startDateTimeField;
            }
            set
            {
                this.startDateTimeField = value;
                this.startDateTimeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartDateTimeSpecified
        {
            get
            {
                return this.startDateTimeFieldSpecified;
            }
            set
            {
                this.startDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public System.DateTime EndDateTime
        {
            get
            {
                return this.endDateTimeField;
            }
            set
            {
                this.endDateTimeField = value;
                this.endDateTimeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDateTimeSpecified
        {
            get
            {
                return this.endDateTimeFieldSpecified;
            }
            set
            {
                this.endDateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int Occurrences
        {
            get
            {
                return this.occurrencesField;
            }
            set
            {
                this.occurrencesField = value;
                this.occurrencesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccurrencesSpecified
        {
            get
            {
                return this.occurrencesFieldSpecified;
            }
            set
            {
                this.occurrencesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string Keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public TimeZone TimeZone
        {
            get
            {
                return this.timeZoneField;
            }
            set
            {
                this.timeZoneField = value;
            }
        }
    }
}