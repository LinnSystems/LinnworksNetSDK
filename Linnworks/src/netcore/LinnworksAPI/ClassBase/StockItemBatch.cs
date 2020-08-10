using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemBatch
	{
        /// <summary>
        /// Batch ID 
        /// </summary>
		public Int32 BatchId { get; set; }

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// 0 - None, 1 - Order by sell by date, 2 - Ordered by priority sequence 
        /// </summary>
		public Int32 InventoryTrackingType { get; set; }

        /// <summary>
        /// Product ID 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber { get; set; }

        /// <summary>
        /// Batch expiry date 
        /// </summary>
		public DateTime ExpiresOn { get; set; }

        /// <summary>
        /// Batch sell by date 
        /// </summary>
		public DateTime SellBy { get; set; }

        /// <summary>
        /// Batch records 
        /// </summary>
		public List<StockItemBatchInventory> Inventory { get; set; }

        /// <summary>
        /// Is the batch deleted 
        /// </summary>
		public Boolean IsDeleted { get; set; }

		public IEnumerable<StockItemBatchInventory> Item { get; set; }
	} 
}