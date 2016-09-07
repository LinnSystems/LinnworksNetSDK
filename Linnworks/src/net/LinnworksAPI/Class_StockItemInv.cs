using System;

namespace LinnworksAPI
{
    public class StockItemInv
    {
        public String VariationGroupName;
        public String MetaData;
        public Double TaxRate;
        public Guid CategoryId;
        public Guid PackageGroupId;
        public Guid PostalServiceId;
        public Double Weight;
        public Double Width;
        public Double Depth;
        public Double Height;
        public Int32 Quantity;
        public Int32 InOrder;
        public Int32 Due;
        public Int32 MinimumLevel;
        public Int32 Available;
        public String ItemNumber;
        public String ItemTitle;
        public String BarcodeNumber;
        public Double PurchasePrice;
        public Double? RetailPrice;
        public String PostalServiceName;
        public String CategoryName;
        public String PackageGroupName;
        public Guid StockItemId;
    }
}