namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AutomationTaskInstance : AutomationTask
    {
        
        private AutomationTask stepDefinitionField;
        
        private AutomationInstance automationInstanceField;
        
        private AutomationActivityInstance[] activityInstancesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public AutomationTask StepDefinition
        {
            get
            {
                return this.stepDefinitionField;
            }
            set
            {
                this.stepDefinitionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public AutomationInstance AutomationInstance
        {
            get
            {
                return this.automationInstanceField;
            }
            set
            {
                this.automationInstanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ActivityInstance", IsNullable=false)]
        public AutomationActivityInstance[] ActivityInstances
        {
            get
            {
                return this.activityInstancesField;
            }
            set
            {
                this.activityInstancesField = value;
            }
        }
    }
}