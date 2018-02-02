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
		public Guid pkPurchaseID;

        /// <summary>
        /// Unique identifier for the supplier. Empty Guid is default supplier. Otherwise use Supplier API to get the names and additional data for the supplier 
        /// </summary>
		public Guid fkSupplierId;

        /// <summary>
        /// Unique idenfidier of the location where the PO is expected to be delivered to. Empty Guid is default location. Use Locations API methods to get the names and additional details for the locations 
        /// </summary>
		public Guid fkLocationId;

        /// <summary>
        /// Purchase order reference number 
        /// </summary>
		public String ExternalInvoiceNumber;

        /// <summary>
        /// Purchase order status. 
        /// PENDING - purchase order can be changed, not yet affecting stock levels
        /// OPEN - purchase order is created and stock levels Due are reflected
        /// PARTIAL - partially delivered 
        /// DELIVERED - fully delivered 
        /// </summary>
		public PurchaseOrderStatus Status;

        /// <summary>
        /// Currency of the monetary values in the purchase order 
        /// </summary>
		public String Currency;

        /// <summary>
        /// Supplier reference number for the purchase order 
        /// </summary>
		public String SupplierReferenceNumber;

        /// <summary>
        /// Identified whether the PO is locked. This is for external application use only. 
        /// </summary>
		public Boolean Locked;

        /// <summary>
        /// Number of items in the purchase order 
        /// </summary>
		public Int32 LineCount;

        /// <summary>
        /// Count of all purchase order lines which are delivered 
        /// (lines where some but not all of the stock has been received are counted as undelivered) 
        /// </summary>
		public Int32 DeliveredLinesCount;

        /// <summary>
        /// DateTime of the purchase order UTC 
        /// </summary>
		public DateTime DateOfPurchase;

        /// <summary>
        /// DateTime of the purchase order delivered, will be set to DateOfPurchase until the PO is fully delivered UTC 
        /// </summary>
		public DateTime DateOfDelivery;

        /// <summary>
        /// DateTime of the purchase order qouted/expected delivery date UTC 
        /// </summary>
		public DateTime QuotedDeliveryDate;

        /// <summary>
        /// Shipping cost including tax 
        /// </summary>
		public Decimal PostagePaid;

        /// <summary>
        /// Total purchase price of the purchase order. Calculated from all purchase order items including tax and postage. 
        /// </summary>
		public Decimal TotalCost;

        /// <summary>
        /// Total tax of the purchase order. Calculated from all purchase order items (excludes postage). 
        /// </summary>
		public Decimal taxPaid;

        /// <summary>
        /// Shipping tax rate 
        /// </summary>
		public Decimal ShippingTaxRate;

        /// <summary>
        /// Conversion rate of the purchase order currency. When PO is delivered Stock Value will be multipled by this conversion rate. For example if your system currency is GBP and Purchase order is in EUR the conversion rate is 0.81. 
        /// </summary>
		public Decimal ConversionRate;
	} 
}