using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockTakeItem
	{
        /// <summary>
        /// (optional) Only applicable to non-batched and non-WMS locations. Singular BinRack will be updated for the given item for a given location. Will be ignored for a batched or WMS item. 
        /// </summary>
		public String BinRack;

        /// <summary>
        /// Stock Item Id 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// Current stock level 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// (Optional) Original quantity, used to validate if the original has changed since the items have been counted. If supplied and different to expected then an error will be returned. 
        /// </summary>
		public Int32? OriginalQuantity;

        /// <summary>
        /// (optional) Stock value (unit cost * quantity). If not provided it will be calculated from current stock value 
        /// </summary>
		public Decimal? StockValue;

        /// <summary>
        /// (conditional) If item is batched or in WMS location, you must provide BatchInventoryId which is being updated. 
        /// If its newly discovered item, use BookInStockBatch call in Stock controller to create a new batch inventory	 
        /// </summary>
		public Int32? BatchInventoryId;
	} 
}