using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
namespace LinnworksAPI
{public static class PrintServiceMethods 
{ public static CreatePDFResult CreatePDFfromJobForceTemplate(String templateType,List<Guid> IDs,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplate", "templateType=" + templateType + "&IDs=" + Newtonsoft.Json.JsonConvert.SerializeObject(IDs) + "&templateID=" + Newtonsoft.Json.JsonConvert.SerializeObject(templateID) + "&parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters) + "&printerName=" + printerName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static CreatePDFResult PrintTemplatePreview(Int32 templateId,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/PrintTemplatePreview", "templateId=" + templateId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<TemplateHeader> GetTemplateList(String templateType,String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<TemplateHeader>>(Factory.GetResponse("PrintService/GetTemplateList", "templateType=" + templateType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
}

public static List<VirtualPrinter> VP_GetPrinters(String ApiToken, String ApiServer)
{
 return Newtonsoft.Json.JsonConvert.DeserializeObject<List<VirtualPrinter>>(Factory.GetResponse("PrintService/VP_GetPrinters", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
} 
}
}