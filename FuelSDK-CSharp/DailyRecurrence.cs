namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class DailyRecurrence : Recurrence
    {
        
        private DailyRecurrencePatternTypeEnum dailyRecurrencePatternTypeField;
        
        private bool dailyRecurrencePatternTypeFieldSpecified;
        
        private int dayIntervalField;
        
        private bool dayIntervalFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public DailyRecurrencePatternTypeEnum DailyRecurrencePatternType
        {
            get
            {
                return this.dailyRecurrencePatternTypeField;
            }
            set
            {
                this.dailyRecurrencePatternTypeField = value;
                this.dailyRecurrencePatternTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DailyRecurrencePatternTypeSpecified
        {
            get
            {
                return this.dailyRecurrencePatternTypeFieldSpecified;
            }
            set
            {
                this.dailyRecurrencePatternTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int DayInterval
        {
            get
            {
                return this.dayIntervalField;
            }
            set
            {
                this.dayIntervalField = value;
                this.dayIntervalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DayIntervalSpecified
        {
            get
            {
                return this.dayIntervalFieldSpecified;
            }
            set
            {
                this.dayIntervalFieldSpecified = value;
            }
        }
    }
}