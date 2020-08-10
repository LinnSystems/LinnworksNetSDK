using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProductIdentifiersByStockItemIdResponse
	{
		public IEnumerable<StockItemProductIdentifier> ProductIdentifiers { get; set; }
	} 
}