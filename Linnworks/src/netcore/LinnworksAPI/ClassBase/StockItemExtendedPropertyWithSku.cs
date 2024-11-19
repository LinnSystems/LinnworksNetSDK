using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemExtendedPropertyWithSku : LinnObject
	{
        /// <summary>
        /// The ItemNumber (SKU) of the item
        /// This is used to calculate the StockItemId if it has been omitted 
        /// </summary>
		public String ItemNumber { get; set; }

		public Guid pkRowId { get; set; }

		public Guid fkStockItemId { get; set; }

		public String ProperyName { get; set; }

		public String PropertyValue { get; set; }

		public String PropertyType { get; set; }
	} 
}