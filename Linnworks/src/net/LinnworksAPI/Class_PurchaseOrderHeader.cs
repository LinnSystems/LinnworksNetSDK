using System;

namespace LinnworksAPI
{
    public class PurchaseOrderHeader
    {
        public Guid pkPurchaseID;
        public Guid fkSupplierId;
        public Guid fkLocationId;
        public String ExternalInvoiceNumber;
        public PurchaseOrderStatus Status;
        public String Currency;
        public String SupplierReferenceNumber;
        public Boolean Locked;
        public Int32 LineCount;
        public Int32 DeliveredLinesCount;
        public DateTime DateOfPurchase;
        public DateTime DateOfDelivery;
        public DateTime QuotedDeliveryDate;
        public Decimal PostagePaid;
        public Decimal TotalCost;
        public Decimal taxPaid;
        public Decimal ShippingTaxRate;
        public Decimal ConversionRate;
    }
}