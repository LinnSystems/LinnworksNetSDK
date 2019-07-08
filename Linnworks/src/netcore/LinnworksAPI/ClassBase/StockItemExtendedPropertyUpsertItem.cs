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
		public Guid? fkStockItemId;

        /// <summary>
        /// Stock Item ID, optional if fkStockItemId provided 
        /// </summary>
		public String SKU;

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