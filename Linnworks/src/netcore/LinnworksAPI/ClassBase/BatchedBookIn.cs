using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class BatchedBookIn
	{
        /// <summary>
        /// Product SKU 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber { get; set; }

        /// <summary>
        /// Location ID 
        /// </summary>
		public Guid LocationId { get; set; }

        /// <summary>
        /// Bin rack 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// Quantity booked in 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Stock value 
        /// </summary>
		public Decimal StockValue { get; set; }

        /// <summary>
        /// Batch status 
        /// </summary>
		public String BatchStatus { get; set; }

		public Int32? PrioritySequence { get; set; }

        /// <summary>
        /// Batch expiry date 
        /// </summary>
		public DateTime? ExpiresOn { get; set; }

        /// <summary>
        /// Batch sell by date 
        /// </summary>
		public DateTime? SellBy { get; set; }
	} 
}