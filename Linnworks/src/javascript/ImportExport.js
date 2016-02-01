var ImportExport =
{
	// http://apidoc.linnworks.net/#/ImportExport-RenameFTPFolder
	RenameFTPFolder: function(server,port,ssl,userName,password,passiveMode,path,newfolderName,token, server)
	{
		return Factory.GetResponse("ImportExport/RenameFTPFolder", token, server, "server=" + server + "&port=" + port + "&ssl=" + ssl + "&userName=" + userName + "&password=" + password + "&passiveMode=" + passiveMode + "&path=" + path + "&newfolderName=" + newfolderName +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetColumnsFromFile
	GetColumnsFromFile: function(URL,delimiter,hasHeaders,escape,token, server)
	{
		return Factory.GetResponse("ImportExport/GetColumnsFromFile", token, server, "URL=" + URL + "&delimiter=" + JSON.stringify(delimiter) + "&hasHeaders=" + hasHeaders + "&escape=" + JSON.stringify(escape) +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-CheckFile
	CheckFile: function(URL,token, server)
	{
		return Factory.GetResponse("ImportExport/CheckFile", token, server, "URL=" + URL +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImportTypes
	GetImportTypes: function(token, server)
	{
		return Factory.GetResponse("ImportExport/GetImportTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ImportExport-SaveImport
	SaveImport: function(importConfig,feedType,feedJSON,token, server)
	{
		return Factory.GetResponse("ImportExport/SaveImport", token, server, "importConfig=" + JSON.stringify(importConfig) + "&feedType=" + feedType + "&feedJSON=" + feedJSON +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-IsImportEnabled
	IsImportEnabled: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/IsImportEnabled", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-EnableImport
	EnableImport: function(importId,enable,token, server)
	{
		return Factory.GetResponse("ImportExport/EnableImport", token, server, "importId=" + importId + "&enable=" + enable +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-RunNowImport
	RunNowImport: function(importId,token, server)
	{
		return Factory.GetResponse("ImportExport/RunNowImport", token, server, "importId=" + importId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImport
	GetImport: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/GetImport", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImportIdByName
	GetImportIdByName: function(friendlyName,token, server)
	{
		return Factory.GetResponse("ImportExport/GetImportIdByName", token, server, "friendlyName=" + friendlyName +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-DeleteImport
	DeleteImport: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/DeleteImport", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExecutingOrQueuedImports
	GetExecutingOrQueuedImports: function(token, server)
	{
		return Factory.GetResponse("ImportExport/GetExecutingOrQueuedImports", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImportSessionErrors
	GetImportSessionErrors: function(sessionId,pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("ImportExport/GetImportSessionErrors", token, server, "sessionId=" + sessionId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImportSessions
	GetImportSessions: function(importId,pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("ImportExport/GetImportSessions", token, server, "importId=" + importId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImports
	GetImports: function(token, server)
	{
		return Factory.GetResponse("ImportExport/GetImports", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImportRegister
	GetImportRegister: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/GetImportRegister", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-DownloadImportedFile
	DownloadImportedFile: function(fileId,token, server)
	{
		return Factory.GetResponse("ImportExport/DownloadImportedFile", token, server, "fileId=" + fileId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetImportListOfValues
	GetImportListOfValues: function(importType,columnName,additionalFieldName,token, server)
	{
		return Factory.GetResponse("ImportExport/GetImportListOfValues", token, server, "importType=" + JSON.stringify(importType) + "&columnName=" + columnName + "&additionalFieldName=" + additionalFieldName +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetFullfilmentCenterSettings
	GetFullfilmentCenterSettings: function(fkStockLocationId,token, server)
	{
		return Factory.GetResponse("ImportExport/GetFullfilmentCenterSettings", token, server, "fkStockLocationId=" + fkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-SaveOrdersExportId
	SaveOrdersExportId: function(fkStockLocationId,fkOrdersExportId,token, server)
	{
		return Factory.GetResponse("ImportExport/SaveOrdersExportId", token, server, "fkStockLocationId=" + fkStockLocationId + "&fkOrdersExportId=" + fkOrdersExportId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-SaveOrdersImportId
	SaveOrdersImportId: function(fkStockLocationId,fkOrdersImportId,token, server)
	{
		return Factory.GetResponse("ImportExport/SaveOrdersImportId", token, server, "fkStockLocationId=" + fkStockLocationId + "&fkOrdersImportId=" + fkOrdersImportId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-SaveInventoryImportId
	SaveInventoryImportId: function(fkStockLocationId,fkInventoryImportId,token, server)
	{
		return Factory.GetResponse("ImportExport/SaveInventoryImportId", token, server, "fkStockLocationId=" + fkStockLocationId + "&fkInventoryImportId=" + fkInventoryImportId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-DeleteOrdersExportId
	DeleteOrdersExportId: function(fkStockLocationId,token, server)
	{
		return Factory.GetResponse("ImportExport/DeleteOrdersExportId", token, server, "fkStockLocationId=" + fkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-DeleteOrdersImportId
	DeleteOrdersImportId: function(fkStockLocationId,token, server)
	{
		return Factory.GetResponse("ImportExport/DeleteOrdersImportId", token, server, "fkStockLocationId=" + fkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-DeleteInventoryImportId
	DeleteInventoryImportId: function(fkStockLocationId,token, server)
	{
		return Factory.GetResponse("ImportExport/DeleteInventoryImportId", token, server, "fkStockLocationId=" + fkStockLocationId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetFulfilmentCenterNameByOrdersExportId
	GetFulfilmentCenterNameByOrdersExportId: function(fkOrdersExportId,token, server)
	{
		return Factory.GetResponse("ImportExport/GetFulfilmentCenterNameByOrdersExportId", token, server, "fkOrdersExportId=" + fkOrdersExportId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetFulfilmentCenterNameByOrdersImportId
	GetFulfilmentCenterNameByOrdersImportId: function(fkOrdersImportId,token, server)
	{
		return Factory.GetResponse("ImportExport/GetFulfilmentCenterNameByOrdersImportId", token, server, "fkOrdersImportId=" + fkOrdersImportId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetFulfilmentCenterNameByInventoryImportId
	GetFulfilmentCenterNameByInventoryImportId: function(fkInventoryImportId,token, server)
	{
		return Factory.GetResponse("ImportExport/GetFulfilmentCenterNameByInventoryImportId", token, server, "fkInventoryImportId=" + fkInventoryImportId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExportIdByName
	GetExportIdByName: function(friendlyName,token, server)
	{
		return Factory.GetResponse("ImportExport/GetExportIdByName", token, server, "friendlyName=" + friendlyName +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExportTypes
	GetExportTypes: function(token, server)
	{
		return Factory.GetResponse("ImportExport/GetExportTypes", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExportSubQuerySelectionFieldValues
	GetExportSubQuerySelectionFieldValues: function(exportType,subQueryName,selectionFieldName,token, server)
	{
		return Factory.GetResponse("ImportExport/GetExportSubQuerySelectionFieldValues", token, server, "exportType=" + JSON.stringify(exportType) + "&subQueryName=" + subQueryName + "&selectionFieldName=" + selectionFieldName +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-SaveExport
	SaveExport: function(exportConfig,feedType,feedJSON,token, server)
	{
		return Factory.GetResponse("ImportExport/SaveExport", token, server, "exportConfig=" + JSON.stringify(exportConfig) + "&feedType=" + feedType + "&feedJSON=" + feedJSON +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-IsExportEnabled
	IsExportEnabled: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/IsExportEnabled", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-EnableExport
	EnableExport: function(exportId,enable,token, server)
	{
		return Factory.GetResponse("ImportExport/EnableExport", token, server, "exportId=" + exportId + "&enable=" + enable +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-RunNowExport
	RunNowExport: function(exportId,token, server)
	{
		return Factory.GetResponse("ImportExport/RunNowExport", token, server, "exportId=" + exportId +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExport
	GetExport: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/GetExport", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-DeleteExport
	DeleteExport: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/DeleteExport", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExecutingOrQueuedExports
	GetExecutingOrQueuedExports: function(token, server)
	{
		return Factory.GetResponse("ImportExport/GetExecutingOrQueuedExports", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExportSessionErrors
	GetExportSessionErrors: function(sessionId,pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("ImportExport/GetExportSessionErrors", token, server, "sessionId=" + sessionId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExportSessions
	GetExportSessions: function(exportId,pageNumber,entriesPerPage,token, server)
	{
		return Factory.GetResponse("ImportExport/GetExportSessions", token, server, "exportId=" + exportId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExports
	GetExports: function(token, server)
	{
		return Factory.GetResponse("ImportExport/GetExports", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetExportRegister
	GetExportRegister: function(id,token, server)
	{
		return Factory.GetResponse("ImportExport/GetExportRegister", token, server, "id=" + id +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetSQLColumns
	GetSQLColumns: function(sqlQuery,token, server)
	{
		return Factory.GetResponse("ImportExport/GetSQLColumns", token, server, "sqlQuery=" + sqlQuery +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetDropboxAccounts
	GetDropboxAccounts: function(token, server)
	{
		return Factory.GetResponse("ImportExport/GetDropboxAccounts", token, server, "");
	},
	// http://apidoc.linnworks.net/#/ImportExport-SetDropboxAccounts
	SetDropboxAccounts: function(accounts,token, server)
	{
		return Factory.GetResponse("ImportExport/SetDropboxAccounts", token, server, "accounts=" + JSON.stringify(accounts) +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetColumnsFromUploadedFile
	GetColumnsFromUploadedFile: function(fileId,delimiter,comment,hasHeaders,escape,quote,token, server)
	{
		return Factory.GetResponse("ImportExport/GetColumnsFromUploadedFile", token, server, "fileId=" + fileId + "&delimiter=" + delimiter + "&comment=" + comment + "&hasHeaders=" + hasHeaders + "&escape=" + escape + "&quote=" + quote +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-CheckHTTPFile
	CheckHTTPFile: function(URL,token, server)
	{
		return Factory.GetResponse("ImportExport/CheckHTTPFile", token, server, "URL=" + URL +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-EvalExpression
	EvalExpression: function(expression,token, server)
	{
		return Factory.GetResponse("ImportExport/EvalExpression", token, server, "expression=" + expression +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetColumnsFromDropboxFile
	GetColumnsFromDropboxFile: function(token,filePath,fileName,delimiter,comment,hasHeaders,escape,quote,token, server)
	{
		return Factory.GetResponse("ImportExport/GetColumnsFromDropboxFile", token, server, "token=" + token + "&filePath=" + filePath + "&fileName=" + fileName + "&delimiter=" + delimiter + "&comment=" + comment + "&hasHeaders=" + hasHeaders + "&escape=" + escape + "&quote=" + quote +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetColumnsFromHTTPFile
	GetColumnsFromHTTPFile: function(URL,delimiter,comment,hasHeaders,escape,quote,token, server)
	{
		return Factory.GetResponse("ImportExport/GetColumnsFromHTTPFile", token, server, "URL=" + URL + "&delimiter=" + delimiter + "&comment=" + comment + "&hasHeaders=" + hasHeaders + "&escape=" + escape + "&quote=" + quote +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-CheckFTPFile
	CheckFTPFile: function(server,port,filePath,fileName,SSL,passiveMode,protocol,userName,password,postDownload,ftpMoveToFolder,token, server)
	{
		return Factory.GetResponse("ImportExport/CheckFTPFile", token, server, "server=" + server + "&port=" + port + "&filePath=" + filePath + "&fileName=" + fileName + "&SSL=" + SSL + "&passiveMode=" + passiveMode + "&protocol=" + JSON.stringify(protocol) + "&userName=" + userName + "&password=" + password + "&postDownload=" + JSON.stringify(postDownload) + "&ftpMoveToFolder=" + ftpMoveToFolder +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-CheckSFTPFile
	CheckSFTPFile: function(server,port,filePath,fileName,compression,userName,password,postDownload,ftpMoveToFolder,token, server)
	{
		return Factory.GetResponse("ImportExport/CheckSFTPFile", token, server, "server=" + server + "&port=" + port + "&filePath=" + filePath + "&fileName=" + fileName + "&compression=" + compression + "&userName=" + userName + "&password=" + password + "&postDownload=" + JSON.stringify(postDownload) + "&ftpMoveToFolder=" + ftpMoveToFolder +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-CheckDropboxFile
	CheckDropboxFile: function(token,filePath,fileName,token, server)
	{
		return Factory.GetResponse("ImportExport/CheckDropboxFile", token, server, "token=" + token + "&filePath=" + filePath + "&fileName=" + fileName +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetColumnsFromFTPFile
	GetColumnsFromFTPFile: function(server,port,filePath,fileName,SSL,passiveMode,protocol,userName,password,delimiter,hasHeaders,escape,token, server)
	{
		return Factory.GetResponse("ImportExport/GetColumnsFromFTPFile", token, server, "server=" + server + "&port=" + port + "&filePath=" + filePath + "&fileName=" + fileName + "&SSL=" + SSL + "&passiveMode=" + passiveMode + "&protocol=" + JSON.stringify(protocol) + "&userName=" + userName + "&password=" + password + "&delimiter=" + delimiter + "&hasHeaders=" + hasHeaders + "&escape=" + escape +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetColumnsFromSFTPFile
	GetColumnsFromSFTPFile: function(server,port,filePath,fileName,compression,userName,password,delimiter,hasHeaders,escape,token, server)
	{
		return Factory.GetResponse("ImportExport/GetColumnsFromSFTPFile", token, server, "server=" + server + "&port=" + port + "&filePath=" + filePath + "&fileName=" + fileName + "&compression=" + compression + "&userName=" + userName + "&password=" + password + "&delimiter=" + delimiter + "&hasHeaders=" + hasHeaders + "&escape=" + escape +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-CheckFTPConnection
	CheckFTPConnection: function(server,port,filePath,SSL,passiveMode,protocol,userName,password,token, server)
	{
		return Factory.GetResponse("ImportExport/CheckFTPConnection", token, server, "server=" + server + "&port=" + port + "&filePath=" + filePath + "&SSL=" + SSL + "&passiveMode=" + passiveMode + "&protocol=" + JSON.stringify(protocol) + "&userName=" + userName + "&password=" + password +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-CheckSFTPConnection
	CheckSFTPConnection: function(server,port,filePath,compression,userName,password,token, server)
	{
		return Factory.GetResponse("ImportExport/CheckSFTPConnection", token, server, "server=" + server + "&port=" + port + "&filePath=" + filePath + "&compression=" + compression + "&userName=" + userName + "&password=" + password +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetFTPFolderContent
	GetFTPFolderContent: function(server,port,ssl,userName,password,passiveMode,path,token, server)
	{
		return Factory.GetResponse("ImportExport/GetFTPFolderContent", token, server, "server=" + server + "&port=" + port + "&ssl=" + ssl + "&userName=" + userName + "&password=" + password + "&passiveMode=" + passiveMode + "&path=" + path +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-GetSFTPFolderContent
	GetSFTPFolderContent: function(server,port,userName,password,compression,path,token, server)
	{
		return Factory.GetResponse("ImportExport/GetSFTPFolderContent", token, server, "server=" + server + "&port=" + port + "&userName=" + userName + "&password=" + password + "&compression=" + compression + "&path=" + path +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-CreateFTPFolder
	CreateFTPFolder: function(server,port,ssl,userName,password,passiveMode,path,folderName,token, server)
	{
		return Factory.GetResponse("ImportExport/CreateFTPFolder", token, server, "server=" + server + "&port=" + port + "&ssl=" + ssl + "&userName=" + userName + "&password=" + password + "&passiveMode=" + passiveMode + "&path=" + path + "&folderName=" + folderName +"");
	},
	// http://apidoc.linnworks.net/#/ImportExport-DeleteFTPFile
	DeleteFTPFile: function(server,port,ssl,userName,password,passiveMode,path,token, server)
	{
		return Factory.GetResponse("ImportExport/DeleteFTPFile", token, server, "server=" + server + "&port=" + port + "&ssl=" + ssl + "&userName=" + userName + "&password=" + password + "&passiveMode=" + passiveMode + "&path=" + path +"");
	},
};
