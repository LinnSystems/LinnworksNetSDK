using System;

namespace LinnworksAPI
{
    public class StockItemComposition
    {
        public Guid LinkedStockItemId;
        public String ItemTitle;
        public String SKU;
        public Int32 Quantity;
        public Double PurchasePrice;
        public Byte InventoryTrackingType;
        public Guid StockItemId;
    }
}