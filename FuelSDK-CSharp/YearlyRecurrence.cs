namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class YearlyRecurrence : Recurrence
    {
        
        private YearlyRecurrencePatternTypeEnum yearlyRecurrencePatternTypeField;
        
        private bool yearlyRecurrencePatternTypeFieldSpecified;
        
        private int scheduledDayField;
        
        private bool scheduledDayFieldSpecified;
        
        private WeekOfMonthEnum scheduledWeekField;
        
        private bool scheduledWeekFieldSpecified;
        
        private MonthOfYearEnum scheduledMonthField;
        
        private bool scheduledMonthFieldSpecified;
        
        private DayOfWeekEnum scheduledDayOfWeekField;
        
        private bool scheduledDayOfWeekFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public YearlyRecurrencePatternTypeEnum YearlyRecurrencePatternType
        {
            get
            {
                return this.yearlyRecurrencePatternTypeField;
            }
            set
            {
                this.yearlyRecurrencePatternTypeField = value;
                this.yearlyRecurrencePatternTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool YearlyRecurrencePatternTypeSpecified
        {
            get
            {
                return this.yearlyRecurrencePatternTypeFieldSpecified;
            }
            set
            {
                this.yearlyRecurrencePatternTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public MonthOfYearEnum ScheduledMonth
        {
            get
            {
                return this.scheduledMonthField;
            }
            set
            {
                this.scheduledMonthField = value;
                this.scheduledMonthFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScheduledMonthSpecified
        {
            get
            {
                return this.scheduledMonthFieldSpecified;
            }
            set
            {
                this.scheduledMonthFieldSpecified = value;
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