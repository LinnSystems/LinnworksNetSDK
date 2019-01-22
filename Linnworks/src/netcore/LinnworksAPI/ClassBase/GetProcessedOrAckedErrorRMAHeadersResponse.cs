using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProcessedOrAckedErrorRMAHeadersResponse
	{
        /// <summary>
        /// The page number returned 
        /// </summary>
		public Int32 Page;

        /// <summary>
        /// A count of the total number of RMA headers matching the filter set by the request 
        /// </summary>
		public Int32 TotalHeaders;

        /// <summary>
        /// A count of the number of RMA headers returned per page 
        /// </summary>
		public Int32 HeadersPerPage;

        /// <summary>
        /// A collection of RMA headers matching the filter set by the request 
        /// </summary>
		public List<OrderRMAHeader> RMAHeaders;
	} 
}