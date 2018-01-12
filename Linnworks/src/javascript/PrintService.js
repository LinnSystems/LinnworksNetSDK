var PrintService =
{
	// http://apidoc.linnworks.net/#/PrintService-CreatePDFfromJobForceTemplate
	CreatePDFfromJobForceTemplate: function(templateType,IDs,templateID,parameters,printerName,token, server)
	{
		return Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplate", token, server, "templateType=" + templateType + "&IDs=" + JSON.stringify(IDs) + "&templateID=" + JSON.stringify(templateID) + "&parameters=" + JSON.stringify(parameters) + "&printerName=" + printerName +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-CreatePDFfromJobForceTemplateStockIn
	CreatePDFfromJobForceTemplateStockIn: function(templateType,PrintingKeys,templateID,parameters,printerName,token, server)
	{
		return Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplateStockIn", token, server, "templateType=" + templateType + "&PrintingKeys=" + JSON.stringify(PrintingKeys) + "&templateID=" + JSON.stringify(templateID) + "&parameters=" + JSON.stringify(parameters) + "&printerName=" + printerName +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-CreatePDFfromJobForceTemplateWithQuantities
	CreatePDFfromJobForceTemplateWithQuantities: function(templateType,IDsAndQuantities,templateID,parameters,printerName,token, server)
	{
		return Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplateWithQuantities", token, server, "templateType=" + templateType + "&IDsAndQuantities=" + JSON.stringify(IDsAndQuantities) + "&templateID=" + JSON.stringify(templateID) + "&parameters=" + JSON.stringify(parameters) + "&printerName=" + printerName +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-CreateReturnShippingLabelsPDF
	CreateReturnShippingLabelsPDF: function(IDs,orderItemIdsAndQuantities,returnPostalServiceName,token, server)
	{
		return Factory.GetResponse("PrintService/CreateReturnShippingLabelsPDF", token, server, "IDs=" + JSON.stringify(IDs) + "&orderItemIdsAndQuantities=" + JSON.stringify(orderItemIdsAndQuantities) + "&returnPostalServiceName=" + returnPostalServiceName +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-CreateReturnShippingLabelsPDFWithSKUs
	CreateReturnShippingLabelsPDFWithSKUs: function(referenceNum,SKUsAndQuantities,returnPostalServiceName,token, server)
	{
		return Factory.GetResponse("PrintService/CreateReturnShippingLabelsPDFWithSKUs", token, server, "referenceNum=" + referenceNum + "&SKUsAndQuantities=" + JSON.stringify(SKUsAndQuantities) + "&returnPostalServiceName=" + returnPostalServiceName +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-GetTemplateList
	GetTemplateList: function(templateType,token, server)
	{
		return Factory.GetResponse("PrintService/GetTemplateList", token, server, "templateType=" + templateType +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-GetUsersForPrinterConfig
	GetUsersForPrinterConfig: function(token, server)
	{
		return Factory.GetResponse("PrintService/GetUsersForPrinterConfig", token, server, "");
	},
	// http://apidoc.linnworks.net/#/PrintService-PrintTemplatePreview
	PrintTemplatePreview: function(templateId,token, server)
	{
		return Factory.GetResponse("PrintService/PrintTemplatePreview", token, server, "templateId=" + templateId +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-VP_GetPrinters
	VP_GetPrinters: function(token, server)
	{
		return Factory.GetResponse("PrintService/VP_GetPrinters", token, server, "");
	},
};
