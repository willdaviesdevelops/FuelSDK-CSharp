using System;
using System.Collections.Generic;

namespace FuelSDK
{
    public class ET_DataExtensionRow : FuelSDK.DataExtensionObject
    {
        public string DataExtensionName { get; set; }
        public string DataExtensionCustomerKey { get; set; }
        public Dictionary<string, string> ColumnValues { get; set; }

        public ET_DataExtensionRow()
        {
            ColumnValues = new Dictionary<string, string>();
        }

        public FuelSDK.PostReturn Post()
        {
            this.GetDataExtensionCustomerKey();
            ET_DataExtensionRow tempRow = this;
            tempRow.CustomerKey = this.DataExtensionCustomerKey;
            List<APIProperty> lProperties = new List<APIProperty>();
            foreach (KeyValuePair<string, string> kvp in this.ColumnValues)
            {
                APIProperty tempAPIProp = new APIProperty() { Name = kvp.Key, Value = kvp.Value };
                lProperties.Add(tempAPIProp);
            }
            tempRow.ColumnValues = null;
            tempRow.Properties = lProperties.ToArray();
            tempRow.DataExtensionName = null;
            tempRow.DataExtensionCustomerKey = null;
            return new FuelSDK.PostReturn(tempRow);
        }
        public FuelSDK.PatchReturn Patch()
        {
            this.GetDataExtensionCustomerKey();
            ET_DataExtensionRow tempRow = this;
            tempRow.CustomerKey = this.DataExtensionCustomerKey;
            List<APIProperty> lProperties = new List<APIProperty>();
            foreach (KeyValuePair<string, string> kvp in this.ColumnValues)
            {
                APIProperty tempAPIProp = new APIProperty() { Name = kvp.Key, Value = kvp.Value };
                lProperties.Add(tempAPIProp);
            }
            tempRow.ColumnValues = null;
            tempRow.Properties = lProperties.ToArray();
            tempRow.DataExtensionName = null;
            tempRow.DataExtensionCustomerKey = null;
            return new FuelSDK.PatchReturn(tempRow);
        }
        public FuelSDK.DeleteReturn Delete()
        {
            this.GetDataExtensionCustomerKey();
            ET_DataExtensionRow tempRow = this;
            tempRow.CustomerKey = this.DataExtensionCustomerKey;
            List<APIProperty> lProperties = new List<APIProperty>();
            foreach (KeyValuePair<string, string> kvp in this.ColumnValues)
            {
                APIProperty tempAPIProp = new APIProperty() { Name = kvp.Key, Value = kvp.Value };
                lProperties.Add(tempAPIProp);
            }
            tempRow.ColumnValues = null;
            tempRow.Keys = lProperties.ToArray();
            tempRow.DataExtensionName = null;
            tempRow.DataExtensionCustomerKey = null;
            return new FuelSDK.DeleteReturn(tempRow);
        }
        public FuelSDK.GetReturn Get()
        {
            this.GetDataExtensionName();
            FuelSDK.GetReturn response = new GetReturn(this, false, "DataExtensionObject[" + this.DataExtensionName + "]");
            this.LastRequestID = response.RequestID;

            foreach (ET_DataExtensionRow dr in response.Results)
            {
                Dictionary<string, string> returnColumns = new Dictionary<string, string>();
                foreach (APIProperty ap in dr.Properties)
                {
                    returnColumns.Add(ap.Name, ap.Value);
                }
                dr.ColumnValues = returnColumns;
                dr.Properties = null;
            }

            return response;
        }
        public FuelSDK.GetReturn GetMoreResults()
        {
            this.GetDataExtensionName();
            FuelSDK.GetReturn response = new GetReturn(this, true, "DataExtensionObject[" + this.DataExtensionName + "]");
            this.LastRequestID = response.RequestID;

            foreach (ET_DataExtensionRow dr in response.Results)
            {
                Dictionary<string, string> returnColumns = new Dictionary<string, string>();
                foreach (APIProperty ap in dr.Properties)
                {
                    returnColumns.Add(ap.Name, ap.Value);
                }
                dr.ColumnValues = returnColumns;
                dr.Properties = null;
            }

            return response;
        }
        public FuelSDK.InfoReturn Info()
        {
            return new FuelSDK.InfoReturn(this);
        }

        private void GetDataExtensionName()
        {
            if (this.DataExtensionName == null)
            {
                if (this.DataExtensionCustomerKey != null)
                {
                    ET_DataExtension lookupDE = new ET_DataExtension();
                    lookupDE.AuthStub = this.AuthStub;
                    lookupDE.Props = new string[] { "Name", "CustomerKey" };
                    lookupDE.SearchFilter = new SimpleFilterPart() { Property = "CustomerKey", SimpleOperator = SimpleOperators.equals, Value = new string[] { this.DataExtensionCustomerKey } };
                    GetReturn grDEName = lookupDE.Get();

                    if (grDEName.Status && grDEName.Results.Length > 0)
                    {
                        this.DataExtensionName = ((ET_DataExtension)grDEName.Results[0]).Name;
                    }
                    else
                    {
                        throw new Exception("Unable to process ET_DataExtensionRow request due to unable to find DataExtension based on CustomerKey");
                    }
                }
                else
                {
                    throw new Exception("Unable to process ET_DataExtensionRow request due to DataExtensionCustomerKey or DataExtensionName not being defined on ET_DatExtensionRow");
                }
            }
        }

        private void GetDataExtensionCustomerKey()
        {
            if (this.DataExtensionCustomerKey == null)
            {
                if (this.DataExtensionName != null)
                {
                    ET_DataExtension lookupDE = new ET_DataExtension();
                    lookupDE.AuthStub = this.AuthStub;
                    lookupDE.Props = new string[] { "Name", "CustomerKey" };
                    lookupDE.SearchFilter = new SimpleFilterPart() { Property = "Name", SimpleOperator = SimpleOperators.equals, Value = new string[] { this.DataExtensionName } };
                    GetReturn grDEName = lookupDE.Get();

                    if (grDEName.Status && grDEName.Results.Length > 0)
                    {
                        this.DataExtensionCustomerKey = ((ET_DataExtension)grDEName.Results[0]).CustomerKey;
                    }
                    else
                    {
                        throw new Exception("Unable to process ET_DataExtensionRow request due to unable to find DataExtension based on DataExtensionName provided.");
                    }
                }
                else
                {
                    throw new Exception("Unable to process ET_DataExtensionRow request due to DataExtensionCustomerKey or DataExtensionName not being defined on ET_DatExtensionRow");
                }
            }
        }
    }
}