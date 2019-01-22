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
		public Boolean EntireRMAHeaderSetToErrorAcked;

		public Int32? RMAHeaderId;

		public List<VerifiedRMAItem> Items;

		public List<String> Errors;

		public List<String> Info;
	} 
}