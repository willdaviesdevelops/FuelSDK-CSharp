namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class MonthlyRecurrence : Recurrence
    {
        
        private MonthlyRecurrencePatternTypeEnum monthlyRecurrencePatternTypeField;
        
        private bool monthlyRecurrencePatternTypeFieldSpecified;
        
        private int monthlyIntervalField;
        
        private bool monthlyIntervalFieldSpecified;
        
        private int scheduledDayField;
        
        private bool scheduledDayFieldSpecified;
        
        private WeekOfMonthEnum scheduledWeekField;
        
        private bool scheduledWeekFieldSpecified;
        
        private DayOfWeekEnum scheduledDayOfWeekField;
        
        private bool scheduledDayOfWeekFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public MonthlyRecurrencePatternTypeEnum MonthlyRecurrencePatternType
        {
            get
            {
                return this.monthlyRecurrencePatternTypeField;
            }
            set
            {
                this.monthlyRecurrencePatternTypeField = value;
                this.monthlyRecurrencePatternTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MonthlyRecurrencePatternTypeSpecified
        {
            get
            {
                return this.monthlyRecurrencePatternTypeFieldSpecified;
            }
            set
            {
                this.monthlyRecurrencePatternTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int MonthlyInterval
        {
            get
            {
                return this.monthlyIntervalField;
            }
            set
            {
                this.monthlyIntervalField = value;
                this.monthlyIntervalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MonthlyIntervalSpecified
        {
            get
            {
                return this.monthlyIntervalFieldSpecified;
            }
            set
            {
                this.monthlyIntervalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int ScheduledDay
        {
            get
            {
                return this.scheduledDayField;
            }
            set
            {
                this.scheduledDayField = value;
                this.scheduledDayFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduledDaySpecified
        {
            get
            {
                return this.scheduledDayFieldSpecified;
            }
            set
            {
                this.scheduledDayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public WeekOfMonthEnum ScheduledWeek
        {
            get
            {
                return this.scheduledWeekField;
            }
            set
            {
                this.scheduledWeekField = value;
                this.scheduledWeekFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduledWeekSpecified
        {
            get
            {
                return this.scheduledWeekFieldSpecified;
            }
            set
            {
                this.scheduledWeekFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public DayOfWeekEnum ScheduledDayOfWeek
        {
            get
            {
                return this.scheduledDayOfWeekField;
            }
            set
            {
                this.scheduledDayOfWeekField = value;
                this.scheduledDayOfWeekFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduledDayOfWeekSpecified
        {
            get
            {
                return this.scheduledDayOfWeekFieldSpecified;
            }
            set
            {
                this.scheduledDayOfWeekFieldSpecified = value;
            }
        }
    }
}