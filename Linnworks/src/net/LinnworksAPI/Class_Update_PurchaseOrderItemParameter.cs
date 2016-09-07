using System;

namespace LinnworksAPI
{
    public class Update_PurchaseOrderItemParameter
    {
        public Guid pkPurchaseItemId;
        public Guid pkPurchaseId;
        public Int32? Quantity;
        public Int32? PackQuantity;
        public Int32? PackSize;
        public Decimal? Cost;
        public Decimal? TaxRate;
    }
}