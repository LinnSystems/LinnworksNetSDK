using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetActionableRMAHeadersResponse
	{
        /// <summary>
        /// The page number returned 
        /// </summary>
		public Int32 Page { get; set; }

        /// <summary>
        /// A count of the total number of RMA headers matching the filter set by the request 
        /// </summary>
		public Int32 TotalHeaders { get; set; }

        /// <summary>
        /// A count of the number of RMA headers returned per page 
        /// </summary>
		public Int32 HeadersPerPage { get; set; }

        /// <summary>
        /// A collection of RMA headers matching the filter set by the request 
        /// </summary>
		public List<OrderRMAHeader> RMAHeaders { get; set; }
	} 
}