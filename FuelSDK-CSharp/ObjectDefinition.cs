namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ObjectDefinition
    {
        
        private string objectTypeField;
        
        private string nameField;
        
        private bool isCreatableField;
        
        private bool isCreatableFieldSpecified;
        
        private bool isUpdatableField;
        
        private bool isUpdatableFieldSpecified;
        
        private bool isRetrievableField;
        
        private bool isRetrievableFieldSpecified;
        
        private bool isQueryableField;
        
        private bool isQueryableFieldSpecified;
        
        private bool isReferenceField;
        
        private bool isReferenceFieldSpecified;
        
        private string referencedTypeField;
        
        private string isPropertyCollectionField;
        
        private bool isObjectCollectionField;
        
        private bool isObjectCollectionFieldSpecified;
        
        private PropertyDefinition[] propertiesField;
        
        private PropertyDefinition[] extendedPropertiesField;
        
        private ObjectDefinition[] childObjectsField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string ObjectType
        {
            get
            {
                return this.objectTypeField;
            }
            set
            {
                this.objectTypeField = value;
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
        public bool IsCreatable
        {
            get
            {
                return this.isCreatableField;
            }
            set
            {
                this.isCreatableField = value;
                this.isCreatableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsCreatableSpecified
        {
            get
            {
                return this.isCreatableFieldSpecified;
            }
            set
            {
                this.isCreatableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool IsUpdatable
        {
            get
            {
                return this.isUpdatableField;
            }
            set
            {
                this.isUpdatableField = value;
                this.isUpdatableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsUpdatableSpecified
        {
            get
            {
                return this.isUpdatableFieldSpecified;
            }
            set
            {
                this.isUpdatableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool IsRetrievable
        {
            get
            {
                return this.isRetrievableField;
            }
            set
            {
                this.isRetrievableField = value;
                this.isRetrievableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsRetrievableSpecified
        {
            get
            {
                return this.isRetrievableFieldSpecified;
            }
            set
            {
                this.isRetrievableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool IsQueryable
        {
            get
            {
                return this.isQueryableField;
            }
            set
            {
                this.isQueryableField = value;
                this.isQueryableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsQueryableSpecified
        {
            get
            {
                return this.isQueryableFieldSpecified;
            }
            set
            {
                this.isQueryableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool IsReference
        {
            get
            {
                return this.isReferenceField;
            }
            set
            {
                this.isReferenceField = value;
                this.isReferenceFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsReferenceSpecified
        {
            get
            {
                return this.isReferenceFieldSpecified;
            }
            set
            {
                this.isReferenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string ReferencedType
        {
            get
            {
                return this.referencedTypeField;
            }
            set
            {
                this.referencedTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string IsPropertyCollection
        {
            get
            {
                return this.isPropertyCollectionField;
            }
            set
            {
                this.isPropertyCollectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool IsObjectCollection
        {
            get
            {
                return this.isObjectCollectionField;
            }
            set
            {
                this.isObjectCollectionField = value;
                this.isObjectCollectionFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsObjectCollectionSpecified
        {
            get
            {
                return this.isObjectCollectionFieldSpecified;
            }
            set
            {
                this.isObjectCollectionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Properties", Order=10)]
        public PropertyDefinition[] Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=11)]
        [System.Xml.Serialization.XmlArrayItemAttribute("ExtendedProperty", IsNullable=false)]
        public PropertyDefinition[] ExtendedProperties
        {
            get
            {
                return this.extendedPropertiesField;
            }
            set
            {
                this.extendedPropertiesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ChildObjects", Order=12)]
        public ObjectDefinition[] ChildObjects
        {
            get
            {
                return this.childObjectsField;
            }
            set
            {
                this.childObjectsField = value;
            }
        }
    }
}