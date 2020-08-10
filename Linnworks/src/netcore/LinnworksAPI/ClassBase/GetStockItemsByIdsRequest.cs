using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemsByIdsRequest
	{
        /// <summary>
        /// Collection of Stock item id (uniqueidentifier) 
        /// </summary>
		public List<Guid> StockItemIds { get; set; }
	} 
}