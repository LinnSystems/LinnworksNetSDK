using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Add/remove from all orders in the request body to the provided tag 
    /// </summary>
    public class ChangeOrderIdentifierRequest
	{
        /// <summary>
        /// Primary key of the orders to assign/unassign the identifier to. 
        /// </summary>
		public Guid[] OrderIds { get; set; }

        /// <summary>
        /// Identifier tag to assign/unassign. E.g. AMAZON_PRIME 
        /// </summary>
		public String Tag { get; set; }
	} 
}