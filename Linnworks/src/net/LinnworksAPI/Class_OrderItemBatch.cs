using System;

namespace LinnworksAPI
{
    public class OrderItemBatch
    {
        public Guid OrderItemRowId;
        public Int32 BatchInventoryId;
        public Int32 Quantity;
        public StockItemBatch Batch;
    }
}