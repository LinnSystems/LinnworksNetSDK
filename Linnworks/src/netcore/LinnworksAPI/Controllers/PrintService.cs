using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Threading.Tasks;

namespace LinnworksAPI
{
    public class PrintServiceController : BaseController, IPrintServiceController
    {
        public PrintServiceController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Creates a PDF file from a print job request 
        /// </summary>
        /// <param name="templateType">The template type</param>
        /// <param name="IDs">A list of IDs to print (e.g. Order IDs or Warehouse Transfer IDs)</param>
        /// <param name="templateID">The ID of the template to use</param>
        /// <param name="parameters"></param>
        /// <param name="printerName">printer name of the ivrtual printer to use. If null then the sepecified in the template</param>
        /// <param name="printZoneCode">Print zone code, if present, will override the printer used if the template has a set printer for that zone</param>
        /// <param name="pageStartNumber">First page number. Used for splitting prints into multiple requests.</param>
        public CreatePDFResult CreatePDFfromJobForceTemplate(String templateType,List<Guid> IDs,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName,String printZoneCode = "",Int32 pageStartNumber = 0,Guid? operationId = null,ClientContext context = null)
		{
			var response = GetResponse("PrintService/CreatePDFfromJobForceTemplate", "templateType=" + System.Net.WebUtility.UrlEncode(templateType) + "&IDs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(IDs)) + "&templateID=" + templateID + "&parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "&printerName=" + System.Net.WebUtility.UrlEncode(printerName) + "&printZoneCode=" + System.Net.WebUtility.UrlEncode(printZoneCode) + "&pageStartNumber=" + pageStartNumber + "&operationId=" + operationId + "&context=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(context)) + "");
            return JsonFormatter.ConvertFromJson<CreatePDFResult>(response);
		}

		/// <summary>
        /// Creates a PDF file from a print job request 
        /// </summary>
        /// <param name="templateType">The template type</param>
        /// <param name="PrintingKeys">A list of IDs to print (e.g. Order IDs or Warehouse Transfer IDs)</param>
        /// <param name="templateID">The ID of the template to use</param>
        /// <param name="parameters"></param>
        /// <param name="printerName">printer name of the ivrtual printer to use. If null then the sepecified in the template</param>
        /// <param name="printZoneCode">Print zone code, if present, will override the printer used if the template has a set printer for that zone</param>
        public CreatePDFResult CreatePDFfromJobForceTemplateStockIn(String templateType,List<PrintingKey> PrintingKeys,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName,String printZoneCode = "",Int32 pageStartNumber = 0,Guid? operationId = null,ClientContext context = null)
		{
			var response = GetResponse("PrintService/CreatePDFfromJobForceTemplateStockIn", "templateType=" + System.Net.WebUtility.UrlEncode(templateType) + "&PrintingKeys=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(PrintingKeys)) + "&templateID=" + templateID + "&parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "&printerName=" + System.Net.WebUtility.UrlEncode(printerName) + "&printZoneCode=" + System.Net.WebUtility.UrlEncode(printZoneCode) + "&pageStartNumber=" + pageStartNumber + "&operationId=" + operationId + "&context=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(context)) + "");
            return JsonFormatter.ConvertFromJson<CreatePDFResult>(response);
		}

		/// <summary>
        /// Creates a PDF file with Stock Item labels from a print job request 
        /// </summary>
        /// <param name="templateType">The template type</param>
        /// <param name="IDsAndQuantities">Stock Id and quantity of stock</param>
        /// <param name="templateID">The ID of the template to use</param>
        /// <param name="parameters"></param>
        /// <param name="printerName">Printer name of the virtual printer to use. If null then the sepecified in the template</param>
        /// <param name="printZoneCode">Print zone code, if present, will override the printer used if the template has a set printer for that zone</param>
        public CreatePDFResult CreatePDFfromJobForceTemplateWithQuantities(String templateType,List<KeyValuePair<Guid,Int32>> IDsAndQuantities,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName,String printZoneCode = "")
		{
			var response = GetResponse("PrintService/CreatePDFfromJobForceTemplateWithQuantities", "templateType=" + System.Net.WebUtility.UrlEncode(templateType) + "&IDsAndQuantities=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(IDsAndQuantities)) + "&templateID=" + templateID + "&parameters=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(parameters)) + "&printerName=" + System.Net.WebUtility.UrlEncode(printerName) + "&printZoneCode=" + System.Net.WebUtility.UrlEncode(printZoneCode) + "");
            return JsonFormatter.ConvertFromJson<CreatePDFResult>(response);
		}

		/// <summary>
        /// Creates a PDF file of return shipping labels for a single order 
        /// </summary>
        /// <param name="IDs">A list containing the (single) pkOrderId of the order to print return labels for</param>
        /// <param name="orderItemIdsAndQuantities">A list of the order item IDs and quantities to include. If empty then same as the outbound shipment</param>
        /// <param name="returnPostalServiceName">Name of the postal service to use. If null then specified in settings or same as the outbound shipment</param>
        public CreatePDFResult CreateReturnShippingLabelsPDF(List<Guid> IDs,List<KeyValuePair<Guid,Int32>> orderItemIdsAndQuantities,String returnPostalServiceName)
		{
			var response = GetResponse("PrintService/CreateReturnShippingLabelsPDF", "IDs=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(IDs)) + "&orderItemIdsAndQuantities=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(orderItemIdsAndQuantities)) + "&returnPostalServiceName=" + System.Net.WebUtility.UrlEncode(returnPostalServiceName) + "");
            return JsonFormatter.ConvertFromJson<CreatePDFResult>(response);
		}

