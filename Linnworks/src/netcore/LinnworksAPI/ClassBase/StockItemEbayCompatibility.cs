using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemEbayCompatibility
	{
        /// <summary>
        /// StockItem unique identifier (Optional if SKU is supplied) 
        /// </summary>
		public Guid? FkStockItemId { get; set; }

        /// <summary>
        /// Compatibility list ID (Optional) 
        /// </summary>
		public Guid? FkCompatibilityListId { get; set; }

        /// <summary>
        /// Stock item SKU (Will be ignored fkStockItemId is supplied) 
        /// </summary>
		public String SKU { get; set; }

        /// <summary>
        /// Compatibility notes 
        /// </summary>
		public String CompatibilityNotes { get; set; }

        /// <summary>
        /// Value 
        /// </summary>
		public String Value { get; set; }

        /// <summary>
        /// Years to include 
        /// </summary>
		public String IncludeYears { get; set; }

        /// <summary>
        /// Years to exclude 
        /// </summary>
		public String ExcludeYears { get; set; }

        /// <summary>
        /// Compatibility culture, one of US, UK, DE, AU, CA, FR, IT, ES 
        /// </summary>
		public String Culture { get; set; }
	} 
}