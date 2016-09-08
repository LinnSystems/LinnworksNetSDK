using System;

namespace LinnworksAPI
{
    public class Add_PurchaseOrderItemParameter
    {
        public Guid pkPurchaseId;
        public Guid fkStockItemId;
        public Int32 Qty;
        public Int32 PackQuantity;
        public Int32 PackSize;
        public Decimal Cost;
        public Decimal TaxRate;
    }
}