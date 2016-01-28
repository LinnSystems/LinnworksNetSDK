using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class LocationsMethods
    {
        public static StockLocation GetLocation(Guid pkStockLocationId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<StockLocation>(Factory.GetResponse("Locations/GetLocation", "pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void AddLocation(StockLocation location, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/AddLocation", "location=" + Newtonsoft.Json.JsonConvert.SerializeObject(location) + "", ApiToken, ApiServer);
        }

        public static void UpdateLocation(StockLocation location, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/UpdateLocation", "location=" + Newtonsoft.Json.JsonConvert.SerializeObject(location) + "", ApiToken, ApiServer);
        }

        public static void DeleteLocation(Guid pkStockLocationId, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/DeleteLocation", "pkStockLocationId=" + pkStockLocationId + "", ApiToken, ApiServer);
        }

        public static Dictionary<String, List<ColumnMapping>> GetDefaultColumns(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<String, List<ColumnMapping>>>(Factory.GetResponse("Locations/GetDefaultColumns", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String TestFTPConnection(String ftpPath, String username, String password, Boolean active, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Locations/TestFTPConnection", "ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&active=" + active + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String TestSFTPConnection(String ftpPath, String username, String password, Int32 port, Boolean compression, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Locations/TestSFTPConnection", "ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&port=" + port + "&compression=" + compression + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String TestURLConnection(String url, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Locations/TestURLConnection", "url=" + url + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static void UploadOpenOrdersFlatFile(FlatFileSettings settings, List<ColumnMapping> mapping, Guid locationId, String ftpPath, String username, String password, Boolean active, String filename, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/UploadOpenOrdersFlatFile", "settings=" + Newtonsoft.Json.JsonConvert.SerializeObject(settings) + "&mapping=" + Newtonsoft.Json.JsonConvert.SerializeObject(mapping) + "&locationId=" + locationId + "&ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&active=" + active + "&filename=" + filename + "", ApiToken, ApiServer);
        }

        public static void UploadOpenOrdersFlatFileSFTP(FlatFileSettings settings, List<ColumnMapping> mapping, Guid locationId, String ftpPath, String username, String password, Int32 port, Boolean compression, String filename, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("Locations/UploadOpenOrdersFlatFileSFTP", "settings=" + Newtonsoft.Json.JsonConvert.SerializeObject(settings) + "&mapping=" + Newtonsoft.Json.JsonConvert.SerializeObject(mapping) + "&locationId=" + locationId + "&ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&port=" + port + "&compression=" + compression + "&filename=" + filename + "", ApiToken, ApiServer);
        }

        public static Guid DownloadFileFromFTP(String ftpPath, String username, String password, Boolean active, String filename, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("Locations/DownloadFileFromFTP", "ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&active=" + active + "&filename=" + filename + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static Guid DownloadFileFromSFTP(String ftpPath, String username, String password, Int32 port, Boolean compression, String filename, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Guid>(Factory.GetResponse("Locations/DownloadFileFromSFTP", "ftpPath=" + ftpPath + "&username=" + username + "&password=" + password + "&port=" + port + "&compression=" + compression + "&filename=" + filename + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static String GetFileColumnNames(Guid fileId, FlatFileSettings settings, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<String>(Factory.GetResponse("Locations/GetFileColumnNames", "fileId=" + fileId + "&settings=" + Newtonsoft.Json.JsonConvert.SerializeObject(settings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static DataTablePreview GetImportFilePreview(Guid fileId, FlatFileSettings settings, List<ColumnMapping> mapping, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DataTablePreview>(Factory.GetResponse("Locations/GetImportFilePreview", "fileId=" + fileId + "&settings=" + Newtonsoft.Json.JsonConvert.SerializeObject(settings) + "&mapping=" + Newtonsoft.Json.JsonConvert.SerializeObject(mapping) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static DataTablePreview GetExportFilePreview(Guid locationId, List<ColumnMapping> mapping, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<DataTablePreview>(Factory.GetResponse("Locations/GetExportFilePreview", "locationId=" + locationId + "&mapping=" + Newtonsoft.Json.JsonConvert.SerializeObject(mapping) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}