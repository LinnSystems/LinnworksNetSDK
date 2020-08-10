using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class WarehouseLocation
	{
        /// <summary>
        /// Location name 
        /// </summary>
		public String LocationName { get; set; }

        /// <summary>
        /// Stock location ID 
        /// </summary>
		public Guid pkStockLocationId { get; set; }
	} 
}