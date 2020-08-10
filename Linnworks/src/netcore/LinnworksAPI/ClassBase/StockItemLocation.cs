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
		public Guid StockLocationId;

        /// <summary>
        /// Location name 
        /// </summary>
		public String LocationName;

        /// <summary>
        /// BinRack 
        /// </summary>
		public String BinRack;

		public Guid StockItemId;

		public Int32 StockItemIntId;
	} 
}