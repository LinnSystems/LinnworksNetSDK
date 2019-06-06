using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchStockLevelDelta
	{
		public String SKU;

		public String BatchNumber;

		public String BinRack;

		public Int32 DeltaQuantity;

		public String Reason;

		public Int32? pkBatchInventoryId;

		public Int32 Quantity;

		public Decimal StockValue;

		public List<String> Errors;

		public Int32 NewLevel;
	} 
}