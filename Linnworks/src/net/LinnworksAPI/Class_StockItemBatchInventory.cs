using System;

namespace LinnworksAPI
{
    public class StockItemBatchInventory
    {
        public Int32 BatchInventoryId;
        public Int32 BatchId;
        public Guid StockLocationId;
        public String BinRack;
        public Int16 PrioritySequence;
        public Int32 Quantity;
        public Decimal StockValue;
        public Int32 StartQuantity;
        public Int32 PickedQuantity;
        public String BatchStatus;
    }
}