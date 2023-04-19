using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemsLocationResponse : LinnObject
	{
		public List<StockItemLocation> StockItemLocations { get; set; }
	} 
}