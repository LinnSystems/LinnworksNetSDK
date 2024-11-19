using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class DeleteRMARequest : LinnObject
	{
        /// <summary>
        /// Identifies the RMA header to be deleted 
        /// </summary>
		public Int32 RMAHeaderId { get; set; }

        /// <summary>
        /// Reason for deleting the RMA. Channel Dependant 
        /// </summary>
		public String ReasonTag { get; set; }

        /// <summary>
        /// Bool to say whether rejection note should be sent to the channel 
        /// </summary>
		public Boolean RejectOnChannel { get; set; }
	} 
}