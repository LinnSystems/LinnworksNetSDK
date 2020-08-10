using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Update purchase order item parameter 
    /// </summary>
    public class Update_PurchaseOrderItemParameter
	{
        /// <summary>
        /// Purchase order item unique row identifier 
        /// </summary>
		public Guid pkPurchaseItemId { get; set; }

        /// <summary>
        /// Purchase order id 
        /// </summary>
		public Guid pkPurchaseId { get; set; }

        /// <summary>
        /// Quantity to be updated. (optional) 
        /// </summary>
		public Int32? Quantity { get; set; }

        /// <summary>
        /// Number of items in a single pack. This is for reference purposes only. Not used for any calculations. Optional 
        /// </summary>
		public Int32? PackQuantity { get; set; }

        /// <summary>
        /// Number of packs ordered. This is for reference purposes only. Not used for any calculations. Optional 
        /// </summary>
		public Int32? PackSize { get; set; }

        /// <summary>
        /// Line Total cost of all the purchase order item inclusive of tax (unitcost * qty) + tax. 
        /// Value should be in the currency of the purchase order
        /// (Optional) if not specified the cost will be recalculated from current cost specified on the PO 
        /// </summary>
		public Decimal? Cost { get; set; }

        /// <summary>
        /// Tax Rate (Optional) 
        /// </summary>
		public Decimal? TaxRate { get; set; }
	} 
}