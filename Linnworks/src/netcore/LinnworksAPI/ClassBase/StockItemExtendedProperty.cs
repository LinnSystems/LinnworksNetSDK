using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemExtendedProperty
	{
        /// <summary>
        /// Record row ID (generate random) 
        /// </summary>
		public Guid pkRowId { get; set; }

        /// <summary>
        /// Stock Item ID 
        /// </summary>
		public Guid fkStockItemId { get; set; }

        /// <summary>
        /// Property name 
        /// </summary>
		public String ProperyName { get; set; }

        /// <summary>
        /// Property value 
        /// </summary>
		public String PropertyValue { get; set; }

        /// <summary>
        /// Property type 
        /// </summary>
		public String PropertyType { get; set; }
	} 
}