using System;

namespace LinnworksAPI
{
    public class StockItem
    {
        public String ItemNumber;
        public String ItemTitle;
        public String BarcodeNumber;
        public Double PurchasePrice;
        public Double RetailPrice;
        public Int32 Quantity;
        public Double TaxRate;
        public Guid StockItemId;
    }
}