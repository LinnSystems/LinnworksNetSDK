using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DownloadResponse : LinnObject
	{
		public String Url { get; set; }

		public String Path { get; set; }
	} 
}