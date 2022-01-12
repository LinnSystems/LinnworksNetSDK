using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class GetOpenOrdersDetailsResponse
	{
        /// <summary>
        /// List of orders 
        /// </summary>
		public List<OrderDetails> Orders { get; set; }
	} 
}