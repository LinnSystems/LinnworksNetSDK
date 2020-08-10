using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Book in parameters used to update stock items 
    /// </summary>
    public class BookInStockItem
	{
        /// <summary>
        /// Id of the stock item 
        /// </summary>
		public Guid StockItemId { get; set; }

        /// <summary>
        /// Id of the location 
        /// </summary>
		public Guid LocationId { get; set; }

        /// <summary>
        /// Quantity to be booked in 
        /// </summary>
		public Int32 QuantityReceived { get; set; }

        /// <summary>
        /// Cost of the item for this order 
        /// </summary>
		public Decimal CostPerUnit { get; set; }

        /// <summary>
        /// Binrack of the item to be booked in. 
        /// </summary>
		public String BinRack { get; set; }
	} 
}