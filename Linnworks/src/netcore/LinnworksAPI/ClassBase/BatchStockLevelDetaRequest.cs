using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchStockLevelDetaRequest
	{
		public List<BatchStockLevelDelta> StockLevelDeltas;

		public Guid StockLocationId;
	} 
}