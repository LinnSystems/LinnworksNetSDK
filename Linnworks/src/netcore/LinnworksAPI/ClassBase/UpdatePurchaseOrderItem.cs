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
		public Guid Id;

		public Guid PurchaseItemId;

		public Guid StockItemId;

		public Int32 Qty;

		public Int32 PackQuantity;

		public Int32 PackSize;

		public Decimal Cost;

		public Decimal TaxRate;
	} 
}