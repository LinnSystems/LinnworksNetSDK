using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchStockLevelDelta
	{
		public String SKU { get; set; }

		public String BatchNumber { get; set; }

		public String BinRack { get; set; }

		public Int32 DeltaQuantity { get; set; }

		public String Reason { get; set; }

		public Int32? pkBatchInventoryId { get; set; }

		public Int32 Quantity { get; set; }

		public Decimal StockValue { get; set; }

		public List<String> Errors { get; set; }

		public Int32 NewLevel { get; set; }

		public String BatchStatus { get; set; }
	} 
}