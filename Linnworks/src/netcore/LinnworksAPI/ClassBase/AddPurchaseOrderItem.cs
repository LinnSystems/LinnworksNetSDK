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
		public Guid Id { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 Qty { get; set; }

		public Decimal Cost { get; set; }

		public Decimal TaxRate { get; set; }

		public Int32? PackQuantity { get; set; }

		public Int32? PackSize { get; set; }
	} 
}