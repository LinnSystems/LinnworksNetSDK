using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class Orders_AddOrderServiceRequest : LinnObject
	{
        /// <summary>
        /// Order id 
        /// </summary>
		public Guid OrderId { get; set; }

        /// <summary>
        /// Service 
        /// </summary>
		public String Service { get; set; }

        /// <summary>
        /// Price Per Unit of each service item 
        /// </summary>
		public Double Cost { get; set; }

        /// <summary>
        /// Tax rate. Optional, defaults to 0. 
        /// </summary>
		public Double TaxRate { get; set; }

        /// <summary>
        /// Current fulfilment center 
        /// </summary>
		public Guid FulfilmentCenter { get; set; }

        /// <summary>
        /// Quantity of the service item. Optional, defaults to 1. 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Discount percentage applied to the service item. Optional, defaults to 0. 
        /// </summary>
		public Double DiscountPercentage { get; set; }
	} 
}