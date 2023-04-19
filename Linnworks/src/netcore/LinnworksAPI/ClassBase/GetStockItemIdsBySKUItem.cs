using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Response item of StockItemId and SKU 
    /// </summary>
    public class GetStockItemIdsBySKUItem : LinnObject
	{
		public Guid StockItemId { get; set; }

		public String SKU { get; set; }
	} 
}