namespace FuelSDK
{
    public class ET_DataExtension : DataExtension
    {
        public int? FolderID { get; set; }
        internal string FolderMediaType = "dataextension";
        public ET_DataExtensionColumn[] Columns { get; set; }
        public FuelSDK.PostReturn Post()
        {
            ET_DataExtension tempDE = this;
            tempDE.Fields = this.Columns;
            tempDE.Columns = null;
            PostReturn tempPR = new FuelSDK.PostReturn(tempDE);
            foreach (ResultDetail rd in tempPR.Results)
            {
                ((ET_DataExtension)rd.Object).Columns = (ET_DataExtensionColumn[])((ET_DataExtension)rd.Object).Fields;
                ((ET_DataExtension)rd.Object).Fields = null;
            }
            return tempPR;
        }
        public FuelSDK.PatchReturn Patch()
        {
            ET_DataExtension tempDE = this;
            tempDE.Fields = this.Columns;
            tempDE.Columns = null;
            PatchReturn tempPR = new FuelSDK.PatchReturn(tempDE);
            foreach (ResultDetail rd in tempPR.Results)
            {
                ((ET_DataExtension)rd.Object).Columns = (ET_DataExtensionColumn[])((ET_DataExtension)rd.Object).Fields;
                ((ET_DataExtension)rd.Object).Fields = null;
            }
            return tempPR;
        }
        public FuelSDK.DeleteReturn Delete()
        {
            ET_DataExtension tempDE = this;
            tempDE.Fields = this.Columns;
            return new FuelSDK.DeleteReturn(tempDE);
        }
        public FuelSDK.GetReturn Get()
        {
            FuelSDK.GetReturn response = new GetReturn(this);
            this.LastRequestID = response.RequestID;
            foreach (ET_DataExtension rd in response.Results)
            {
                rd.Columns = (ET_DataExtensionColumn[])rd.Fields;
                rd.Fields = null;
            }
            return response;
        }
        public FuelSDK.GetReturn GetMoreResults()
        {
            FuelSDK.GetReturn response = new GetReturn(this, true, null);
            this.LastRequestID = response.RequestID;
            foreach (ET_DataExtension rd in response.Results)
            {
                rd.Columns = (ET_DataExtensionColumn[])rd.Fields;
                rd.Fields = null;
            }
            return response;
        }
        public FuelSDK.InfoReturn Info()
        {
            return new FuelSDK.InfoReturn(this);
        }
    }
}