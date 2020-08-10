using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// List of Purchase Order Ids return using the Stock Item and Location Id parameters 
    /// </summary>
    public class PurchaseOrderWithStockItem
	{
        /// <summary>
        /// The Id of the Stock Item 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// List of Location Ids to determine whether to return Purchase Order Ids based on stock location as well as Stock Item Id 
        /// </summary>
		public List<Guid> LocationIds { get; set; }
	} 
}