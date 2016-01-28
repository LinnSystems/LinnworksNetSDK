using System;

namespace LinnworksAPI
{
    public class BasicStockItem
    {
        public Guid pkStockItemId;
        public String ItemNumber;
        public String ItemTitle;
        public Double TaxRate;
        public Double Weight;
        public Double StockUnitCost;
        public Double PricePerUnit;
        public Double PurchasePrice;
        public String BarcodeNumber;
    }
}