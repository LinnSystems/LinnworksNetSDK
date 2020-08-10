using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class represents purchase order header. 
    /// </summary>
    public class PurchaseOrderHeader
	{
        /// <summary>
        /// Unique identifier for the purchase order. You have to use this ID for all updates to the PO 
        /// </summary>
		public Guid pkPurchaseID { get; set; }

        /// <summary>
        /// Unique identifier for the supplier. Empty Guid is default supplier. Otherwise use Supplier API to get the names and additional data for the supplier 
        /// </summary>
		public Guid fkSupplierId { get; set; }

        /// <summary>
        /// Unique idenfidier of the location where the PO is expected to be delivered to. Empty Guid is default location. Use Locations API methods to get the names and additional details for the locations 
        /// </summary>
		public Guid fkLocationId { get; set; }

        /// <summary>
        /// Purchase order reference number 
        /// </summary>
		public String ExternalInvoiceNumber { get; set; }

        /// <summary>
        /// Purchase order status. 
        /// PENDING - purchase order can be changed, not yet affecting stock levels
        /// OPEN - purchase order is created and stock levels Due are reflected
        /// PARTIAL - partially delivered 
        /// DELIVERED - fully delivered 
        /// </summary>
		public PurchaseOrderStatus Status { get; set; }

        /// <summary>
        /// Currency of the monetary values in the purchase order 
        /// </summary>
		public String Currency { get; set; }

        /// <summary>
        /// Supplier reference number for the purchase order 
        /// </summary>
		public String SupplierReferenceNumber { get; set; }

        /// <summary>
        /// Identified whether the PO is locked. This is for external application use only. 
        /// </summary>
		public Boolean Locked { get; set; }

        /// <summary>
        /// Number of items in the purchase order 
        /// </summary>
		public Int32 LineCount { get; set; }

        /// <summary>
        /// Count of all purchase order lines which are delivered 
        /// (lines where some but not all of the stock has been received are counted as undelivered) 
        /// </summary>
		public Int32 DeliveredLinesCount { get; set; }

        /// <summary>
        /// Unit amount includes,exclud or no tax. 0 - Tax Exclusive cost, 1 - Cost Inclusive of tax, 2 - No Tax 
        /// </summary>
		public Int32 UnitAmountTaxIncludedType { get; set; }

        /// <summary>
        /// DateTime of the purchase order UTC 
        /// </summary>
		public DateTime DateOfPurchase { get; set; }

        /// <summary>
        /// DateTime of the purchase order delivered, will be set to DateOfPurchase until the PO is fully delivered UTC 
        /// </summary>
		public DateTime DateOfDelivery { get; set; }

        /// <summary>
        /// DateTime of the purchase order qouted/expected delivery date UTC 
        /// </summary>
		public DateTime QuotedDeliveryDate { get; set; }

        /// <summary>
        /// **DEPRECIATED** 
        /// Use additional costs with Shipping flag to record shipping costs. This field remains available in the API for backward compatibility and acts pretty much like an additional cost item with type id = 0 
        /// </summary>
		public Decimal PostagePaid { get; set; }

        /// <summary>
        /// Total purchase price of the purchase order. Calculated from all purchase order items including tax and postage. 
        /// </summary>
		public Decimal TotalCost { get; set; }

        /// <summary>
        /// Total tax of the purchase order. Calculated from all purchase order items (excludes postage). 
        /// </summary>
		public Decimal taxPaid { get; set; }

        /// <summary>
        /// **DEPRECIATED** 
        /// Use additional costs with Shipping flag to record shipping costs. This field remains available in the API for backward compatibility and acts pretty much like an additional cost item with type id = 0 
        /// </summary>
		public Decimal ShippingTaxRate { get; set; }

        /// <summary>
        /// Conversion rate of the purchase order currency. When PO is delivered Stock Value will be multipled by this conversion rate. For example if your system currency is GBP and Purchase order is in EUR the conversion rate is 0.81. 
        /// </summary>
		public Decimal ConversionRate { get; set; }

        /// <summary>
        /// Total shipping cost of the purchase order, converted to system currency 
        /// </summary>
		public Decimal ConvertedShippingCost { get; set; }

        /// <summary>
        /// Total shipping cost tax of the purchase order, converted to system currency 
        /// </summary>
		public Decimal ConvertedShippingTax { get; set; }

        /// <summary>
        /// Total amount of additional costs of the purchase order, converted to system currency 
        /// </summary>
		public Decimal ConvertedOtherCost { get; set; }

        /// <summary>
        /// Total tax amount of additional costs of the purchase order, converted to system currency 
        /// </summary>
		public Decimal ConvertedOtherTax { get; set; }

        /// <summary>
        /// Total amount of the purchase order, converted to system currency 
        /// </summary>
		public Decimal ConvertedGrandTotal { get; set; }
	} 
}