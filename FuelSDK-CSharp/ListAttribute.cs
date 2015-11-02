namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ListAttribute : APIObject
    {
        
        private List listField;
        
        private string nameField;
        
        private string descriptionField;
        
        private ListAttributeFieldType fieldTypeField;
        
        private bool fieldTypeFieldSpecified;
        
        private int fieldLengthField;
        
        private bool fieldLengthFieldSpecified;
        
        private int scaleField;
        
        private bool scaleFieldSpecified;
        
        private string minValueField;
        
        private string maxValueField;
        
        private string defaultValueField;
        
        private bool isNullableField;
        
        private bool isNullableFieldSpecified;
        
        private bool isHiddenField;
        
        private bool isHiddenFieldSpecified;
        
        private bool isReadOnlyField;
        
        private bool isReadOnlyFieldSpecified;
        
        private bool inheritableField;
        
        private bool inheritableFieldSpecified;
        
        private bool overridableField;
        
        private bool overridableFieldSpecified;
        
        private bool mustOverrideField;
        
        private bool mustOverrideFieldSpecified;
        
        private OverrideType overrideTypeField;
        
        private bool overrideTypeFieldSpecified;
        
        private int ordinalField;
        
        private bool ordinalFieldSpecified;
        
        private ListAttributeRestrictedValue[] restrictedValuesField;
        
        private ListAttribute baseAttributeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public List List
        {
            get
            {
                return this.listField;
            }
            set
            {
                this.listField = value;
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
        public ListAttributeFieldType FieldType
        {
            get
            {
                return this.fieldTypeField;
            }
            set
            {
                this.fieldTypeField = value;
                this.fieldTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FieldTypeSpecified
        {
            get
            {
                return this.fieldTypeFieldSpecified;
            }
            set
            {
                this.fieldTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int FieldLength
        {
            get
            {
                return this.fieldLengthField;
            }
            set
            {
                this.fieldLengthField = value;
                this.fieldLengthFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FieldLengthSpecified
        {
            get
            {
                return this.fieldLengthFieldSpecified;
            }
            set
            {
                this.fieldLengthFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
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
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool IsNullable
        {
            get
            {
                return this.isNullableField;
            }
            set
            {
                this.isNullableField = value;
                this.isNullableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsNullableSpecified
        {
            get
            {
                return this.isNullableFieldSpecified;
            }
            set
            {
                this.isNullableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool IsHidden
        {
            get
            {
                return this.isHiddenField;
            }
            set
            {
                this.isHiddenField = value;
                this.isHiddenFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsHiddenSpecified
        {
            get
            {
                return this.isHiddenFieldSpecified;
            }
            set
            {
                this.isHiddenFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool IsReadOnly
        {
            get
            {
                return this.isReadOnlyField;
            }
            set
            {
                this.isReadOnlyField = value;
                this.isReadOnlyFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsReadOnlySpecified
        {
            get
            {
                return this.isReadOnlyFieldSpecified;
            }
            set
            {
                this.isReadOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public bool Inheritable
        {
            get
            {
                return this.inheritableField;
            }
            set
            {
                this.inheritableField = value;
                this.inheritableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InheritableSpecified
        {
            get
            {
                return this.inheritableFieldSpecified;
            }
            set
            {
                this.inheritableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public bool Overridable
        {
            get
            {
                return this.overridableField;
            }
            set
            {
                this.overridableField = value;
                this.overridableFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OverridableSpecified
        {
            get
            {
                return this.overridableFieldSpecified;
            }
            set
            {
                this.overridableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public bool MustOverride
        {
            get
            {
                return this.mustOverrideField;
            }
            set
            {
                this.mustOverrideField = value;
                this.mustOverrideFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MustOverrideSpecified
        {
            get
            {
                return this.mustOverrideFieldSpecified;
            }
            set
            {
                this.mustOverrideFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public OverrideType OverrideType
        {
            get
            {
                return this.overrideTypeField;
            }
            set
            {
                this.overrideTypeField = value;
                this.overrideTypeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OverrideTypeSpecified
        {
            get
            {
                return this.overrideTypeFieldSpecified;
            }
            set
            {
                this.overrideTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=16)]
        public int Ordinal
        {
            get
            {
                return this.ordinalField;
            }
            set
            {
                this.ordinalField = value;
                this.ordinalFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrdinalSpecified
        {
            get
            {
                return this.ordinalFieldSpecified;
            }
            set
            {
                this.ordinalFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RestrictedValues", Order=17)]
        public ListAttributeRestrictedValue[] RestrictedValues
        {
            get
            {
                return this.restrictedValuesField;
            }
            set
            {
                this.restrictedValuesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=18)]
        public ListAttribute BaseAttribute
        {
            get
            {
                return this.baseAttributeField;
            }
            set
            {
                this.baseAttributeField = value;
            }
        }
    }
}