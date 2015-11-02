using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace FuelSDK
{
    public class InfoReturn : FuelReturn
    {
        public ET_PropertyDefinition[] Results { get; set; }
        public InfoReturn(APIObject theObject)
        {
            string RequestID = string.Empty;
            theObject.AuthStub.refreshToken();
            this.Results = new ET_PropertyDefinition[0];
            using (var scope = new OperationContextScope(theObject.AuthStub.soapclient.InnerChannel))
            {
                //Add oAuth token to SOAP header.
                XNamespace ns = "http://exacttarget.com";
                var oauthElement = new XElement(ns + "oAuthToken", theObject.AuthStub.internalAuthToken);
                var xmlHeader = MessageHeader.CreateHeader("oAuth", "http://exacttarget.com", oauthElement);
                OperationContext.Current.OutgoingMessageHeaders.Add(xmlHeader);

                var httpRequest = new System.ServiceModel.Channels.HttpRequestMessageProperty();
                OperationContext.Current.OutgoingMessageProperties.Add(System.ServiceModel.Channels.HttpRequestMessageProperty.Name, httpRequest);
                httpRequest.Headers.Add(HttpRequestHeader.UserAgent, theObject.AuthStub.SDKVersion);

                ObjectDefinitionRequest odr = new ObjectDefinitionRequest();
                odr.ObjectType = this.TranslateObject(theObject).GetType().ToString().Replace("FuelSDK.", "");
                ObjectDefinition[] definitionResults = theObject.AuthStub.soapclient.Describe(new ObjectDefinitionRequest[] { odr }, out RequestID);

                this.RequestID = RequestID;
                this.Status = true;
                this.Code = 200;
                this.MoreResults = false;
                this.Message = "";


                if (definitionResults.Length > 0)
                {

                    List<ET_PropertyDefinition> cleanedObjectResults = new List<ET_PropertyDefinition>();
                    foreach (PropertyDefinition obj in definitionResults[0].Properties)
                    {
                        cleanedObjectResults.Add((ET_PropertyDefinition)(this.TranslateObject(obj)));
                    }
                    this.Results = cleanedObjectResults.ToArray();
                }
                else
                {
                    this.Status = false;
                }
            }
        }
    }
}