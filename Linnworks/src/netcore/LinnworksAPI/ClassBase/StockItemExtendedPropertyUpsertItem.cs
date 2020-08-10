using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    /// <summary>
    /// Stock item extended property 
    /// </summary>
    public class StockItemExtendedPropertyUpsertItem
	{
        /// <summary>
        /// Stock Item ID, optional if SKU provided 
        /// </summary>
		public Guid? fkStockItemId { get; set; }

        /// <summary>
        /// Stock Item ID, optional if fkStockItemId provided 
        /// </summary>
		public String SKU { get; set; }

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