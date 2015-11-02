using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Collections.Specialized;
using Newtonsoft.Json.Linq;
using System.Net;
using System.IO;

/*
 * <?xml version="1.0" encoding="utf-8" ?>
<configuration>
    <appSignature>none</appSignature>
    <clientId>###########################</clientId>
    <clientSecret>###########################</clientSecret>
    <soapEndPoint>https://webservice.s4.exacttarget.com/Service.asmx</soapEndPoint>
</configuration>
 */ 

namespace FuelSDK
{
    public class ET_Client
    {
        //Variables
        public string authToken;
        public SoapClient soapclient;
        private string appSignature = string.Empty;
        private string clientId = string.Empty;
        private string clientSecret = string.Empty;
        private string soapEndPoint = string.Empty;
        private string sandbox = string.Empty;
        public string internalAuthToken = string.Empty;
        private string refreshKey = string.Empty;
        private DateTime authTokenExpiration = DateTime.Now;
        public string SDKVersion = "FuelSDX-C#-V.9";

        //Constructor
        public ET_Client(NameValueCollection parameters = null)
        {
            //Get configuration file and set variables
            if (File.Exists(@"FuelSDK_config.xml"))
            {
                System.Xml.XPath.XPathDocument doc = new System.Xml.XPath.XPathDocument(@"FuelSDK_config.xml");

                foreach (System.Xml.XPath.XPathNavigator child in doc.CreateNavigator().Select("configuration"))
                {
                    appSignature = child.SelectSingleNode("appSignature").Value.ToString().Trim();
                    clientId = child.SelectSingleNode("clientId").Value.ToString().Trim();
                    clientSecret = child.SelectSingleNode("clientSecret").Value.ToString().Trim();
                    soapEndPoint = child.SelectSingleNode("soapEndPoint").Value.ToString().Trim();
                }
            }

            if (parameters != null)
            {
                if (parameters.AllKeys.Contains("appSignature"))
                    appSignature = parameters["appSignature"];
                if (parameters.AllKeys.Contains("clientId"))
                    clientId = parameters["clientId"];
                if (parameters.AllKeys.Contains("clientSecret"))
                    clientSecret = parameters["clientSecret"];
                if (parameters.AllKeys.Contains("soapEndPoint"))
                    soapEndPoint = parameters["soapEndPoint"];
                if (parameters.AllKeys.Contains("sandbox"))
                    sandbox = parameters["sandbox"];
            }

            if (clientId.Equals(string.Empty) || clientSecret.Equals(string.Empty))
                throw new Exception("clientId or clientSecret is null: Must be provided in config file or passed when instantiating ET_Client");

            //If JWT URL Parameter Used
            if (parameters != null && parameters.AllKeys.Contains("jwt"))
            {
                if (appSignature.Equals(string.Empty))
                    throw new Exception("Unable to utilize JWT for SSO without appSignature: Must be provided in config file or passed when instantiating ET_Client");
                string encodedJWT = parameters["jwt"].ToString().Trim();
                String decodedJWT = JsonWebToken.Decode(encodedJWT, appSignature);
                JObject parsedJWT = JObject.Parse(decodedJWT);
                authToken = parsedJWT["request"]["user"]["oauthToken"].Value<string>().Trim();
                authTokenExpiration = DateTime.Now.AddSeconds(int.Parse(parsedJWT["request"]["user"]["expiresIn"].Value<string>().Trim()));
                internalAuthToken = parsedJWT["request"]["user"]["internalOauthToken"].Value<string>().Trim();
                refreshKey = parsedJWT["request"]["user"]["refreshToken"].Value<string>().Trim();
            }
            else
            {
                refreshToken();
            }

            // Find the appropriate endpoint for the acccount
            ET_Endpoint getSingleEndpoint = new ET_Endpoint();
            getSingleEndpoint.AuthStub = this;
            getSingleEndpoint.Type = "soap";
            GetReturn grSingleEndpoint = getSingleEndpoint.Get();

            if (grSingleEndpoint.Status && grSingleEndpoint.Results.Length == 1)
            {
                soapEndPoint = ((ET_Endpoint)grSingleEndpoint.Results[0]).URL;
            }
            else
            {
                throw new Exception("Unable to determine stack using /platform/v1/endpoints: " + grSingleEndpoint.Message);
            }

            //Create the SOAP binding for call with Oauth.
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Name = "UserNameSoapBinding";
            binding.Security.Mode = BasicHttpSecurityMode.TransportWithMessageCredential;
            binding.MaxReceivedMessageSize = 2147483647;
            soapclient = new SoapClient(binding, new EndpointAddress(new Uri(soapEndPoint)));
            soapclient.ClientCredentials.UserName.UserName = "*";
            soapclient.ClientCredentials.UserName.Password = "*";

        }

