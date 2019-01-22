using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateRefundRequest
	{
        /// <summary>
        /// The identifier for the refund header to update 
        /// </summary>
		public Int32 RefundHeaderId;

        /// <summary>
        /// The unique identifier for the order the refund lines pertain to 
        /// </summary>
		public Guid OrderId;

        /// <summary>
        /// A list of refund lines to update within the given refund 
        /// </summary>
		public List<UpdatedRefundLine> RefundLines;
	} 
}