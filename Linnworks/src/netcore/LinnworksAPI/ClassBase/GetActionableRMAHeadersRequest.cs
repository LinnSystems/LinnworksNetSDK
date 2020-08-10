using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetActionableRMAHeadersRequest
	{
        /// <summary>
        /// The page number to return for a given set of filters 
        /// </summary>
		public Int32 Page { get; set; }

        /// <summary>
        /// A set of filters to restrict the RMA headers output by the call 
        /// </summary>
		public ActionablePostSaleSearchFilters Filters { get; set; }
	} 
}