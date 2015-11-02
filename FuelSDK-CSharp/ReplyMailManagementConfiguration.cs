namespace FuelSDK
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://exacttarget.com/wsdl/partnerAPI")]
    public partial class ReplyMailManagementConfiguration : APIObject
    {
        
        private string emailDisplayNameField;
        
        private string replySubdomainField;
        
        private string emailReplyAddressField;
        
        private bool dNSRedirectCompleteField;
        
        private bool dNSRedirectCompleteFieldSpecified;
        
        private bool deleteAutoRepliesField;
        
        private bool deleteAutoRepliesFieldSpecified;
        
        private bool supportUnsubscribesField;
        
        private bool supportUnsubscribesFieldSpecified;
        
        private bool supportUnsubKeywordField;
        
        private bool supportUnsubKeywordFieldSpecified;
        
        private bool supportUnsubscribeKeywordField;
        
        private bool supportUnsubscribeKeywordFieldSpecified;
        
        private bool supportRemoveKeywordField;
        
        private bool supportRemoveKeywordFieldSpecified;
        
        private bool supportOptOutKeywordField;
        
        private bool supportOptOutKeywordFieldSpecified;
        
        private bool supportLeaveKeywordField;
        
        private bool supportLeaveKeywordFieldSpecified;
        
        private bool supportMisspelledKeywordsField;
        
        private bool supportMisspelledKeywordsFieldSpecified;
        
        private bool sendAutoRepliesField;
        
        private bool sendAutoRepliesFieldSpecified;
        
        private string autoReplySubjectField;
        
        private string autoReplyBodyField;
        
        private string forwardingAddressField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string EmailDisplayName
        {
            get
            {
                return this.emailDisplayNameField;
            }
            set
            {
                this.emailDisplayNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string ReplySubdomain
        {
            get
            {
                return this.replySubdomainField;
            }
            set
            {
                this.replySubdomainField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string EmailReplyAddress
        {
            get
            {
                return this.emailReplyAddressField;
            }
            set
            {
                this.emailReplyAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public bool DNSRedirectComplete
        {
            get
            {
                return this.dNSRedirectCompleteField;
            }
            set
            {
                this.dNSRedirectCompleteField = value;
                this.dNSRedirectCompleteFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DNSRedirectCompleteSpecified
        {
            get
            {
                return this.dNSRedirectCompleteFieldSpecified;
            }
            set
            {
                this.dNSRedirectCompleteFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public bool DeleteAutoReplies
        {
            get
            {
                return this.deleteAutoRepliesField;
            }
            set
            {
                this.deleteAutoRepliesField = value;
                this.deleteAutoRepliesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeleteAutoRepliesSpecified
        {
            get
            {
                return this.deleteAutoRepliesFieldSpecified;
            }
            set
            {
                this.deleteAutoRepliesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool SupportUnsubscribes
        {
            get
            {
                return this.supportUnsubscribesField;
            }
            set
            {
                this.supportUnsubscribesField = value;
                this.supportUnsubscribesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupportUnsubscribesSpecified
        {
            get
            {
                return this.supportUnsubscribesFieldSpecified;
            }
            set
            {
                this.supportUnsubscribesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool SupportUnsubKeyword
        {
            get
            {
                return this.supportUnsubKeywordField;
            }
            set
            {
                this.supportUnsubKeywordField = value;
                this.supportUnsubKeywordFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupportUnsubKeywordSpecified
        {
            get
            {
                return this.supportUnsubKeywordFieldSpecified;
            }
            set
            {
                this.supportUnsubKeywordFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public bool SupportUnsubscribeKeyword
        {
            get
            {
                return this.supportUnsubscribeKeywordField;
            }
            set
            {
                this.supportUnsubscribeKeywordField = value;
                this.supportUnsubscribeKeywordFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupportUnsubscribeKeywordSpecified
        {
            get
            {
                return this.supportUnsubscribeKeywordFieldSpecified;
            }
            set
            {
                this.supportUnsubscribeKeywordFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public bool SupportRemoveKeyword
        {
            get
            {
                return this.supportRemoveKeywordField;
            }
            set
            {
                this.supportRemoveKeywordField = value;
                this.supportRemoveKeywordFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupportRemoveKeywordSpecified
        {
            get
            {
                return this.supportRemoveKeywordFieldSpecified;
            }
            set
            {
                this.supportRemoveKeywordFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public bool SupportOptOutKeyword
        {
            get
            {
                return this.supportOptOutKeywordField;
            }
            set
            {
                this.supportOptOutKeywordField = value;
                this.supportOptOutKeywordFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupportOptOutKeywordSpecified
        {
            get
            {
                return this.supportOptOutKeywordFieldSpecified;
            }
            set
            {
                this.supportOptOutKeywordFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool SupportLeaveKeyword
        {
            get
            {
                return this.supportLeaveKeywordField;
            }
            set
            {
                this.supportLeaveKeywordField = value;
                this.supportLeaveKeywordFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupportLeaveKeywordSpecified
        {
            get
            {
                return this.supportLeaveKeywordFieldSpecified;
            }
            set
            {
                this.supportLeaveKeywordFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public bool SupportMisspelledKeywords
        {
            get
            {
                return this.supportMisspelledKeywordsField;
            }
            set
            {
                this.supportMisspelledKeywordsField = value;
                this.supportMisspelledKeywordsFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SupportMisspelledKeywordsSpecified
        {
            get
            {
                return this.supportMisspelledKeywordsFieldSpecified;
            }
            set
            {
                this.supportMisspelledKeywordsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=12)]
        public bool SendAutoReplies
        {
            get
            {
                return this.sendAutoRepliesField;
            }
            set
            {
                this.sendAutoRepliesField = value;
                this.sendAutoRepliesFieldSpecified = (value != null);
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SendAutoRepliesSpecified
        {
            get
            {
                return this.sendAutoRepliesFieldSpecified;
            }
            set
            {
                this.sendAutoRepliesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public string AutoReplySubject
        {
            get
            {
                return this.autoReplySubjectField;
            }
            set
            {
                this.autoReplySubjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public string AutoReplyBody
        {
            get
            {
                return this.autoReplyBodyField;
            }
            set
            {
                this.autoReplyBodyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public string ForwardingAddress
        {
            get
            {
                return this.forwardingAddressField;
            }
            set
            {
                this.forwardingAddressField = value;
            }
        }
    }
}