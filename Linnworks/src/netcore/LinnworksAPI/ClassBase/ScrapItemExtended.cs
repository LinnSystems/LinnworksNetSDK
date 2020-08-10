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
		public Guid pkScrapId { get; set; }

        /// <summary>
        /// Inventory batch id 
        /// </summary>
		public Int32 BatchInventoryId { get; set; }

        /// <summary>
        /// Stock item id to scrap 
        /// </summary>
		public Guid fkStockItemId { get; set; }

        /// <summary>
        /// Quantity to scrap 
        /// </summary>
		public Int32 Quantity { get; set; }

        /// <summary>
        /// Scrap category 
        /// </summary>
		public String ScrapCategory { get; set; }

        /// <summary>
        /// Scrap reason (max 600 characters) 
        /// </summary>
		public String ScrapReason { get; set; }
	} 
}