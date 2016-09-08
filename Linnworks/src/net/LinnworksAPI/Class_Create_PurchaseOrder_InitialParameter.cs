using System;

namespace LinnworksAPI
{
    public class Create_PurchaseOrder_InitialParameter
    {
        public Guid fkSupplierId;
        public Guid fkLocationId;
        public String ExternalInvoiceNumber;
        public String Currency;
        public String SupplierReferenceNumber;
        public DateTime DateOfPurchase;
        public DateTime QuotedDeliveryDate;
        public Decimal PostagePaid;
        public Decimal ShippingTaxRate;
        public Decimal ConversionRate;
    }
}