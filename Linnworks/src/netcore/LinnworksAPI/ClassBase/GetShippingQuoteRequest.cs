using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Request class for GetShippingQuote 
    /// </summary>
    public class GetShippingQuoteRequest : LinnObject
	{
        /// <summary>
        /// Unique Order Identifier for which the shipping quote will be run 
        /// </summary>
		public Guid pkOrderId { get; set; }

        /// <summary>
        /// List of Integrated accounts to include in the shipping quote. Only shipping integrations that support shipping quotes will be used. 
        /// </summary>
		public List<ShippingQuoteAccounts> Accounts { get; set; }
	} 
}