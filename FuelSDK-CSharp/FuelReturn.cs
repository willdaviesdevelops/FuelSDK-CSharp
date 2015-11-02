using System;
using System.Collections.Generic;
using System.Reflection;

namespace FuelSDK
{
    public abstract class FuelReturn
    {
        public Boolean Status { get; set; }
        public String Message { get; set; }
        public Boolean MoreResults { get; set; }
        public int Code { get; set; }
        public string RequestID { get; set; }

        private Dictionary<Type, Type> translator = new Dictionary<Type, Type>();

        public FuelReturn()
        {
            translator.Add(typeof(ET_Folder), typeof(DataFolder));
            translator.Add(typeof(DataFolder), typeof(ET_Folder));

            translator.Add(typeof(ET_List), typeof(List));
            translator.Add(typeof(List), typeof(ET_List));

            translator.Add(typeof(ET_ContentArea), typeof(ContentArea));
            translator.Add(typeof(ContentArea), typeof(ET_ContentArea));

            translator.Add(typeof(ET_ObjectDefinition), typeof(ObjectDefinition));
            translator.Add(typeof(ObjectDefinition), typeof(ET_ObjectDefinition));

            translator.Add(typeof(ET_PropertyDefinition), typeof(PropertyDefinition));
            translator.Add(typeof(PropertyDefinition), typeof(ET_PropertyDefinition));

            translator.Add(typeof(Subscriber), typeof(ET_Subscriber));
            translator.Add(typeof(ET_Subscriber), typeof(Subscriber));

            translator.Add(typeof(ET_ProfileAttribute), typeof(FuelSDK.Attribute));
            translator.Add(typeof(FuelSDK.Attribute), typeof(ET_ProfileAttribute));

            translator.Add(typeof(ET_Email), typeof(FuelSDK.Email));
            translator.Add(typeof(FuelSDK.Email), typeof(ET_Email));

            translator.Add(typeof(ET_SubscriberList), typeof(FuelSDK.SubscriberList));
            translator.Add(typeof(FuelSDK.SubscriberList), typeof(ET_SubscriberList));

            translator.Add(typeof(ET_List_Subscriber), typeof(FuelSDK.ListSubscriber));
            translator.Add(typeof(FuelSDK.ListSubscriber), typeof(ET_List_Subscriber));

            translator.Add(typeof(ET_DataExtension), typeof(FuelSDK.DataExtension));
            translator.Add(typeof(FuelSDK.DataExtension), typeof(ET_DataExtension));

            translator.Add(typeof(ET_DataExtensionColumn), typeof(FuelSDK.DataExtensionField));
            translator.Add(typeof(FuelSDK.DataExtensionField), typeof(ET_DataExtensionColumn));

            translator.Add(typeof(ET_DataExtensionRow), typeof(FuelSDK.DataExtensionObject));
            translator.Add(typeof(FuelSDK.DataExtensionObject), typeof(ET_DataExtensionRow));

            translator.Add(typeof(ET_SendClassification), typeof(FuelSDK.SendClassification));
            translator.Add(typeof(FuelSDK.SendClassification), typeof(ET_SendClassification));

            translator.Add(typeof(ET_SendDefinitionList), typeof(FuelSDK.SendDefinitionList));
            translator.Add(typeof(FuelSDK.SendDefinitionList), typeof(ET_SendDefinitionList));

            translator.Add(typeof(ET_SenderProfile), typeof(FuelSDK.SenderProfile));
            translator.Add(typeof(FuelSDK.SenderProfile), typeof(ET_SenderProfile));

            translator.Add(typeof(ET_DeliveryProfile), typeof(FuelSDK.DeliveryProfile));
            translator.Add(typeof(FuelSDK.DeliveryProfile), typeof(ET_DeliveryProfile));

            translator.Add(typeof(ET_TriggeredSend), typeof(FuelSDK.TriggeredSendDefinition));
            translator.Add(typeof(FuelSDK.TriggeredSendDefinition), typeof(ET_TriggeredSend));

            translator.Add(typeof(ET_EmailSendDefinition), typeof(FuelSDK.EmailSendDefinition));
            translator.Add(typeof(FuelSDK.EmailSendDefinition), typeof(ET_EmailSendDefinition));

            translator.Add(typeof(ET_Send), typeof(FuelSDK.Send));
            translator.Add(typeof(FuelSDK.Send), typeof(ET_Send));

            translator.Add(typeof(ET_Import), typeof(FuelSDK.ImportDefinition));
            translator.Add(typeof(FuelSDK.ImportDefinition), typeof(ET_Import));

            translator.Add(typeof(ET_ImportResult), typeof(FuelSDK.ImportResultsSummary));
            translator.Add(typeof(FuelSDK.ImportResultsSummary), typeof(ET_ImportResult));

            // The translation for this is handled in the Get() method for DataExtensionObject so no need to translate it
            translator.Add(typeof(APIProperty), typeof(APIProperty));

            translator.Add(typeof(ET_Trigger), typeof(FuelSDK.TriggeredSend));
            translator.Add(typeof(FuelSDK.TriggeredSend), typeof(ET_Trigger));

            // Tracking Events
            translator.Add(typeof(ET_BounceEvent), typeof(BounceEvent));
            translator.Add(typeof(BounceEvent), typeof(ET_BounceEvent));
            translator.Add(typeof(OpenEvent), typeof(ET_OpenEvent));
            translator.Add(typeof(ET_OpenEvent), typeof(OpenEvent));
            translator.Add(typeof(ET_ClickEvent), typeof(ClickEvent));
            translator.Add(typeof(ClickEvent), typeof(ET_ClickEvent));
            translator.Add(typeof(ET_UnsubEvent), typeof(UnsubEvent));
            translator.Add(typeof(UnsubEvent), typeof(ET_UnsubEvent));
            translator.Add(typeof(ET_SentEvent), typeof(SentEvent));
            translator.Add(typeof(SentEvent), typeof(ET_SentEvent));

        }


