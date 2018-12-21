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
        /// Unit amount includes,excludes or no tax. 0 - Excludes Tax, 1 - Includes tax, 2 - No Tax 
        /// </summary>
		public Int32 UnitAmountTaxIncludedType;

        /// <summary>
        /// DateTime of the purchase order 
        /// </summary>
		public DateTime DateOfPurchase;

        /// <summary>
        /// DateTime of the expected delivery date. 
        /// </summary>
		public DateTime QuotedDeliveryDate;

        /// <summary>
        /// **DEPRECIATED** 
        /// Use additional costs with Shipping flag to record shipping costs. This field remains available in the API for backward compatibility and acts pretty much like an additional cost item with type 
        /// </summary>
		public Decimal PostagePaid;

        /// <summary>
        /// **DEPRECIATED** 
        /// Use additional costs with Shipping flag to record shipping costs. This field remains available in the API for backward compatibility and acts pretty much like an additional cost item with type 
        /// </summary>
		public Decimal ShippingTaxRate;

        /// <summary>
        /// Currency conversion rate, multiplier to change the purchase order currency into the system currecny 
        /// </summary>
		public Decimal ConversionRate;
	} 
}