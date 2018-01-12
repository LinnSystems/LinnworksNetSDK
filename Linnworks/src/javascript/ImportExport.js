var ImportExport =
{
	// http://apidoc.linnworks.net/#/ImportExport-DeleteExport
	DeleteExport: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/DeleteExport", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-DeleteImport
	DeleteImport: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/DeleteImport", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-DownloadImportedFile
	DownloadImportedFile: function(fileId,token, server)
	{
		return Factory.GetResponse("ImportExport/DownloadImportedFile", token, server, "fileId=" + fileId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-EnableExport
	EnableExport: function(exportId,enable,token, server)
	{
		return Factory.GetResponse("ImportExport/EnableExport", token, server, "exportId=" + exportId + "&enable=" + enable +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-EnableImport
	EnableImport: function(importId,enable,token, server)
	{
		return Factory.GetResponse("ImportExport/EnableImport", token, server, "importId=" + importId + "&enable=" + enable +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExport
	GetExport: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/GetExport", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExports
	GetExports: function(token, server)
	{
		return Factory.GetResponse("ImportExport/GetExports", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetFullfilmentCenterSettings
	GetFullfilmentCenterSettings: function(fkStockLocationId,token, server)
	{
		return Factory.GetResponse("ImportExport/GetFullfilmentCenterSettings", token, server, "fkStockLocationId=" + fkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImport
	GetImport: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/GetImport", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImports
	GetImports: function(token, server)
	{
		return Factory.GetResponse("ImportExport/GetImports", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ImportExport-RunNowExport
	RunNowExport: function(exportId,token, server)
	{
		return Factory.GetResponse("ImportExport/RunNowExport", token, server, "exportId=" + exportId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-RunNowImport
	RunNowImport: function(importId,token, server)
	{
		return Factory.GetResponse("ImportExport/RunNowImport", token, server, "importId=" + importId +"");
	},
};
