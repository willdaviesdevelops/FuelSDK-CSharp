namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class RetrieveSingleRequest : Request
    {
        
        private APIObject requestedObjectField;
        
        private Options retrieveOptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public APIObject RequestedObject
        {
            get
            {
                return this.requestedObjectField;
            }
            set
            {
                this.requestedObjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public Options RetrieveOption
        {
            get
            {
                return this.retrieveOptionField;
            }
            set
            {
                this.retrieveOptionField = value;
            }
        }
    }
}