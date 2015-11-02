using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace FuelSDK
{
    public class PatchReturn : FuelReturn
    {
        public ResultDetail[] Results { get; set; }

        public PatchReturn(APIObject theObject)
        {
            string OverallStatus = string.Empty, RequestID = string.Empty;
            Result[] requestResults = new Result[0];

            theObject.AuthStub.refreshToken();
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

                theObject = this.TranslateObject(theObject);
                requestResults = theObject.AuthStub.soapclient.Update(new UpdateOptions(), new APIObject[] { theObject }, out RequestID, out OverallStatus);

                this.Status = true;
                this.Code = 200;
                this.MoreResults = false;
                this.Message = "";

                if (OverallStatus != "OK")
                {
                    this.Status = false;
                }

                if (requestResults.GetType() == typeof(UpdateResult[]) && requestResults.Length > 0)
                {
                    List<ResultDetail> results = new List<ResultDetail>();
                    foreach (UpdateResult cr in requestResults)
                    {
                        ResultDetail detail = new ResultDetail();
                        if (cr.StatusCode != null)
                            detail.StatusCode = cr.StatusCode;
                        if (cr.StatusMessage != null)
                            detail.StatusMessage = cr.StatusMessage;
                        if (cr.Object != null)
                            detail.Object = this.TranslateObject(cr.Object);
                        detail.OrdinalID = cr.OrdinalID;
                        detail.ErrorCode = cr.ErrorCode;
                        results.Add(detail);
                    }
                    this.Results = results.ToArray();
                }
            }
        }
    }
}