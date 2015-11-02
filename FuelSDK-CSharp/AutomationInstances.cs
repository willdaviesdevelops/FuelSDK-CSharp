namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AutomationInstances : APIObject
    {
        
        private int instanceCountField;
        
        private bool instanceCountFieldSpecified;
        
        private AutomationInstance[] automationInstanceCollectionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int InstanceCount
        {
            get
            {
                return this.instanceCountField;
            }
            set
            {
                this.instanceCountField = value;
                this.instanceCountFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InstanceCountSpecified
        {
            get
            {
                return this.instanceCountFieldSpecified;
            }
            set
            {
                this.instanceCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=1)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public AutomationInstance[] AutomationInstanceCollection
        {
            get
            {
                return this.automationInstanceCollectionField;
            }
            set
            {
                this.automationInstanceCollectionField = value;
            }
        }
    }
}