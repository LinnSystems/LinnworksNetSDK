using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{
	public static class PrintServiceMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static CreatePDFResult CreatePDFfromJobForceTemplateStockIn(String templateType,List<PrintingKey> PrintingKeys,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplateStockIn", "templateType=" + templateType + "&PrintingKeys=" + Newtonsoft.Json.JsonConvert.SerializeObject(PrintingKeys, serializerSettings) + "&templateID=" + Newtonsoft.Json.JsonConvert.SerializeObject(templateID, serializerSettings) + "&parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "&printerName=" + printerName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static CreatePDFResult CreatePDFfromJobForceTemplate(String templateType,List<Guid> IDs,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplate", "templateType=" + templateType + "&IDs=" + Newtonsoft.Json.JsonConvert.SerializeObject(IDs, serializerSettings) + "&templateID=" + Newtonsoft.Json.JsonConvert.SerializeObject(templateID, serializerSettings) + "&parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "&printerName=" + printerName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static CreatePDFResult CreatePDFfromJobForceTemplateWithQuantities(String templateType,List<KeyValuePair<Guid,Int32>> IDsAndQuantities,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplateWithQuantities", "templateType=" + templateType + "&IDsAndQuantities=" + Newtonsoft.Json.JsonConvert.SerializeObject(IDsAndQuantities, serializerSettings) + "&templateID=" + Newtonsoft.Json.JsonConvert.SerializeObject(templateID, serializerSettings) + "&parameters=" + Newtonsoft.Json.JsonConvert.SerializeObject(parameters, serializerSettings) + "&printerName=" + printerName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static CreatePDFResult PrintTemplatePreview(Int32 templateId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/PrintTemplatePreview", "templateId=" + templateId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<TemplateHeader> GetTemplateList(String templateType,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<TemplateHeader>>(Factory.GetResponse("PrintService/GetTemplateList", "templateType=" + templateType + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<VirtualPrinter> VP_GetPrinters(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<VirtualPrinter>>(Factory.GetResponse("PrintService/VP_GetPrinters", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<PermissionsUser> GetUsersForPrinterConfig(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<PermissionsUser>>(Factory.GetResponse("PrintService/GetUsersForPrinterConfig", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static CreatePDFResult CreateReturnShippingLabelsPDFWithSKUs(String referenceNum,List<KeyValuePair<String,Int32>> SKUsAndQuantities,String returnPostalServiceName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreateReturnShippingLabelsPDFWithSKUs", "referenceNum=" + referenceNum + "&SKUsAndQuantities=" + Newtonsoft.Json.JsonConvert.SerializeObject(SKUsAndQuantities, serializerSettings) + "&returnPostalServiceName=" + returnPostalServiceName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static CreatePDFResult CreateReturnShippingLabelsPDF(List<Guid> IDs,List<KeyValuePair<Guid,Int32>> orderItemIdsAndQuantities,String returnPostalServiceName,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<CreatePDFResult>(Factory.GetResponse("PrintService/CreateReturnShippingLabelsPDF", "IDs=" + Newtonsoft.Json.JsonConvert.SerializeObject(IDs, serializerSettings) + "&orderItemIdsAndQuantities=" + Newtonsoft.Json.JsonConvert.SerializeObject(orderItemIdsAndQuantities, serializerSettings) + "&returnPostalServiceName=" + returnPostalServiceName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		} 
	}
}