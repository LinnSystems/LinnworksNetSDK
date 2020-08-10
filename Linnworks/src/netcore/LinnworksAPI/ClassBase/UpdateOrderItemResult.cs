using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class UpdateOrderItemResult
	{
        /// <summary>
        /// Order figures 
        /// </summary>
		public OrderTotalsInfo TotalsInfo { get; set; }

        /// <summary>
        /// Order items information 
        /// </summary>
		public OrderItem Item { get; set; }

        /// <summary>
        /// Order item weight 
        /// </summary>
		public Double ItemWeight { get; set; }

        /// <summary>
        /// Order total weight 
        /// </summary>
		public Double TotalWeight { get; set; }
	} 
}