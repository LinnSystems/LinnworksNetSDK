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
		public OrderTotalsInfo TotalsInfo;

        /// <summary>
        /// Order items information 
        /// </summary>
		public OrderItem Item;

        /// <summary>
        /// Order item weight 
        /// </summary>
		public Double ItemWeight;

        /// <summary>
        /// Order total weight 
        /// </summary>
		public Double TotalWeight;
	} 
}