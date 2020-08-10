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
		public Int32 RefundHeaderId { get; set; }

        /// <summary>
        /// A list of row ids to acknowledge errors for. Can be left empty when "AcknowledgeAllErrors" is set to true 
        /// </summary>
		public List<Guid> RefundRowIds { get; set; }

        /// <summary>
        /// Ignores the RefundRowIds list and acknowledges all errors for the given refund header id 
        /// </summary>
		public Boolean AcknowledgeAllErrors { get; set; }
	} 
}