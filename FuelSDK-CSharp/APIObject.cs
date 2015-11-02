using System;
using Newtonsoft.Json;

namespace FuelSDK
{
    public partial class APIObject
    {
        [System.Xml.Serialization.XmlIgnore()]
        [JsonIgnore]
        public FuelSDK.ET_Client AuthStub { get; set; }
        [System.Xml.Serialization.XmlIgnore()]
        public string[] Props { get; set; }
        [System.Xml.Serialization.XmlIgnore()]
        public FilterPart SearchFilter { get; set; }
        [System.Xml.Serialization.XmlIgnore()]
        public String LastRequestID { get; set; }
    }
}