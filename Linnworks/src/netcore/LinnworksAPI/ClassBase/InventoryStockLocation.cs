using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class InventoryStockLocation : LinnObject
	{
		public Guid StockLocationId { get; set; }

		public Int32 StockLocationIntId { get; set; }

		public String LocationName { get; set; }

		public String LocationTag { get; set; }

		public Boolean IsFulfillmentCenter { get; set; }

		public Boolean IsWarehouseManaged { get; set; }

		public String BinRack { get; set; }
	} 
}