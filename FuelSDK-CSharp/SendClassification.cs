namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class SendClassification : APIObject
    {
        
        private SendClassificationTypeEnum sendClassificationTypeField;
        
        private bool sendClassificationTypeFieldSpecified;
        
        private string nameField;
        
        private string descriptionField;
        
        private SenderProfile senderProfileField;
        
        private DeliveryProfile deliveryProfileField;
        
        private bool honorPublicationListOptOutsForTransactionalSendsField;
        
        private bool honorPublicationListOptOutsForTransactionalSendsFieldSpecified;
        
        private SendPriorityEnum sendPriorityField;
        
        private bool sendPriorityFieldSpecified;
        
        private bool archiveEmailField;
        
        private bool archiveEmailFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public SendClassificationTypeEnum SendClassificationType
        {
            get
            {
                return this.sendClassificationTypeField;
            }
            set
            {
                this.sendClassificationTypeField = value;
                this.sendClassificationTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendClassificationTypeSpecified
        {
            get
            {
                return this.sendClassificationTypeFieldSpecified;
            }
            set
            {
                this.sendClassificationTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public SenderProfile SenderProfile
        {
            get
            {
                return this.senderProfileField;
            }
            set
            {
                this.senderProfileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public DeliveryProfile DeliveryProfile
        {
            get
            {
                return this.deliveryProfileField;
            }
            set
            {
                this.deliveryProfileField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool HonorPublicationListOptOutsForTransactionalSends
        {
            get
            {
                return this.honorPublicationListOptOutsForTransactionalSendsField;
            }
            set
            {
                this.honorPublicationListOptOutsForTransactionalSendsField = value;
                this.honorPublicationListOptOutsForTransactionalSendsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HonorPublicationListOptOutsForTransactionalSendsSpecified
        {
            get
            {
                return this.honorPublicationListOptOutsForTransactionalSendsFieldSpecified;
            }
            set
            {
                this.honorPublicationListOptOutsForTransactionalSendsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public SendPriorityEnum SendPriority
        {
            get
            {
                return this.sendPriorityField;
            }
            set
            {
                this.sendPriorityField = value;
                this.sendPriorityFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendPrioritySpecified
        {
            get
            {
                return this.sendPriorityFieldSpecified;
            }
            set
            {
                this.sendPriorityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool ArchiveEmail
        {
            get
            {
                return this.archiveEmailField;
            }
            set
            {
                this.archiveEmailField = value;
                this.archiveEmailFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArchiveEmailSpecified
        {
            get
            {
                return this.archiveEmailFieldSpecified;
            }
            set
            {
                this.archiveEmailFieldSpecified = value;
            }
        }
    }
}