namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ValidationResult
    {
        
        private Subscriber subscriberField;
        
        private System.DateTime checkTimeField;
        
        private bool checkTimeFieldSpecified;
        
        private System.DateTime checkTimeUTCField;
        
        private bool checkTimeUTCFieldSpecified;
        
        private bool isResultValidField;
        
        private bool isResultValidFieldSpecified;
        
        private bool isSpamField;
        
        private bool isSpamFieldSpecified;
        
        private double scoreField;
        
        private bool scoreFieldSpecified;
        
        private double thresholdField;
        
        private bool thresholdFieldSpecified;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public Subscriber Subscriber
        {
            get
            {
                return this.subscriberField;
            }
            set
            {
                this.subscriberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public System.DateTime CheckTime
        {
            get
            {
                return this.checkTimeField;
            }
            set
            {
                this.checkTimeField = value;
                this.checkTimeFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckTimeSpecified
        {
            get
            {
                return this.checkTimeFieldSpecified;
            }
            set
            {
                this.checkTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public System.DateTime CheckTimeUTC
        {
            get
            {
                return this.checkTimeUTCField;
            }
            set
            {
                this.checkTimeUTCField = value;
                this.checkTimeUTCFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CheckTimeUTCSpecified
        {
            get
            {
                return this.checkTimeUTCFieldSpecified;
            }
            set
            {
                this.checkTimeUTCFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool IsResultValid
        {
            get
            {
                return this.isResultValidField;
            }
            set
            {
                this.isResultValidField = value;
                this.isResultValidFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsResultValidSpecified
        {
            get
            {
                return this.isResultValidFieldSpecified;
            }
            set
            {
                this.isResultValidFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool IsSpam
        {
            get
            {
                return this.isSpamField;
            }
            set
            {
                this.isSpamField = value;
                this.isSpamFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsSpamSpecified
        {
            get
            {
                return this.isSpamFieldSpecified;
            }
            set
            {
                this.isSpamFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public double Score
        {
            get
            {
                return this.scoreField;
            }
            set
            {
                this.scoreField = value;
                this.scoreFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ScoreSpecified
        {
            get
            {
                return this.scoreFieldSpecified;
            }
            set
            {
                this.scoreFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public double Threshold
        {
            get
            {
                return this.thresholdField;
            }
            set
            {
                this.thresholdField = value;
                this.thresholdFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ThresholdSpecified
        {
            get
            {
                return this.thresholdFieldSpecified;
            }
            set
            {
                this.thresholdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
    }
}