using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class PostShipmentUploadRequest : LinnObject
	{
		public FileUploadItem[] FileUploadItems { get; set; }
	} 
}