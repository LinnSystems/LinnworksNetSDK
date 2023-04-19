using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProductIdentifiersByStockItemIdResponse : LinnObject
	{
		public IEnumerable<StockItemProductIdentifier> ProductIdentifiers { get; set; }
	} 
}