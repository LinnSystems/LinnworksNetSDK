using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;
using System;
using System.IO;
using System.Net.Http;

namespace LinnworksAPI
{ 
    public interface IImportExportController
	{
		void DeleteExport(Int32 id);
		void DeleteImport(Int32 id);
		HttpResponseMessage DownloadImportedFile(Guid fileId);
		ExportRegister EnableExport(Int32 exportId,Boolean enable);
		ImportRegister EnableImport(Int32 importId,Boolean enable);
		Export GetExport(Int32 id);
		GetExportListResponse GetExportList(GetExportListRequest request);
		FulfilmentCenterImportExportSettings GetFullfilmentCenterSettings(Guid fkStockLocationId);
		Import GetImport(Int32 id);
		GetImportListResponse GetImportList(GetImportListRequest request);
		void RunNowExport(Int32 exportId);
		void RunNowImport(Int32 importId);
	} 
}