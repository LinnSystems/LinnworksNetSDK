using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockLocationStockItemId : LinnObject
	{
        /// <summary>
        /// StockItemId 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// StockLocationId 
        /// </summary>
		public Guid StockLocationId { get; set; }
	} 
}