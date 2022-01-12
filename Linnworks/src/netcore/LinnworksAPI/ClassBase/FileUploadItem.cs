using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class FileUploadItem
	{
		public String EncodedFile { get; set; }

		public String Name { get; set; }

		public String DocType { get; set; }

		public String ExpirationDate { get; set; }

		public String DocUsageType { get; set; }

		public String OrderId { get; set; }

		public String AccountId { get; set; }

		public String Vendor { get; set; }
	} 
}