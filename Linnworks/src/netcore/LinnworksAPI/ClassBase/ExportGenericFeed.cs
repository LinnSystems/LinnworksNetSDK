using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExportGenericFeed
	{
		public ExportFeedType FeedType { get; set; }

		public String FileName { get; set; }

		public String FilePath { get; set; }

		public FileExistAction? IfFileExist { get; set; }
	} 
}