using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class RowQty
	{
        /// <summary>
        /// Order item record row ID 
        /// </summary>
		public Guid OrderItemRowId { get; set; }

        /// <summary>
        /// Batch inventory id 
        /// </summary>
		public Int32? OrderItemBatchId { get; set; }

        /// <summary>
        /// Refund amount 
        /// </summary>
		public Double Refund { get; set; }

        /// <summary>
        /// Affected quantity 
        /// </summary>
		public Int32 Qty { get; set; }

        /// <summary>
        /// Scrapped quantity 
        /// </summary>
		public Int32? ScrapQty { get; set; }

        /// <summary>
        /// The batch related to the rowqty 
        /// </summary>
		public OrderItemBatch Batch { get; set; }

        /// <summary>
        /// Additional costs 
        /// </summary>
		public Double AdditionalCost { get; set; }

        /// <summary>
        /// New (returned) stock item ID 
        /// </summary>
		public Guid? NewStockItemId { get; set; }

        /// <summary>
        /// Returned qty 
        /// </summary>
		public Int32 NewQty { get; set; }
	} 
}