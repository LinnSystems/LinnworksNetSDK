using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockLevel_BatchRequest
	{
        /// <summary>
        /// List of stock item ids to get stock level 
        /// </summary>
		public List<Guid> StockItemIds { get; set; }
	} 
}