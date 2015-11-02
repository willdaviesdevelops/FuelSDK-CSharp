using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace FuelSDK
{
    public class PerformReturn : FuelReturn
    {
        public ResultDetail[] Results { get; set; }

        public PerformReturn(APIObject theObject, string PerformAction)
        {
            string OverallStatus = string.Empty, RequestID = string.Empty, OverallStatusMessage = string.Empty;
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
                requestResults = theObject.AuthStub.soapclient.Perform(new PerformOptions(), PerformAction, new APIObject[] { theObject }, out OverallStatus, out OverallStatusMessage, out RequestID);
                    

                this.Status = true;
                this.Code = 200;
                this.MoreResults = false;
                this.Message = OverallStatusMessage;

                if (OverallStatus != "OK")
                {
                    this.Status = false;
                }

                if (requestResults.GetType() == typeof(PerformResult[]) && requestResults.Length > 0)
                {
                    List<ResultDetail> results = new List<ResultDetail>();
                    foreach (PerformResult cr in requestResults)
                    {
                        ResultDetail detail = new ResultDetail();
                        if (cr.StatusCode != null)
                            detail.StatusCode = cr.StatusCode;
                        if (cr.StatusMessage != null)
                            detail.StatusMessage = cr.StatusMessage;
                        if (cr.Object != null)
                            detail.Object = this.TranslateObject(cr.Object);
                        if (cr.Task != null)
                            detail.Task = cr.Task;
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