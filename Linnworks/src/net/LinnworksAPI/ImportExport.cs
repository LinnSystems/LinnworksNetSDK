using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class ImportExportMethods
    {
        public static AjaxResult<Boolean> RenameFTPFolder(String server, Int32 port, Boolean ssl, String userName, String password, Boolean passiveMode, String path, String newfolderName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/RenameFTPFolder", "server=" + server + "&port=" + port + "&ssl=" + ssl + "&userName=" + userName + "&password=" + password + "&passiveMode=" + passiveMode + "&path=" + path + "&newfolderName=" + newfolderName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<String> GetColumnsFromFile(String URL, Char delimiter, Boolean hasHeaders, Char escape, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<String>>(Factory.GetResponse("ImportExport/GetColumnsFromFile", "URL=" + URL + "&delimiter=" + Newtonsoft.Json.JsonConvert.SerializeObject(delimiter) + "&hasHeaders=" + hasHeaders + "&escape=" + Newtonsoft.Json.JsonConvert.SerializeObject(escape) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<Boolean> CheckFile(String URL, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/CheckFile", "URL=" + URL + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<IImportType> GetImportTypes(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<IImportType>>(Factory.GetResponse("ImportExport/GetImportTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Import SaveImport(Import importConfig, String feedType, String feedJSON, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Import>(Factory.GetResponse("ImportExport/SaveImport", "importConfig=" + Newtonsoft.Json.JsonConvert.SerializeObject(importConfig) + "&feedType=" + feedType + "&feedJSON=" + feedJSON + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Boolean IsImportEnabled(Int32 id, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("ImportExport/IsImportEnabled", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ImportRegister EnableImport(Int32 importId, Boolean enable, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ImportRegister>(Factory.GetResponse("ImportExport/EnableImport", "importId=" + importId + "&enable=" + enable + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RunNowImport(Int32 importId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/RunNowImport", "importId=" + importId + "", ApiToken, ApiServer);
        }

        public static Import GetImport(Int32 id, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Import>(Factory.GetResponse("ImportExport/GetImport", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Int32 GetImportIdByName(String friendlyName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("ImportExport/GetImportIdByName", "friendlyName=" + friendlyName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteImport(Int32 id, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/DeleteImport", "id=" + id + "", ApiToken, ApiServer);
        }

        public static ExecutingOrQueuedResult GetExecutingOrQueuedImports(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ExecutingOrQueuedResult>(Factory.GetResponse("ImportExport/GetExecutingOrQueuedImports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<String> GetImportSessionErrors(Int32 sessionId, Int32 pageNumber, Int32 entriesPerPage, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<String>>(Factory.GetResponse("ImportExport/GetImportSessionErrors", "sessionId=" + sessionId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<ImportSession> GetImportSessions(Int32 importId, Int32 pageNumber, Int32 entriesPerPage, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<ImportSession>>(Factory.GetResponse("ImportExport/GetImportSessions", "importId=" + importId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ImportRegister> GetImports(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ImportRegister>>(Factory.GetResponse("ImportExport/GetImports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ImportRegister GetImportRegister(Int32 id, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ImportRegister>(Factory.GetResponse("ImportExport/GetImportRegister", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DownloadImportedFile(Guid fileId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/DownloadImportedFile", "fileId=" + fileId + "", ApiToken, ApiServer);
        }

        public static List<String> GetImportListOfValues(ImportType importType, String columnName, String additionalFieldName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("ImportExport/GetImportListOfValues", "importType=" + Newtonsoft.Json.JsonConvert.SerializeObject(importType) + "&columnName=" + columnName + "&additionalFieldName=" + additionalFieldName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static FulfilmentCenterImportExportSettings GetFullfilmentCenterSettings(Guid fkStockLocationId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FulfilmentCenterImportExportSettings>(Factory.GetResponse("ImportExport/GetFullfilmentCenterSettings", "fkStockLocationId=" + fkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SaveOrdersExportId(Guid fkStockLocationId, Int32 fkOrdersExportId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/SaveOrdersExportId", "fkStockLocationId=" + fkStockLocationId + "&fkOrdersExportId=" + fkOrdersExportId + "", ApiToken, ApiServer);
        }

        public static void SaveOrdersImportId(Guid fkStockLocationId, Int32 fkOrdersImportId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/SaveOrdersImportId", "fkStockLocationId=" + fkStockLocationId + "&fkOrdersImportId=" + fkOrdersImportId + "", ApiToken, ApiServer);
        }

        public static void SaveInventoryImportId(Guid fkStockLocationId, Int32 fkInventoryImportId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/SaveInventoryImportId", "fkStockLocationId=" + fkStockLocationId + "&fkInventoryImportId=" + fkInventoryImportId + "", ApiToken, ApiServer);
        }

        public static void DeleteOrdersExportId(Guid fkStockLocationId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/DeleteOrdersExportId", "fkStockLocationId=" + fkStockLocationId + "", ApiToken, ApiServer);
        }

        public static void DeleteOrdersImportId(Guid fkStockLocationId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/DeleteOrdersImportId", "fkStockLocationId=" + fkStockLocationId + "", ApiToken, ApiServer);
        }

        public static void DeleteInventoryImportId(Guid fkStockLocationId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/DeleteInventoryImportId", "fkStockLocationId=" + fkStockLocationId + "", ApiToken, ApiServer);
        }

        public static String GetFulfilmentCenterNameByOrdersExportId(Int32 fkOrdersExportId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("ImportExport/GetFulfilmentCenterNameByOrdersExportId", "fkOrdersExportId=" + fkOrdersExportId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String GetFulfilmentCenterNameByOrdersImportId(Int32 fkOrdersImportId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("ImportExport/GetFulfilmentCenterNameByOrdersImportId", "fkOrdersImportId=" + fkOrdersImportId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String GetFulfilmentCenterNameByInventoryImportId(Int32 fkInventoryImportId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("ImportExport/GetFulfilmentCenterNameByInventoryImportId", "fkInventoryImportId=" + fkInventoryImportId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Int32 GetExportIdByName(String friendlyName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Int32>(Factory.GetResponse("ImportExport/GetExportIdByName", "friendlyName=" + friendlyName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<IExportType> GetExportTypes(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<IExportType>>(Factory.GetResponse("ImportExport/GetExportTypes", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<String> GetExportSubQuerySelectionFieldValues(ExportType exportType, String subQueryName, String selectionFieldName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<String>>(Factory.GetResponse("ImportExport/GetExportSubQuerySelectionFieldValues", "exportType=" + Newtonsoft.Json.JsonConvert.SerializeObject(exportType) + "&subQueryName=" + subQueryName + "&selectionFieldName=" + selectionFieldName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Export SaveExport(Export exportConfig, String feedType, String feedJSON, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Export>(Factory.GetResponse("ImportExport/SaveExport", "exportConfig=" + Newtonsoft.Json.JsonConvert.SerializeObject(exportConfig) + "&feedType=" + feedType + "&feedJSON=" + feedJSON + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Boolean IsExportEnabled(Int32 id, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Boolean>(Factory.GetResponse("ImportExport/IsExportEnabled", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ExportRegister EnableExport(Int32 exportId, Boolean enable, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ExportRegister>(Factory.GetResponse("ImportExport/EnableExport", "exportId=" + exportId + "&enable=" + enable + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void RunNowExport(Int32 exportId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/RunNowExport", "exportId=" + exportId + "", ApiToken, ApiServer);
        }

        public static Export GetExport(Int32 id, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Export>(Factory.GetResponse("ImportExport/GetExport", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void DeleteExport(Int32 id, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/DeleteExport", "id=" + id + "", ApiToken, ApiServer);
        }

        public static ExecutingOrQueuedResult GetExecutingOrQueuedExports(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ExecutingOrQueuedResult>(Factory.GetResponse("ImportExport/GetExecutingOrQueuedExports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<String> GetExportSessionErrors(Int32 sessionId, Int32 pageNumber, Int32 entriesPerPage, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<String>>(Factory.GetResponse("ImportExport/GetExportSessionErrors", "sessionId=" + sessionId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static GenericPagedResult<ExportSession> GetExportSessions(Int32 exportId, Int32 pageNumber, Int32 entriesPerPage, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GenericPagedResult<ExportSession>>(Factory.GetResponse("ImportExport/GetExportSessions", "exportId=" + exportId + "&pageNumber=" + pageNumber + "&entriesPerPage=" + entriesPerPage + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<ExportRegister> GetExports(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExportRegister>>(Factory.GetResponse("ImportExport/GetExports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static ExportRegister GetExportRegister(Int32 id, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ExportRegister>(Factory.GetResponse("ImportExport/GetExportRegister", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<String> GetSQLColumns(String sqlQuery, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<String>>(Factory.GetResponse("ImportExport/GetSQLColumns", "sqlQuery=" + sqlQuery + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static List<DropboxAccount> GetDropboxAccounts(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<DropboxAccount>>(Factory.GetResponse("ImportExport/GetDropboxAccounts", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void SetDropboxAccounts(List<DropboxAccount> accounts, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/SetDropboxAccounts", "accounts=" + Newtonsoft.Json.JsonConvert.SerializeObject(accounts) + "", ApiToken, ApiServer);
        }

        public static AjaxResult<String> GetColumnsFromUploadedFile(Guid fileId, String delimiter, String comment, Boolean hasHeaders, String escape, String quote, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<String>>(Factory.GetResponse("ImportExport/GetColumnsFromUploadedFile", "fileId=" + fileId + "&delimiter=" + delimiter + "&comment=" + comment + "&hasHeaders=" + hasHeaders + "&escape=" + escape + "&quote=" + quote + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<Boolean> CheckHTTPFile(String URL, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/CheckHTTPFile", "URL=" + URL + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String EvalExpression(String expression, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("ImportExport/EvalExpression", "expression=" + expression + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<String> GetColumnsFromDropboxFile(String token, String filePath, String fileName, String delimiter, String comment, Boolean hasHeaders, String escape, String quote, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<String>>(Factory.GetResponse("ImportExport/GetColumnsFromDropboxFile", "token=" + token + "&filePath=" + filePath + "&fileName=" + fileName + "&delimiter=" + delimiter + "&comment=" + comment + "&hasHeaders=" + hasHeaders + "&escape=" + escape + "&quote=" + quote + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<String> GetColumnsFromHTTPFile(String URL, String delimiter, String comment, Boolean hasHeaders, String escape, String quote, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<String>>(Factory.GetResponse("ImportExport/GetColumnsFromHTTPFile", "URL=" + URL + "&delimiter=" + delimiter + "&comment=" + comment + "&hasHeaders=" + hasHeaders + "&escape=" + escape + "&quote=" + quote + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<Boolean> CheckFTPFile(String server, Int32 port, String filePath, String fileName, Boolean SSL, Boolean passiveMode, Protocol protocol, String userName, String password, PostEventType postDownload, String ftpMoveToFolder, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/CheckFTPFile", "server=" + server + "&port=" + port + "&filePath=" + filePath + "&fileName=" + fileName + "&SSL=" + SSL + "&passiveMode=" + passiveMode + "&protocol=" + Newtonsoft.Json.JsonConvert.SerializeObject(protocol) + "&userName=" + userName + "&password=" + password + "&postDownload=" + Newtonsoft.Json.JsonConvert.SerializeObject(postDownload) + "&ftpMoveToFolder=" + ftpMoveToFolder + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<Boolean> CheckSFTPFile(String server, Int32 port, String filePath, String fileName, Boolean compression, String userName, String password, PostEventType postDownload, String ftpMoveToFolder, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/CheckSFTPFile", "server=" + server + "&port=" + port + "&filePath=" + filePath + "&fileName=" + fileName + "&compression=" + compression + "&userName=" + userName + "&password=" + password + "&postDownload=" + Newtonsoft.Json.JsonConvert.SerializeObject(postDownload) + "&ftpMoveToFolder=" + ftpMoveToFolder + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<Boolean> CheckDropboxFile(String token, String filePath, String fileName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/CheckDropboxFile", "token=" + token + "&filePath=" + filePath + "&fileName=" + fileName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<String> GetColumnsFromFTPFile(String server, Int32 port, String filePath, String fileName, Boolean SSL, Boolean passiveMode, Protocol protocol, String userName, String password, String delimiter, Boolean hasHeaders, String escape, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<String>>(Factory.GetResponse("ImportExport/GetColumnsFromFTPFile", "server=" + server + "&port=" + port + "&filePath=" + filePath + "&fileName=" + fileName + "&SSL=" + SSL + "&passiveMode=" + passiveMode + "&protocol=" + Newtonsoft.Json.JsonConvert.SerializeObject(protocol) + "&userName=" + userName + "&password=" + password + "&delimiter=" + delimiter + "&hasHeaders=" + hasHeaders + "&escape=" + escape + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<String> GetColumnsFromSFTPFile(String server, Int32 port, String filePath, String fileName, Boolean compression, String userName, String password, String delimiter, Boolean hasHeaders, String escape, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<String>>(Factory.GetResponse("ImportExport/GetColumnsFromSFTPFile", "server=" + server + "&port=" + port + "&filePath=" + filePath + "&fileName=" + fileName + "&compression=" + compression + "&userName=" + userName + "&password=" + password + "&delimiter=" + delimiter + "&hasHeaders=" + hasHeaders + "&escape=" + escape + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<Boolean> CheckFTPConnection(String server, Int32 port, String filePath, Boolean SSL, Boolean passiveMode, Protocol protocol, String userName, String password, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/CheckFTPConnection", "server=" + server + "&port=" + port + "&filePath=" + filePath + "&SSL=" + SSL + "&passiveMode=" + passiveMode + "&protocol=" + Newtonsoft.Json.JsonConvert.SerializeObject(protocol) + "&userName=" + userName + "&password=" + password + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<Boolean> CheckSFTPConnection(String server, Int32 port, String filePath, Boolean compression, String userName, String password, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/CheckSFTPConnection", "server=" + server + "&port=" + port + "&filePath=" + filePath + "&compression=" + compression + "&userName=" + userName + "&password=" + password + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<List<DirectoryItem>> GetFTPFolderContent(String server, Int32 port, Boolean ssl, String userName, String password, Boolean passiveMode, String path, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<List<DirectoryItem>>>(Factory.GetResponse("ImportExport/GetFTPFolderContent", "server=" + server + "&port=" + port + "&ssl=" + ssl + "&userName=" + userName + "&password=" + password + "&passiveMode=" + passiveMode + "&path=" + path + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<List<DirectoryItem>> GetSFTPFolderContent(String server, Int32 port, String userName, String password, Boolean compression, String path, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<List<DirectoryItem>>>(Factory.GetResponse("ImportExport/GetSFTPFolderContent", "server=" + server + "&port=" + port + "&userName=" + userName + "&password=" + password + "&compression=" + compression + "&path=" + path + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<Boolean> CreateFTPFolder(String server, Int32 port, Boolean ssl, String userName, String password, Boolean passiveMode, String path, String folderName, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/CreateFTPFolder", "server=" + server + "&port=" + port + "&ssl=" + ssl + "&userName=" + userName + "&password=" + password + "&passiveMode=" + passiveMode + "&path=" + path + "&folderName=" + folderName + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static AjaxResult<Boolean> DeleteFTPFile(String server, Int32 port, Boolean ssl, String userName, String password, Boolean passiveMode, String path, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<AjaxResult<Boolean>>(Factory.GetResponse("ImportExport/DeleteFTPFile", "server=" + server + "&port=" + port + "&ssl=" + ssl + "&userName=" + userName + "&password=" + password + "&passiveMode=" + passiveMode + "&path=" + path + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}