using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteRefundRequest : LinnObject
	{
        /// <summary>
        /// Identifies the refund header to be deleted 
        /// </summary>
		public Int32 RefundHeaderId { get; set; }

        /// <summary>
        /// Reason for deleting the refund. Channel Dependant 
        /// </summary>
		public String ReasonTag { get; set; }

        /// <summary>
        /// Bool to say whether rejection note should be sent to the channel 
        /// </summary>
		public Boolean RejectOnChannel { get; set; }
	} 
}