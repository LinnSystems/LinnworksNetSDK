using System;

namespace LinnworksAPI
{
    public class Deliver_PurchaseItemParameter
    {
        public Guid pkPurchaseId;
        public Guid pkPurchaseItemId;
        public Int32? Delivered;
        public Int32? AddToDelivered;
    }
}