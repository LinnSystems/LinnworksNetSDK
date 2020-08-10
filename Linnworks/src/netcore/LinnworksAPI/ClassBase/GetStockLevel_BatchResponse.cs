using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Response class with info about stock level in each location for a list of stock items 
    /// </summary>
    public class GetStockLevel_BatchResponse
	{
        /// <summary>
        /// Id of the stock item 
        /// </summary>
		public Guid pkStockItemId { get; set; }

        /// <summary>
        /// List of stock level for each location 
        /// </summary>
		public List<StockItemLevel> StockItemLevels { get; set; }
	} 
}