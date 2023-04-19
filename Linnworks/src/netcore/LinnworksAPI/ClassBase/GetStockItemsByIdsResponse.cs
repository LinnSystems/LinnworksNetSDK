using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetStockItemsByIdsResponse : LinnObject
	{
        /// <summary>
        /// List of stock item headers. 
        /// </summary>
		public List<StockItemHeader> Items { get; set; }
	} 
}