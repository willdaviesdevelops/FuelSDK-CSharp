namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class HourlyRecurrence : Recurrence
    {
        
        private HourlyRecurrencePatternTypeEnum hourlyRecurrencePatternTypeField;
        
        private bool hourlyRecurrencePatternTypeFieldSpecified;
        
        private int hourIntervalField;
        
        private bool hourIntervalFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public HourlyRecurrencePatternTypeEnum HourlyRecurrencePatternType
        {
            get
            {
                return this.hourlyRecurrencePatternTypeField;
            }
            set
            {
                this.hourlyRecurrencePatternTypeField = value;
                this.hourlyRecurrencePatternTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HourlyRecurrencePatternTypeSpecified
        {
            get
            {
                return this.hourlyRecurrencePatternTypeFieldSpecified;
            }
            set
            {
                this.hourlyRecurrencePatternTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int HourInterval
        {
            get
            {
                return this.hourIntervalField;
            }
            set
            {
                this.hourIntervalField = value;
                this.hourIntervalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HourIntervalSpecified
        {
            get
            {
                return this.hourIntervalFieldSpecified;
            }
            set
            {
                this.hourIntervalFieldSpecified = value;
            }
        }
    }
}