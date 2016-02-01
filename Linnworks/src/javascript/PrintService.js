var PrintService =
{
	// http://apidoc.linnworks.net/#/PrintService-CreatePDFfromJobForceTemplate
	CreatePDFfromJobForceTemplate: function(templateType,IDs,templateID,parameters,printerName,token, server)
	{
		return Factory.GetResponse("PrintService/CreatePDFfromJobForceTemplate", token, server, "templateType=" + templateType + "&IDs=" + JSON.stringify(IDs) + "&templateID=" + templateID + "&parameters=" + JSON.stringify(parameters) + "&printerName=" + printerName +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-PrintTemplatePreview
	PrintTemplatePreview: function(templateId,token, server)
	{
		return Factory.GetResponse("PrintService/PrintTemplatePreview", token, server, "templateId=" + templateId +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-GetTemplateList
	GetTemplateList: function(templateType,token, server)
	{
		return Factory.GetResponse("PrintService/GetTemplateList", token, server, "templateType=" + templateType +"");
	},
	// http://apidoc.linnworks.net/#/PrintService-VP_GetPrinters
	VP_GetPrinters: function(token, server)
	{
		return Factory.GetResponse("PrintService/VP_GetPrinters", token, server, "");
	},
	// http://apidoc.linnworks.net/#/PrintService-DownloadVirtualPrinterClient
	DownloadVirtualPrinterClient: function(token, server)
	{
		return Factory.GetResponse("PrintService/DownloadVirtualPrinterClient", token, server, "");
	},
};
