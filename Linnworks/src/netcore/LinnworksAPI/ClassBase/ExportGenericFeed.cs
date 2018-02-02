using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExportGenericFeed
	{
		public FeedType FeedType;

		public String FileName;

		public String FilePath;

		public FileExistAction? IfFileExist;
	} 
}