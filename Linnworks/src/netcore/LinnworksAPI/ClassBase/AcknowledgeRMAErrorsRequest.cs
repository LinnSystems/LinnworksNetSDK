using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AcknowledgeRMAErrorsRequest
	{
        /// <summary>
        /// The unique identifier for the RMA header whose errors will be acknowledged 
        /// </summary>
		public Int32 RMAHeaderId { get; set; }

        /// <summary>
        /// A list of row ids to acknowledge errors for 
        /// </summary>
		public List<Int32> RMARowIds { get; set; }

        /// <summary>
        /// Ignores the RefundRowIds list and acknowledges all errors for the given rma header id 
        /// </summary>
		public Boolean AcknowledgeAllErrors { get; set; }
	} 
}