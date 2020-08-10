using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AcknowledgeRMAErrorsResponse
	{
        /// <summary>
        /// Determines whether the entire RMA header was set to "ERROR_ACKED" state as a result of this call (will be found in the History tab) 
        /// </summary>
		public Boolean EntireRMAHeaderSetToErrorAcked { get; set; }

		public Int32? RMAHeaderId { get; set; }

		public List<VerifiedRMAItem> Items { get; set; }

		public List<String> Errors { get; set; }

		public List<String> Info { get; set; }
	} 
}