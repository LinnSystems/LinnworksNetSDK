using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class that represents entry parameters for creating new PENDING purchase order 
    /// </summary>
    public class Create_PurchaseOrder_InitialParameter
	{
        /// <summary>
        /// Supplier unique identifier. Use Inventory/GetSupplierList to get the supplier ids 
        /// </summary>
		public Guid fkSupplierId;

        /// <summary>
        /// Location id where the PO will be delivered to. Use Inventory/GetStockLocations to get the location ids 
        /// </summary>
		public Guid fkLocationId;

        /// <summary>
        /// Purchase order reference 
        /// </summary>
		public String ExternalInvoiceNumber;

        /// <summary>
        /// Currency of the purchase order 
        /// </summary>
		public String Currency;

        /// <summary>
        /// Supplier purchase order reference number 
        /// </summary>
		public String SupplierReferenceNumber;

        /// <summary>
        /// DateTime of the purchase order 
        /// </summary>
		public DateTime DateOfPurchase;

        /// <summary>
        /// DateTime of the expected delivery date. 
        /// </summary>
		public DateTime QuotedDeliveryDate;

        /// <summary>
        /// Shipping cost including tax in the purchase order currency 
        /// </summary>
		public Decimal PostagePaid;

        /// <summary>
        /// Shipping cost tax rate 
        /// </summary>
		public Decimal ShippingTaxRate;

        /// <summary>
        /// Currency conversion rate, multiplier to change the purchase order currency into the system currecny 
        /// </summary>
		public Decimal ConversionRate;
	} 
}