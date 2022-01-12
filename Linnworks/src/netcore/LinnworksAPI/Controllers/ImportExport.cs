using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Net.Http;

namespace LinnworksAPI
{
    public class ImportExportController : BaseController, IImportExportController
    {
        public ImportExportController(ApiContext apiContext) : base(apiContext)
        {                       
        }

        /// <summary>
        /// Delete an export configuration 
        /// </summary>
        /// <param name="id">Id of the export to delete</param>
        public void DeleteExport(Int32 id)
		{
			GetResponse("ImportExport/DeleteExport", "id=" + id + "");
		}

		/// <summary>
        /// Delete an import configuration 
        /// </summary>
        /// <param name="id">Id of the import to delete</param>
        public void DeleteImport(Int32 id)
		{
			GetResponse("ImportExport/DeleteImport", "id=" + id + "");
		}

		/// <summary>
        /// Download an already imported file 
        /// </summary>
        /// <param name="fileId">Id of the file to get</param>
        public HttpResponseMessage DownloadImportedFile(Guid fileId)
		{
			var response = GetResponse("ImportExport/DownloadImportedFile", "fileId=" + fileId + "", "GET");
            return JsonFormatter.ConvertFromJson<HttpResponseMessage>(response);
		}

		/// <summary>
        /// Enable/disable a specific export 
        /// </summary>
        /// <param name="exportId">Export id to enable/disable</param>
        /// <param name="enable">Boolean value to indicate the state</param>
        /// <returns>The exportRegister object after enable/disable it, with a possible next schedule date</returns>
        public ExportRegister EnableExport(Int32 exportId,Boolean enable)
		{
			var response = GetResponse("ImportExport/EnableExport", "exportId=" + exportId + "&enable=" + enable + "");
            return JsonFormatter.ConvertFromJson<ExportRegister>(response);
		}

		/// <summary>
        /// Enable/disable a specific import 
        /// </summary>
        /// <param name="importId">Import id to enable/disable</param>
        /// <param name="enable">Boolean value to indicate the state</param>
        /// <returns>The importRegister object after enable/disable it, with a possible next schedule date</returns>
        public ImportRegister EnableImport(Int32 importId,Boolean enable)
		{
			var response = GetResponse("ImportExport/EnableImport", "importId=" + importId + "&enable=" + enable + "");
            return JsonFormatter.ConvertFromJson<ImportRegister>(response);
		}

		/// <summary>
        /// Get an export configuration 
        /// </summary>
        /// <param name="id">Id of the export to get</param>
        /// <returns>Export object</returns>
        public Export GetExport(Int32 id)
		{
			var response = GetResponse("ImportExport/GetExport", "id=" + id + "");
            return JsonFormatter.ConvertFromJson<Export>(response);
		}

		/// <summary>
        /// Get all existing exports 
        /// </summary>
        /// <returns>List of ExportRegister objects</returns>
        public GetExportListResponse GetExportList(GetExportListRequest request)
		{
			var response = GetResponse("ImportExport/GetExportList", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetExportListResponse>(response);
		}

		/// <summary>
        /// gets fulfillment center settings 
        /// </summary>
        /// <param name="fkStockLocationId">stock location id</param>
        /// <returns>settings</returns>
        public FulfilmentCenterImportExportSettings GetFullfilmentCenterSettings(Guid fkStockLocationId)
		{
			var response = GetResponse("ImportExport/GetFullfilmentCenterSettings", "fkStockLocationId=" + fkStockLocationId + "");
            return JsonFormatter.ConvertFromJson<FulfilmentCenterImportExportSettings>(response);
		}

		/// <summary>
        /// Get an import configuration 
        /// </summary>
        /// <param name="id">Id of the import to get</param>
        /// <returns>Import object</returns>
        public Import GetImport(Int32 id)
		{
			var response = GetResponse("ImportExport/GetImport", "id=" + id + "");
            return JsonFormatter.ConvertFromJson<Import>(response);
		}

		/// <summary>
        /// Get all existing imports 
        /// </summary>
        /// <returns>List of ImportRegister objects</returns>
        public GetImportListResponse GetImportList(GetImportListRequest request)
		{
			var response = GetResponse("ImportExport/GetImportList", "request=" + System.Net.WebUtility.UrlEncode(JsonFormatter.ConvertToJson(request)) + "");
            return JsonFormatter.ConvertFromJson<GetImportListResponse>(response);
		}

		/// <summary>
        /// Put the specific export immediately in the queue 
        /// </summary>
        /// <param name="exportId">Export id to execute</param>
        public void RunNowExport(Int32 exportId)
		{
			GetResponse("ImportExport/RunNowExport", "exportId=" + exportId + "");
		}

		/// <summary>
        /// Put the specific import immediately in the queue 
        /// </summary>
        /// <param name="importId">Import id to execute</param>
        public void RunNowImport(Int32 importId)
		{
			GetResponse("ImportExport/RunNowImport", "importId=" + importId + "");
		} 
    }
}