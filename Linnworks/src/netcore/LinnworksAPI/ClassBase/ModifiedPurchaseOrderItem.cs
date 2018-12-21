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
		public Guid Id;

        /// <summary>
        /// Unique purchase order item id. Purchase order item is deleted and updated by PurchaseOrderItemId 
        /// </summary>
		public Guid PurchaseItemId;

		public Guid StockItemId;

		public Int32 Qty;

		public Int32 PackQuantity;

		public Int32 PackSize;

		public Decimal Cost;

		public Decimal TaxRate;
	} 
}