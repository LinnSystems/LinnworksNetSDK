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
		public Guid pkRowId;

        /// <summary>
        /// Stock Item ID 
        /// </summary>
		public Guid fkStockItemId;

        /// <summary>
        /// Property name 
        /// </summary>
		public String ProperyName;

        /// <summary>
        /// Property value 
        /// </summary>
		public String PropertyValue;

        /// <summary>
        /// Property type 
        /// </summary>
		public String PropertyType;
	} 
}