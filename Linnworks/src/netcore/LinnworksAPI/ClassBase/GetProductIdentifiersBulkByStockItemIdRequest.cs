using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProductIdentifiersBulkByStockItemIdRequest : LinnObject
	{
		public IEnumerable<Guid> StockItemIds { get; set; }
	} 
}