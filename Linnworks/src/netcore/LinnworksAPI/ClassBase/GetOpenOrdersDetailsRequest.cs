using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOpenOrdersDetailsRequest
	{
        /// <summary>
        /// List of order ids as unique identifiers 
        /// </summary>
		public Guid[] OrderIds { get; set; }

        /// <summary>
        /// (optional) List of detail level limiters. If the list is null or empty Full details will be returned, as in all detail levels are applied 
        /// </summary>
		public OrderDetailLevel[] DetailLevel { get; set; }
	} 
}