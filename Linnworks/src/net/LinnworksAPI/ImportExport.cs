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

		public static GetExportListResponse GetExportList(GetExportListRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetExportListResponse>(Factory.GetResponse("ImportExport/GetExportList", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static FulfilmentCenterImportExportSettings GetFullfilmentCenterSettings(Guid fkStockLocationId,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<FulfilmentCenterImportExportSettings>(Factory.GetResponse("ImportExport/GetFullfilmentCenterSettings", "fkStockLocationId=" + fkStockLocationId + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static Import GetImport(Int32 id,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<Import>(Factory.GetResponse("ImportExport/GetImport", "id=" + id + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static GetImportListResponse GetImportList(GetImportListRequest request,Guid ApiToken, String ApiServer)		{
			return Newtonsoft.Json.JsonConvert.DeserializeObject<GetImportListResponse>(Factory.GetResponse("ImportExport/GetImportList", "request=" + Newtonsoft.Json.JsonConvert.SerializeObject(request, serializerSettings) + "", ApiToken, ApiServer), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore}); 
		}

		public static void RunNowExport(Int32 exportId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ImportExport/RunNowExport", "exportId=" + exportId + "", ApiToken, ApiServer); 
		}

		public static void RunNowImport(Int32 importId,Guid ApiToken, String ApiServer)		{
			Factory.GetResponse("ImportExport/RunNowImport", "importId=" + importId + "", ApiToken, ApiServer); 
		} 
	}
}