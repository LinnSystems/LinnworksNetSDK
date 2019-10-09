using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{ 
    public class ScrapItemExtended
	{
        /// <summary>
        /// Nullable 
        /// </summary>
		public Guid pkScrapId;

        /// <summary>
        /// Inventory batch id 
        /// </summary>
		public Int32 BatchInventoryId;

        /// <summary>
        /// Stock item id to scrap 
        /// </summary>
		public Guid fkStockItemId;

        /// <summary>
        /// Quantity to scrap 
        /// </summary>
		public Int32 Quantity;

        /// <summary>
        /// Scrap category 
        /// </summary>
		public String ScrapCategory;

        /// <summary>
        /// Scrap reason (max 600 characters) 
        /// </summary>
		public String ScrapReason;
	} 
}