using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DownloadOrdersToCSVResponse
	{
		public String Url { get; set; }

		public Single DownloadProgress { get; set; }

		public Single UploadProgress { get; set; }

		public Guid Id { get; set; }

		public String CreationDate { get; set; }
	} 
}