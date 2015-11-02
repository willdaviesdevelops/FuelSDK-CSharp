namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class CampaignPerformOptions : PerformOptions
    {
        
        private string[] occurrenceIDsField;
        
        private int occurrenceIDsIndexField;
        
        private bool occurrenceIDsIndexFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OccurrenceIDs", Order=0)]
        public string[] OccurrenceIDs
        {
            get
            {
                return this.occurrenceIDsField;
            }
            set
            {
                this.occurrenceIDsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int OccurrenceIDsIndex
        {
            get
            {
                return this.occurrenceIDsIndexField;
            }
            set
            {
                this.occurrenceIDsIndexField = value;
                this.occurrenceIDsIndexFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OccurrenceIDsIndexSpecified
        {
            get
            {
                return this.occurrenceIDsIndexFieldSpecified;
            }
            set
            {
                this.occurrenceIDsIndexFieldSpecified = value;
            }
        }
    }
}