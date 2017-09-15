using System;
using System.Collections.Generic;

namespace LinnworksAPI
{
    public class StockItemBatch
    {
        public Int32 BatchId;
        public String SKU;
        public Int32 InventoryTrackingType;
        public Guid StockItemId;
        public String BatchNumber;
        public DateTime ExpiresOn;
        public DateTime SellBy;
        public List<StockItemBatchInventory> Inventory;
        public IEnumerable<StockItemBatchInventory> Item;
    }
}