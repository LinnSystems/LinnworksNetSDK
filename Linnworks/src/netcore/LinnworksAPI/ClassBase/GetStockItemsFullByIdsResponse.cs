using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemsFullByIdsResponse : LinnObject
	{
		public List<StockItemFullExtended> StockItemsFullExtended { get; set; }
	} 
}