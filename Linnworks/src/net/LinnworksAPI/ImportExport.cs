using System.Text;
using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System.Net.Http;
using System.Drawing;
using System.Collections.ObjectModel;
using System.Xml;
using System.ComponentModel;
using System.Reflection;

namespace LinnworksAPI
{
	public static class ImportExportMethods 
	{ 
		private static JsonSerializerSettings serializerSettings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-ddTHH:mm:ss.ffZ"};
 		public static void DeleteExport(Int32 id,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ImportExport/DeleteExport", "id=" + id + "", ApiToken, ApiServer); 
		}

		public static void DeleteImport(Int32 id,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ImportExport/DeleteImport", "id=" + id + "", ApiToken, ApiServer); 
		}

		public static HttpResponseMessage DownloadImportedFile(Guid fileId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<HttpResponseMessage>(Factory.GetResponse("ImportExport/DownloadImportedFile", "fileId=" + fileId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static ExportRegister EnableExport(Int32 exportId,Boolean enable,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ExportRegister>(Factory.GetResponse("ImportExport/EnableExport", "exportId=" + exportId + "&enable=" + enable + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static ImportRegister EnableImport(Int32 importId,Boolean enable,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<ImportRegister>(Factory.GetResponse("ImportExport/EnableImport", "importId=" + importId + "&enable=" + enable + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Export GetExport(Int32 id,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Export>(Factory.GetResponse("ImportExport/GetExport", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static List<ExportRegister> GetExports(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<List<ExportRegister>>(Factory.GetResponse("ImportExport/GetExports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static FulfilmentCenterImportExportSettings GetFullfilmentCenterSettings(Guid fkStockLocationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<FulfilmentCenterImportExportSettings>(Factory.GetResponse("ImportExport/GetFullfilmentCenterSettings", "fkStockLocationId=" + fkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Import GetImport(Int32 id,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Import>(Factory.GetResponse("ImportExport/GetImport", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static IEnumerable<ImportRegister> GetImports(Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<ImportRegister>>(Factory.GetResponse("ImportExport/GetImports", "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void RunNowExport(Int32 exportId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ImportExport/RunNowExport", "exportId=" + exportId + "", ApiToken, ApiServer); 
		}

		public static void RunNowImport(Int32 importId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ImportExport/RunNowImport", "importId=" + importId + "", ApiToken, ApiServer); 
		} 
	}
}