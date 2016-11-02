using System;

namespace LinnworksAPI
{
    public class BookInStockItem
    {
        public Guid StockItemId;
        public Guid LocationId;
        public Int32 QuantityReceived;
        public Decimal CostPerUnit;
    }
}