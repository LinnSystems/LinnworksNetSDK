using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateWarehouseMoveRequest : LinnObject
	{
        /// <summary>
        /// The Id of the stock move to update 
        /// </summary>
		public Int32 MoveId { get; set; }

		public Int32 BatchInventoryId { get; set; }

		public Int32 Quantity { get; set; }

		public Int32? BinrackIdDestination { get; set; }

		public Int32? JobId { get; set; }

		public Int32? TotId { get; set; }

		public TransactionType TxType { get; set; }

		public Guid? UserId { get; set; }
	} 
}