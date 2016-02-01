var Locations =
{
	// http://apidoc.linnworks.net/#/Locations-GetLocation
	GetLocation: function(pkStockLocationId,token, server)
	{
		return Factory.GetResponse("Locations/GetLocation", token, server, "pkStockLocationId=" + pkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/Locations-AddLocation
	AddLocation: function(location,token, server)
	{
		return Factory.GetResponse("Locations/AddLocation", token, server, "location=" + JSON.stringify(location) +"");
	},
	// http://apidoc.linnworks.net/#/Locations-UpdateLocation
	UpdateLocation: function(location,token, server)
	{
		return Factory.GetResponse("Locations/UpdateLocation", token, server, "location=" + JSON.stringify(location) +"");
	},
	// http://apidoc.linnworks.net/#/Locations-DeleteLocation
	DeleteLocation: function(pkStockLocationId,token, server)
	{
		return Factory.GetResponse("Locations/DeleteLocation", token, server, "pkStockLocationId=" + pkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/Locations-GetDefaultColumns
	GetDefaultColumns: function(token, server)
	{
		return Factory.GetResponse("Locations/GetDefaultColumns", token, server, "");
	},
	// http://apidoc.linnworks.net/#/Locations-TestFTPConnection
	TestFTPConnection: function(ftpPath,username,password,active,token, server)
	{
		return Factory.GetResponse("Locations/TestFTPConnection", token, server, "ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&active=" + active +"");
	},
	// http://apidoc.linnworks.net/#/Locations-TestSFTPConnection
	TestSFTPConnection: function(ftpPath,username,password,port,compression,token, server)
	{
		return Factory.GetResponse("Locations/TestSFTPConnection", token, server, "ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&port=" + port + "&compression=" + compression +"");
	},
	// http://apidoc.linnworks.net/#/Locations-TestURLConnection
	TestURLConnection: function(url,token, server)
	{
		return Factory.GetResponse("Locations/TestURLConnection", token, server, "url=" + url +"");
	},
	// http://apidoc.linnworks.net/#/Locations-UploadOpenOrdersFlatFile
	UploadOpenOrdersFlatFile: function(settings,mapping,locationId,ftpPath,username,password,active,filename,token, server)
	{
		return Factory.GetResponse("Locations/UploadOpenOrdersFlatFile", token, server, "settings=" + JSON.stringify(settings) + "&mapping=" + JSON.stringify(mapping) + "&locationId=" + locationId + "&ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&active=" + active + "&filename=" + filename +"");
	},
	// http://apidoc.linnworks.net/#/Locations-UploadOpenOrdersFlatFileSFTP
	UploadOpenOrdersFlatFileSFTP: function(settings,mapping,locationId,ftpPath,username,password,port,compression,filename,token, server)
	{
		return Factory.GetResponse("Locations/UploadOpenOrdersFlatFileSFTP", token, server, "settings=" + JSON.stringify(settings) + "&mapping=" + JSON.stringify(mapping) + "&locationId=" + locationId + "&ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&port=" + port + "&compression=" + compression + "&filename=" + filename +"");
	},
	// http://apidoc.linnworks.net/#/Locations-DownloadFileFromFTP
	DownloadFileFromFTP: function(ftpPath,username,password,active,filename,token, server)
	{
		return Factory.GetResponse("Locations/DownloadFileFromFTP", token, server, "ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&active=" + active + "&filename=" + filename +"");
	},
	// http://apidoc.linnworks.net/#/Locations-DownloadFileFromSFTP
	DownloadFileFromSFTP: function(ftpPath,username,password,port,compression,filename,token, server)
	{
		return Factory.GetResponse("Locations/DownloadFileFromSFTP", token, server, "ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&port=" + port + "&compression=" + compression + "&filename=" + filename +"");
	},
	// http://apidoc.linnworks.net/#/Locations-GetFileColumnNames
	GetFileColumnNames: function(fileId,settings,token, server)
	{
		return Factory.GetResponse("Locations/GetFileColumnNames", token, server, "fileId=" + fileId + "&settings=" + JSON.stringify(settings) +"");
	},
	// http://apidoc.linnworks.net/#/Locations-GetImportFilePreview
	GetImportFilePreview: function(fileId,settings,mapping,token, server)
	{
		return Factory.GetResponse("Locations/GetImportFilePreview", token, server, "fileId=" + fileId + "&settings=" + JSON.stringify(settings) + "&mapping=" + JSON.stringify(mapping) +"");
	},
	// http://apidoc.linnworks.net/#/Locations-GetExportFilePreview
	GetExportFilePreview: function(locationId,mapping,token, server)
	{
		return Factory.GetResponse("Locations/GetExportFilePreview", token, server, "locationId=" + locationId + "&mapping=" + JSON.stringify(mapping) +"");
	},
};
