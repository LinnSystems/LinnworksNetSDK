using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ExportPurchaseOrderSettingModel : LinnObject
	{
		public IReadOnlyList<ColumnPurchaseOrderMappingModel> ColumnMappings { get; set; }

		public String Delimiter { get; set; }

		public CommonEncoding Encoding { get; set; }

		public Guid PurchaseId { get; set; }

		public String StringDelimiter { get; set; }

		public String FileName { get; set; }
	} 
}