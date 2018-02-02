using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;

namespace LinnworksAPI
{ 
    public interface IPrintServiceController
	{
		CreatePDFResult CreatePDFfromJobForceTemplate(String templateType,List<Guid> IDs,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName);
		CreatePDFResult CreatePDFfromJobForceTemplateStockIn(String templateType,List<PrintingKey> PrintingKeys,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName);
		CreatePDFResult CreatePDFfromJobForceTemplateWithQuantities(String templateType,List<KeyValuePair<Guid,Int32>> IDsAndQuantities,Int32? templateID,List<KeyValuePair<String,String>> parameters,String printerName);
		CreatePDFResult CreateReturnShippingLabelsPDF(List<Guid> IDs,List<KeyValuePair<Guid,Int32>> orderItemIdsAndQuantities,String returnPostalServiceName);
		CreatePDFResult CreateReturnShippingLabelsPDFWithSKUs(String referenceNum,List<KeyValuePair<String,Int32>> SKUsAndQuantities,String returnPostalServiceName);
		List<TemplateHeader> GetTemplateList(String templateType);
		List<PermissionsUser> GetUsersForPrinterConfig();
		CreatePDFResult PrintTemplatePreview(Int32 templateId);
		List<VirtualPrinter> VP_GetPrinters();
	} 
}