using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Get stock item id's by sku request class. 
    /// </summary>
    public class GetStockItemIdsBySKU
	{
        /// <summary>
        /// Response items of StockItemId and SKU 
        /// </summary>
		public List<GetStockItemIdsBySKUItem> Items { get; set; }
	} 
}