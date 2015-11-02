namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class AccountPrivateLabel : APIObject
    {
        
        private string nameField;
        
        private int ownerMemberIDField;
        
        private string colorPaletteXMLField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int OwnerMemberID
        {
            get
            {
                return this.ownerMemberIDField;
            }
            set
            {
                this.ownerMemberIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string ColorPaletteXML
        {
            get
            {
                return this.colorPaletteXMLField;
            }
            set
            {
                this.colorPaletteXMLField = value;
            }
        }
    }
}