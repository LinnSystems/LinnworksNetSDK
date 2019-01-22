using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProcessedOrAckedErrorRefundHeadersResponse
	{
        /// <summary>
        /// The page number returned 
        /// </summary>
		public Int32 Page;

        /// <summary>
        /// A count of the total number of refund headers matching the filter set by the request 
        /// </summary>
		public Int32 TotalHeaders;

        /// <summary>
        /// A count of the number of refund headers returned per page 
        /// </summary>
		public Int32 HeadersPerPage;

        /// <summary>
        /// A collection of refund headers matching the filter set by the request 
        /// </summary>
		public List<OrderRefundHeader> RefundHeaders;
	} 
}