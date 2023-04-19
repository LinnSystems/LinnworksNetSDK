using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchStockLevelDetaRequest : LinnObject
	{
		public List<BatchStockLevelDelta> StockLevelDeltas { get; set; }

		public Guid StockLocationId { get; set; }
	} 
}