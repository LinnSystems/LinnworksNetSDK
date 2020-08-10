using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetProcessedOrAckedErrorRefundHeadersRequest
	{
        /// <summary>
        /// The page number to return for a given set of filters 
        /// </summary>
		public Int32 Page { get; set; }

        /// <summary>
        /// A set of filters to restrict the refund headers output by the call 
        /// </summary>
		public ProcessedPostSaleSearchFilters Filters { get; set; }
	} 
}