        public void refreshToken(bool force = false)
        {
            //RefreshToken
            if ((authToken == null || authToken.Length == 0 || DateTime.Now.AddSeconds(300) > authTokenExpiration) || force)
            {
                string strURL = "https://auth.exacttargetapis.com/v1/requestToken?legacy=1";
                if (sandbox == "true")
                    strURL = "https://auth-test.exacttargetapis.com/v1/requestToken?legacy=1";                    
                

                //Build the request
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strURL.Trim());
                request.Method = "POST";
                request.ContentType = "application/json";
                request.UserAgent = this.SDKVersion;

                string json;
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {

                    if (refreshKey.Length > 0)
                        json = @"{""clientId"": """ + clientId + @""", ""clientSecret"": """ + clientSecret + @""", ""refreshToken"": """ + refreshKey + @""", ""scope"": ""cas:" + internalAuthToken + @""" , ""accessType"": ""offline""}";
                    else
                        json = @"{""clientId"": """ + clientId + @""", ""clientSecret"": """ + clientSecret + @"""}";
                    streamWriter.Write(json);
                }

                //Get the response
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

                //Parse the response
                JObject parsedResponse = JObject.Parse(responseFromServer);
                internalAuthToken = parsedResponse["legacyToken"].Value<string>().Trim();
                authToken = parsedResponse["accessToken"].Value<string>().Trim();
                authTokenExpiration = DateTime.Now.AddSeconds(int.Parse(parsedResponse["expiresIn"].Value<string>().Trim()));
                if (parsedResponse["refreshToken"] != null)
                    refreshKey = parsedResponse["refreshToken"].Value<string>().Trim();
            }
        }

        public FuelReturn AddSubscribersToList(string EmailAddress, string SubscriberKey, List<int> ListIDs)
        {
            return this.ProcessAddSubscriberToList(EmailAddress, SubscriberKey, ListIDs);
        }

        public FuelReturn AddSubscribersToList(string EmailAddress, List<int> ListIDs)
        {
            return this.ProcessAddSubscriberToList(EmailAddress, null, ListIDs);
        }

        protected FuelReturn ProcessAddSubscriberToList(string EmailAddress, string SubscriberKey, List<int> ListIDs)
        {
            ET_Subscriber sub = new ET_Subscriber();
            sub.EmailAddress = EmailAddress;
            if (SubscriberKey != null)
                sub.SubscriberKey = SubscriberKey;
            List<ET_SubscriberList> lLists = new List<ET_SubscriberList>();
            foreach (int listID in ListIDs)
            {
                ET_SubscriberList feList = new ET_SubscriberList();
                feList.ID = listID;
                lLists.Add(feList);
            }
            sub.AuthStub = this;
            sub.Lists = lLists.ToArray();
            PostReturn prAddSub = sub.Post();
            if (!prAddSub.Status && prAddSub.Results.Length > 0 && prAddSub.Results[0].ErrorCode == 12014)
            {
                return sub.Patch();
            }
            else
            {
                return prAddSub;
            }
        }

        public FuelReturn CreateDataExtensions(ET_DataExtension[] ArrayOfET_DataExtension)
        {

            List<ET_DataExtension> cleanedArray = new List<ET_DataExtension>();

            foreach (ET_DataExtension de in ArrayOfET_DataExtension)
            {
                de.Fields = de.Columns;
                de.Columns = null;
                cleanedArray.Add(de);
            }
            return new PostReturn(cleanedArray.ToArray(), this);
        }

    }


    // Subscriber Related Objects

    //Content Related


    // Data Extension Objects 


    // Misc Objects


    // Tracking Events

    //
}