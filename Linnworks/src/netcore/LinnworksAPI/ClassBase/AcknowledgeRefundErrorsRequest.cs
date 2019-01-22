using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AcknowledgeRefundErrorsRequest
	{
        /// <summary>
        /// The unique identifier for the refund header whose errors will be acknowledged 
        /// </summary>
		public Int32 RefundHeaderId;

        /// <summary>
        /// A list of row ids to acknowledge errors for 
        /// </summary>
		public List<Guid> RefundRowIds;
	} 
}