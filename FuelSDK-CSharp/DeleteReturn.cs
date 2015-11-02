using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;

namespace FuelSDK
{
    public class DeleteReturn : FuelReturn
    {
        public ResultDetail[] Results { get; set; }

        public DeleteReturn(APIObject theObject)
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
                requestResults = theObject.AuthStub.soapclient.Delete(new DeleteOptions(), new APIObject[] { theObject }, out RequestID, out OverallStatus);

                this.Status = true;
                this.Code = 200;
                this.MoreResults = false;
                this.Message = "";

                if (OverallStatus != "OK")
                {
                    this.Status = false;
                }

                if (requestResults.GetType() == typeof(DeleteResult[]) && requestResults.Length > 0)
                {
                    List<ResultDetail> results = new List<ResultDetail>();
                    foreach (DeleteResult cr in requestResults)
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

        public DeleteReturn(FuelObject theObject)
        {

            this.Message = "";
            this.Status = true;
            this.MoreResults = false;
            this.Results = new ResultDetail[] { };


            theObject.AuthStub.refreshToken();

            string completeURL = theObject.Endpoint;
            string additionalQS;

            // All URL Props are required when doing Delete	
            bool match;
            if (theObject.URLProperties != null)
            {
                foreach (string urlProp in theObject.URLProperties)
                {
                    match = false;
                    if (theObject != null)
                    {
                        foreach (PropertyInfo prop in theObject.GetType().GetProperties())
                        {
                            if (theObject.URLProperties.Contains(prop.Name) && prop.GetValue(theObject, null) != null)
                                if (prop.GetValue(theObject, null).ToString().Trim() != "" && prop.GetValue(theObject, null).ToString().Trim() != "0")
                                    match = true;
                        }
                        if (match == false)
                            throw new Exception("Unable to process request due to missing required prop: " + urlProp);
                    }
                    else
                        throw new Exception("Unable to process request due to missing required prop: " + urlProp);
                }
            }

            if (theObject != null)
            {
                foreach (PropertyInfo prop in theObject.GetType().GetProperties())
                {
                    if (theObject.URLProperties.Contains(prop.Name) && prop.GetValue(theObject, null) != null)
                        if (prop.GetValue(theObject, null).ToString().Trim() != "" && prop.GetValue(theObject, null).ToString().Trim() != "0")
                            completeURL = completeURL.Replace("{" + prop.Name + "}", prop.GetValue(theObject, null).ToString());
                }
            }

            additionalQS = "access_token=" + theObject.AuthStub.authToken;
            completeURL = completeURL + "?" + additionalQS;
            restDelete(theObject, completeURL);
        }




        private void restDelete(FuelObject theObject, string url)
        {
            //Build the request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url.Trim());
            request.Method = "DELETE";
            request.ContentType = "application/json";
            request.UserAgent = theObject.AuthStub.SDKVersion;

            //Get the response
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();

                if (response != null)
                    this.Code = (int)response.StatusCode;
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        this.Status = true;
                    }
                    else
                    {
                        this.Status = false;
                        this.Message = response.ToString();
                    }
                }

                response.Close();
            }
            catch (WebException we)
            {
                this.Code = (int)((HttpWebResponse)we.Response).StatusCode;
                this.Status = false;
                using (var stream = we.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    this.Message = reader.ReadToEnd();
                }
            }
        }
    }
}