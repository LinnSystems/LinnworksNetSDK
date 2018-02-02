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
		public Guid OrderItemRowId;

        /// <summary>
        /// Batch inventory id 
        /// </summary>
		public Int32? OrderItemBatchId;

        /// <summary>
        /// Refund amount 
        /// </summary>
		public Double Refund;

        /// <summary>
        /// Affected quantity 
        /// </summary>
		public Int32 Qty;

        /// <summary>
        /// Scrapped quantity 
        /// </summary>
		public Int32? ScrapQty;

        /// <summary>
        /// Additional costs 
        /// </summary>
		public Double AdditionalCost;

        /// <summary>
        /// New (returned) stock item ID 
        /// </summary>
		public Guid? NewStockItemId;

        /// <summary>
        /// Returned qty 
        /// </summary>
		public Int32 NewQty;
	} 
}