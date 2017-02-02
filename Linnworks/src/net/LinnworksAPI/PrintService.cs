using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class PrintServiceMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

        public static CreatePDFResult CreatePDFfromJobForceTemplate(String templateType, List<Guid> IDs, Int32? templateID, List<KeyValuePair<String, String>> parameters, String printerName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplate", "templateType=" + templateType + "&IDs=" + Newtonsoft.Json.JsonConvert.SerializeObject(IDs, serializerSettings) + "&templateID=" + Newtonsoft.Json.JsonConvert.SerializeObject(templateID, serializerSettings) + "&parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "&printerName=" + printerName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CreatePDFResult CreatePDFfromJobForceTemplateWithQuantities(String templateType, List<KeyValuePair<Guid, Int32>> IDsAndQuantities, Int32? templateID, List<KeyValuePair<String, String>> parameters, String printerName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplateWithQuantities", "templateType=" + templateType + "&IDsAndQuantities=" + Newtonsoft.Json.JsonConvert.SerializeObject(IDsAndQuantities, serializerSettings) + "&templateID=" + Newtonsoft.Json.JsonConvert.SerializeObject(templateID, serializerSettings) + "&parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "&printerName=" + printerName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static CreatePDFResult PrintTemplatePreview(Int32 templateId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/PrintTemplatePreview", "templateId=" + templateId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<TemplateHeader> GetTemplateList(String templateType, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<TemplateHeader>>(Factory.GetResponse("PrintService/GetTemplateList", "templateType=" + templateType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<VirtualPrinter> VP_GetPrinters(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<VirtualPrinter>>(Factory.GetResponse("PrintService/VP_GetPrinters", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<PermissionsUser> GetUsersForPrinterConfig(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionsUser>>(Factory.GetResponse("PrintService/GetUsersForPrinterConfig", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}