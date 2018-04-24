using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockLevel_BatchResponse
	{
		public Guid pkStockItemId;

		public List<StockItemLevel> StockItemLevels;
	} 
}