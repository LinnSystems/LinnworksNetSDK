using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Modified purchase order item 
    /// </summary>
    public class ModifiedPurchaseOrderItem
	{
        /// <summary>
        /// unique row id which was supplied in the ModifyPurchaseOrderItem, you can match this id to the request item. The same Id is returned to back from the request parameter 
        /// </summary>
		public Guid Id { get; set; }

        /// <summary>
        /// Unique purchase order item id. Purchase order item is deleted and updated by PurchaseOrderItemId 
        /// </summary>
		public Guid PurchaseItemId { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 Qty { get; set; }

		public Int32 BoundToOpenOrdersItems { get; set; }

		public Int32 QuantityBoundToOpenOrdersItems { get; set; }

		public Decimal Cost { get; set; }

		public Decimal TaxRate { get; set; }

		public Int32? PackQuantity { get; set; }

		public Int32? PackSize { get; set; }
	} 
}