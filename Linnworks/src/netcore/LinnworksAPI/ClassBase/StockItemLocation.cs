using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemLocation
	{
        /// <summary>
        /// Stock location ID 
        /// </summary>
		public Guid StockLocationId { get; set; }

        /// <summary>
        /// Location name 
        /// </summary>
		public String LocationName { get; set; }

        /// <summary>
        /// BinRack 
        /// </summary>
		public String BinRack { get; set; }

		public Guid StockItemId { get; set; }

		public Int32 StockItemIntId { get; set; }
	} 
}