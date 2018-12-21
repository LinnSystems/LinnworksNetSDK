using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Purchase order item to add 
    /// </summary>
    public class AddPurchaseOrderItem
	{
        /// <summary>
        /// unique row id, the same id will be returned to you in the response 
        /// </summary>
		public Guid Id;

		public Guid StockItemId;

		public Int32 Qty;

		public Int32 PackQuantity;

		public Int32 PackSize;

		public Decimal Cost;

		public Decimal TaxRate;
	} 
}