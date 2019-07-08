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
		public Guid? FkStockItemId;

        /// <summary>
        /// Compatibility list ID (Optional) 
        /// </summary>
		public Guid? FkCompatibilityListId;

        /// <summary>
        /// Stock item SKU (Will be ignored fkStockItemId is supplied) 
        /// </summary>
		public String SKU;

        /// <summary>
        /// Compatibility notes 
        /// </summary>
		public String CompatibilityNotes;

        /// <summary>
        /// Value 
        /// </summary>
		public String Value;

        /// <summary>
        /// Years to include 
        /// </summary>
		public String IncludeYears;

        /// <summary>
        /// Years to exclude 
        /// </summary>
		public String ExcludeYears;

        /// <summary>
        /// Compatibility culture, one of US, UK, DE, AU, CA, FR, IT, ES 
        /// </summary>
		public String Culture;
	} 
}