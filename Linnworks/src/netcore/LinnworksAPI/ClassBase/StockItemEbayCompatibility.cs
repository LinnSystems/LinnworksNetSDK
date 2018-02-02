using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class StockItemEbayCompatibility
	{
        /// <summary>
        /// StockItem unique identifier 
        /// </summary>
		public Guid FkStockItemId;

        /// <summary>
        /// Compatibility list ID 
        /// </summary>
		public Guid FkCompatibilityListId;

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
	} 
}