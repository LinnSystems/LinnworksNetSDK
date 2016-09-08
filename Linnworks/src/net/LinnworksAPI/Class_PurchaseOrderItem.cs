using System;

namespace LinnworksAPI
{
    public class PurchaseOrderItem
    {
        public Guid pkPurchaseItemId;
        public Guid fkStockItemId;
        public Int32 Quantity;
        public Decimal Cost;
        public Int32 Delivered;
        public Decimal TaxRate;
        public Decimal Tax;
        public Int32 PackQuantity;
        public Int32 PackSize;
        public String SKU;
        public String ItemTitle;
    }
}