using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class AddWarehouseZoneTypeRequest : LinnObject
	{
        /// <summary>
        /// Warehouse zone type name 
        /// </summary>
		public String Name { get; set; }

        /// <summary>
        /// Stock location interger id 
        /// </summary>
		public Int32 StockLocationIntId { get; set; }
	} 
}