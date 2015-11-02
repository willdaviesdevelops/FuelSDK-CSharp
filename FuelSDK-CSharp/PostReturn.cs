using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FuelSDK
{
    public class PostReturn : FuelReturn
    {
        public ResultDetail[] Results { get; set; }

        public PostReturn(APIObject[] theObjects, ET_Client theClient)
        {
            this.Message = "";
            this.Status = true;
            this.MoreResults = false;
            string OverallStatus = string.Empty, RequestID = string.Empty;
            Result[] requestResults = new Result[0];

            theClient.refreshToken();
            using (var scope = new OperationContextScope(theClient.soapclient.InnerChannel))
            {
                //Add oAuth token to SOAP header.
                XNamespace ns = "http://exacttarget.com";
                var oauthElement = new XElement(ns + "oAuthToken", theClient.internalAuthToken);
                var xmlHeader = MessageHeader.CreateHeader("oAuth", "http://exacttarget.com", oauthElement);
                OperationContext.Current.OutgoingMessageHeaders.Add(xmlHeader);

                var httpRequest = new System.ServiceModel.Channels.HttpRequestMessageProperty();
                OperationContext.Current.OutgoingMessageProperties.Add(System.ServiceModel.Channels.HttpRequestMessageProperty.Name, httpRequest);
                httpRequest.Headers.Add(HttpRequestHeader.UserAgent, theClient.SDKVersion);

                List<APIObject> lObjects = new List<APIObject>();
                foreach (APIObject ao in theObjects)
                {
                    lObjects.Add(this.TranslateObject(ao));
                }

                requestResults = theClient.soapclient.Create(new CreateOptions(), lObjects.ToArray(), out RequestID, out OverallStatus);

                this.Status = true;
                this.Code = 200;
                this.MoreResults = false;
                this.Message = "";

                if (OverallStatus != "OK")
                {
                    this.Status = false;
                }

                if (requestResults.GetType() == typeof(CreateResult[]) && requestResults.Length > 0)
                {
                    List<ResultDetail> results = new List<ResultDetail>();
                    foreach (CreateResult cr in requestResults)
                    {
                        ResultDetail detail = new ResultDetail();
                        if (cr.StatusCode != null)
                            detail.StatusCode = cr.StatusCode;
                        if (cr.StatusMessage != null)
                            detail.StatusMessage = cr.StatusMessage;
                        if (cr.NewObjectID != null)
                            detail.NewObjectID = cr.NewObjectID;
                        if (cr.Object != null)
                            detail.Object = this.TranslateObject(cr.Object);
                        detail.OrdinalID = cr.OrdinalID;
                        detail.ErrorCode = cr.ErrorCode;
                        detail.NewID = cr.NewID;
                        results.Add(detail);
                    }
                    this.Results = results.ToArray();
                }
            }
        }


        public PostReturn(APIObject theObject)
        {
            this.Message = "";
            this.Status = true;
            this.MoreResults = false;
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

                requestResults = theObject.AuthStub.soapclient.Create(new CreateOptions(), new APIObject[] { theObject }, out RequestID, out OverallStatus);

                this.Status = true;
                this.Code = 200;
                this.MoreResults = false;
                this.Message = "";

                if (OverallStatus != "OK")
                {
                    this.Status = false;
                }

                if (requestResults.GetType() == typeof(CreateResult[]) && requestResults.Length > 0)
                {
                    List<ResultDetail> results = new List<ResultDetail>();
                    foreach (CreateResult cr in requestResults)
                    {
                        ResultDetail detail = new ResultDetail();
                        if (cr.StatusCode != null)
                            detail.StatusCode = cr.StatusCode;
                        if (cr.StatusMessage != null)
                            detail.StatusMessage = cr.StatusMessage;
                        if (cr.NewObjectID != null)
                            detail.NewObjectID = cr.NewObjectID;
                        if (cr.Object != null)
                            detail.Object = this.TranslateObject(cr.Object);
                        detail.OrdinalID = cr.OrdinalID;
                        detail.ErrorCode = cr.ErrorCode;
                        detail.NewID = cr.NewID;
                        results.Add(detail);
                    }
                    this.Results = results.ToArray();
                }
            }
        }

        public PostReturn(APIObject theObject, CreateOptions createOptions)
        {
            this.Message = "";
            this.Status = true;
            this.MoreResults = false;
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

                requestResults = theObject.AuthStub.soapclient.Create(createOptions, new APIObject[] { theObject }, out RequestID, out OverallStatus);

                this.Status = true;
                this.Code = 200;
                this.MoreResults = false;
                this.Message = "";

                if (OverallStatus != "OK")
                {
                    this.Status = false;
                }

                if (requestResults.GetType() == typeof(CreateResult[]) && requestResults.Length > 0)
                {
                    List<ResultDetail> results = new List<ResultDetail>();
                    foreach (CreateResult cr in requestResults)
                    {
                        ResultDetail detail = new ResultDetail();
                        if (cr.StatusCode != null)
                            detail.StatusCode = cr.StatusCode;
                        if (cr.StatusMessage != null)
                            detail.StatusMessage = cr.StatusMessage;
                        if (cr.NewObjectID != null)
                            detail.NewObjectID = cr.NewObjectID;
                        if (cr.Object != null)
                            detail.Object = this.TranslateObject(cr.Object);
                        detail.OrdinalID = cr.OrdinalID;
                        detail.ErrorCode = cr.ErrorCode;
                        detail.NewID = cr.NewID;
                        results.Add(detail);
                    }
                    this.Results = results.ToArray();
                }
            }
        }

        public PostReturn(FuelObject theObject)
        {
            this.Message = "";
            this.Status = true;
            this.MoreResults = false;
            string completeURL = theObject.Endpoint;
            string additionalQS;

            theObject.AuthStub.refreshToken();

            foreach (PropertyInfo prop in theObject.GetType().GetProperties())
            {
                if (theObject.URLProperties.Contains(prop.Name) && prop.GetValue(theObject, null) != null)
                    if (prop.GetValue(theObject, null).ToString().Trim() != "" && prop.GetValue(theObject, null).ToString().Trim() != "0")
                        completeURL = completeURL.Replace("{" + prop.Name + "}", prop.GetValue(theObject, null).ToString());
            }

            bool match;
            if (theObject.RequiredURLProperties != null)
            {
                foreach (string urlProp in theObject.RequiredURLProperties)
                {
                    match = false;

                    foreach (PropertyInfo prop in theObject.GetType().GetProperties())
                    {
                        if (theObject.URLProperties.Contains(prop.Name))
                            if (prop.GetValue(theObject, null) != null)
                            {
                                if (prop.GetValue(theObject, null).ToString().Trim() != "" && prop.GetValue(theObject, null).ToString().Trim() != "0")
                                    match = true;
                            }
                    }
                    if (match == false)
                        throw new Exception("Unable to process request due to missing required property: " + urlProp);

                }
            }

            // Clean up not required URL parameters
            int j = 0;
            if (theObject.URLProperties != null)
            {
                foreach (string urlProp in theObject.URLProperties)
                {
                    completeURL = completeURL.Replace("{" + urlProp + "}", "");
                    j++;
                }
            }

            additionalQS = "access_token=" + theObject.AuthStub.authToken;
            completeURL = completeURL + "?" + additionalQS;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(completeURL.Trim());
            request.Method = "POST";
            request.ContentType = "application/json";
            request.UserAgent = theObject.AuthStub.SDKVersion;

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string jsonPayload = JsonConvert.SerializeObject(theObject);
                streamWriter.Write(jsonPayload);
            }

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
                        List<ResultDetail> AllResults = new List<ResultDetail>();

                        if (responseFromServer.ToString().StartsWith("["))
                        {
                            JArray jsonArray = JArray.Parse(responseFromServer.ToString());
                            foreach (JObject obj in jsonArray)
                            {
                                APIObject currentObject = (APIObject)Activator.CreateInstance(theObject.GetType(), System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance, null, new object[] { obj }, null);
                                ResultDetail result = new ResultDetail();
                                result.Object = currentObject;
                                AllResults.Add(result);
                            }

                            this.Results = AllResults.ToArray();
                        }
                        else
                        {
                            JObject jsonObject = JObject.Parse(responseFromServer.ToString());
                            ResultDetail result = new ResultDetail();
                            APIObject currentObject = (APIObject)Activator.CreateInstance(theObject.GetType(), System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance, null, new object[] { jsonObject }, null);
                            result.Object = currentObject;
                            AllResults.Add(result);
                            this.Results = AllResults.ToArray();
                        }


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
                this.Results = new ResultDetail[] { };
                using (var stream = we.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    Message = reader.ReadToEnd();
                }
            }


        }

    }
}