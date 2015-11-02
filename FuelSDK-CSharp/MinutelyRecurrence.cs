namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class MinutelyRecurrence : Recurrence
    {
        
        private MinutelyRecurrencePatternTypeEnum minutelyRecurrencePatternTypeField;
        
        private bool minutelyRecurrencePatternTypeFieldSpecified;
        
        private int minuteIntervalField;
        
        private bool minuteIntervalFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public MinutelyRecurrencePatternTypeEnum MinutelyRecurrencePatternType
        {
            get
            {
                return this.minutelyRecurrencePatternTypeField;
            }
            set
            {
                this.minutelyRecurrencePatternTypeField = value;
                this.minutelyRecurrencePatternTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinutelyRecurrencePatternTypeSpecified
        {
            get
            {
                return this.minutelyRecurrencePatternTypeFieldSpecified;
            }
            set
            {
                this.minutelyRecurrencePatternTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int MinuteInterval
        {
            get
            {
                return this.minuteIntervalField;
            }
            set
            {
                this.minuteIntervalField = value;
                this.minuteIntervalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinuteIntervalSpecified
        {
            get
            {
                return this.minuteIntervalFieldSpecified;
            }
            set
            {
                this.minuteIntervalFieldSpecified = value;
            }
        }
    }
}