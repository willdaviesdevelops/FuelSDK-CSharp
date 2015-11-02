namespace FuelSDK
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataExtensionField))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class PropertyDefinition : APIObject
    {
        
        private string nameField;
        
        private string dataTypeField;
        
        private SoapType valueTypeField;
        
        private bool valueTypeFieldSpecified;
        
        private PropertyType propertyTypeField;
        
        private bool propertyTypeFieldSpecified;
        
        private bool isCreatableField;
        
        private bool isCreatableFieldSpecified;
        
        private bool isUpdatableField;
        
        private bool isUpdatableFieldSpecified;
        
        private bool isRetrievableField;
        
        private bool isRetrievableFieldSpecified;
        
        private bool isQueryableField;
        
        private bool isQueryableFieldSpecified;
        
        private bool isFilterableField;
        
        private bool isFilterableFieldSpecified;
        
        private bool isPartnerPropertyField;
        
        private bool isPartnerPropertyFieldSpecified;
        
        private bool isAccountPropertyField;
        
        private bool isAccountPropertyFieldSpecified;
        
        private string partnerMapField;
        
        private AttributeMap[] attributeMapsField;
        
        private APIProperty[] markupsField;
        
        private int precisionField;
        
        private bool precisionFieldSpecified;
        
        private int scaleField;
        
        private bool scaleFieldSpecified;
        
        private string labelField;
        
        private string descriptionField;
        
        private string defaultValueField;
        
        private int minLengthField;
        
        private bool minLengthFieldSpecified;
        
        private int maxLengthField;
        
        private bool maxLengthFieldSpecified;
        
        private string minValueField;
        
        private string maxValueField;
        
        private bool isRequiredField;
        
        private bool isRequiredFieldSpecified;
        
        private bool isViewableField;
        
        private bool isViewableFieldSpecified;
        
        private bool isEditableField;
        
        private bool isEditableFieldSpecified;
        
        private bool isNillableField;
        
        private bool isNillableFieldSpecified;
        
        private bool isRestrictedPicklistField;
        
        private bool isRestrictedPicklistFieldSpecified;
        
        private PicklistItem[] picklistItemsField;
        
        private bool isSendTimeField;
        
        private bool isSendTimeFieldSpecified;
        
        private int displayOrderField;
        
        private bool displayOrderFieldSpecified;
        
        private APIObject[] referencesField;
        
        private string relationshipNameField;
        
        private string statusField;
        
        private bool isContextSpecificField;
        
        private bool isContextSpecificFieldSpecified;
        
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
        public string DataType
        {
            get
            {
                return this.dataTypeField;
            }
            set
            {
                this.dataTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public SoapType ValueType
        {
            get
            {
                return this.valueTypeField;
            }
            set
            {
                this.valueTypeField = value;
                this.valueTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValueTypeSpecified
        {
            get
            {
                return this.valueTypeFieldSpecified;
            }
            set
            {
                this.valueTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public PropertyType PropertyType
        {
            get
            {
                return this.propertyTypeField;
            }
            set
            {
                this.propertyTypeField = value;
                this.propertyTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertyTypeSpecified
        {
            get
            {
                return this.propertyTypeFieldSpecified;
            }
            set
            {
                this.propertyTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool IsFilterable
        {
            get
            {
                return this.isFilterableField;
            }
            set
            {
                this.isFilterableField = value;
                this.isFilterableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsFilterableSpecified
        {
            get
            {
                return this.isFilterableFieldSpecified;
            }
            set
            {
                this.isFilterableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool IsPartnerProperty
        {
            get
            {
                return this.isPartnerPropertyField;
            }
            set
            {
                this.isPartnerPropertyField = value;
                this.isPartnerPropertyFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsPartnerPropertySpecified
        {
            get
            {
                return this.isPartnerPropertyFieldSpecified;
            }
            set
            {
                this.isPartnerPropertyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool IsAccountProperty
        {
            get
            {
                return this.isAccountPropertyField;
            }
            set
            {
                this.isAccountPropertyField = value;
                this.isAccountPropertyFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsAccountPropertySpecified
        {
            get
            {
                return this.isAccountPropertyFieldSpecified;
            }
            set
            {
                this.isAccountPropertyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public string PartnerMap
        {
            get
            {
                return this.partnerMapField;
            }
            set
            {
                this.partnerMapField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttributeMaps", Order=12)]
        public AttributeMap[] AttributeMaps
        {
            get
            {
                return this.attributeMapsField;
            }
            set
            {
                this.attributeMapsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Markups", Order=13)]
        public APIProperty[] Markups
        {
            get
            {
                return this.markupsField;
            }
            set
            {
                this.markupsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public int Precision
        {
            get
            {
                return this.precisionField;
            }
            set
            {
                this.precisionField = value;
                this.precisionFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrecisionSpecified
        {
            get
            {
                return this.precisionFieldSpecified;
            }
            set
            {
                this.precisionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public int Scale
        {
            get
            {
                return this.scaleField;
            }
            set
            {
                this.scaleField = value;
                this.scaleFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScaleSpecified
        {
            get
            {
                return this.scaleFieldSpecified;
            }
            set
            {
                this.scaleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public string Label
        {
            get
            {
                return this.labelField;
            }
            set
            {
                this.labelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public string DefaultValue
        {
            get
            {
                return this.defaultValueField;
            }
            set
            {
                this.defaultValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=19)]
        public int MinLength
        {
            get
            {
                return this.minLengthField;
            }
            set
            {
                this.minLengthField = value;
                this.minLengthFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinLengthSpecified
        {
            get
            {
                return this.minLengthFieldSpecified;
            }
            set
            {
                this.minLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=20)]
        public int MaxLength
        {
            get
            {
                return this.maxLengthField;
            }
            set
            {
                this.maxLengthField = value;
                this.maxLengthFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxLengthSpecified
        {
            get
            {
                return this.maxLengthFieldSpecified;
            }
            set
            {
                this.maxLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=21)]
        public string MinValue
        {
            get
            {
                return this.minValueField;
            }
            set
            {
                this.minValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=22)]
        public string MaxValue
        {
            get
            {
                return this.maxValueField;
            }
            set
            {
                this.maxValueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=23)]
        public bool IsRequired
        {
            get
            {
                return this.isRequiredField;
            }
            set
            {
                this.isRequiredField = value;
                this.isRequiredFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsRequiredSpecified
        {
            get
            {
                return this.isRequiredFieldSpecified;
            }
            set
            {
                this.isRequiredFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=24)]
        public bool IsViewable
        {
            get
            {
                return this.isViewableField;
            }
            set
            {
                this.isViewableField = value;
                this.isViewableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsViewableSpecified
        {
            get
            {
                return this.isViewableFieldSpecified;
            }
            set
            {
                this.isViewableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=25)]
        public bool IsEditable
        {
            get
            {
                return this.isEditableField;
            }
            set
            {
                this.isEditableField = value;
                this.isEditableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsEditableSpecified
        {
            get
            {
                return this.isEditableFieldSpecified;
            }
            set
            {
                this.isEditableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=26)]
        public bool IsNillable
        {
            get
            {
                return this.isNillableField;
            }
            set
            {
                this.isNillableField = value;
                this.isNillableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsNillableSpecified
        {
            get
            {
                return this.isNillableFieldSpecified;
            }
            set
            {
                this.isNillableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=27)]
        public bool IsRestrictedPicklist
        {
            get
            {
                return this.isRestrictedPicklistField;
            }
            set
            {
                this.isRestrictedPicklistField = value;
                this.isRestrictedPicklistFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsRestrictedPicklistSpecified
        {
            get
            {
                return this.isRestrictedPicklistFieldSpecified;
            }
            set
            {
                this.isRestrictedPicklistFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=28)]
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable=false)]
        public PicklistItem[] PicklistItems
        {
            get
            {
                return this.picklistItemsField;
            }
            set
            {
                this.picklistItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=29)]
        public bool IsSendTime
        {
            get
            {
                return this.isSendTimeField;
            }
            set
            {
                this.isSendTimeField = value;
                this.isSendTimeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSendTimeSpecified
        {
            get
            {
                return this.isSendTimeFieldSpecified;
            }
            set
            {
                this.isSendTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=30)]
        public int DisplayOrder
        {
            get
            {
                return this.displayOrderField;
            }
            set
            {
                this.displayOrderField = value;
                this.displayOrderFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayOrderSpecified
        {
            get
            {
                return this.displayOrderFieldSpecified;
            }
            set
            {
                this.displayOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=31)]
        [System.Xml.Serialization.XmlArrayItemAttribute("Reference", IsNullable=false)]
        public APIObject[] References
        {
            get
            {
                return this.referencesField;
            }
            set
            {
                this.referencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=32)]
        public string RelationshipName
        {
            get
            {
                return this.relationshipNameField;
            }
            set
            {
                this.relationshipNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=33)]
        public string Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=34)]
        public bool IsContextSpecific
        {
            get
            {
                return this.isContextSpecificField;
            }
            set
            {
                this.isContextSpecificField = value;
                this.isContextSpecificFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsContextSpecificSpecified
        {
            get
            {
                return this.isContextSpecificFieldSpecified;
            }
            set
            {
                this.isContextSpecificFieldSpecified = value;
            }
        }
    }
}