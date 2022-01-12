using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class CreateWarehouseMoveRequest
	{
        /// <summary>
        /// Batch Inventory Id of the stock item you are moving 
        /// </summary>
		public Int32 BatchInventoryId { get; set; }

        /// <summary>
        /// Quantity of items being moved 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Destination if known, can be null 
        /// </summary>
		public Int32? BinrackIdDestination { get; set; }

        /// <summary>
        /// If the move is part of a specific job, specify job id so it can be marked off from the job 
        /// </summary>
		public Int32? JobId { get; set; }

        /// <summary>
        /// (Optional) Move to TOT id, create or retrive tot scan barcode first. To unassign from Tot send 0 
        /// </summary>
		public Int32? TotId { get; set; }

        /// <summary>
        /// Type of the move. Open means its an instruction to move, In Transit actually marks the item as unavilable and physically being moved 
        /// </summary>
		public TransactionType TxType { get; set; }

		public Guid? UserId { get; set; }
	} 
}