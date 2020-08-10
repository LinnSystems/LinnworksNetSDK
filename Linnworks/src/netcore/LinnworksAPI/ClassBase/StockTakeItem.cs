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
		public String BinRack { get; set; }

        /// <summary>
        /// (optional) Pickwave items associated with the batch. This data will be used for concurrency check and validation of data. 
        /// Super important stuff when you are submitting batch inventory stock count in WMS location. 
        /// Order items will automatically be allocated to a specific batch when the order is placed/printed/added to pickwave. This will normally block stock count, 
        /// however it is possible to get the state of pickwave items, and if all items are picked from the location the user can still count them. When stock count is submitted
        /// we need to also submit the state of the pickwave at the point of count, so we can compare state was and the state is, discount any stock from the count that was processed/shipped	
        /// If this parameter is not supplied and the batch is allocated to orders, the stock count for this item will be blocked and will not be submitted 
        /// </summary>
		public List<BatchPickingWaveStockItems> PickingWaveItems { get; set; }

        /// <summary>
        /// Stock Item Id 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Current stock level 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// (Optional) Original quantity, used to validate if the original has changed since the items have been counted. If supplied and different to expected then an error will be returned. 
        /// </summary>
		public Int32? OriginalQuantity { get; set; }

        /// <summary>
        /// (optional) Stock value (unit cost * quantity). If not provided it will be calculated from current stock value 
        /// </summary>
		public Decimal? StockValue { get; set; }

        /// <summary>
        /// (conditional) If item is batched or in WMS location, you must provide BatchInventoryId which is being updated. 
        /// If its newly discovered item, use BookInStockBatch call in Stock controller to create a new batch inventory	 
        /// </summary>
		public Int32? BatchInventoryId { get; set; }
	} 
}