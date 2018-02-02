using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Change purchase order status. You can change from PENDING to OPEN, from OPEN to DELIVERED, from PARTIAL to DELIVERED 
    /// </summary>
    public class Update_PurchaseOrderHeaderParameter
	{
        /// <summary>
        /// Unique identifier for the purchase order. You have to use this ID for all updates to the PO 
        /// </summary>
		public Guid pkPurchaseID;

        /// <summary>
        /// Supplier reference number for the purchase order 
        /// </summary>
		public String SupplierReferenceNumber;

        /// <summary>
        /// Unique idenfidier of the location where the PO is expected to be delivered to. Empty Guid is default location. Use Locations API methods to get the names and additional details for the locations 
        /// </summary>
		public Guid? fkLocationId;

        /// <summary>
        /// Unique identifier for the supplier. Empty Guid is default supplier. Otherwise use Supplier API to get the names and additional data for the supplier 
        /// </summary>
		public Guid? fkSupplierId;

        /// <summary>
        /// Currency of the values in the purchase order 
        /// </summary>
		public String Currency;

        /// <summary>
        /// Purchase order reference 
        /// </summary>
		public String ExternalInvoiceNumber;

        /// <summary>
        /// DateTime of the purchase order delivered, will be set to DateOfPurchase until the PO is fully delivered UTC 
        /// </summary>
		public DateTime? DateOfPurchase;

        /// <summary>
        /// DateTime of the purchase order quoted/expected delivery date UTC 
        /// </summary>
		public DateTime? QuotedDeliveryDate;

        /// <summary>
        /// Shipping tax rate 
        /// </summary>
		public Decimal? ShippingTaxRate;

        /// <summary>
        /// Conversion rate of the purchase order currency. When PO is delivered Stock Value will be multipled by this conversion rate. For example if your system currency is GBP and Purchase order is in EUR the conversion rate is 0.81. 
        /// </summary>
		public Decimal? ConversionRate;

        /// <summary>
        /// Shipping cost including tax in purchase order currency 
        /// </summary>
		public Decimal? PostagePaid;
	} 
}