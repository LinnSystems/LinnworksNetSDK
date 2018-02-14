using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Simplified StockLocation information for use in settings screen 
    /// </summary>
    public class InventoryStockLocation
	{
        /// <summary>
        /// Location ID 
        /// </summary>
		public Guid StockLocationId;

        /// <summary>
        /// Location name 
        /// </summary>
		public String LocationName;

        /// <summary>
        /// If location is a fulfilment center 
        /// </summary>
		public Boolean IsFulfillmentCenter;

        /// <summary>
        /// Location tag 
        /// </summary>
		public String LocationTag;

        /// <summary>
        /// Bin rack 
        /// </summary>
		public String BinRack;
	} 
}