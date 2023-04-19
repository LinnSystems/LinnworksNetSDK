using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class OpenTemplatesByInventoryResponse : LinnObject
	{
		public Int32 TotalEntries { get; set; }

		public DynamicInfo TemplatesInfo { get; set; }
	} 
}