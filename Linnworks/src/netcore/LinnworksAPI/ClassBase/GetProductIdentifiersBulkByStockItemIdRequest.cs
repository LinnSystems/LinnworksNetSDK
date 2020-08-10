using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProductIdentifiersBulkByStockItemIdRequest
	{
		public IEnumerable<Guid> StockItemIds { get; set; }
	} 
}