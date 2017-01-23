using System;

namespace LinnworksAPI
{
    public class StockItemSupplierStat
    {
        public Boolean IsDefault;
        public String Supplier;
        public Guid SupplierID;
        public String Code;
        public String SupplierBarcode;
        public Int32 LeadTime;
        public Double PurchasePrice;
        public Double MinPrice;
        public Double MaxPrice;
        public Double AveragePrice;
        public Double AverageLeadTime;
        public Int32 SupplierMinOrderQty;
        public Int32 SupplierPackSize;
        public String SupplierCurrency;
        public Guid StockItemId;
    }
}