        public APIObject TranslateObject(APIObject inputObject)
        {

            if (this.translator.ContainsKey(inputObject.GetType()))
            {
                APIObject returnObject = (APIObject)Activator.CreateInstance(translator[inputObject.GetType()]);

                foreach (PropertyInfo prop in inputObject.GetType().GetProperties())
                {
                    if ((prop.PropertyType.IsSubclassOf(typeof(APIObject)) || prop.PropertyType == typeof(APIObject)) && prop.GetValue(inputObject, null) != null)
                    {
                        prop.SetValue(returnObject, this.TranslateObject(prop.GetValue(inputObject, null)), null);
                    }
                    else if (translator.ContainsKey(prop.PropertyType) && prop.GetValue(inputObject, null) != null)
                    {
                        prop.SetValue(returnObject, this.TranslateObject(prop.GetValue(inputObject, null)), null);
                    }
                    else if (prop.PropertyType.IsArray && prop.GetValue(inputObject, null) != null)
                    {
                        Array a = (Array)prop.GetValue(inputObject, null);
                        Array outArray;

                        if (a.Length > 0)
                        {
                            if (translator.ContainsKey(a.GetValue(0).GetType()))
                            {
                                outArray = Array.CreateInstance(translator[a.GetValue(0).GetType()], a.Length);

                                for (int i = 0; i < a.Length; i++)
                                {
                                    if (translator.ContainsKey(a.GetValue(i).GetType()))
                                    {
                                        outArray.SetValue(TranslateObject(a.GetValue(i)), i);
                                    }
                                }
                                if (outArray.Length > 0)
                                {
                                    prop.SetValue(returnObject, outArray, null);
                                }
                            }
                        }
                    }
                    else if (prop.Name == "FolderID" && prop.GetValue(inputObject, null) != null)
                    {
                        if (inputObject.GetType().GetProperty("Category") != null)
                        {
                            PropertyInfo categoryIDProp = inputObject.GetType().GetProperty("Category");
                            categoryIDProp.SetValue(returnObject, prop.GetValue(inputObject, null), null);
                        }
                        else if (inputObject.GetType().GetProperty("CategoryID") != null)
                        {
                            PropertyInfo categoryIDProp = inputObject.GetType().GetProperty("CategoryID");
                            categoryIDProp.SetValue(returnObject, prop.GetValue(inputObject, null), null);
                        }
                    }
                    else if ((prop.Name == "CategoryIDSpecified" || prop.Name == "CategorySpecified") && prop.GetValue(inputObject, null) != null)
                    {
                        // Do nothing
                    }
                    else if ((prop.Name == "CategoryID" || prop.Name == "Category") && prop.GetValue(inputObject, null) != null)
                    {
                        if (returnObject.GetType().GetProperty("FolderID") != null)
                        {
                            PropertyInfo folderIDProp = returnObject.GetType().GetProperty("FolderID");
                            folderIDProp.SetValue(returnObject, Convert.ToInt32(prop.GetValue(inputObject, null)), null);

                        }
                    }
                    else if (prop.GetValue(inputObject, null) != null && returnObject.GetType().GetProperty(prop.Name) != null)
                    {
                        prop.SetValue(returnObject, prop.GetValue(inputObject, null), null);
                    }

                }
                return returnObject;

            }
            else
            {
                return inputObject;
            }
        }

        protected object TranslateObject(object inputObject)
        {

            if (this.translator.ContainsKey(inputObject.GetType()))
            {
                object returnObject = (object)Activator.CreateInstance(translator[inputObject.GetType()]);
                foreach (PropertyInfo prop in inputObject.GetType().GetProperties())
                {
                    if (prop.GetValue(inputObject, null) != null && returnObject.GetType().GetProperty(prop.Name) != null)
                    {
                        prop.SetValue(returnObject, prop.GetValue(inputObject, null), null);
                    }
                }
                return returnObject;

            }
            else
            {
                return inputObject;
            }
        }
    }
}