using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Purchase order item to update 
    /// </summary>
    public class UpdatePurchaseOrderItem
	{
        /// <summary>
        /// unique row id, to uniquely identify submitted item. This Id will be returned in the response so you can match request to response items 
        /// </summary>
		public Guid Id { get; set; }

		public Guid PurchaseItemId { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 Qty { get; set; }

		public Decimal Cost { get; set; }

		public Decimal TaxRate { get; set; }

		public Int32? PackQuantity { get; set; }

		public Int32? PackSize { get; set; }
	} 
}