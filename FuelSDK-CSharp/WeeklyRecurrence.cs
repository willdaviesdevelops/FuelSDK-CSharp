namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class WeeklyRecurrence : Recurrence
    {
        
        private WeeklyRecurrencePatternTypeEnum weeklyRecurrencePatternTypeField;
        
        private bool weeklyRecurrencePatternTypeFieldSpecified;
        
        private int weekIntervalField;
        
        private bool weekIntervalFieldSpecified;
        
        private bool sundayField;
        
        private bool sundayFieldSpecified;
        
        private bool mondayField;
        
        private bool mondayFieldSpecified;
        
        private bool tuesdayField;
        
        private bool tuesdayFieldSpecified;
        
        private bool wednesdayField;
        
        private bool wednesdayFieldSpecified;
        
        private bool thursdayField;
        
        private bool thursdayFieldSpecified;
        
        private bool fridayField;
        
        private bool fridayFieldSpecified;
        
        private bool saturdayField;
        
        private bool saturdayFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public WeeklyRecurrencePatternTypeEnum WeeklyRecurrencePatternType
        {
            get
            {
                return this.weeklyRecurrencePatternTypeField;
            }
            set
            {
                this.weeklyRecurrencePatternTypeField = value;
                this.weeklyRecurrencePatternTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeeklyRecurrencePatternTypeSpecified
        {
            get
            {
                return this.weeklyRecurrencePatternTypeFieldSpecified;
            }
            set
            {
                this.weeklyRecurrencePatternTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int WeekInterval
        {
            get
            {
                return this.weekIntervalField;
            }
            set
            {
                this.weekIntervalField = value;
                this.weekIntervalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WeekIntervalSpecified
        {
            get
            {
                return this.weekIntervalFieldSpecified;
            }
            set
            {
                this.weekIntervalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool Sunday
        {
            get
            {
                return this.sundayField;
            }
            set
            {
                this.sundayField = value;
                this.sundayFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SundaySpecified
        {
            get
            {
                return this.sundayFieldSpecified;
            }
            set
            {
                this.sundayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool Monday
        {
            get
            {
                return this.mondayField;
            }
            set
            {
                this.mondayField = value;
                this.mondayFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MondaySpecified
        {
            get
            {
                return this.mondayFieldSpecified;
            }
            set
            {
                this.mondayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool Tuesday
        {
            get
            {
                return this.tuesdayField;
            }
            set
            {
                this.tuesdayField = value;
                this.tuesdayFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TuesdaySpecified
        {
            get
            {
                return this.tuesdayFieldSpecified;
            }
            set
            {
                this.tuesdayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool Wednesday
        {
            get
            {
                return this.wednesdayField;
            }
            set
            {
                this.wednesdayField = value;
                this.wednesdayFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WednesdaySpecified
        {
            get
            {
                return this.wednesdayFieldSpecified;
            }
            set
            {
                this.wednesdayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool Thursday
        {
            get
            {
                return this.thursdayField;
            }
            set
            {
                this.thursdayField = value;
                this.thursdayFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThursdaySpecified
        {
            get
            {
                return this.thursdayFieldSpecified;
            }
            set
            {
                this.thursdayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool Friday
        {
            get
            {
                return this.fridayField;
            }
            set
            {
                this.fridayField = value;
                this.fridayFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FridaySpecified
        {
            get
            {
                return this.fridayFieldSpecified;
            }
            set
            {
                this.fridayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool Saturday
        {
            get
            {
                return this.saturdayField;
            }
            set
            {
                this.saturdayField = value;
                this.saturdayFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SaturdaySpecified
        {
            get
            {
                return this.saturdayFieldSpecified;
            }
            set
            {
                this.saturdayFieldSpecified = value;
            }
        }
    }
}