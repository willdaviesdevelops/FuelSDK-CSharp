namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class CreateOptions : Options
    {
        
        private ContainerID containerField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ContainerID Container
        {
            get
            {
                return this.containerField;
            }
            set
            {
                this.containerField = value;
            }
        }
    }
}