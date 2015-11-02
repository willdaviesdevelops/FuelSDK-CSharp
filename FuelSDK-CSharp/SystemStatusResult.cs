namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SystemStatusResult : Result
    {
        
        private SystemStatusType systemStatusField;
        
        private SystemOutage[] outagesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SystemStatusType SystemStatus
        {
            get
            {
                return this.systemStatusField;
            }
            set
            {
                this.systemStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Outage", IsNullable=false)]
        public SystemOutage[] Outages
        {
            get
            {
                return this.outagesField;
            }
            set
            {
                this.outagesField = value;
            }
        }
    }
}