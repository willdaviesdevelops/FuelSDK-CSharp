namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ClientID
    {
        
        private int clientID1Field;
        
        private bool clientID1FieldSpecified;
        
        private int idField;
        
        private bool idFieldSpecified;
        
        private string partnerClientKeyField;
        
        private int userIDField;
        
        private bool userIDFieldSpecified;
        
        private string partnerUserKeyField;
        
        private int createdByField;
        
        private bool createdByFieldSpecified;
        
        private int modifiedByField;
        
        private bool modifiedByFieldSpecified;
        
        private long enterpriseIDField;
        
        private bool enterpriseIDFieldSpecified;
        
        private string customerKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClientID", Order=0)]
        public int ClientID1
        {
            get
            {
                return this.clientID1Field;
            }
            set
            {
                this.clientID1Field = value;
                this.clientID1FieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ClientID1Specified
        {
            get
            {
                return this.clientID1FieldSpecified;
            }
            set
            {
                this.clientID1FieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
                this.idFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IDSpecified
        {
            get
            {
                return this.idFieldSpecified;
            }
            set
            {
                this.idFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string PartnerClientKey
        {
            get
            {
                return this.partnerClientKeyField;
            }
            set
            {
                this.partnerClientKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
                this.userIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserIDSpecified
        {
            get
            {
                return this.userIDFieldSpecified;
            }
            set
            {
                this.userIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string PartnerUserKey
        {
            get
            {
                return this.partnerUserKeyField;
            }
            set
            {
                this.partnerUserKeyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int CreatedBy
        {
            get
            {
                return this.createdByField;
            }
            set
            {
                this.createdByField = value;
                this.createdByFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreatedBySpecified
        {
            get
            {
                return this.createdByFieldSpecified;
            }
            set
            {
                this.createdByFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int ModifiedBy
        {
            get
            {
                return this.modifiedByField;
            }
            set
            {
                this.modifiedByField = value;
                this.modifiedByFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifiedBySpecified
        {
            get
            {
                return this.modifiedByFieldSpecified;
            }
            set
            {
                this.modifiedByFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public long EnterpriseID
        {
            get
            {
                return this.enterpriseIDField;
            }
            set
            {
                this.enterpriseIDField = value;
                this.enterpriseIDFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EnterpriseIDSpecified
        {
            get
            {
                return this.enterpriseIDFieldSpecified;
            }
            set
            {
                this.enterpriseIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string CustomerKey
        {
            get
            {
                return this.customerKeyField;
            }
            set
            {
                this.customerKeyField = value;
            }
        }
    }
}