using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ColumnPurchaseOrderMappingModel : LinnObject
	{
		public String CsvField { get; set; }

		public Int32 Index { get; set; }

		public ExportPurchaseOrderColumn LinnworksFieldType { get; set; }
	} 
}