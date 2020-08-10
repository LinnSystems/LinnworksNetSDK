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
		public Guid StockLocationId { get; set; }

        /// <summary>
        /// Stock location integet id 
        /// </summary>
		public Int32 StockLocationIntId { get; set; }

        /// <summary>
        /// Location name 
        /// </summary>
		public String LocationName { get; set; }

        /// <summary>
        /// If location is a fulfilment center 
        /// </summary>
		public Boolean IsFulfillmentCenter { get; set; }

        /// <summary>
        /// Location tag 
        /// </summary>
		public String LocationTag { get; set; }

        /// <summary>
        /// Bin rack 
        /// </summary>
		public String BinRack { get; set; }

        /// <summary>
        /// If the location is warehosue managed. 
        /// </summary>
		public Boolean? IsWarehouseManaged { get; set; }
	} 
}