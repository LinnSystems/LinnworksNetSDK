using System;

namespace LinnworksAPI
{
    public class Update_PurchaseOrderHeaderParameter
    {
        public Guid pkPurchaseID;
        public String SupplierReferenceNumber;
        public Guid? fkLocationId;
        public Guid? fkSupplierId;
        public String Currency;
        public String ExternalInvoiceNumber;
        public DateTime? DateOfPurchase;
        public DateTime? QuotedDeliveryDate;
        public Decimal? ShippingTaxRate;
        public Decimal? ConversionRate;
        public Decimal? PostagePaid;
    }
}