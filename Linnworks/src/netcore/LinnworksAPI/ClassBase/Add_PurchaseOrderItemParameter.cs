using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Class represents parameter for adding line to the purchase order. 
    /// </summary>
    public class Add_PurchaseOrderItemParameter
	{
        /// <summary>
        /// Purchase order id. You can only add items to pending purchase orders 
        /// </summary>
		public Guid pkPurchaseId { get; set; }

        /// <summary>
        /// pkStockItemId. Use Get Stock Item API call to get the id of a product by SKU or Title 
        /// </summary>
		public Guid fkStockItemId { get; set; }

        /// <summary>
        /// Quantity of items in the purchase order line 
        /// </summary>
		public Int32 Qty { get; set; }

        /// <summary>
        /// Number of items in a single pack. This is for reference purposes only. Not used for any calculations. 
        /// </summary>
		public Int32 PackQuantity { get; set; }

        /// <summary>
        /// Number of packs ordered. This is for reference purposes only. Not used for any calculations. 
        /// </summary>
		public Int32 PackSize { get; set; }

        /// <summary>
        /// Line Total cost of all the purchase order item inclusive of tax (unitcost * qty) + tax 
        /// </summary>
		public Decimal Cost { get; set; }

        /// <summary>
        /// Product tax rate 
        /// </summary>
		public Decimal TaxRate { get; set; }
	} 
}