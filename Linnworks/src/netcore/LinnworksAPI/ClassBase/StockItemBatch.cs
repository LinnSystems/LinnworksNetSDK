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
		public Int32 BatchId;

        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU;

        /// <summary>
        /// 0 - None, 1 - Order by sell by date, 2 - Ordered by priority sequence 
        /// </summary>
		public Int32 InventoryTrackingType;

        /// <summary>
        /// Product ID 
        /// </summary>
		public Guid StockItemId;

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber;

        /// <summary>
        /// Batch expiry date 
        /// </summary>
		public DateTime ExpiresOn;

        /// <summary>
        /// Batch sell by date 
        /// </summary>
		public DateTime SellBy;

        /// <summary>
        /// Batch records 
        /// </summary>
		public List<StockItemBatchInventory> Inventory;

        /// <summary>
        /// Is the batch deleted 
        /// </summary>
		public Boolean IsDeleted;

		public IEnumerable<StockItemBatchInventory> Item;
	} 
}