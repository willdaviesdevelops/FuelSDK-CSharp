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
    public class GetReturn : FuelReturn
    {
        public int LastPageNumber { get; set; }

        public APIObject[] Results { get; set; }

        public GetReturn(APIObject theObject) : this(theObject, false, null) { }
        public GetReturn(APIObject theObject, Boolean Continue, String OverrideObjectType)
        {
            string OverallStatus = string.Empty, RequestID = string.Empty;
            APIObject[] objectResults = new APIObject[0];
            theObject.AuthStub.refreshToken();
            this.Results = new APIObject[0];
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

                RetrieveRequest rr = new RetrieveRequest();

                // Handle RetrieveAllSinceLastBatch
                if (theObject.GetType().GetProperty("GetSinceLastBatch") != null)
                {
                    rr.RetrieveAllSinceLastBatch = (Boolean)theObject.GetType().GetProperty("GetSinceLastBatch").GetValue(theObject, null);
                }


                if (Continue)
                {
                    if (theObject.LastRequestID == null)
                    {
                        throw new Exception("Unable to call GetMoreResults without first making successful Get() request");
                    }
                    rr.ContinueRequest = theObject.LastRequestID;
                }
                else
                {
                    if (theObject.SearchFilter != null)
                    {
                        rr.Filter = theObject.SearchFilter;
                    }

                    // Use the name from the object passed in unless an override is passed (Used for DataExtensionObject)
                    if (OverrideObjectType == null)
                        rr.ObjectType = this.TranslateObject(theObject).GetType().ToString().Replace("FuelSDK.", "");
                    else
                        rr.ObjectType = OverrideObjectType;

                    //If they didn't specify Props then we look them up using Info()
                    if (theObject.Props == null && theObject.GetType().GetMethod("Info") != null)
                    {
                        InfoReturn ir = new InfoReturn(theObject);
                        List<string> lProps = new List<string>();
                        if (ir.Status)
                        {
                            foreach (ET_PropertyDefinition pd in ir.Results)
                            {
                                if (pd.IsRetrievable)
                                    lProps.Add(pd.Name);
                            }
                        }
                        else
                        {
                            throw new Exception("Unable to find properties for object in order to perform Get() request");
                        }
                        rr.Properties = lProps.ToArray();
                    }
                    else
                        rr.Properties = theObject.Props;
                }
                OverallStatus = theObject.AuthStub.soapclient.Retrieve(rr, out RequestID, out objectResults);

                this.RequestID = RequestID;

                if (objectResults.Length > 0)
                {
                    List<APIObject> cleanedObjectResults = new List<APIObject>();
                    foreach (APIObject obj in objectResults)
                    {
                        cleanedObjectResults.Add(this.TranslateObject(obj));
                    }
                    this.Results = cleanedObjectResults.ToArray();
                }

                this.Status = true;
                this.Code = 200;
                this.MoreResults = false;
                this.Message = "";

                if (OverallStatus != "OK" && OverallStatus != "MoreDataAvailable")
                {
                    this.Status = false;
                    this.Message = OverallStatus;
                }
                else if (OverallStatus == "MoreDataAvailable")
                {
                    this.MoreResults = true;
                }
            }
        }

        public GetReturn(FuelObject theObject)
        {
            this.Message = "";
            this.Status = true;
            this.MoreResults = false;
            this.Results = new APIObject[] { };

            theObject.AuthStub.refreshToken();

            string completeURL = theObject.Endpoint;
            string additionalQS = "";
            bool boolAdditionalQS = false;

            if (theObject != null)
            {
                foreach (PropertyInfo prop in theObject.GetType().GetProperties())
                {
                    if (theObject.URLProperties.Contains(prop.Name) && prop.GetValue(theObject, null) != null)
                        if (prop.GetValue(theObject, null).ToString().Trim() != "" && prop.GetValue(theObject, null).ToString().Trim() != "0")
                            completeURL = completeURL.Replace("{" + prop.Name + "}", prop.GetValue(theObject, null).ToString());
                }
            }

            ////props code for paging
            if (theObject.Page != 0)
            {
                additionalQS += "$page=" + theObject.Page;
                boolAdditionalQS = true;
            }

            bool match;
            if (theObject.RequiredURLProperties != null)
            {
                foreach (string urlProp in theObject.RequiredURLProperties)
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

            //Clean up not required URL parameters
            int j = 0;
            if (theObject.URLProperties != null)
            {
                foreach (string urlProp in theObject.URLProperties)
                {
                    completeURL = completeURL.Replace("{" + urlProp + "}", "");
                    j++;
                }
            }

            if (!boolAdditionalQS)
                additionalQS += "access_token=" + theObject.AuthStub.authToken;
            else
                additionalQS += "&access_token=" + theObject.AuthStub.authToken;

            completeURL = completeURL + "?" + additionalQS;
            restGet(ref theObject, completeURL);
        }

        private void restGet(ref FuelObject theObject, string url)
        {
            //Build the request
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url.Trim());
            request.Method = "GET";
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
                        if (responseFromServer != null)
                        {
                            JObject parsedResponse = JObject.Parse(responseFromServer);
                            //Check on the paging information from response
                            if (parsedResponse["page"] != null)
                            {
                                this.LastPageNumber = int.Parse(parsedResponse["page"].Value<string>().Trim());
                                int pageSize = int.Parse(parsedResponse["pageSize"].Value<string>().Trim());

                                int count = -1;
                                if (parsedResponse["count"] != null)
                                {
                                    count = int.Parse(parsedResponse["count"].Value<string>().Trim());
                                }
                                else if (parsedResponse["totalCount"] != null)
                                {
                                    count = int.Parse(parsedResponse["totalCount"].Value<string>().Trim());
                                }

                                if (count != -1 && (count > (this.LastPageNumber * pageSize)))
                                {
                                    this.MoreResults = true;
                                }
                            }

                            APIObject[] getResults = new APIObject[] { };

                            if (parsedResponse["items"] != null)
                                getResults = processResults(parsedResponse["items"].ToString().Trim(), theObject.GetType());
                            else if (parsedResponse["entities"] != null)
                                getResults = processResults(parsedResponse["entities"].ToString().Trim(), theObject.GetType());
                            else
                                getResults = processResults(responseFromServer.Trim(), theObject.GetType());

                            this.Results = getResults.ToArray();
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
                using (var stream = we.Response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    this.Message = reader.ReadToEnd();
                }
            }
        }

        protected APIObject[] processResults(string restResponse, Type fuelType)
        {
            List<APIObject> allObjects = new System.Collections.Generic.List<APIObject>();

            if (restResponse != null)
            {
                if (JsonConvert.DeserializeObject(restResponse.ToString()) != null && JsonConvert.DeserializeObject(restResponse.ToString()).ToString() != "")
                {
                    if (restResponse.ToString().StartsWith("["))
                    {
                        JArray jsonArray = JArray.Parse(restResponse.ToString());
                        foreach (JObject obj in jsonArray)
                        {
                            APIObject currentObject = (APIObject)Activator.CreateInstance(fuelType, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance, null, new object[] { obj }, null);
                            allObjects.Add(currentObject);
                        }

                        return allObjects.ToArray();
                    }
                    else
                    {
                        JObject jsonObject = JObject.Parse(restResponse.ToString());
                        ResultDetail result = new ResultDetail();
                        APIObject currentObject = (APIObject)Activator.CreateInstance(fuelType, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance, null, new object[] { jsonObject }, null);
                        allObjects.Add(currentObject);
                        return allObjects.ToArray();
                    }
                }
                else
                    return allObjects.ToArray();
            }
            else
                return allObjects.ToArray();
        }
    }
}