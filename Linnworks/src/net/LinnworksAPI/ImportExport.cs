using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public static class ImportExportMethods
    {
        private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ" };

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

        public static void DeleteImport(Int32 id, String ApiToken, String ApiServer)
        {
            Factory.GetResponse("ImportExport/DeleteImport", "id=" + id + "", ApiToken, ApiServer);
        }

        public static List<ImportRegister> GetImports(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ImportRegister>>(Factory.GetResponse("ImportExport/GetImports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }

        public static FulfilmentCenterImportExportSettings GetFullfilmentCenterSettings(Guid fkStockLocationId, String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<FulfilmentCenterImportExportSettings>(Factory.GetResponse("ImportExport/GetFullfilmentCenterSettings", "fkStockLocationId=" + fkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
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

        public static List<ExportRegister> GetExports(String ApiToken, String ApiServer)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExportRegister>>(Factory.GetResponse("ImportExport/GetExports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}