		/// <summary>
        /// Creates a PDF file of return shipping labels for a single order 
        /// </summary>
        /// <param name="referenceNum">Reference number of the order to print return labels for</param>
        /// <param name="SKUsAndQuantities">A list of the SKUs and quantities to include. If empty then same as the outbound shipment</param>
        /// <param name="returnPostalServiceName">Name of the postal service to use. If null then specified in settings or same as the outbound shipment</param>
        public CreatePDFResult CreateReturnShippingLabelsPDFWithSKUs(String referenceNum,List<KeyValuePair<String,Int32>> SKUsAndQuantities,String returnPostalServiceName)
		{
			var response = GetResponse("PrintService/CreateReturnShippingLabelsPDFWithSKUs", "referenceNum=" + System.Net.WebUtility.UrlEncode(referenceNum) + "&SKUsAndQuantities=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(SKUsAndQuantities)) + "&returnPostalServiceName=" + System.Net.WebUtility.UrlEncode(returnPostalServiceName) + "");
            return JsonFormatter.ConvertFromJson<CreatePDFResult>(response);
		}

		/// <summary>
        /// Get list of templates for a specific type 
        /// </summary>
        /// <param name="templateType">The template type to load (e.g. Warehouse Transfer). Empty body will return them all</param>
        public List<TemplateHeader> GetTemplateList(String templateType)
		{
			var response = GetResponse("PrintService/GetTemplateList", "templateType=" + System.Net.WebUtility.UrlEncode(templateType) + "");
            return JsonFormatter.ConvertFromJson<List<TemplateHeader>>(response);
		}

		/// <summary>
        /// Gets a list of users for printer configuration. Only super admin can get the full list. Non super admins can only get their own user 
        /// </summary>
        /// <returns>Returns a list of users for printer configuration</returns>
        public List<PermissionsUser> GetUsersForPrinterConfig()
		{
			var response = GetResponse("PrintService/GetUsersForPrinterConfig", "");
            return JsonFormatter.ConvertFromJson<List<PermissionsUser>>(response);
		}

		/// <summary>
        /// Generate a PDF preview of a specific template 
        /// </summary>
        /// <param name="templateId">Template id</param>
        /// <returns>Object with the PDF url</returns>
        public CreatePDFResult PrintTemplatePreview(Int32 templateId)
		{
			var response = GetResponse("PrintService/PrintTemplatePreview", "templateId=" + templateId + "");
            return JsonFormatter.ConvertFromJson<CreatePDFResult>(response);
		}

		/// <summary>
        /// Gets list of virtual printers. 
        /// </summary>
        public List<VirtualPrinter> VP_GetPrinters()
		{
			var response = GetResponse("PrintService/VP_GetPrinters", "");
            return JsonFormatter.ConvertFromJson<List<VirtualPrinter>>(response);
		} 
    }
}