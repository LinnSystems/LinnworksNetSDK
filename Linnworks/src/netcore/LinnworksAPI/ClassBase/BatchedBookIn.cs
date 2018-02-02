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
		public String SKU;

        /// <summary>
        /// Batch number 
        /// </summary>
		public String BatchNumber;

        /// <summary>
        /// Location ID 
        /// </summary>
		public Guid LocationId;

        /// <summary>
        /// Bin rack 
        /// </summary>
		public String BinRack;

        /// <summary>
        /// Quantity booked in 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Stock value 
        /// </summary>
		public Decimal StockValue;

        /// <summary>
        /// Batch status 
        /// </summary>
		public String BatchStatus;

		public Int16? PrioritySequence;

        /// <summary>
        /// Batch expiry date 
        /// </summary>
		public DateTime? ExpiresOn;

        /// <summary>
        /// Batch sell by date 
        /// </summary>
		public DateTime? SellBy;
	} 
}